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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginLoadingWF));
			this.labelStatus = new DevExpress.XtraEditors.LabelControl();
			this.labelCopyright = new DevExpress.XtraEditors.LabelControl();
			this.peLogo = new DevExpress.XtraEditors.PictureEdit();
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.progressBarControl1 = new DevExpress.XtraEditors.ProgressBarControl();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.LoginTime = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// labelStatus
			// 
			this.labelStatus.Location = new System.Drawing.Point(4, 24);
			this.labelStatus.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.labelStatus.Name = "labelStatus";
			this.labelStatus.Size = new System.Drawing.Size(65, 15);
			this.labelStatus.TabIndex = 7;
			this.labelStatus.Text = "Yükleniyor...";
			// 
			// labelCopyright
			// 
			this.labelCopyright.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelCopyright.Appearance.Options.UseFont = true;
			this.labelCopyright.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.labelCopyright.Location = new System.Drawing.Point(4, 98);
			this.labelCopyright.Name = "labelCopyright";
			this.labelCopyright.Size = new System.Drawing.Size(149, 19);
			this.labelCopyright.TabIndex = 6;
			this.labelCopyright.Text = "Tüm Hakları Saklıdır.";
			// 
			// peLogo
			// 
			this.peLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.peLogo.EditValue = ((object)(resources.GetObject("peLogo.EditValue")));
			this.peLogo.Location = new System.Drawing.Point(370, 24);
			this.peLogo.Name = "peLogo";
			this.peLogo.Properties.AllowFocused = false;
			this.peLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.peLogo.Properties.Appearance.Options.UseBackColor = true;
			this.peLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.peLogo.Properties.ShowMenu = false;
			this.peLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.peLogo.Size = new System.Drawing.Size(108, 27);
			this.peLogo.TabIndex = 8;
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(370, 64);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.AllowFocused = false;
			this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.ShowMenu = false;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(38, 28);
			this.pictureEdit1.TabIndex = 9;
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
			this.pictureEdit2.Location = new System.Drawing.Point(431, 64);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.AllowFocused = false;
			this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit2.Properties.ShowMenu = false;
			this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit2.Size = new System.Drawing.Size(38, 28);
			this.pictureEdit2.TabIndex = 10;
			// 
			// progressBarControl1
			// 
			this.progressBarControl1.Location = new System.Drawing.Point(4, 4);
			this.progressBarControl1.Name = "progressBarControl1";
			this.progressBarControl1.Size = new System.Drawing.Size(474, 14);
			this.progressBarControl1.TabIndex = 11;
			// 
			// labelControl1
			// 
			this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(370, 101);
			this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(99, 16);
			this.labelControl1.TabIndex = 12;
			this.labelControl1.Text = "ve daha fazlası...";
			// 
			// LoginTime
			// 
			this.LoginTime.Tick += new System.EventHandler(this.LoginTime_Tick);
			// 
			// LoginLoadingWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(482, 123);
			this.Controls.Add(this.labelControl1);
			this.Controls.Add(this.progressBarControl1);
			this.Controls.Add(this.pictureEdit2);
			this.Controls.Add(this.pictureEdit1);
			this.Controls.Add(this.peLogo);
			this.Controls.Add(this.labelStatus);
			this.Controls.Add(this.labelCopyright);
			this.Name = "LoginLoadingWF";
			this.Padding = new System.Windows.Forms.Padding(1);
			this.Text = "LoginLoadingWF";
			this.Load += new System.EventHandler(this.LoginLoadingWF_Load);
			((System.ComponentModel.ISupportInitialize)(this.peLogo.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.progressBarControl1.Properties)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DevExpress.XtraEditors.LabelControl labelStatus;
		private DevExpress.XtraEditors.LabelControl labelCopyright;
		private DevExpress.XtraEditors.PictureEdit peLogo;
		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.PictureEdit pictureEdit2;
		private DevExpress.XtraEditors.ProgressBarControl progressBarControl1;
		private DevExpress.XtraEditors.LabelControl labelControl1;
		private System.Windows.Forms.Timer LoginTime;
	}
}
