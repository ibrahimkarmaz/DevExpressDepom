using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace PresentationLayer.Reports
{
    public partial class CompanyMovementReport : DevExpress.XtraReports.UI.XtraReport
    {
        public CompanyMovementReport()
        {
            InitializeComponent();
        }
        public static string IDInfo;
        private void CompanyMovementReport_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
        {
            this.Parameters["SerialNo"].Value = IDInfo.ToString();
        }


    }
}
/*KAYNAKÇA
 * https://github.com/ibrahimkarmaz/DevExpressDepom/blob/main/RaporOlusturmaveKullanma/RaporOlusturmaveKullanma/Form1.Designer.cs
 https://docs.devexpress.com/XtraReports/9997/detailed-guide-to-devexpress-reporting/use-report-parameters/create-a-report-parameter
https://docs.devexpress.com/WindowsForms/DevExpress.XtraPrinting.PrintTool.ShowPreviewDialog 
https://supportcenter.devexpress.com/ticket/details/q292754/auto-submit-action-for-a-report-with-parameters
SON DESTEK BİLGİSİNDE ZİP İÇİNDE BAZI BİLGİLER MEVCUTTUR. 


//ŞARTA BAĞLI VERİ GETİRME VE FİYAT GETİRME EXPENSE FİLTERLA KISIMLA ILIGLI :)
https://supportcenter.devexpress.com/ticket/details/t644276/expressions-and-conditional-sum


 */