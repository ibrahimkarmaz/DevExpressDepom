﻿namespace PresentationLayer.WinFormList.ProductStockWF
{
	partial class ProductStocksControlWF
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
			this.dashboardViewer1 = new DevExpress.DashboardWin.DashboardViewer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).BeginInit();
			this.SuspendLayout();
			// 
			// dashboardViewer1
			// 
			this.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
			this.dashboardViewer1.Appearance.Options.UseBackColor = true;
			this.dashboardViewer1.AsyncMode = true;
			this.dashboardViewer1.DashboardSource = new System.Uri("C:\\Users\\ibrah\\OneDrive\\Belgeler\\GitHub\\DevExpressDepom\\TOProjectV2\\PresentationL" +
        "ayer\\Reports\\StokKontrol.xml", System.UriKind.Absolute);
			this.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dashboardViewer1.Location = new System.Drawing.Point(0, 0);
			this.dashboardViewer1.Name = "dashboardViewer1";
			this.dashboardViewer1.Size = new System.Drawing.Size(1113, 498);
			this.dashboardViewer1.TabIndex = 4;
			this.dashboardViewer1.UseNeutralFilterMode = true;
			// 
			// ProductStocksControlWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1113, 498);
			this.Controls.Add(this.dashboardViewer1);
			this.Name = "ProductStocksControlWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ÜRÜN STOK KONTROL";
			((System.ComponentModel.ISupportInitialize)(this.dashboardViewer1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.DashboardWin.DashboardViewer dashboardViewer1;
	}
}