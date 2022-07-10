using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;//COPY İŞİLEMİ İÇİN GEREKLİ KÜTÜPHANE.
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using System.Data.Entity;

namespace PictureEditKullanimi
{
    public partial class PiceEditKullanim : DevExpress.XtraEditors.XtraForm
    {
        public PiceEditKullanim()
        {
            InitializeComponent();
        }
        DBResimIslemleriDVEntities1 dataBase = new DBResimIslemleriDVEntities1();
        OpenFileDialog ResimSec = new OpenFileDialog();
        DragDropProvider Surekle;
        string ResimYeniAd, ResimYeniAdres;
        private void PiceEditKullanim_Load(object sender, EventArgs e)
        {
            TabloGetir();
            TabloDuzen();
            PEResimAyarlari();
            AddUnboundColumn(gridView1);//GRİDVİEW ÜZERİNDE YENİ RESİM ALANI EKLENDİ
            AssignPictureEdittoImageColumn(gridView1.Columns["Image"]);//BURADA EKLENEN ALAN ADINI GÖSTERDİK
            gridView1.Columns["imageLine"].Visible = false;//BURADA VERİ KAPATILDI ADRESİ MODEL İLE ALINACAK
            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
        }

        void TabloGetir()
        {
            GC.DataSource = dataBase.TblKisiResims.ToList();
        }
        void TabloDuzen()
        {
            gridView1.Columns[1].Caption = "AD";
            gridView1.Columns[2].Caption = "SOYAD";
            gridView1.Columns[3].Caption = "RESİM";
        }
        void PEResimAyarlari()
        {
            //DOSYADAN ÇEKİLİRKEN YAPILACAK AYARLAR
            ResimSec.Title = "RESİM SEÇ";
            ResimSec.Filter = "RESİM SEÇ | *jpg;*png;";
            ResimSec.Multiselect = false;
            ResimSec.RestoreDirectory = true;

            //PictureEdit İÇİN ÖZEL AYARLAR
            PEResim.Properties.NullText = "SÜRÜKLE BIRAK";
            PEResim.Properties.ShowMenu = false;//SAĞ TIK MENU KAPANDI

            //SÜRÜKLE BIRAK SİSTEMİ İÇİN CLASS OLUŞTURULDU.
            Surekle = new DragDropProvider(PEResim);
            Surekle.EnableDragDrop();
        }

        private void SBtnResimAc_Click(object sender, EventArgs e)
        {
            if (ResimSec.ShowDialog()==DialogResult.OK)
            {
                PEResim.Image = Image.FromFile(ResimSec.FileName);
            }
        }

