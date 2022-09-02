using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SmsGondermeUygulamasi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SmsServis SmsApi = new SmsServis();
            SmsApi.SmsSender(textEdit1.Text,memoEdit1.Text);
            Console.WriteLine("Gönderildi");
        }
    }
}
