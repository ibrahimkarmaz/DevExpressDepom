using BusinessLayer.Concrete;
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

namespace PresentationLayer.WinFormList.GuidesWF
{
    public partial class CompanyGuideWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyGuideWF()
        {
            InitializeComponent();
        }
        CompanyManager _companyManager = new CompanyManager(new EFCompanyDAL());
        private void GetAllCompany()
        {
            GControlCompany.DataSource = _companyManager.CompanyGetList(x => x.CompanyArchive == true);
        }
        private void MailOpenWindow(int ColumIndex)
        {
            try
            {
                SMSSenderWF.PhoneInfo = GViewCompany.GetRowCellValue(GViewCompany.FocusedRowHandle, GViewCompany.Columns[ColumIndex]).ToString();
                SMSSenderWF SmsApi = new SMSSenderWF();
                SmsApi.ShowDialog();
            }
            catch (Exception)
            {
                SMSSenderWF.PhoneInfo = "";
                XtraMessageBox.Show("İŞLEM BAŞARISIZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void repositoryItemBtnMail_Click(object sender, EventArgs e)
        {
            SendMailWF.BuyerMail = GViewCompany.GetRowCellValue(GViewCompany.FocusedRowHandle, GViewCompany.Columns[7]).ToString();
            SendMailWF sendMailWF = new SendMailWF();
            sendMailWF.ShowDialog();
        }
       

        private void CompanyGuideWF_Load(object sender, EventArgs e)
        {
            GetAllCompany();
        }
        private void repositoryItemBtnSms1_Click(object sender, EventArgs e)
        {
            MailOpenWindow(4);
        }
        private void repositoryItemBtnSms2_Click(object sender, EventArgs e)
        {
            MailOpenWindow(5);
        }
       
        private void repositoryItemBtnSms3_Click(object sender, EventArgs e)
        {
            MailOpenWindow(6);
        }
    }
}