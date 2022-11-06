using DevExpress.XtraEditors;
using PresentationLayer.JointTransactions;
using System;
using System.Collections;
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
    public partial class SendMailWF : DevExpress.XtraEditors.XtraForm
    {
        public SendMailWF()
        {
            InitializeComponent();
        }
        public string SenderNameSurnameInfo="ADMİN";
        public string SenderMailInfo="ben_ceza-85@hotmail.com";
        public string SenderPassword="2009.2010";

        public static string BuyerMail;

        private void SBtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        OpenFileDialog FileSelect = new OpenFileDialog();

        private void buttonEdit1_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FileSelect.Title = "EK SEÇİNİZ.";
            FileSelect.Multiselect = false;
            FileSelect.RestoreDirectory = true;
            if (FileSelect.ShowDialog()==DialogResult.OK)
            {
                BEExtra.Text = FileSelect.FileName;
            }
        }

        private void SBtnMailSend_Click(object sender, EventArgs e)
        {
            MailMessegeApi sendMail = new MailMessegeApi();
            sendMail.Microsoft(SenderNameSurnameInfo,SenderMailInfo,SenderPassword,BuyerMail,TETitle.Text,MMContents.Text,BEExtra.Text);
            XtraMessageBox.Show("E-POSTA GÖNDERİLDİ.","BAŞARILI",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }

        private void SendMailWF_Load(object sender, EventArgs e)
        {
            Console.WriteLine(BuyerMail);
        }
    }
}