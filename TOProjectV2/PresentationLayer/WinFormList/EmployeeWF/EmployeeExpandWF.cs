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

namespace PresentationLayer.WinFormList.EmployeeWF
{
    public partial class EmployeeExpandWF : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeExpandWF()
        {
            InitializeComponent();
        }
        EmployeeManager _employeeManager = new EmployeeManager(new EFEmployeeDAL());
        private void GetAllEmployeOrEmployeeArchive()
        {
            GControlEmployee.DataSource = _employeeManager.GetAllEmployee(x => x.EmployeeArchive == EmployeeWF.Archive);
        }

        private void EmployeeExpandWF_Load(object sender, EventArgs e)
        {
            GetAllEmployeOrEmployeeArchive();
        }
    }
}