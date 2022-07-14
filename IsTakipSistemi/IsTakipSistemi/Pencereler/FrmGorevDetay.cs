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
using System.Data.Entity;

namespace IsTakipSistemi.Pencereler
{
    public partial class FrmGorevDetay : DevExpress.XtraEditors.XtraForm
    {
        public FrmGorevDetay()
        {
            InitializeComponent();
        }
        DbIsTakipEntitiesUP1 dataBase = new DbIsTakipEntitiesUP1();
        private void FrmGorevDetay_Load(object sender, EventArgs e)
        {
            dataBase.TblGorevlerDetaylars.Load();
            bindingSource1.DataSource = dataBase.TblGorevlerDetaylars.Local;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}