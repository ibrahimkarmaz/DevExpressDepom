using DevExpress.XtraCharts;
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
    public partial class FrmPersonelistatistikler : DevExpress.XtraEditors.XtraForm
    {
        public FrmPersonelistatistikler()
        {
            InitializeComponent();
        }
        //EKSTRA KAYNAKLAR: https://docs.devexpress.com/WindowsForms/6240/controls-and-libraries/chart-control/examples/chart-elements/how-to-add-titles-to-a-chart?v=20.1
        private void FrmPersonelistatistikler_Load(object sender, EventArgs e)
        {
            comboBoxEdit1.Properties.Items.Add("TOPLAM PERSONEL SAYISI");
            comboBoxEdit1.Properties.Items.Add("TOPLAM DEPARTMAN SAYISI");
            comboBoxEdit1.Properties.Items.Add("AKTİF İŞ SAYISI");
            comboBoxEdit1.Properties.Items.Add("PASİF İŞ SAYISI");
            comboBoxEdit1.Properties.Items.Add("BUGÜNKÜ İŞ SAYISI-GÖREVLER");
            comboBoxEdit1.Properties.Items.Add("FİRMA SAYISI");
            comboBoxEdit1.Properties.Items.Add("İŞ YAPILAN ŞEHİR SAYISI");
            comboBoxEdit1.Properties.Items.Add("SEKTÖR SAYISI");
            comboBoxEdit1.Properties.Items.Add("AYIN PERSONELİ");
            comboBoxEdit1.Properties.Items.Add("AYIN DEPARTMANI");

        }
        DbIsTakipEntitiesUP1 dataBase = new DbIsTakipEntitiesUP1();
        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChartTitle baslik = new ChartTitle();
            Series islembilgi = new Series();
            chartControl1.Series.Clear();
            chartControl1.Titles.Clear();
            chartControl1.Series.Add(islembilgi);
            if (comboBoxEdit1.SelectedIndex == 0)
            {
                baslik.Text = "PERSONEL SAYISI";
                islembilgi.Name = "Toplam Personel Sayısı";
                int sayi = dataBase.TblPersonels.Count();
                chartControl1.Series[0].Points.Add(new SeriesPoint("TOPLAM PERSONEL", sayi));

            }
            else if (comboBoxEdit1.SelectedIndex==1)
            {
                baslik.Text = "DEPARTMAN SAYISI";
                islembilgi.Name = "Departman Sayısı";
                int DbBilgi = dataBase.TblDepartmanlars.Count();
                chartControl1.Series[0].Points.Add(new SeriesPoint("DEPARTMAN SAYISI",DbBilgi));
            }
            else if (comboBoxEdit1.SelectedIndex == 2)
            {
                baslik.Text = "AKTİF İŞ SAYISI";
                islembilgi.Name = "AKTİF İŞ SAYISI";
                int DbBilgi = dataBase.TblGorevlers.Count(x => x.Durum == true);
                chartControl1.Series[0].Points.Add(new SeriesPoint("AKTİF İŞ SAYISI", DbBilgi));
            }
            else if (comboBoxEdit1.SelectedIndex == 3)
            {
                baslik.Text = "PASİF İŞ SAYISI";
                islembilgi.Name = "Pasif İş Sayısı";
                int DbBilgi = dataBase.TblGorevlers.Count(y=>y.Durum==false);
                chartControl1.Series[0].Points.Add(new SeriesPoint("PASİF İŞ SAYISI", DbBilgi));
            }
            else if (comboBoxEdit1.SelectedIndex == 4)
            {
                baslik.Text = "BUGÜNKÜ İŞ SAYISI";
                islembilgi.Name = "Bugünkü İş Sayısı";
                int DbBilgi = dataBase.TblGorevlers.Count(a=>a.Tarih==DateTime.Today);
                chartControl1.Series[0].Points.Add(new SeriesPoint("BUGÜNKÜ İŞ SAYISI", DbBilgi));
            }
            else if (comboBoxEdit1.SelectedIndex == 5)
            {
                baslik.Text = "FİRMA SAYISI";
                islembilgi.Name = "Firma Sayısı";
                int DbBilgi = dataBase.TblFirmalars.Count();
                chartControl1.Series[0].Points.Add(new SeriesPoint("FİRMA SAYISI", DbBilgi));
            }
            else if (comboBoxEdit1.SelectedIndex == 6)
            {
                baslik.Text = "İŞ YAPILAN ŞEHİR SAYISI";
                islembilgi.Name = "İş Yapılan Şehir Sayısı";
                int DbBilgi = dataBase.TblFirmalars.Select(x=>x.il).Distinct().Count();
                chartControl1.Series[0].Points.Add(new SeriesPoint("İŞ YAPILAN ŞEHİR SAYISI", DbBilgi));
            }
            else if (comboBoxEdit1.SelectedIndex == 7)
            {
                baslik.Text = "SEKTÖR SAYISI";
                islembilgi.Name = "Sektör Sayısı";
                int DbBilgi = dataBase.TblFirmalars.Select(x => x.Sektor).Distinct().Count();
                chartControl1.Series[0].Points.Add(new SeriesPoint("SEKTÖR SAYISI", DbBilgi));
            }
            else if (comboBoxEdit1.SelectedIndex == 8)
            {
                var equery = dataBase.TblGorevlers.GroupBy(x => x.GorevAlan).OrderByDescending(z=>z.Count()).Select(y=>y.Key).FirstOrDefault();//KEY ID ,COUNT SAYISI OLUYOR
                var equery2 = dataBase.TblPersonels.Find(equery);
                Console.WriteLine(equery2.Ad+" "+equery2.Soyad);
            }
            else if (comboBoxEdit1.SelectedIndex == 9)
            {
                var sorgu =dataBase.TblPersonels.Find(dataBase.TblGorevlers.GroupBy(a => a.GorevAlan).OrderByDescending(z => z.Count()).Select(y => y.Key).FirstOrDefault());
                var sorgu2 = dataBase.TblDepartmanlars.Find(sorgu.DepartmanID);
                Console.WriteLine("DEPARTMAN ADI:"+ sorgu2.Ad);
            }
            baslik.Alignment = StringAlignment.Center;
            baslik.Dock = ChartTitleDockStyle.Top;
            baslik.TextColor = Color.DarkBlue;
            baslik.Indent = 10;//BAŞLIĞIN ALTINDA NE KADAR BOŞLUK OLACAK
            baslik.Antialiasing = true;//KENAR YUMUSAKMA
            baslik.Font = new Font("Tahoma",20,FontStyle.Bold);
            chartControl1.Titles.Add(baslik);
        }
    }
}