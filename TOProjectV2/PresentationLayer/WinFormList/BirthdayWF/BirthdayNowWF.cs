using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.PivotGrid.OLAP.SchemaEntities;
using DevExpress.XtraEditors;
using PresentationLayer.WinFormList.GuidesWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.BirthdayWF
{
	public partial class BirthdayNowWF : DevExpress.XtraEditors.XtraForm
	{
		public BirthdayNowWF()
		{
			InitializeComponent();
		}
		CustomerManager _customerManager = new CustomerManager(new EFCustomerDAL());
		private void GetListBirthday()
		{
			GControlBirthday.DataSource = _customerManager.GetListWhoIsBirthday().Where(x=>(Convert.ToDateTime(x.CustomerDateOfBirth).Day==DateTime.Now.Day && Convert.ToDateTime(x.CustomerDateOfBirth).Month == DateTime.Now.Month));
		}
		private void BirthdayNowWF_Load(object sender, EventArgs e)
		{
			GetListBirthday();
		}
		private void SmsOpenWindow()
		{
			try
			{

				SMSSenderWF.PhoneInfo = _customerManager.GetById((int)(GViewBirthday.GetRowCellValue(GViewBirthday.FocusedRowHandle, GViewBirthday.Columns["CustomerID"]))).CustomerMobilePhone.ToString();
				SMSSenderWF SmsApi = new SMSSenderWF();
				SmsApi.ShowDialog();
			}
			catch (Exception)
			{
				SMSSenderWF.PhoneInfo = "";
				XtraMessageBox.Show("İŞLEM BAŞARISIZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void SBtnSMSSeender_Click(object sender, EventArgs e)
		{
			SmsOpenWindow();
		}

		private void SBtnMailSend_Click(object sender, EventArgs e)
		{
			SendMailWF.BuyerMail = SMSSenderWF.PhoneInfo = _customerManager.GetById((int)(GViewBirthday.GetRowCellValue(GViewBirthday.FocusedRowHandle, GViewBirthday.Columns["CustomerID"]))).CustomerMail.ToString();
			SendMailWF sendMailWF = new SendMailWF();
			sendMailWF.ShowDialog();
		}

		private void SBCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}