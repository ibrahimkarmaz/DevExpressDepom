using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraCharts;

namespace Ders6_ChartControlKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chartControl1.Series["Sehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("İstanbul", 13000));
            chartControl1.Series["Sehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Ankara", 3000));
            chartControl1.Series["Sehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("İzmir", 7000));
            chartControl1.Series["Sehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Çorum", 1000));
            chartControl1.Series["Sehir"].Points.Add(new DevExpress.XtraCharts.SeriesPoint("Niğde", 150));

            Series a = new Series();
            a.Name = "b;";

            chartControl1.Series.Add(a);

            ChartTitle baslik = new ChartTitle();
            baslik.Text = "Şehirlere göre kitap okuyanların sayısı";
            // baslik.WordWrap = true;
            // baslik.MaxLineCount = 2;
            baslik.Alignment = StringAlignment.Center;
            baslik.Dock = ChartTitleDockStyle.Top;//Yazının nerede olacağı yani sağda mı üste mi yoksa alttamı gösterilecek
            baslik.Antialiasing = true;

            baslik.Font = new Font("Tahoma",14,FontStyle.Underline);
            baslik.TextColor = Color.Red;
            baslik.Indent = 111;//Başlığın altında ne kadar boşluk bırakılacak.

            chartControl1.Titles.Add(baslik);

            chartControl1.BackColor = Color.White;
            chartControl1.Cursor = Cursors.Hand;

            chartControl1.AnimationStartMode = ChartAnimationMode.OnDataChanged;

        }
    }
}
