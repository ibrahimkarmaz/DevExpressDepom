using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using PresentationLayer.WinFormList.EmployeeWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.CustomerWF
{
	public partial class CustomerSelectWF : DevExpress.XtraEditors.XtraForm
	{
		public CustomerSelectWF()
		{
			InitializeComponent();
		}
		CustomerManager _customerManager = new CustomerManager(new EFCustomerDAL());
		public static CustomerSelectDTO customerSelect;
		public static bool customerSelectStatus;
		private void CustomertGetAllList()
		{
			_customerManager = new CustomerManager(new EFCustomerDAL());//LİSTEYİ YENİLEMİYORDU.
			GControlCustomer.DataSource = _customerManager.CustomerGetList(x => x.CustomerArchive == true);
		}
		private void CustomerSelectWF_Load(object sender, EventArgs e)
		{
			CustomertGetAllList();
		}
		private CustomerSelectDTO GetCustomerINFO()
		{
			return new CustomerSelectDTO()
			{
				CustomerID = (int)GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[0]),
				CustomerFullName = GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[2]).ToString() + " " + GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[3]).ToString()
			};
		}
		private void SBtnSelect_Click(object sender, EventArgs e)
		{
			CommonCustomer();
		}
		private void CommonCustomer()
		{
			try
			{
				customerSelectStatus = true;
				customerSelect = GetCustomerINFO();
				this.Close();
			}
			catch (Exception)
			{
				XtraMessageBox.Show("MÜŞTERİ SEÇİLEMEDİ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void GControlCustomer_DoubleClick(object sender, EventArgs e)
		{
			CommonCustomer();
		}

		private void SBCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}