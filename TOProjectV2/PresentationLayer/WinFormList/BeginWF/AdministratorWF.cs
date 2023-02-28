using DevExpress.XtraEditors;
using PresentationLayer.WinFormList.MapControlListWF.EmployeeMapControlWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.BeginWF
{
	public partial class AdministratorWF : DevExpress.XtraEditors.XtraForm
	{
		public AdministratorWF()
		{
			InitializeComponent();
		}

		private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{

		}


		EmployeeMapControlWF employeeMapControlWF;
		private void barEmployeeDistrictMAP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
		{
			if (employeeMapControlWF==null || employeeMapControlWF.IsDisposed)
			{
				employeeMapControlWF = new EmployeeMapControlWF();
				employeeMapControlWF.MdiParent = this;
				employeeMapControlWF.Show();
			}
		}
	}
}