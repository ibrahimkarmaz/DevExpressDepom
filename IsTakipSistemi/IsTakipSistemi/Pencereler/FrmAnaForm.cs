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
    public partial class FrmAnaForm : DevExpress.XtraEditors.XtraForm
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }
        DbIsTakipEntitiesUP1 dataBase = new DbIsTakipEntitiesUP1();
        private void FrmAnaForm_Load(object sender, EventArgs e)
        {//Aktif Görevler
            gridControl1.DataSource = (from gv in dataBase.TblGorevlers
                                       where(gv.Durum==true)
                                       select new
                                       {
                                           gv.Aciklama,
                                           AdSoyad=gv.TblPersonel.Ad+" "+gv.TblPersonel.Soyad
                                       }
                                     ).ToList();

            //Bugün Yapılan Görevler
            gridControl2.DataSource = (from x in dataBase.TblGorevlerDetaylars
                                       where(x.Tarih==DateTime.Today)
                                       select new
                                       {
                                           GorevAciklama=x.TblGorevler.Aciklama,
                                           GDetayAciklama=x.Aciklama,

                                       }).ToList();
            //AKTİF ÇAĞRI LİSTESİ
            gridControl3.DataSource = (from CagriTable in dataBase.TblCagrilars
                                       where(CagriTable.Durum==true)
                                       select new
                                       {
                                           CagriTable.TblFirmalar.Ad,
                                           CagriTable.Konu,
                                           CagriTable.Tarih
                                       }).ToList();
            //Fihrist Komutları
            gridControl5.DataSource = (from a in dataBase.TblFirmalars
                                       select new
                                       {
                                           a.Ad,
                                           a.Telefon,
                                           a.Mail
                                       }).ToList();
            //"{A}: {V:0} ({VP:p0})"
            /*
             A:KONU BAŞLIĞI ÖRNEK AKTİF ÇAĞRILAR VS
            V:DEĞER         ÖRNEK:5 (Cagrilar içerisinden çekilen veri)
            VP:ise Yüzdelik değer %75 vs gibi ama V değerine göre
             */

            chartControl1.Series["Durum"].Points.AddPoint("AKTİF ÇAĞRILAR",(dataBase.TblCagrilars.Count(x=>x.Durum==true)));
            chartControl1.Series["Durum"].Points.AddPoint("PASİF ÇAĞRILAR",(dataBase.TblCagrilars.Count(x=>x.Durum==false)));
            chartControl1.Series[0].Label.TextPattern = "{A}:{V:0} ({VP:P0})";
            chartControl1.Series[0].LegendTextPattern = "{A}";
            
        }

    }
}