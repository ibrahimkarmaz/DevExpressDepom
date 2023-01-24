using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace PresentationLayer.Reports
{
	public partial class CustomerMovementReportX : DevExpress.XtraReports.UI.XtraReport
	{
		public CustomerMovementReportX()
		{
			InitializeComponent();
		}
		public static string IDInfo;

		private void CustomerMovementReportX_ParametersRequestBeforeShow(object sender, DevExpress.XtraReports.Parameters.ParametersRequestEventArgs e)
		{
			this.Parameters["SerialNo"].Value = IDInfo.ToString();
		}
	}
}