        private void SBtnKaydet_Click(object sender, EventArgs e)
        {
            ResimYeniAd = @"image\" + Guid.NewGuid() + ".jpg";
            ResimYeniAdres = Application.StartupPath +"\\"+ ResimYeniAd;

            if (PEResim.GetLoadedImageLocation()=="")//EĞER VERİ SÜRÜKLENEREK GELDİ İSE;(PEResim_DragDrop)
                File.Copy(ResimSec.FileName,ResimYeniAdres);
            else//EĞER VERİ OPENDİALOG İLE ALINDI İSE;
                File.Copy(PEResim.GetLoadedImageLocation(),ResimYeniAdres);

            TblKisiResim Kaydet = new TblKisiResim();
            Kaydet.Ad = TEAd.Text;
            Kaydet.Soyad = TESoyad.Text;
            Kaydet.imageLine = ResimYeniAd;//BURADA DİREK ADRESİ ALMAMIZA GEREK YOK ÇÜNKÜ BİR KENDİ DOSYALARIMIZ ARASINDA BUNU ARIYORUZ
            dataBase.TblKisiResims.Add(Kaydet);
            dataBase.SaveChanges();
            XtraMessageBox.Show("İŞLEM BAŞARILI","RESİM İŞLEMLERİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            NesneleriTemizle();
        }
        void NesneleriTemizle()
        {
            foreach (Control TE in this.Controls)
            {
                if (TE is TextEdit)
                    TE.Text = "";
            }
            PEResim.Image = null;
            ResimSec.FileName = null;
        }
        private void SBtnListele_Click(object sender, EventArgs e)
        {
            TabloGetir();
        }

        private void PEResim_DragDrop(object sender, DragEventArgs e)
        {//SÜRÜKLE BIRAK İŞLEMİ SONUCUNDA RESİM SEÇ KISMINI BUNUN UZANTISINI GÖSTERMEMİZ GEREKİYOR.
            ResimSec.FileName = Surekle.FileLocation;
        }
        //Unbound:İlişkisiz
        void AddUnboundColumn(GridView view)//İlişkisiz Sütun Ekle
        {
            // Create an unbound column.
            GridColumn colImage = new GridColumn();
            colImage.FieldName = "Image";
            colImage.Caption = "RESİM";
            colImage.UnboundType =DevExpress.Data.UnboundColumnType.Object;
            colImage.OptionsColumn.AllowEdit = false;
            colImage.Visible = true;

            // Add the Image column to the grid's Columns collection.
            view.Columns.Add(colImage);
        }
        void AssignPictureEdittoImageColumn(GridColumn column)//Resim Düzenlemeyi Resim Sütununa Ata
        {
            //PictureEdit deposu öğesini oluşturun ve özelleştirin.
            RepositoryItemPictureEdit riPictureEdit = new RepositoryItemPictureEdit();
            riPictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;

            // PictureEdit'i kılavuzun RepositoryItems koleksiyonuna ekleyin.

            GC.RepositoryItems.Add(riPictureEdit);

            // PictureEdit'i 'Image' sütununa atayın.
            column.ColumnEdit = riPictureEdit;
        }
        Dictionary<string, Image> imageCache = new Dictionary<string, Image>(StringComparer.OrdinalIgnoreCase);
        private void GC_DoubleClick(object sender, EventArgs e)
        {
            
            var query = dataBase.TblKisiResims.Find(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
            TEAd.Text = query.Ad;
            TESoyad.Text = query.Soyad;
            PEResim.Image = Image.FromFile(query.imageLine);
            ResimSec.FileName = query.imageLine;
        }

        private void SBtnDuzenle_Click(object sender, EventArgs e)
        {
            var Duzenle = dataBase.TblKisiResims.Find(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0]));
             Duzenle.Ad = TEAd.Text;
             Duzenle.Soyad = TESoyad.Text;
             if (Duzenle.imageLine!=ResimSec.FileName)
             {
                ResimYeniAd = @"image\" + Guid.NewGuid() + ".jpg";
                ResimYeniAdres = Application.StartupPath + "\\" + ResimYeniAd;
                if (PEResim.GetLoadedImageLocation() == "")//EĞER VERİ SÜRÜKLENEREK GELDİ İSE;(PEResim_DragDrop)
                {
                    File.Copy(ResimSec.FileName, ResimYeniAdres);//RESMİ KOPYALAMA
                    Duzenle.imageLine = ResimYeniAd;
                    PEResim.Image?.Dispose();//RESMİ KOPYALADIKTAN SONRA KOPYALANAN RESMİ KAPATMA
                    File.Delete(ResimSec.FileName);//KOPYALANAN RESMİ SİLME

                }
                else//EĞER VERİ OPENDİALOG İLE ALINDI İSE;
                {
                    File.Copy(PEResim.GetLoadedImageLocation(), ResimYeniAdres);
                    Duzenle.imageLine = ResimYeniAd;
                    File.Delete(PEResim.GetLoadedImageLocation());
                }
            }
            dataBase.SaveChanges();
            XtraMessageBox.Show("İŞLEM BAŞARILI", "RESİM İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NesneleriTemizle();
        }

        private void SBtnSil_Click(object sender, EventArgs e)
        {
            var Sil = dataBase.TblKisiResims.First(x=>x.ID==Convert.ToInt32(gridView1.GetRowCellValue(gridView1.FocusedRowHandle,gridView1.Columns[0])));
            dataBase.TblKisiResims.Remove(Sil);
            dataBase.SaveChanges();
            XtraMessageBox.Show("İŞLEM BAŞARILI", "RESİM İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            NesneleriTemizle();
        }

        private void SBtnAramaYap_Click(object sender, EventArgs e)
        {
            var Sil = dataBase.TblKisiResims.Where(z=>z.Ad.StartsWith(TEAd.Text));
            GC.DataSource = Sil.ToList();
        }

        private void gridView1_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
        {
            if (e.Column.FieldName == "Image" && e.IsGetData)
            {
                GridView view = sender as GridView;
                string fileName = view.GetRowCellValue(view.GetRowHandle(e.ListSourceRowIndex), "imageLine") as string ?? string.Empty;//DEĞİŞTİRİLDİ VE EKLENDİ.(RESİM YOLU)
                if (!imageCache.ContainsKey(fileName))
                {
                    Image img = null;
                    if (File.Exists(fileName))
                        img = Image.FromFile(fileName);
                    else
                        img = Image.FromFile(@"image\SoruSimgesi.jpg");//DEĞİŞTİRİLDİ.

                    imageCache.Add(fileName, img);
                }
                e.Value = imageCache[fileName];
            }
        }
    }
}
