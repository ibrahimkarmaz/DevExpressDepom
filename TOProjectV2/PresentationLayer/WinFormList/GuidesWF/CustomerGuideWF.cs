using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using PresentationLayer.WinFormList.CustomerWF;
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
    public partial class CustomerGuideWF : DevExpress.XtraEditors.XtraForm
    {
        public CustomerGuideWF()
        {
            InitializeComponent();
        }
        CustomerManager _customerManager = new CustomerManager(new EFCustomerDAL());
        private void CustomertGetAllList()
        {
            GControlCustomer.DataSource = _customerManager.CustomerGetList(x => x.CustomerArchive == true);
        }
        private void CustomerGuideWF_Load(object sender, EventArgs e)
        {
            CustomertGetAllList();
        }

        private void repositoryItemBtnMail_Click(object sender, EventArgs e)
        {
            SendMailWF.BuyerMail = GViewCustomer.GetRowCellValue(GViewCustomer.FocusedRowHandle, GViewCustomer.Columns[7]).ToString();
            SendMailWF sendMailWF = new SendMailWF();
            sendMailWF.ShowDialog();
        }
        private void SmsOpenWindow(int ColumnIndex)
        {
            try
            {
                SMSSenderWF.PhoneInfo = GViewCustomer.GetRowCellValue(GViewCustomer.FocusedRowHandle, GViewCustomer.Columns[ColumnIndex]).ToString();
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

        private void repositoryItemBtnSms2_Click(object sender, EventArgs e)
        {
            SmsOpenWindow(6);

        }
    }
}