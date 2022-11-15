using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;

namespace PresentationLayer.WinFormList
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }
        public static int IDInfo;

        private void XtraReport1_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.Parameters["ProductIDSet"].Value = IDInfo.ToString();
            Console.WriteLine(this.Parameters["ProductIDSet"].Value);
            
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