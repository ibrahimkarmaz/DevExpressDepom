using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
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

namespace PresentationLayer.WinFormList.EmployeeWF
{
    public partial class EmployeeSelectWF : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeSelectWF()
        {
            InitializeComponent();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        EmployeeManager _employeeManager = new EmployeeManager(new EFEmployeeDAL());
        public static EmployeeSelectDTO employeeSelect;
        public static bool EmployeeSelectStatus;
        private void EmployeeSelectWF_Load(object sender, EventArgs e)
        {
            EmployeeGetAllList();
        }
        private EmployeeSelectDTO GetEmployeeINFO()
        {
            return new EmployeeSelectDTO()
            {
                EmployeeID = (int)GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[0]),
                EmployeeNameSurName = GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[2]).ToString()+" "+ GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[3]).ToString()
            };
        }
        private void EmployeeGetAllList()
        {
            GControlEmployee.DataSource = _employeeManager.GetAllEmployee(x => x.EmployeeArchive == true);
        }

        private void SBtnSelect_Click(object sender, EventArgs e)
        {
            CommonEmployee();
        }
        private void CommonEmployee()
        {
            try
            {
                EmployeeSelectStatus = true;
                employeeSelect = GetEmployeeINFO();
                this.Close();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("PERSONEL SEÇİLEMEDİ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GControlEmployee_DoubleClick(object sender, EventArgs e)
        {
            CommonEmployee();
        }
    }
}