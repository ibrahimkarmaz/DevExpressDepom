namespace PresentationLayer.WinFormList.ProductWF
{
    partial class ProductStockUpdateWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductStockUpdateWF));
            this.CBEPiece = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.MMEDetails = new DevExpress.XtraEditors.MemoEdit();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TEProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CheckArchive = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.CBEPiece.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMEDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckArchive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CBEPiece
            // 
            this.CBEPiece.EditValue = "Adet Sayısı";
            this.CBEPiece.Location = new System.Drawing.Point(123, 44);
            this.CBEPiece.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBEPiece.Name = "CBEPiece";
            this.CBEPiece.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBEPiece.Properties.DropDownRows = 10;
            this.CBEPiece.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBEPiece.Size = new System.Drawing.Size(233, 30);
            this.CBEPiece.TabIndex = 67;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(16, 79);
            this.pictureEdit8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit8.TabIndex = 66;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(16, 48);
            this.pictureEdit5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit5.TabIndex = 63;
            // 
            // MMEDetails
            // 
            this.MMEDetails.Location = new System.Drawing.Point(55, 100);
            this.MMEDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MMEDetails.Name = "MMEDetails";
            this.MMEDetails.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MMEDetails.Size = new System.Drawing.Size(301, 137);
            this.MMEDetails.TabIndex = 62;
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(123, 271);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(97, 39);
            this.SBCancel.TabIndex = 61;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnUpdate
            // 
            this.SBtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBSave.ImageOptions.Image")));
            this.SBtnUpdate.Location = new System.Drawing.Point(226, 271);
            this.SBtnUpdate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnUpdate.Name = "SBtnUpdate";
            this.SBtnUpdate.Size = new System.Drawing.Size(130, 39);
            this.SBtnUpdate.TabIndex = 60;
            this.SBtnUpdate.Text = "Düzenle";
            this.SBtnUpdate.Click += new System.EventHandler(this.SBtnUpdate_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(55, 79);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 15);
            this.labelControl8.TabIndex = 59;
            this.labelControl8.Text = "Detaylar:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(55, 51);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 15);
            this.labelControl5.TabIndex = 54;
            this.labelControl5.Text = "Adet:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(16, 12);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit1.TabIndex = 70;
            // 
            // TEProductName
            // 
            this.TEProductName.Location = new System.Drawing.Point(123, 8);
            this.TEProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEProductName.Name = "TEProductName";
            this.TEProductName.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TEProductName.Properties.MaskSettings.Set("mask", "\\p{Lu}+");
            this.TEProductName.Properties.ReadOnly = true;
            this.TEProductName.Size = new System.Drawing.Size(233, 30);
            this.TEProductName.TabIndex = 69;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(55, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 15);
            this.labelControl1.TabIndex = 68;
            this.labelControl1.Text = "Ürün Adı:";
            // 
            // CheckArchive
            // 
            this.CheckArchive.Location = new System.Drawing.Point(55, 243);
            this.CheckArchive.Name = "CheckArchive";
            this.CheckArchive.Properties.Caption = "Ürünü Arşivle";
            this.CheckArchive.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.CheckArchive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CheckArchive.Size = new System.Drawing.Size(301, 22);
            this.CheckArchive.TabIndex = 84;
            // 
            // ProductStockUpdateWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 321);
            this.Controls.Add(this.CheckArchive);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TEProductName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.CBEPiece);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.MMEDetails);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnUpdate);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl5);
            this.Name = "ProductStockUpdateWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN STOK BİLGİSİNİ DÜZENLE";
            this.Load += new System.EventHandler(this.ProductStockUpdateWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CBEPiece.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMEDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckArchive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit CBEPiece;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.MemoEdit MMEDetails;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnUpdate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TEProductName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CheckArchive;
    }
}