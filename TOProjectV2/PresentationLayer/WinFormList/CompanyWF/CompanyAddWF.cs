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

namespace PresentationLayer.WinFormList.CompanyWF
{
    public partial class CompanyAddWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyAddWF()
        {
            InitializeComponent();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}