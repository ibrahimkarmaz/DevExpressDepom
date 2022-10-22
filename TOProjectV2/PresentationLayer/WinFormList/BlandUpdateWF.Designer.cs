namespace PresentationLayer.WinFormList
{
    partial class BlandUpdateWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlandUpdateWF));
            this.SBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TEBlandName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnBlandNameBack = new DevExpress.XtraEditors.SimpleButton();
            this.CheckEArchive = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEBlandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEArchive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // SBtnUpdate
            // 
            this.SBtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnUpdate.ImageOptions.Image")));
            this.SBtnUpdate.Location = new System.Drawing.Point(223, 76);
            this.SBtnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnUpdate.Name = "SBtnUpdate";
            this.SBtnUpdate.Size = new System.Drawing.Size(125, 39);
            this.SBtnUpdate.TabIndex = 31;
            this.SBtnUpdate.Text = "Düzenle";
            this.SBtnUpdate.Click += new System.EventHandler(this.SBtnUpdate_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(13, 12);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit1.TabIndex = 30;
            // 
            // TEBlandName
            // 
            this.TEBlandName.Location = new System.Drawing.Point(107, 12);
            this.TEBlandName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEBlandName.Name = "TEBlandName";
            this.TEBlandName.Size = new System.Drawing.Size(207, 30);
            this.TEBlandName.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 16);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Tür Adı:";
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(107, 76);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(108, 39);
            this.SBCancel.TabIndex = 32;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnBlandNameBack
            // 
            this.SBtnBlandNameBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnBlandNameBack.ImageOptions.Image")));
            this.SBtnBlandNameBack.Location = new System.Drawing.Point(322, 12);
            this.SBtnBlandNameBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnBlandNameBack.Name = "SBtnBlandNameBack";
            this.SBtnBlandNameBack.Size = new System.Drawing.Size(26, 30);
            this.SBtnBlandNameBack.TabIndex = 33;
            this.SBtnBlandNameBack.Click += new System.EventHandler(this.SBtnBlandNameBack_Click);
            // 
            // CheckEArchive
            // 
            this.CheckEArchive.Location = new System.Drawing.Point(107, 48);
            this.CheckEArchive.Name = "CheckEArchive";
            this.CheckEArchive.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckEArchive.Properties.Appearance.Options.UseFont = true;
            this.CheckEArchive.Properties.Caption = "Markayı Arşivle";
            this.CheckEArchive.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.CheckEArchive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CheckEArchive.Size = new System.Drawing.Size(207, 22);
            this.CheckEArchive.TabIndex = 34;
            // 
            // BlandUpdateWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 126);
            this.Controls.Add(this.CheckEArchive);
            this.Controls.Add(this.SBtnBlandNameBack);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnUpdate);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TEBlandName);
            this.Controls.Add(this.labelControl1);
            this.Name = "BlandUpdateWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARKA BİLGİSİNİ DÜZENLE";
            this.Load += new System.EventHandler(this.BlandUpdateWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEBlandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEArchive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton SBtnUpdate;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TEBlandName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnBlandNameBack;
        private DevExpress.XtraEditors.CheckEdit CheckEArchive;
    }
}