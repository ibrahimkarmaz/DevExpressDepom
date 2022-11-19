using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using PresentationLayer.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.InvoiceWF
{
    public partial class CompanyMovementDetailsInvoiceWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyMovementDetailsInvoiceWF()
        {
            InitializeComponent();
        }
        CompanyMovementDetailManager _companyMovementDetailManager = new CompanyMovementDetailManager(new EFCompanyMovementDetailDAL());


        public static int CompanyMovementIDINFO;
        private void GetAllCompanyMovementDetails()
        {
            GControlCompanyMovementDetail.DataSource = _companyMovementDetailManager.GetAllCompanyMovementDetail(x => x.CompanyMovementID == CompanyMovementIDINFO);
        }
        private void CompanyMovementDetailsInvoiceWF_Load(object sender, EventArgs e)
        {
            GetAllCompanyMovementDetails();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnInvoiceCreate_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyMovementReport.IDInfo = CompanyMovementIDINFO.ToString();
                CompanyMovementReport companyMovementReportOpen = new CompanyMovementReport();
                companyMovementReportOpen.RequestParameters = false;
                companyMovementReportOpen.ShowPreviewDialog();
                this.Close();

            }
            catch (Exception)
            {
                
            }
        }
    }
}