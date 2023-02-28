namespace PresentationLayer.WinFormList.MapControlListWF.CompanyMapControlWF
{
	partial class CompanyMapControlWF
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPageDistrictMap = new DevExpress.XtraTab.XtraTabPage();
			this.dashboardViewer2 = new DevExpress.DashboardWin.DashboardViewer(this.components);
			this.xtraTabPageCountyMap = new DevExpress.XtraTab.XtraTabPage();
			this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPageDistrictMap.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dashboardViewer2)).BeginInit();
			this.xtraTabPageCountyMap.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
			this.SuspendLayout();
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseBackColor = true;
			this.xtraTabControl1.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InTabControlHeader;
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.HeaderLocation = DevExpress.XtraTab.TabHeaderLocation.Right;
			this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
			this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.True;
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPageCountyMap;
			this.xtraTabControl1.Size = new System.Drawing.Size(1093, 499);
			this.xtraTabControl1.TabIndex = 0;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageCountyMap,
            this.xtraTabPageDistrictMap});
			// 
			// xtraTabPageDistrictMap
			// 
			this.xtraTabPageDistrictMap.Controls.Add(this.dashboardViewer2);
			this.xtraTabPageDistrictMap.Name = "xtraTabPageDistrictMap";
			this.xtraTabPageDistrictMap.Size = new System.Drawing.Size(954, 497);
			this.xtraTabPageDistrictMap.Text = "FİRMA İLÇE HARİTASİ";
			// 
			// dashboardViewer2
			// 
			this.dashboardViewer2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dashboardViewer2.Appearance.Options.UseBackColor = true;
			this.dashboardViewer2.AsyncMode = true;
			this.dashboardViewer2.DashboardSource = new System.Uri("C:\\Users\\ibrah\\OneDrive\\Belgeler\\GitHub\\DevExpressDepom\\TOProjectV2\\PresentationL" +
        "ayer\\MapControlList\\CompanyMapControl\\CompanyDistrictMapControl.xml", System.UriKind.Absolute);
			this.dashboardViewer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dashboardViewer2.Location = new System.Drawing.Point(0, 0);
			this.dashboardViewer2.Name = "dashboardViewer2";
			this.dashboardViewer2.Size = new System.Drawing.Size(954, 497);
			this.dashboardViewer2.TabIndex = 0;
			// 
			// xtraTabPageCountyMap
			// 
			this.xtraTabPageCountyMap.Controls.Add(this.dashboardViewer1);
			this.xtraTabPageCountyMap.Name = "xtraTabPageCountyMap";
			this.xtraTabPageCountyMap.Size = new System.Drawing.Size(1062, 497);
			this.xtraTabPageCountyMap.Text = "FİRMA İL HARİTASİ";
			// 
			// dashboardViewer1
			// 
			this.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dashboardViewer1.Appearance.Options.UseBackColor = true;
			this.dashboardViewer1.AsyncMode = true;
			this.dashboardViewer1.DashboardSource = new System.Uri("C:\\Users\\ibrah\\OneDrive\\Belgeler\\GitHub\\DevExpressDepom\\TOProjectV2\\PresentationL" +
        "ayer\\MapControlList\\CompanyMapControl\\CompanyCountyMapControl.xml", System.UriKind.Absolute);
			this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
			this.dashboardViewer1.Name = "dashboardViewer1";
			this.dashboardViewer1.Size = new System.Drawing.Size(1062, 497);
			this.dashboardViewer1.TabIndex = 0;
			// 
			// CompanyMapControlWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1093, 499);
			this.Controls.Add(this.xtraTabControl1);
			this.Name = "CompanyMapControlWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FİRMA HARİTASİ";
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPageDistrictMap.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dashboardViewer2)).EndInit();
			this.xtraTabPageCountyMap.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPageDistrictMap;
		private DevExpress.DashboardWin.DashboardViewer dashboardViewer2;
		private DevExpress.XtraTab.XtraTabPage xtraTabPageCountyMap;
		private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
	}
}