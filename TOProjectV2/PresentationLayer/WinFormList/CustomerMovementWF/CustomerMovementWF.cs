using DataAccessLayer.DTO;
using DevExpress.XtraEditors;
using PresentationLayer.WinFormList.CustomerWF;
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
		CustomerSelectDTO customerSelect= new CustomerSelectDTO();
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
	}
}