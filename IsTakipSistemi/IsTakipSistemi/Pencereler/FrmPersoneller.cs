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
    public partial class FrmPersoneller : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }
        DbIsTakipEntitiesUP1 dataBase = new DbIsTakipEntitiesUP1();
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            MPersonelListesi();
            LUEDepartman.Properties.NullValuePrompt = "Departman Seçiniz";
            MDepatmanListesi();
            LUEDepartman.Properties.DisplayMember = "Ad";
            LUEDepartman.Properties.ValueMember = "ID";
            GViewPersonelListe.OptionsBehavior.Editable = false;
            GViewPersonelListe.OptionsBehavior.ReadOnly = true;
        }
        void MPersonelListesi()
        {
            GControlPersonel.DataSource = (from personeller in dataBase.TblPersonels
                                             join departman in dataBase.TblDepartmanlars
                                             on personeller.DepartmanID equals departman.ID
                                             where(personeller.Arsiv==true)
                                             select new
                                             {
                                                 personeller.ID,
                                                 personeller.Ad,
                                                 personeller.Soyad,
                                                 personeller.Mail,
                                               DepartmanAd=departman.Ad
                                             }
                                           ).ToList();
        }
        void MDepatmanListesi()
        {
            LUEDepartman.Properties.DataSource = (from departman in dataBase.TblDepartmanlars
                                                  select new
                                                  {
                                                      departman.ID,
                                                      departman.Ad
                                                  }
                ).ToList();
        }
        private void SBtnListele_Click(object sender, EventArgs e)
        {
            MPersonelListesi();
        }

        private void SBtnKaydet_Click(object sender, EventArgs e)
        {
            TblPersonel Kaydet = new TblPersonel();
            Kaydet.Ad = TEPersonelAd.Text;
            Kaydet.Soyad = TEPersonelSoyad.Text;
            Kaydet.Mail = TEMail.Text;
            Kaydet.DepartmanID = Convert.ToInt32(LUEDepartman.EditValue);
            dataBase.TblPersonels.Add(Kaydet);
            dataBase.SaveChanges();
            MPersonelListesi();
            XtraMessageBox.Show("YENİ PERSONEL KAYIT İŞLEMİ BAŞARILI","PERSONEL İŞLEMLERİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void SbtnSil_Click(object sender, EventArgs e)
        {//ARŞİVLEME İŞLEMİ
            var Arsivle = dataBase.TblPersonels.Find(Convert.ToInt32(TEPersonelID.Text));
            Arsivle.Arsiv = false;
            dataBase.SaveChanges();
            MPersonelListesi();
            XtraMessageBox.Show("PERSONEL SİLME İŞLEMİ BAŞARILI", "PERSONEL İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GViewPersonelListe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TEPersonelID.Text = GViewPersonelListe.GetFocusedRowCellValue("ID").ToString();
            TEPersonelAd.Text = GViewPersonelListe.GetFocusedRowCellValue("Ad").ToString();
            TEPersonelSoyad.Text = GViewPersonelListe.GetFocusedRowCellValue("Soyad").ToString();
            TEMail.Text = GViewPersonelListe.GetFocusedRowCellValue("Mail").ToString();
            LUEDepartman.EditValue = dataBase.TblPersonels.Find(Convert.ToInt32(GViewPersonelListe.GetFocusedRowCellValue("ID").ToString())).DepartmanID;
        }

        private void SBtnGuncelle_Click(object sender, EventArgs e)
        {
            var Duzenle = dataBase.TblPersonels.Find(Convert.ToInt32(TEPersonelID.Text));
            Duzenle.Ad = TEPersonelAd.Text;
            Duzenle.Soyad = TEPersonelSoyad.Text;
            Duzenle.Mail = TEMail.Text;
            Duzenle.DepartmanID =Convert.ToInt32(LUEDepartman.EditValue);
            dataBase.SaveChanges();
            MPersonelListesi();
            XtraMessageBox.Show("PERSONEL DÜZENLEME İŞLEMİ BAŞARILI", "PERSONEL İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}