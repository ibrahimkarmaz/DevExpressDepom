namespace PresentationLayer.WinFormList.SectorWF
{
    partial class SectorUpdateWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectorUpdateWF));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CheckEArchive = new DevExpress.XtraEditors.CheckEdit();
            this.SBtnSectorNameBack = new DevExpress.XtraEditors.SimpleButton();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TESectorName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEArchive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESectorName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 16);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Sektör Adı:";
            // 
            // CheckEArchive
            // 
            this.CheckEArchive.Location = new System.Drawing.Point(118, 48);
            this.CheckEArchive.Name = "CheckEArchive";
            this.CheckEArchive.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckEArchive.Properties.Appearance.Options.UseFont = true;
            this.CheckEArchive.Properties.Caption = "Sektörü Arşivle";
            this.CheckEArchive.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.CheckEArchive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CheckEArchive.Size = new System.Drawing.Size(207, 22);
            this.CheckEArchive.TabIndex = 41;
            // 
            // SBtnSectorNameBack
            // 
            this.SBtnSectorNameBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnBlandNameBack.ImageOptions.Image")));
            this.SBtnSectorNameBack.Location = new System.Drawing.Point(333, 12);
            this.SBtnSectorNameBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSectorNameBack.Name = "SBtnSectorNameBack";
            this.SBtnSectorNameBack.Size = new System.Drawing.Size(26, 30);
            this.SBtnSectorNameBack.TabIndex = 40;
            this.SBtnSectorNameBack.Click += new System.EventHandler(this.SBtnSectorNameBack_Click);
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(118, 76);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(108, 39);
            this.SBCancel.TabIndex = 39;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnUpdate
            // 
            this.SBtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnUpdate.ImageOptions.Image")));
            this.SBtnUpdate.Location = new System.Drawing.Point(234, 76);
            this.SBtnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnUpdate.Name = "SBtnUpdate";
            this.SBtnUpdate.Size = new System.Drawing.Size(125, 39);
            this.SBtnUpdate.TabIndex = 38;
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
            this.pictureEdit1.TabIndex = 37;
            // 
            // TESectorName
            // 
            this.TESectorName.Location = new System.Drawing.Point(118, 12);
            this.TESectorName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TESectorName.Name = "TESectorName";
            this.TESectorName.Size = new System.Drawing.Size(207, 30);
            this.TESectorName.TabIndex = 36;
            // 
            // SectorUpdateWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 126);
            this.Controls.Add(this.CheckEArchive);
            this.Controls.Add(this.SBtnSectorNameBack);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnUpdate);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TESectorName);
            this.Controls.Add(this.labelControl1);
            this.Name = "SectorUpdateWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEKTÖR BİLGİSİNİ DÜZENLE";
            this.Load += new System.EventHandler(this.SectorUpdateWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckEArchive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESectorName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit CheckEArchive;
        private DevExpress.XtraEditors.SimpleButton SBtnSectorNameBack;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnUpdate;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TESectorName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}