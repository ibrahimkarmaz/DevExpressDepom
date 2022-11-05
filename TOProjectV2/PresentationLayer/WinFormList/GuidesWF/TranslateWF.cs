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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PresentationLayer.WinFormList.GuidesWF
{
    public partial class TranslateWF : DevExpress.XtraEditors.XtraForm
    {
        public TranslateWF()
        {
            InitializeComponent();
        }
        WebBrowser Trans = new WebBrowser();
        private void TranslateWF_Load(object sender, EventArgs e)
        {
            try
            {
                timer1.Interval = 1000;
                //YAZILIRKEN ÇEVRİLİR
                Trans.Navigate("https://www.bing.com/translator");
                Trans.ScriptErrorsSuppressed = true;
                timer1.Start();
            }
            catch (Exception)
            {
                Console.WriteLine("HATA OLUŞTU");
            }
        }

        private void SBtnIptalEt_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnTranslate_Click(object sender, EventArgs e)
        {
            try
            {
                a = 0;
                timer1.Start();
            }
            catch
            {
            }
        }

        private void MMTurkey_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                Trans.Document.GetElementById("tta_input_ta").InnerText = MMTurkey.Text;
            }
            catch
            {
            }
        }
        int a = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (a == 2)
                timer1.Stop();
            try
            {
                MMGB.Text = Trans.Document.GetElementById("tta_output_ta").InnerText;
                a++;
            }
            catch
            {
            }
        }

        private void PEVolTurkey_Click(object sender, EventArgs e)
        {
            Trans.Document.GetElementById("tta_playiconsrc").InvokeMember("click");
        }

        private void PEVolENG_Click(object sender, EventArgs e)
        {
            Trans.Document.GetElementById("tta_playicontgt").InvokeMember("click");
        }
    }
}