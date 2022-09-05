using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MesajKutusuUzerindeDegisikler
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.AutoCloseOptions.Delay = 5000;
            args.Caption = "Auto-close message";
            args.Text = "This message closes automatically after 5 seconds.";
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            XtraMessageBox.Show(args).ToString();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            XtraMessageBoxArgs args = new XtraMessageBoxArgs();
            args.Caption = "Message";
            args.Text = "Buttons in this message box show custom images.";
           // args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel, DialogResult.Retry };
            args.Buttons = new DialogResult[] { DialogResult.OK, DialogResult.Cancel };
            args.Showing += Args_Showing;
            DialogResult a= XtraMessageBox.Show(args);
            if (a==DialogResult.OK)
            {
                Console.WriteLine("das");
            }
        }
        private void Args_Showing(object sender, XtraMessageShowingArgs e)
        {
            e.Buttons[DialogResult.OK].Text = "Custom OK Text";
           // e.Buttons[DialogResult.OK].Width = 200;
            e.Buttons[DialogResult.Cancel].Text = "Custom Cancel Text";
            //e.Buttons[DialogResult.Cancel].Width = 200;
            foreach (var control in e.Form.Controls)
            {
                SimpleButton button = control as SimpleButton;
                if (button != null)
                {
                    button.ImageOptions.SvgImageSize = new Size(16, 16);
                     //button.Height = 25;
                    switch (button.DialogResult.ToString())
                    {
                        case ("OK"):
                            button.ImageOptions.SvgImage = svgImageCollection1[0];
                            break;
                        case ("Cancel"):
                            button.ImageOptions.SvgImage = svgImageCollection1[1];
                            break;
                      /*  case ("Retry"):
                            button.ImageOptions.SvgImage = svgImageCollection1[2];
                            break;*/
                    }
                }
            }
        }
        //KAYNAKÇA
        //https://docs.devexpress.com/WindowsForms/114566/controls-and-libraries/messages-notifications-and-dialogs/xtramessagebox
        //NOT 1:BUTONLARI ORTALAMAK İÇİN YÖNTEM VAR FAKAT KULLANILAMADI(ARAŞTIR)
        //NOT 2:BUTTONLARIN BOYUTLARI AYARLANABİLİYOR KAPATILDI BAKILABİLİR.
    }
}
