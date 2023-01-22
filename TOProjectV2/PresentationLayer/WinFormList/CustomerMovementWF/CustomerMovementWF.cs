using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.WinFormList.CustomerWF;
using PresentationLayer.WinFormList.EmployeeWF;
using PresentationLayer.WinFormList.ProductWF.ProductMovementWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.CustomerMovementWF
{
	public partial class CustomerMovementWF : DevExpress.XtraEditors.XtraForm
	{
		public CustomerMovementWF()
		{
			InitializeComponent();
		}

		private void BEEmployee_EditValueChanged(object sender, EventArgs e)
		{

		}
		CustomerMovementManager _customerMovementManager = new CustomerMovementManager(new EFCustomerMovementDAL());
		CustomerMovementDetailManager _customerMovementDetailManager = new CustomerMovementDetailManager(new EFCustomerMovementDetailDAL());
		CustomerMovementInvoiceManager _customerMovementInvoiceManager = new CustomerMovementInvoiceManager(new EFCustomerMovementInvoiceDAL());
		EmployeeSelectDTO employeeSelect = new EmployeeSelectDTO();
		private void BEEmployee_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			EmployeeSelectWF.EmployeeSelectStatus = false;
			employeeSelect = null;
			EmployeeSelectWF employeeSelectWF = new EmployeeSelectWF();
			employeeSelectWF.ShowDialog();
			employeeSelect = EmployeeSelectWF.employeeSelect;
			if (EmployeeSelectWF.EmployeeSelectStatus)
			{
				BEEmployee.Text = employeeSelect.EmployeeNameSurName;
			}
		}
		CustomerSelectDTO customerSelect = new CustomerSelectDTO();
		private void BECustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
		{
			CustomerSelectWF.customerSelectStatus = false;
			customerSelect = null;
			CustomerSelectWF customerSelectWF = new CustomerSelectWF();
			customerSelectWF.ShowDialog();
			customerSelect = CustomerSelectWF.customerSelect;
			if (CustomerSelectWF.customerSelectStatus)
			{
				BECustomer.Text = customerSelect.CustomerFullName;
			}

		}

		private void CustomerMovementWF_Load(object sender, EventArgs e)
		{

		}
		public static int CustomerrMovementIDINFO;
		private void SBtnCustomerMovement_Click(object sender, EventArgs e)
		{
			try
			{
				CustomerMovement customerMovement = new CustomerMovement();
				if (employeeSelect.EmployeeID != null)
				{
					customerMovement.EmployeeID = employeeSelect.EmployeeID;
				}
				else
				{
					customerMovement.EmployeeID = null;
				}

				if (customerSelect.CustomerID != null)
				{
					customerMovement.CustomerID = customerSelect.CustomerID;
				}
				else
				{
					customerMovement.CustomerID = null;
				}
				if (TECreateDate.Text != "")
				{
					customerMovement.CustomerMovementDate = Convert.ToDateTime(TECreateDate.Text);
				}
				else
				{
					customerMovement.CustomerMovementDate = null;
				}


				customerMovement.CustomerMovemenNote = MMENote.Text;
				customerMovement.CustomerMovemenArchive = true;
				if (new CustomerMovementCommonValidationControl().CustomerMovementValidatorAndMessage(customerMovement))
				{
					_customerMovementManager.TAdd(customerMovement);
					XtraMessageBox.Show("YENİ MÜŞTERİ HAREKETİ OLUŞTURULDU.\nÜRÜN BİLGİSİ İŞLEMLERİNİ UYGULAYABİLİRSİNİZ.\nVE RAPOR OLUŞTURABİLİRSİNİZ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
					accordionControlProduct.Enabled = true;
					GControlCustomerMovementDetail.Enabled = true;
					GroupControlFin.Enabled = true;
					SBtnCustomerMovement.Text = "Müşteri Hareketini Bilgisini Düzenle";

					CustomerrMovementIDINFO = _customerMovementManager.RecentlyAddedMovementCustomerID();//SON HAREKET ID'SI
					GetAllCustomerMovementDetails();


					//SERİ NO MANTIĞI:YIL+GÜN+SAAT+DAKİKA+MÜŞTERİ HAREKET ID ÖRNEK:2022 17 18 52 23 (BİRLEŞİK AMA :))
					DateTime Date = DateTime.Now;
					CustomerMovementInvoice customerMovementInvoiceData = new CustomerMovementInvoice();
					customerMovementInvoiceData.CustomerMovementInvoiceSeries = Date.Year.ToString() + Date.Day.ToString() + Date.Hour + Date.Minute + CustomerrMovementIDINFO.ToString();
					customerMovementInvoiceData.CustomerMovementID = CustomerrMovementIDINFO;
					_customerMovementInvoiceManager.TAdd(customerMovementInvoiceData);
				}
			}
			catch (Exception)
			{
				XtraMessageBox.Show("MÜŞTERİ HAREKETİ BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void GetAllCustomerMovementDetails()
		{
			GControlCustomerMovementDetail.DataSource = _customerMovementDetailManager.GetAllCustomerMovementDetail(x => x.CustomerMovementID == CustomerrMovementIDINFO);
		}

		private void accordionControlAdd_Click(object sender, EventArgs e)
		{
			ProductMovementAddWF.CustomerMovementCame = true;
			ProductMovementAddWF productMovementAddWF = new ProductMovementAddWF();
			productMovementAddWF.ShowDialog();
			ProductMovementAddWF.CustomerMovementCame = false;
			GetAllCustomerMovementDetails();
		}

		public static int CustomerMovementDetailID;
		private void accordionControlUpdate_Click(object sender, EventArgs e)
		{
			try
			{
				ProductMovementUpdateWF.CustomerMovementCame = true;
				CustomerMovementDetailID = (int)GViewCustomerMovementDetail.GetRowCellValue(GViewCustomerMovementDetail.FocusedRowHandle, GViewCustomerMovementDetail.Columns[0]);
				ProductMovementUpdateWF productMovementUpdateWF = new ProductMovementUpdateWF();
				productMovementUpdateWF.ShowDialog();
				ProductMovementUpdateWF.CustomerMovementCame = false;
				GetAllCustomerMovementDetails();
			}
			catch (Exception)
			{
				XtraMessageBox.Show("ÜRÜN SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}