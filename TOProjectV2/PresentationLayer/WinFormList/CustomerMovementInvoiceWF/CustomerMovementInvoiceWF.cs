using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using PresentationLayer.Reports;
using PresentationLayer.WinFormList.CustomerMovementInvoiceWF;
using PresentationLayer.WinFormList.InvoiceWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.CustomerMovementInvoice
{
	public partial class CustomerMovementInvoiceWF : DevExpress.XtraEditors.XtraForm
	{
		public CustomerMovementInvoiceWF()
		{
			InitializeComponent();
		}
		CustomerMovementInvoiceManager _customerMovementInvoiceManager = new CustomerMovementInvoiceManager(new EFCustomerMovementInvoiceDAL());
		private void GetAllCustomerMovementInvoiceMetod()
		{
			GControlInvoice.DataSource = _customerMovementInvoiceManager.GetAllCustomerMovementInvoice().OrderByDescending(x=>x.CustomerMovementDate);
		}
		private void CustomerMovementInvoiceWF_Load(object sender, EventArgs e)
		{
			GetAllCustomerMovementInvoiceMetod();
		}

		private void BtnEditCustomerInvoice_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			SendAndOpenDetail();
		}

		private void SendAndOpenDetail()
		{
			try
			{

				CustomerMovementDetailInvoice.CustomerMovementIDINFO = (int)_customerMovementInvoiceManager.GetById(Convert.ToInt32(GViewCustomer.GetRowCellValue(GViewCustomer.FocusedRowHandle, GViewCustomer.Columns[0]))).CustomerMovementID;
				CustomerMovementDetailInvoice customerMovementDetailInvoice = new CustomerMovementDetailInvoice();
				customerMovementDetailInvoice.ShowDialog();
			}
			catch (Exception)
			{
				XtraMessageBox.Show("MÜŞTERİ HAREKETİ SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}
	}
}