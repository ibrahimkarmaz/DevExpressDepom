using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
namespace Ders7_RibbonControlKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PncOgrenciler ogrenci;
        private void BtnOgrenciler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (ogrenci==null || ogrenci.IsDisposed)
            {
                ogrenci = new PncOgrenciler();
                ogrenci.MdiParent=this;
                ogrenci.Show();
            }
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5DGSRBQ;Initial Catalog=TestDevExpress;Integrated Security=True");
        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into TblOgrenci(AD,SOYAD,NUMARA) values(@p1,@p2,@p3)",baglanti);
            komut.Parameters.Add("@p1", ogrenci.ad);
            komut.Parameters.Add("@p2", ogrenci.soyad);
            komut.Parameters.Add("@p3", ogrenci.numara);
            komut.ExecuteNonQuery();  
            baglanti.Close();
            XtraMessageBox.Show("Öğrenci ekleme işlemi başarılı...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ogrenci.TabloGetir();
        }
    }
}
