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
    public partial class CompanyWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyWF()
        {
            InitializeComponent();
        }
       
        private void accordionControlNewCompany_Click(object sender, EventArgs e)
        {
            CompanyAddWF companyAdd = new CompanyAddWF();
            companyAdd.ShowDialog();

        }
    }
}