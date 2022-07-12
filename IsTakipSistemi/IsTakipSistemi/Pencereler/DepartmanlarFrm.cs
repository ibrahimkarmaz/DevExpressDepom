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
    public partial class DepartmanlarFrm : DevExpress.XtraEditors.XtraForm
    {
        public DepartmanlarFrm()
        {
            InitializeComponent();
        }
        DbIsTakipEntities dataBase = new DbIsTakipEntities();
        private void DepartmanlarFrm_Load(object sender, EventArgs e)
        {
            GViewDepartmanListe.OptionsBehavior.ReadOnly = true;
            GViewDepartmanListe.OptionsBehavior.Editable = false;
            MDepatmanListesi();
        }
        void MDepatmanListesi()
        {
            GControlDepartman.DataSource = (from alanlar in dataBase.TblDepartmanlars
                                           select new
                                           {
                                               alanlar.ID,
                                               alanlar.Ad
                                           }).ToList();
        }

        private void SBtnListele_Click(object sender, EventArgs e)
        {
            MDepatmanListesi();
        }

        private void SBtnKaydet_Click(object sender, EventArgs e)
        {
            TblDepartmanlar Kaydet = new TblDepartmanlar();
            Kaydet.Ad = TEDepartmanAd.Text;
            dataBase.TblDepartmanlars.Add(Kaydet);
            dataBase.SaveChanges();
            MDepatmanListesi();
            XtraMessageBox.Show("YENİ DEPATMAN KAYIT İŞLEMİ BAŞARILI","DEPARTMAN İŞLEMLERİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void SbtnSil_Click(object sender, EventArgs e)
        {
            var Silme = dataBase.TblDepartmanlars.Find(Convert.ToInt32(TEDepartmanID.Text));
            dataBase.TblDepartmanlars.Remove(Silme);
            dataBase.SaveChanges();
            MDepatmanListesi();
            XtraMessageBox.Show("DEPATMAN SİLME İŞLEMİ BAŞARILI", "DEPARTMAN İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void GViewDepartmanListe_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TEDepartmanID.Text = GViewDepartmanListe.GetRowCellValue(GViewDepartmanListe.FocusedRowHandle, GViewDepartmanListe.Columns["ID"]).ToString();
                TEDepartmanAd.Text= GViewDepartmanListe.GetRowCellValue(GViewDepartmanListe.FocusedRowHandle, GViewDepartmanListe.Columns["Ad"]).ToString();
            }
            catch (Exception)
            {

            }
        }

        private void SBtnGuncelle_Click(object sender, EventArgs e)
        {
            var Duzenle = dataBase.TblDepartmanlars.Find(Convert.ToInt32(TEDepartmanID.Text));
            Duzenle.Ad = TEDepartmanAd.Text;
            dataBase.SaveChanges();
            MDepatmanListesi();
            XtraMessageBox.Show("DEPATMAN DÜZENLEME İŞLEMİ BAŞARILI", "DEPARTMAN İŞLEMLERİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}