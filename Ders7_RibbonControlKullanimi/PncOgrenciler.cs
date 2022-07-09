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


namespace Ders7_RibbonControlKullanimi
{
    public partial class PncOgrenciler : Form
    {
        public PncOgrenciler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-5DGSRBQ;Initial Catalog=TestDevExpress;Integrated Security=True");

        private void PncOgrenciler_Load(object sender, EventArgs e)
        {
            TabloGetir();
        }
        public void TabloGetir()
        {
            baglanti.Open();
            SqlDataAdapter komut = new SqlDataAdapter("select * from TblOgrenci", baglanti);
            DataSet aa = new DataSet();
            komut.Fill(aa);
            gridControl1.DataSource = aa.Tables[0];
            baglanti.Close();
           
        }
        public string ad, soyad, numara;

        private void TxeNumara_EditValueChanged(object sender, EventArgs e)
        {
            numara = TxeNumara.Text;
        }

        private void TxeSoyad_EditValueChanged(object sender, EventArgs e)
        {
            soyad = TxeSoyad.Text;
        }

        private void Txe_Ad_EditValueChanged(object sender, EventArgs e)
        {
            ad = Txe_Ad.Text;
        }
    }
}
