using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ButtonEditKullanimi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        OpenFileDialog DosyaSec;
        private void FileSelectProcess()
        {
            DosyaSec = new OpenFileDialog();
            DosyaSec.Title = "Resim Seçiniz";
            DosyaSec.Filter = "Resim Seç | *jpg; *png;";
            DosyaSec.Multiselect = false;
            DosyaSec.RestoreDirectory = true;
        }
        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FileSelectProcess();
            if (DosyaSec.ShowDialog()==DialogResult.OK)
            {
                buttonEdit1.Text = DosyaSec.FileName;
            }
        }

        private void buttonEdit3_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 0:
                    Console.WriteLine("Geri Al");
                    break;
                case 1:
                    Console.WriteLine("Sil");
                    break;
                case 2:
                    Console.WriteLine("Arama Yap");
                    break;
                case 3:
                    Console.WriteLine("Ekle");
                    break;
                default:
                    Console.WriteLine("HATA OLUŞTU.");
                    break;
            }
           /* if (e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Close)
            {
                Console.WriteLine("Kapat Gız");
            }*/
        }
    }
}

//KAYNAKÇA:
//https://www.youtube.com/watch?v=m6D1lnRClH4
//Devexpress sitesine bak

//ButtonEdit'in GridView içinde kullanımı(Daha Sonra Bakılacak Gerekli Veritabani Eksik)
//https://www.youtube.com/watch?v=zMpxTaQuquY