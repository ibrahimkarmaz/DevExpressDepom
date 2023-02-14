namespace PresentationLayer.WinFormList.BeginWF
{
	partial class LoginWF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWF));
			this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
			this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
			this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
			this.TEUserName = new DevExpress.XtraEditors.TextEdit();
			this.TEPassword = new DevExpress.XtraEditors.TextEdit();
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
			this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
			this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
			this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
			this.groupControl2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TEUserName.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TEPassword.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// pictureEdit1
			// 
			this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.No;
			this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
			this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
			this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
			this.pictureEdit1.Name = "pictureEdit1";
			this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit1.Size = new System.Drawing.Size(556, 296);
			this.pictureEdit1.TabIndex = 0;
			// 
			// groupControl1
			// 
			this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
			this.groupControl1.Location = new System.Drawing.Point(0, 296);
			this.groupControl1.Name = "groupControl1";
			this.groupControl1.Size = new System.Drawing.Size(233, 223);
			this.groupControl1.TabIndex = 1;
			this.groupControl1.Text = "Diğer İşlemler";
			// 
			// groupControl2
			// 
			this.groupControl2.Controls.Add(this.labelControl3);
			this.groupControl2.Controls.Add(this.pictureEdit3);
			this.groupControl2.Controls.Add(this.labelControl2);
			this.groupControl2.Controls.Add(this.pictureEdit2);
			this.groupControl2.Controls.Add(this.labelControl1);
			this.groupControl2.Controls.Add(this.simpleButton3);
			this.groupControl2.Controls.Add(this.simpleButton2);
			this.groupControl2.Controls.Add(this.TEPassword);
			this.groupControl2.Controls.Add(this.TEUserName);
			this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControl2.Location = new System.Drawing.Point(233, 296);
			this.groupControl2.Name = "groupControl2";
			this.groupControl2.Size = new System.Drawing.Size(323, 223);
			this.groupControl2.TabIndex = 2;
			this.groupControl2.Text = "Giriş İşlemleri";
			// 
			// TEUserName
			// 
			this.TEUserName.Location = new System.Drawing.Point(6, 61);
			this.TEUserName.Name = "TEUserName";
			this.TEUserName.Properties.NullValuePrompt = "Kullanıcı Adınızı Giriniz";
			this.TEUserName.Size = new System.Drawing.Size(298, 30);
			this.TEUserName.TabIndex = 0;
			// 
			// TEPassword
			// 
			this.TEPassword.Location = new System.Drawing.Point(6, 123);
			this.TEPassword.Name = "TEPassword";
			this.TEPassword.Properties.NullValuePrompt = "Parolanızı Giriniz";
			this.TEPassword.Properties.UseSystemPasswordChar = true;
			this.TEPassword.Size = new System.Drawing.Size(298, 30);
			this.TEPassword.TabIndex = 1;
			// 
			// simpleButton2
			// 
			this.simpleButton2.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
			this.simpleButton2.AppearanceHovered.Options.UseFont = true;
			this.simpleButton2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
			this.simpleButton2.Location = new System.Drawing.Point(125, 177);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(178, 37);
			this.simpleButton2.TabIndex = 1;
			this.simpleButton2.Text = "GİRİŞ YAP";
			// 
			// simpleButton3
			// 
			this.simpleButton3.AppearanceHovered.FontStyleDelta = System.Drawing.FontStyle.Bold;
			this.simpleButton3.AppearanceHovered.Options.UseFont = true;
			this.simpleButton3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
			this.simpleButton3.Location = new System.Drawing.Point(5, 177);
			this.simpleButton3.Name = "simpleButton3";
			this.simpleButton3.Size = new System.Drawing.Size(114, 37);
			this.simpleButton3.TabIndex = 2;
			this.simpleButton3.Text = "ÇIKIŞ YAP";
			// 
			// labelControl1
			// 
			this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl1.Appearance.Options.UseFont = true;
			this.labelControl1.Location = new System.Drawing.Point(37, 37);
			this.labelControl1.Name = "labelControl1";
			this.labelControl1.Size = new System.Drawing.Size(82, 18);
			this.labelControl1.TabIndex = 3;
			this.labelControl1.Text = "Kullanıcı Adı:";
			// 
			// pictureEdit2
			// 
			this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
			this.pictureEdit2.Location = new System.Drawing.Point(6, 35);
			this.pictureEdit2.Name = "pictureEdit2";
			this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit2.Size = new System.Drawing.Size(20, 20);
			this.pictureEdit2.TabIndex = 4;
			// 
			// pictureEdit3
			// 
			this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
			this.pictureEdit3.Location = new System.Drawing.Point(6, 97);
			this.pictureEdit3.Name = "pictureEdit3";
			this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit3.Size = new System.Drawing.Size(20, 20);
			this.pictureEdit3.TabIndex = 6;
			// 
			// labelControl2
			// 
			this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl2.Appearance.Options.UseFont = true;
			this.labelControl2.Location = new System.Drawing.Point(37, 99);
			this.labelControl2.Name = "labelControl2";
			this.labelControl2.Size = new System.Drawing.Size(47, 18);
			this.labelControl2.TabIndex = 5;
			this.labelControl2.Text = "Parola:";
			// 
			// labelControl3
			// 
			this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelControl3.Appearance.Options.UseFont = true;
			this.labelControl3.AppearanceHovered.ForeColor = System.Drawing.Color.Red;
			this.labelControl3.AppearanceHovered.Options.UseForeColor = true;
			this.labelControl3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.labelControl3.Location = new System.Drawing.Point(198, 155);
			this.labelControl3.Name = "labelControl3";
			this.labelControl3.Size = new System.Drawing.Size(105, 16);
			this.labelControl3.TabIndex = 7;
			this.labelControl3.Text = "Parolamı Unuttum";
			// 
			// LoginWF
			// 
			this.Appearance.BackColor = System.Drawing.Color.White;
			this.Appearance.Options.UseBackColor = true;
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 519);
			this.Controls.Add(this.groupControl2);
			this.Controls.Add(this.groupControl1);
			this.Controls.Add(this.pictureEdit1);
			this.Name = "LoginWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Giriş Penceresi";
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
			this.groupControl2.ResumeLayout(false);
			this.groupControl2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TEUserName.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TEPassword.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.PictureEdit pictureEdit1;
		private DevExpress.XtraEditors.GroupControl groupControl1;
		private DevExpress.XtraEditors.GroupControl groupControl2;
		private DevExpress.XtraEditors.SimpleButton simpleButton2;
		private DevExpress.XtraEditors.TextEdit TEPassword;
		private DevExpress.XtraEditors.TextEdit TEUserName;
		private DevExpress.XtraEditors.SimpleButton simpleButton3;
		private DevExpress.XtraEditors.LabelControl labelControl3;
		private DevExpress.XtraEditors.PictureEdit pictureEdit3;
		private DevExpress.XtraEditors.LabelControl labelControl2;
		private DevExpress.XtraEditors.PictureEdit pictureEdit2;
		private DevExpress.XtraEditors.LabelControl labelControl1;
	}
}