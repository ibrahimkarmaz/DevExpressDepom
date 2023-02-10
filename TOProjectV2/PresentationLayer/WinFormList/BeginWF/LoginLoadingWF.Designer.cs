namespace PresentationLayer.WinFormList.BeginWF
{
	partial class LoginLoadingWF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginLoadingWF));
			this.progressBarControl = new DevExpress.XtraEditors.MarqueeProgressBarControl();
			this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
			this.labelStatus = new DevExpress.XtraEditors.LabelControl();
			this.peImage = new DevExpress.XtraEditors.PictureEdit();
			this.peLogo = new DevExpress.XtraEditors.PictureEdit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// progressBarControl
			// 
			this.progressBarControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.progressBarControl.EditValue = 0;
			this.progressBarControl.Location = new System.Drawing.Point(4, 199);
			this.progressBarControl.Name = "progressBarControl";
			this.progressBarControl.Properties.ProgressAnimationMode = DevExpress.Utils.Drawing.ProgressAnimationMode.PingPong;
			this.progressBarControl.Properties.ShowTitle = true;
			this.progressBarControl.Size = new System.Drawing.Size(460, 27);
			this.progressBarControl.TabIndex = 5;
			// 
			// labelCopyright
			// 
			this.labelCopyright.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelCopyright.Appearance.Options.UseFont = true;
			this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.labelCopyright.Location = new System.Drawing.Point(4, 273);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(129, 19);
			this.labelCopyright.TabIndex = 6;
			this.labelCopyright.Text = "KARMAZ YAZILIM";
			// 
			// labelStatus
			// 
			this.labelStatus.Location = new System.Drawing.Point(4, 180);
			this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(65, 15);
			this.labelStatus.TabIndex = 7;
			this.labelStatus.Text = "Yükleniyor...";
			// 
			// peImage
			// 
			this.peImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.peImage.EditValue = ((object)(resources.GetObject("peImage.EditValue")));
			this.peImage.Location = new System.Drawing.Point(1, 1);
			this.peImage.Name = "peImage";
			this.peImage.Properties.AllowFocused = false;
			this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.peImage.Properties.Appearance.Options.UseBackColor = true;
			this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.peImage.Properties.ShowMenu = false;
			this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.peImage.Properties.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.None;
			this.peImage.Size = new System.Drawing.Size(466, 173);
			this.peImage.TabIndex = 9;
			// 
			// peLogo
			// 
			this.peLogo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.peLogo.EditValue = ((object)(resources.GetObject("peLogo.EditValue")));
			this.peLogo.Location = new System.Drawing.Point(288, 250);
			this.peLogo.Name = "peLogo";
			this.peLogo.Properties.AllowFocused = false;
			this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.peLogo.Properties.Appearance.Options.UseBackColor = true;
			this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.peLogo.Properties.ShowMenu = false;
			this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze;
			this.peLogo.Size = new System.Drawing.Size(176, 42);
			this.peLogo.TabIndex = 8;
			// 
			// LoginLoadingWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(468, 301);
			this.Controls.Add(this.peImage);
			this.Controls.Add(this.peLogo);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.labelCopyright);
			this.Controls.Add(this.progressBarControl);
			this.Name = "LoginLoadingWF";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.Text = "LoginLoadingWF";
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.MarqueeProgressBarControl progressBarControl;
		private DevExpress.XtraEditors.LabelControl labelCopyright;
		private DevExpress.XtraEditors.LabelControl labelStatus;
		private DevExpress.XtraEditors.PictureEdit peLogo;
		private DevExpress.XtraEditors.PictureEdit peImage;
	}
}
