using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SinemaTakipOtomasyonSistemi
{

    public class DragDropProvider
    {
        Image draggedImage;
        PictureEdit edit;
        public string FileLocation="";//SONRADAN EKLENDİ DOSYA YOLUNU ALMAK İÇİN

        public DragDropProvider(PictureEdit edit)
        {
            this.edit = edit;
            edit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
        }

        [DllImport("GdiPlus.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
        private static extern int GdipCreateBitmapFromGdiDib(IntPtr pBIH, IntPtr pPix, out IntPtr pBitmap);


        private IntPtr GetPixelInfo(IntPtr bmpPtr)
        {
            BITMAPINFOHEADER bmi = (BITMAPINFOHEADER)Marshal.PtrToStructure(bmpPtr, typeof(BITMAPINFOHEADER));
            if (bmi.biSizeImage == 0)
                bmi.biSizeImage = (uint)(((((bmi.biWidth * bmi.biBitCount) + 31) & ~31) >> 3) * bmi.biHeight);
            int p = (int)bmi.biClrUsed;
            if ((p == 0) && (bmi.biBitCount <= 8))
                p = 1 << bmi.biBitCount; p = (p * 4) + (int)bmi.biSize + (int)bmpPtr;
            return (IntPtr)p;
        }

        private void OnDragDrop(object sender, DragEventArgs e)
        {
            if ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy)
            {
                edit.Image = draggedImage;
                draggedImage = null;
            }
        }

        private void OnDragEnter(object sender, DragEventArgs e)
        {
            SetDragDropEffects(e);
        }

        private void SetDragDropEffects(DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;

            MemoryStream str = e.Data.GetData(DataFormats.Dib) as MemoryStream;
            if (str != null)
            {
                try
                {
                    GCHandle handle = GCHandle.Alloc(str.ToArray(), GCHandleType.Pinned);
                    draggedImage = BitmapFromDIB(handle.AddrOfPinnedObject());
                    if (draggedImage != null)
                        e.Effect = DragDropEffects.Copy;
                }
                catch
                {
                    draggedImage = null;
                }
            }
            else
            {
                string[] fileName = e.Data.GetData("FileName") as string[];
                FileLocation = "";
                if (fileName != null)
                {
                    FileLocation=fileName[0].ToString();//SONRADAN EKLENDI DOSYA YOLUNU GÖSTERMESİ AÇAMLI.
                    try
                    {
                        draggedImage = Image.FromFile(fileName[0]);
                        e.Effect = DragDropEffects.Copy;
                    }
                    catch
                    {
                        draggedImage = null;
                    }
                }
                else
                {
                    object bmp = e.Data.GetData("Bitmap");
                    if (bmp != null)
                    {
                        draggedImage = (Image)bmp;
                        e.Effect = DragDropEffects.Copy;
                    }
                }
            }
        }

        public Bitmap BitmapFromDIB(IntPtr pDIB)
        {

            IntPtr pPix = GetPixelInfo(pDIB);
            MethodInfo mi = typeof(Bitmap).GetMethod("FromGDIplus",
                            BindingFlags.Static | BindingFlags.NonPublic);
            if (mi == null) return null;
            IntPtr pBmp = IntPtr.Zero;
            int status = GdipCreateBitmapFromGdiDib(pDIB, pPix, out pBmp);
            if ((status == 0) && (pBmp != IntPtr.Zero))
                return (Bitmap)mi.Invoke(null, new object[] { pBmp });
            else
                return null;
        }

        public void DisableDragDrop()
        {
            edit.DragEnter -= OnDragEnter;
            edit.DragDrop -= OnDragDrop;
        }

        public void EnableDragDrop()
        {
            edit.AllowDrop = true;
            edit.DragEnter += OnDragEnter;
            edit.DragDrop += OnDragDrop;
        }
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public struct BITMAPINFOHEADER
    {
        public uint biSize;
        public int biWidth;
        public int biHeight;
        public ushort biPlanes;
        public ushort biBitCount;
        public uint biCompression;
        public uint biSizeImage;
        public int biXPelsPerMeter;
        public int biYPelsPerMeter;
        public uint biClrUsed;
        public uint biClrImportant;

        public void Init()
        {
            biSize = (uint)Marshal.SizeOf(this);
        }
    }
}