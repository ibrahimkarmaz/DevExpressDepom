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
using DevExpress.XtraEditors;

namespace lookupEditKullanimi
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(lookUpEdit1.EditValue+"="+lookUpEdit1.Text);
        }
        SCAEntities dataBase = new SCAEntities();
        private void XtraForm1_Load(object sender, EventArgs e)
        {
            //ENG-TR
            /*
             * Value Member:DeğerÜye
               Display Member: Üyeyi Göster
               Member:ÜYE
             */

            lookUpEdit1.Properties.ValueMember = "Plaka";//ARKAPLANDA ÇALIŞAN VERİLER
            lookUpEdit1.Properties.DisplayMember = "İL";//KULLANICIYA GÖZÜKEN SEÇİLEN ALAN
            // lookUpEdit1.Properties.DataSource = dataBase.illers.ToList();
            lookUpEdit1.Properties.DataSource = (from il in dataBase.illers
                                                 select new
                                                 {
                                                     Plaka = il.id,
                                                     İL = il.sehir
                                                 }).ToList();
            lookUpEdit1.Properties.NullText = "İL SEÇİNİZ";
        }
    }
}