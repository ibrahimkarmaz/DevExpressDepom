namespace PresentationLayer.WinFormList.MapControlListWF.EmployeeMapControlWF
{
	partial class EmployeeMapControlWF
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
			this.dashboardDesigner2 = new DevExpress.DashboardWin.DashboardDesigner();
			this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dashboardDesigner2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
			this.SuspendLayout();
			// 
			// dashboardDesigner2
			// 
			this.dashboardDesigner2.AsyncMode = true;
			this.dashboardDesigner2.Location = new System.Drawing.Point(682, 39);
			this.dashboardDesigner2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.dashboardDesigner2.Name = "dashboardDesigner2";
			this.dashboardDesigner2.Size = new System.Drawing.Size(44, 8);
			this.dashboardDesigner2.TabIndex = 1;
			// 
			// dashboardViewer1
			// 
			this.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dashboardViewer1.Appearance.Options.UseBackColor = true;
			this.dashboardViewer1.AsyncMode = true;
			this.dashboardViewer1.DashboardSource = new System.Uri("C:\\Users\\ibrah\\OneDrive\\Belgeler\\GitHub\\DevExpressDepom\\TOProjectV2\\PresentationL" +
        "ayer\\MapControlList\\EmployeeMapControl\\EmployeeMap.xml", System.UriKind.Absolute);
			this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
			this.dashboardViewer1.Name = "dashboardViewer1";
			this.dashboardViewer1.Size = new System.Drawing.Size(1187, 514);
			this.dashboardViewer1.TabIndex = 2;
			// 
			// EmployeeMapControlWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1187, 514);
			this.Controls.Add(this.dashboardViewer1);
			this.Controls.Add(this.dashboardDesigner2);
			this.Name = "EmployeeMapControlWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "PERSONEL HARİTASİ";
			((System.ComponentModel.ISupportInitialize)(this.dashboardDesigner2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.DashboardWin.DashboardDesigner dashboardDesigner2;
		private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
	}
}