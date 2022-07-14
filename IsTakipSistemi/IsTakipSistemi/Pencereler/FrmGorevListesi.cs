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
    public partial class FrmGorevListesi : DevExpress.XtraEditors.XtraForm
    {
        public FrmGorevListesi()
        {
            InitializeComponent();
        }
        DbIsTakipEntitiesUP1 dataBase = new DbIsTakipEntitiesUP1();
        private void FrmGorevListesi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsBehavior.ReadOnly = true;
            GorevListesiGetir();
            istatistikleriGetir();
            istatistikGrafikGetir();
        }
        void GorevListesiGetir()
        {
            gridControl1.DataSource = (from GT in dataBase.TblGorevlers
                                       select new
                                       {
                                           AÇIKLAMA=GT.Aciklama
                                       }).ToList();
        }
        void istatistikleriGetir()
        {
            LblAktifGorev.Text = dataBase.TblGorevlers.Count(x => x.Durum == true).ToString();
            LblPasifGorev.Text = dataBase.TblGorevlers.Count(x => x.Durum == false).ToString();
            LblDepartman.Text = dataBase.TblDepartmanlars.Count().ToString();

        }
        void istatistikGrafikGetir()
        {//***ChartControl Kullanım Dosyasını güncelle
            chartControl1.Series["Durum"].Points.AddPoint("AKTİF GÖREV SAYISI",Convert.ToInt32(LblAktifGorev.Text));
            chartControl1.Series["Durum"].Points.AddPoint("PASİF GÖREV SAYISI",Convert.ToInt32(LblPasifGorev.Text));
            chartControl1.Series[0].Label.TextPattern= "{A}: {V:0} ({VP:p0})";
            chartControl1.Series[0].LegendTextPattern = "{A}";

            //EK KAYNAK: {A} İŞLEMLERİ NE ANLAMA GELİYOR
           // https://docs.devexpress.com/CoreLibraries/DevExpress.XtraCharts.SeriesBase.LegendTextPattern
        }
    }
}