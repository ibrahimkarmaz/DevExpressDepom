using DevExpress.XtraReports.UI;
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
    }
}
/*KAYNAKÇA
 * https://github.com/ibrahimkarmaz/DevExpressDepom/blob/main/RaporOlusturmaveKullanma/RaporOlusturmaveKullanma/Form1.Designer.cs
 https://docs.devexpress.com/XtraReports/9997/detailed-guide-to-devexpress-reporting/use-report-parameters/create-a-report-parameter
https://docs.devexpress.com/WindowsForms/DevExpress.XtraPrinting.PrintTool.ShowPreviewDialog 
https://supportcenter.devexpress.com/ticket/details/q292754/auto-submit-action-for-a-report-with-parameters
SON DESTEK BİLGİSİNDE ZİP İÇİNDE BAZI BİLGİLER MEVCUTTUR. 

 */