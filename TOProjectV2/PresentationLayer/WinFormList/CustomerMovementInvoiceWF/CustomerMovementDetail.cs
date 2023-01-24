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

namespace PresentationLayer.WinFormList.CustomerMovementInvoiceWF
{
	public partial class CustomerMovementDetailInvoice : DevExpress.XtraEditors.XtraForm
	{
		public CustomerMovementDetailInvoice()
		{
			InitializeComponent();
		}
		CustomerMovementDetailManager _customerMovementDetailManager = new CustomerMovementDetailManager(new EFCustomerMovementDetailDAL());
		private void SBCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		public static int CustomerMovementIDINFO;
		private void GetAllCustomerMovementDetails()
		{
			GControlCustomerMovementDetail.DataSource = _customerMovementDetailManager.GetAllCustomerMovementDetail(x => x.CustomerMovementID == CustomerMovementIDINFO);
		}
		private void CustomerMovementDetail_Load(object sender, EventArgs e)
		{
			GetAllCustomerMovementDetails();
		}

		private void SBtnInvoiceShow_Click(object sender, EventArgs e)
		{
			//FATURA GÖSTERME İŞLEMLERİ
			try
			{

				CustomerMovementReportX.IDInfo = CustomerMovementIDINFO.ToString();

				CustomerMovementReportX customerMovementReportX = new CustomerMovementReportX();
				customerMovementReportX.RequestParameters = false;
				customerMovementReportX.ShowPreviewDialog();
				this.Close();

			}
			catch (Exception)
			{

			}
		}
	}
}