using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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

namespace PresentationLayer.WinFormList.InvoiceWF
{
    public partial class CompanyMovementInvoiceWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyMovementInvoiceWF()
        {
            InitializeComponent();
        }
        InvoiceManager _invoiceManager = new InvoiceManager(new EFInvoiceDAL());
        private void GetAllCompanyMovementInvoice()
        {
            GControlInvoice.DataSource = _invoiceManager.GetAllCompanyMovementInvoice().OrderByDescending(x=>x.CompanyMovementDate);
        }
        private void CompanyMovementInvoiceWF_Load(object sender, EventArgs e)
        {
            GetAllCompanyMovementInvoice();
        }

        private void BtnEditCompanyInvoice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            SendAndOpenDetail();
        }
        private void SendAndOpenDetail()
        {
            try
            {
                CompanyMovementDetailsInvoiceWF.CompanyMovementIDINFO = (int)_invoiceManager.GetById(Convert.ToInt32(GViewCompany.GetRowCellValue(GViewCompany.FocusedRowHandle, GViewCompany.Columns[0]))).CompanyMovementID;
                CompanyMovementDetailsInvoiceWF companyMovementDetailsInvoiceWF = new CompanyMovementDetailsInvoiceWF();
                companyMovementDetailsInvoiceWF.ShowDialog();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("FİRMA HAREKETİ SEÇİNİZ.","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }
    }
}