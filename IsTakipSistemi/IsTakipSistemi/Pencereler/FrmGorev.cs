using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IsTakipSistemi.Entitiy;

namespace IsTakipSistemi.Pencereler
{
    public partial class FrmGorev : DevExpress.XtraEditors.XtraForm
    {
        public FrmGorev()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            
        }
        DbIsTakipEntitiesUP1 dataBase = new DbIsTakipEntitiesUP1();
        private void FrmGorev_Load(object sender, EventArgs e)
        {
            GorevVerenAlanPersonelListesi();
        }
        void GorevVerenAlanPersonelListesi()
        {
            LUEGorevAlan.Properties.DataSource = (from tbl in dataBase.TblPersonels
                                                  select new
                                                  {
                                                      tbl.ID,
                                                      AdSoyad = tbl.Ad + " " + tbl.Soyad
                                                  }).ToList();
            LUEGorevAlan.Properties.DisplayMember = "AdSoyad";
            LUEGorevAlan.Properties.ValueMember = "ID";
        }
        private void SBtnKaydet_Click(object sender, EventArgs e)
        {
            TblGorevler Kaydet = new TblGorevler();
            Kaydet.Aciklama = MMAciklama.Text;
            Kaydet.Durum = true;
            Kaydet.Tarih = Convert.ToDateTime(TETarih.Text);
            Kaydet.GorevVeren =int.Parse(TEGorevVeren.Text);
            dataBase.TblGorevlers.Add(Kaydet);
            dataBase.SaveChanges();
            XtraMessageBox.Show("KAYIT İŞLEMİ BAŞARILIR","KAYIT İŞLEMLERİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}