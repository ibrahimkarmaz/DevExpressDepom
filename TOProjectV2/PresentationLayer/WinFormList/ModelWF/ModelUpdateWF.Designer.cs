namespace PresentationLayer.WinFormList.ModelWF
{
    partial class ModelUpdateWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelUpdateWF));
            this.LUEBlandName = new DevExpress.XtraEditors.LookUpEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.TEModelYear = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.TEModelName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CheckEArchive = new DevExpress.XtraEditors.CheckEdit();
            this.SBtnModelNameBack = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.LUEBlandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEModelYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEModelName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEArchive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LUEBlandName
            // 
            this.LUEBlandName.Location = new System.Drawing.Point(122, 12);
            this.LUEBlandName.Name = "LUEBlandName";
            this.LUEBlandName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEBlandName.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlandID", "ID", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlandName", "Marka Adı")});
            this.LUEBlandName.Properties.DisplayMember = "BlandName";
            this.LUEBlandName.Properties.DropDownRows = 10;
            this.LUEBlandName.Properties.NullText = "Marka Seçiniz...";
            this.LUEBlandName.Properties.ValueMember = "BlandID";
            this.LUEBlandName.Size = new System.Drawing.Size(233, 30);
            this.LUEBlandName.TabIndex = 50;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(13, 84);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit3.TabIndex = 49;
            // 
            // TEModelYear
            // 
            this.TEModelYear.Location = new System.Drawing.Point(122, 84);
            this.TEModelYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEModelYear.Name = "TEModelYear";
            this.TEModelYear.Size = new System.Drawing.Size(233, 30);
            this.TEModelYear.TabIndex = 48;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(45, 91);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(62, 16);
            this.labelControl3.TabIndex = 47;
            this.labelControl3.Text = "Model Yılı:";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(13, 48);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit2.TabIndex = 46;
            // 
            // TEModelName
            // 
            this.TEModelName.Location = new System.Drawing.Point(122, 48);
            this.TEModelName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEModelName.Name = "TEModelName";
            this.TEModelName.Size = new System.Drawing.Size(233, 30);
            this.TEModelName.TabIndex = 45;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 55);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Model Adı:";
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(122, 148);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(97, 39);
            this.SBCancel.TabIndex = 43;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnUpdate
            // 
            this.SBtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnUpdate.ImageOptions.Image")));
            this.SBtnUpdate.Location = new System.Drawing.Point(225, 148);
            this.SBtnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnUpdate.Name = "SBtnUpdate";
            this.SBtnUpdate.Size = new System.Drawing.Size(130, 39);
            this.SBtnUpdate.TabIndex = 42;
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
            this.pictureEdit1.TabIndex = 41;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 16);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "Marka Adı:";
            // 
            // CheckEArchive
            // 
            this.CheckEArchive.Location = new System.Drawing.Point(122, 120);
            this.CheckEArchive.Name = "CheckEArchive";
            this.CheckEArchive.Properties.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CheckEArchive.Properties.Appearance.Options.UseFont = true;
            this.CheckEArchive.Properties.Caption = "Modeli Arşivle";
            this.CheckEArchive.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.CheckEArchive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CheckEArchive.Size = new System.Drawing.Size(207, 22);
            this.CheckEArchive.TabIndex = 52;
            // 
            // SBtnModelNameBack
            // 
            this.SBtnModelNameBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnModelNameBack.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnModelNameBack.ImageOptions.Image")));
            this.SBtnModelNameBack.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.SBtnModelNameBack.Location = new System.Drawing.Point(79, 148);
            this.SBtnModelNameBack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnModelNameBack.Name = "SBtnModelNameBack";
            this.SBtnModelNameBack.Size = new System.Drawing.Size(35, 39);
            this.SBtnModelNameBack.TabIndex = 51;
            this.SBtnModelNameBack.Click += new System.EventHandler(this.SBtnModelNameBack_Click);
            // 
            // ModelUpdateWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 199);
            this.Controls.Add(this.CheckEArchive);
            this.Controls.Add(this.SBtnModelNameBack);
            this.Controls.Add(this.LUEBlandName);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.TEModelYear);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.TEModelName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnUpdate);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "ModelUpdateWF";
            this.Text = "ModelUpdateWF";
            this.Load += new System.EventHandler(this.ModelUpdateWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LUEBlandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEModelYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEModelName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckEArchive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit LUEBlandName;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.TextEdit TEModelYear;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.TextEdit TEModelName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnUpdate;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CheckEArchive;
        private DevExpress.XtraEditors.SimpleButton SBtnModelNameBack;
    }
}