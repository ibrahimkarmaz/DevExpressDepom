using DevExpress.XtraReports.UI;
using PresentationLayer.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XtraReport1.IDInfo = 2;
            XtraReport1 a = new XtraReport1();
            a.RequestParameters =false;
            a.ShowPreviewDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* InvoiceReport aa = new InvoiceReport();
             aa.ShowPreviewDialog();*/

            InvReport aaaa = new InvReport();
            aaaa.ShowPreviewDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Report1 aaaaa = new Report1();
            aaaaa.ShowPreviewDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CompanyMovementReport.IDInfo = "12";
            CompanyMovementReport aaaa = new CompanyMovementReport();
            aaaa.RequestParameters = false;
            aaaa.ShowPreviewDialog();
        }
    }
}
/*KAYNAKÇA
 * https://github.com/ibrahimkarmaz/DevExpressDepom/blob/main/RaporOlusturmaveKullanma/RaporOlusturmaveKullanma/Form1.Designer.cs
 https://docs.devexpress.com/XtraReports/9997/detailed-guide-to-devexpress-reporting/use-report-parameters/create-a-report-parameter
https://docs.devexpress.com/WindowsForms/DevExpress.XtraPrinting.PrintTool.ShowPreviewDialog 
https://supportcenter.devexpress.com/ticket/details/q292754/auto-submit-action-for-a-report-with-parameters
SON DESTEK BİLGİSİNDE ZİP İÇİNDE BAZI BİLGİLER MEVCUTTUR. 

 */