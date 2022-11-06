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

namespace PresentationLayer.WinFormList.GuidesWF
{
    public partial class EmployeeGuideWF : DevExpress.XtraEditors.XtraForm
    {
        public EmployeeGuideWF()
        {
            InitializeComponent();
        }
        EmployeeManager _employeeManager = new EmployeeManager(new EFEmployeeDAL());
        private void GetAllEmployeOrEmployee()
        {
            GControlEmployee.DataSource = _employeeManager.GetAllEmployee(x => x.EmployeeArchive == true);
        }
        private void EmployeeGuideWF_Load(object sender, EventArgs e)
        {
            GetAllEmployeOrEmployee();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            SendMailWF.BuyerMail= GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[6]).ToString();
            SendMailWF sendMailWF = new SendMailWF();
            sendMailWF.ShowDialog();
        }
        private void SmsOpenWindow(int ColumnIndex)//ALAN INDEXSINA GÖRE BİLGİ ÇEKİLİR VE PENCERE AÇILIR.
        {
            try
            {
                SMSSenderWF.PhoneInfo = GViewEmployee.GetRowCellValue(GViewEmployee.FocusedRowHandle, GViewEmployee.Columns[ColumnIndex]).ToString();
                SMSSenderWF SmsApi = new SMSSenderWF();
                SmsApi.ShowDialog();
            }
            catch (Exception)
            {
                SMSSenderWF.PhoneInfo = "";
                XtraMessageBox.Show("İŞLEM BAŞARISIZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void repositoryItemBtnSms_Click(object sender, EventArgs e)
        {

            SmsOpenWindow(5);
        }
    }
}