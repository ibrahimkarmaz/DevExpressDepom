using DataAccessLayer.DTO;
using DevExpress.XtraEditors;
using PresentationLayer.WinFormList.CompanyWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.CompanyMovement
{
    public partial class CompanyMovementAddWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyMovementAddWF()
        {
            InitializeComponent();
        }

        private void BECompany_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CompanySelectDTO companySelect;
        private void BECompany_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CompanySelectWF.companySelectStatus = false;
            CompanySelectWF.companySelect = null;
            CompanySelectWF companySelectWF = new CompanySelectWF();
            companySelectWF.ShowDialog();
            companySelect = CompanySelectWF.companySelect;
            if (CompanySelectWF.companySelectStatus)
            {

                //Console.WriteLine(companySelect.CompanyID);
                BECompany.Text = companySelect.CompanyName;
            }
        }

        private void CompanyMovementAddWF_Load(object sender, EventArgs e)
        {

        }
    }
}