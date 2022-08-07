using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Printing;
using System.Windows.Forms;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;

namespace RaporOlusturmaveKullanma
{
    public partial class RaporDeneme1 : DevExpress.XtraReports.UI.XtraReport
    {
        public RaporDeneme1()
        {
            InitializeComponent();
        }
        /*  public XRBarCode CreateCodabarBarCode(string BarCodeText)
          {//BARKOD OLUŞTURMA KODLARI
              // Bir barkod kontrolü oluşturun.
              XRBarCode barCode = new XRBarCode();

              // Barkod türünü Codabar olarak ayarlayın
              barCode.Symbology = new CodabarGenerator();

              //Barkodun ana özelliklerini ayarlayın.
              barCode.Text = BarCodeText;
              barCode.Width = 280;
              barCode.Height = 50;
              barCode.LeftF = 400;
              barCode.TopF = 20;


              // Barkod tipine özel özellikleri ayarlayın.
              ((CodabarGenerator)barCode.Symbology).StartSymbol = CodabarStartStopSymbol.C;
              ((CodabarGenerator)barCode.Symbology).StopSymbol = CodabarStartStopSymbol.D;
              ((CodabarGenerator)barCode.Symbology).WideNarrowRatio = 2.5F;

              return barCode;
          }*/
        public XRBarCode CreateQRCodeBarCode(string BarCodeText)
        {//KARE KOD OLUŞTURMA KODLARI
            // Create a bar code control.
            XRBarCode barCode = new XRBarCode();

            // Set the bar code's type to QRCode.
            barCode.Symbology = new QRCodeGenerator();

            // Adjust the bar code's main properties.
            barCode.Text = BarCodeText;
            barCode.Width = 260;
            barCode.Height = 90;
            barCode.LeftF = 580;
            barCode.TopF = 0;

            // If the AutoModule property is set to false, uncomment the next line.
            barCode.AutoModule = true;
            // barcode.Module = 3;

            // Adjust the properties specific to the bar code type.
            ((QRCodeGenerator)barCode.Symbology).CompactionMode = QRCodeCompactionMode.AlphaNumeric;
            ((QRCodeGenerator)barCode.Symbology).ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H;
            ((QRCodeGenerator)barCode.Symbology).Version = QRCodeVersion.AutoVersion;

            return barCode;
        }
        private void RaporDeneme1_BeforePrint(object sender, PrintEventArgs e)
        {
            this.TopMargin.Controls.Add(CreateQRCodeBarCode("012345678"));
            // this.TopMargin.Controls.Add(CreateCodabarBarCode("3598448816"));
        }
    }
}
