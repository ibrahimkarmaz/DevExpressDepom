using DevExpress.XtraEditors;
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

namespace PresentationLayer.Reports
{
	public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
	{
		public XtraForm1()
		{
			InitializeComponent();
		}

		private void simpleButton2_Click(object sender, EventArgs e)
		{
			CustomerMovementReportX aa = new CustomerMovementReportX();
			aa.ShowPreviewDialog();
		}
	}
}