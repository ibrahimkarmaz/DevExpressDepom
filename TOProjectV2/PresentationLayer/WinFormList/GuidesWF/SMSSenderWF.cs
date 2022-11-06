using DevExpress.XtraEditors;
using PresentationLayer.JointTransactions;
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
    public partial class SMSSenderWF : DevExpress.XtraEditors.XtraForm
    {
        public SMSSenderWF()
        {
            InitializeComponent();
        }
        public static string PhoneInfo = "";

        private void MMSmsIcerigi_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (MMSmsContent.Text.Count() <= 150)
                {
                    labelControl2.Text = MMSmsContent.Text.Count() + "/150";
                }
            }
            catch
            { }
        }

        private void SBtnIptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnGonder_Click(object sender, EventArgs e)
        {
            SmsService smsApi = new SmsService();
            smsApi.SmsSender(PhoneInfo,MMSmsContent.Text);
            XtraMessageBox.Show("SMS GÖNDERİLDİ", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void SMSSenderWF_Load(object sender, EventArgs e)
        {
            Console.WriteLine(PhoneInfo);
        }
    }
}