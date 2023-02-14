using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.BeginWF
{
	public partial class LoginLoadingWF : SplashScreen
	{
		public LoginLoadingWF()
		{
			InitializeComponent();
		}

		#region Overrides

		public override void ProcessCommand(Enum cmd, object arg)
		{
			base.ProcessCommand(cmd, arg);
		}

		#endregion

		public enum SplashScreenCommand
		{
		}

		private void LoginLoadingWF_Load(object sender, EventArgs e)
		{
			labelCopyright.Text = "©2016-" + DateTime.Now.Year + " Tüm Hakları Saklıdır.";
			LoginTime.Interval = 50;
			LoginTime.Start();
		}

		int sayac = 0;
		private void LoginTime_Tick(object sender, EventArgs e)
		{
			progressBarControl1.EditValue = sayac;
			if (Convert.ToInt32(progressBarControl1.EditValue)== 100)
			{
				LoginTime.Stop();
				CommercialAutomation commercialAutomation = new CommercialAutomation();
				commercialAutomation.Show();
				this.Hide();
			}
			sayac++;
		}
	}
}