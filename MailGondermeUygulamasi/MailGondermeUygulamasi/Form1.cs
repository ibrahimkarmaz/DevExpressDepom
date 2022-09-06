using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MailGondermeUygulamasi
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BEEk.Properties.ReadOnly = true;
        }
        OpenFileDialog DosyaSec = new OpenFileDialog();
        private void BEEk_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DosyaSec.Title = "EK SEÇİNİNİZ";
            DosyaSec.Multiselect = false;
            DosyaSec.RestoreDirectory = true;
            //DosyaSec.Filter
            if (DosyaSec.ShowDialog()==DialogResult.OK)
            {
                BEEk.Text = DosyaSec.FileName;
            }
        }

        private void SBtnGonder_Click(object sender, EventArgs e)
        {
            MailGonder MGonder = new MailGonder();
            MGonder.Microsoft(TEGondericiAdSoyad.Text,TEGondericiMail.Text,TEGondericiParola.Text,TEAlici.Text,TEBaslik.Text,MMIcerik.Text,BEEk.Text);
        }
    }
}
