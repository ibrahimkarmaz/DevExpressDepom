using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gridControlVeriCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SCAEntities dataBase = new SCAEntities();
        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from ilce in dataBase.ilcelers
                                       join il in dataBase.illers
                                       on ilce.sehir equals il.id
                                       select new
                                       {
                                           İL = il.sehir,
                                           İLÇE = ilce.ilce
                                       }).ToList();

            gridView1.OptionsBehavior.ReadOnly = true;
            gridView1.OptionsBehavior.Editable = false;
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {//İMLECİN ODAKLANDIĞI SATIR DEĞİŞİNCE NE OLSUN ?
            //1.YÖNTEM GetRowCellValue ile satır ve alan adını belirtip veri alabiriz.
            labelControl1.Text = "SEÇİLİ ALAN:" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[0])+"=>"+ gridView1.GetRowCellValue(gridView1.FocusedRowHandle, gridView1.Columns[1]);
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr!=null)//İLK ÇALIŞMADA BOŞ DEĞER ÇEKMEYE ÇALIŞIYOR İF İFADESİ KULLANILDI
            {
                labelControl2.Text = dr[0].ToString();
            }
        }
    }
}
