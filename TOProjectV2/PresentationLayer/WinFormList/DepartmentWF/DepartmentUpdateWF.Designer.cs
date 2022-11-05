namespace PresentationLayer.WinFormList.DepartmentWF
{
    partial class DepartmentUpdateWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentUpdateWF));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CheckEArchive = new DevExpress.XtraEditors.CheckEdit();
            this.SBtnDepartmentNameBack = new DevExpress.XtraEditors.SimpleButton();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TEDepartmentName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEArchive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEDepartmentName.Properties)).BeginInit();
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
            this.labelControl1.TabIndex = 42;
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
            this.CheckEArchive.TabIndex = 48;
            // 
            // SBtnDepartmentNameBack
            // 
            this.SBtnDepartmentNameBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSectorNameBack.ImageOptions.Image")));
            this.SBtnDepartmentNameBack.Location = new System.Drawing.Point(333, 12);
            this.SBtnDepartmentNameBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnDepartmentNameBack.Name = "SBtnDepartmentNameBack";
            this.SBtnDepartmentNameBack.Size = new System.Drawing.Size(26, 30);
            this.SBtnDepartmentNameBack.TabIndex = 47;
            this.SBtnDepartmentNameBack.Click += new System.EventHandler(this.SBtnDepartmentNameBack_Click);
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(118, 76);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(108, 39);
            this.SBCancel.TabIndex = 46;
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
            this.SBtnUpdate.TabIndex = 45;
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
            this.pictureEdit1.TabIndex = 44;
            // 
            // TEDepartmentName
            // 
            this.TEDepartmentName.Location = new System.Drawing.Point(118, 12);
            this.TEDepartmentName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEDepartmentName.Name = "TEDepartmentName";
            this.TEDepartmentName.Size = new System.Drawing.Size(207, 30);
            this.TEDepartmentName.TabIndex = 43;
            // 
            // DepartmentUpdateWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 126);
            this.Controls.Add(this.CheckEArchive);
            this.Controls.Add(this.SBtnDepartmentNameBack);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnUpdate);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TEDepartmentName);
            this.Controls.Add(this.labelControl1);
            this.Name = "DepartmentUpdateWF";
            this.Text = "DepartmentUpdateWF";
            this.Load += new System.EventHandler(this.DepartmentUpdateWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CheckEArchive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEDepartmentName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.CheckEdit CheckEArchive;
        private DevExpress.XtraEditors.SimpleButton SBtnDepartmentNameBack;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnUpdate;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TEDepartmentName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}