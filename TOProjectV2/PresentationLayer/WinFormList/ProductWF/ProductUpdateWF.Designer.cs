﻿namespace PresentationLayer.WinFormList.ProductWF
{
    partial class ProductUpdateWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductUpdateWF));
            this.LUEModel = new DevExpress.XtraEditors.LookUpEdit();
            this.LUEBland = new DevExpress.XtraEditors.LookUpEdit();
            this.CBEPiece = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit6 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.MMEDetails = new DevExpress.XtraEditors.MemoEdit();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnUpadte = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TESalesPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.TEPurchasePrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TEYear = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TEProductName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CheckBlandModel = new DevExpress.XtraEditors.CheckEdit();
            this.CheckArchive = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEBland.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBEPiece.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMEDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESalesPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPurchasePrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEYear.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBlandModel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckArchive.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LUEModel
            // 
            this.LUEModel.Enabled = false;
            this.LUEModel.Location = new System.Drawing.Point(120, 80);
            this.LUEModel.Name = "LUEModel";
            this.LUEModel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEModel.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModelID", "ID", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ModelName", "Model Adı")});
            this.LUEModel.Properties.DisplayMember = "ModelName";
            this.LUEModel.Properties.NullText = "Model Seçiniz";
            this.LUEModel.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.LUEModel.Properties.ValueMember = "ModelID";
            this.LUEModel.Size = new System.Drawing.Size(233, 30);
            this.LUEModel.TabIndex = 81;
            this.LUEModel.EditValueChanged += new System.EventHandler(this.LUEModel_EditValueChanged);
            // 
            // LUEBland
            // 
            this.LUEBland.Enabled = false;
            this.LUEBland.Location = new System.Drawing.Point(120, 44);
            this.LUEBland.Name = "LUEBland";
            this.LUEBland.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEBland.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlandID", "ID", 10, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BlandName", "Marka Adı")});
            this.LUEBland.Properties.DisplayMember = "BlandName";
            this.LUEBland.Properties.NullText = "Marka Seçiniz";
            this.LUEBland.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.LUEBland.Properties.ValueMember = "BlandID";
            this.LUEBland.Size = new System.Drawing.Size(233, 30);
            this.LUEBland.TabIndex = 80;
            this.LUEBland.EditValueChanged += new System.EventHandler(this.LUEBland_EditValueChanged);
            // 
            // CBEPiece
            // 
            this.CBEPiece.EditValue = "Adet Sayısı";
            this.CBEPiece.Location = new System.Drawing.Point(120, 180);
            this.CBEPiece.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBEPiece.Name = "CBEPiece";
            this.CBEPiece.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBEPiece.Properties.DropDownRows = 10;
            this.CBEPiece.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBEPiece.Size = new System.Drawing.Size(233, 30);
            this.CBEPiece.TabIndex = 79;
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(13, 295);
            this.pictureEdit8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit8.TabIndex = 78;
            // 
            // pictureEdit7
            // 
            this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
            this.pictureEdit7.Location = new System.Drawing.Point(13, 257);
            this.pictureEdit7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit7.Name = "pictureEdit7";
            this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit7.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit7.TabIndex = 77;
            // 
            // pictureEdit6
            // 
            this.pictureEdit6.EditValue = ((object)(resources.GetObject("pictureEdit6.EditValue")));
            this.pictureEdit6.Location = new System.Drawing.Point(13, 221);
            this.pictureEdit6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit6.Name = "pictureEdit6";
            this.pictureEdit6.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit6.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit6.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit6.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit6.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit6.TabIndex = 76;
            // 
            // pictureEdit5
            // 
            this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
            this.pictureEdit5.Location = new System.Drawing.Point(13, 184);
            this.pictureEdit5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit5.Name = "pictureEdit5";
            this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit5.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit5.TabIndex = 75;
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(13, 121);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit4.TabIndex = 74;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(13, 85);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit3.TabIndex = 73;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(13, 49);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit2.TabIndex = 72;
            // 
            // MMEDetails
            // 
            this.MMEDetails.Location = new System.Drawing.Point(52, 316);
            this.MMEDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MMEDetails.Name = "MMEDetails";
            this.MMEDetails.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MMEDetails.Size = new System.Drawing.Size(301, 137);
            this.MMEDetails.TabIndex = 71;
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(120, 482);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(97, 39);
            this.SBCancel.TabIndex = 70;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnUpadte
            // 
            this.SBtnUpadte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnUpadte.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnUpadte.ImageOptions.Image")));
            this.SBtnUpadte.Location = new System.Drawing.Point(223, 482);
            this.SBtnUpadte.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnUpadte.Name = "SBtnUpadte";
            this.SBtnUpadte.Size = new System.Drawing.Size(130, 39);
            this.SBtnUpadte.TabIndex = 69;
            this.SBtnUpadte.Text = "Düzenle";
            this.SBtnUpadte.Click += new System.EventHandler(this.SBtnUpadte_Click);
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
            this.pictureEdit1.TabIndex = 68;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(52, 295);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 15);
            this.labelControl8.TabIndex = 67;
            this.labelControl8.Text = "Detaylar:";
            // 
            // TESalesPrice
            // 
            this.TESalesPrice.EditValue = "0";
            this.TESalesPrice.Location = new System.Drawing.Point(120, 253);
            this.TESalesPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TESalesPrice.Name = "TESalesPrice";
            this.TESalesPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TESalesPrice.Properties.MaskSettings.Set("mask", "c");
            this.TESalesPrice.Size = new System.Drawing.Size(233, 30);
            this.TESalesPrice.TabIndex = 66;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(52, 259);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(61, 15);
            this.labelControl7.TabIndex = 65;
            this.labelControl7.Text = "Satış Fiyati:";
            // 
            // TEPurchasePrice
            // 
            this.TEPurchasePrice.EditValue = "0";
            this.TEPurchasePrice.Location = new System.Drawing.Point(120, 216);
            this.TEPurchasePrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEPurchasePrice.Name = "TEPurchasePrice";
            this.TEPurchasePrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TEPurchasePrice.Properties.MaskSettings.Set("mask", "c");
            this.TEPurchasePrice.Size = new System.Drawing.Size(233, 30);
            this.TEPurchasePrice.TabIndex = 64;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(52, 223);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(53, 15);
            this.labelControl6.TabIndex = 63;
            this.labelControl6.Text = "Alış Fiyati:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(52, 187);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(27, 15);
            this.labelControl5.TabIndex = 62;
            this.labelControl5.Text = "Adet:";
            // 
            // TEYear
            // 
            this.TEYear.Location = new System.Drawing.Point(120, 116);
            this.TEYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEYear.Name = "TEYear";
            this.TEYear.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TEYear.Properties.MaskSettings.Set("MaskManagerSignature", "isOptimistic=False");
            this.TEYear.Properties.MaskSettings.Set("mask", "[0-7]+");
            this.TEYear.Properties.ReadOnly = true;
            this.TEYear.Size = new System.Drawing.Size(233, 30);
            this.TEYear.TabIndex = 61;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(52, 123);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(16, 15);
            this.labelControl4.TabIndex = 60;
            this.labelControl4.Text = "Yıl:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 87);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(38, 15);
            this.labelControl3.TabIndex = 59;
            this.labelControl3.Text = "Model:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(52, 51);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(38, 15);
            this.labelControl2.TabIndex = 58;
            this.labelControl2.Text = "Marka:";
            // 
            // TEProductName
            // 
            this.TEProductName.Location = new System.Drawing.Point(120, 8);
            this.TEProductName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEProductName.Name = "TEProductName";
            this.TEProductName.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TEProductName.Properties.MaskSettings.Set("mask", "\\p{Lu}+");
            this.TEProductName.Size = new System.Drawing.Size(233, 30);
            this.TEProductName.TabIndex = 57;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 15);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 15);
            this.labelControl1.TabIndex = 56;
            this.labelControl1.Text = "Ürün Adı:";
            // 
            // CheckBlandModel
            // 
            this.CheckBlandModel.Location = new System.Drawing.Point(120, 152);
            this.CheckBlandModel.Name = "CheckBlandModel";
            this.CheckBlandModel.Properties.Caption = "Marka/Model Bilgilerini Düzenle";
            this.CheckBlandModel.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CheckBlandModel.Size = new System.Drawing.Size(233, 22);
            this.CheckBlandModel.TabIndex = 82;
            this.CheckBlandModel.CheckedChanged += new System.EventHandler(this.CheckBlandModel_CheckedChanged);
            // 
            // CheckArchive
            // 
            this.CheckArchive.Location = new System.Drawing.Point(52, 454);
            this.CheckArchive.Name = "CheckArchive";
            this.CheckArchive.Properties.Caption = "Ürünü Arşivle";
            this.CheckArchive.Properties.CheckBoxOptions.Style = DevExpress.XtraEditors.Controls.CheckBoxStyle.SvgToggle1;
            this.CheckArchive.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.CheckArchive.Size = new System.Drawing.Size(301, 22);
            this.CheckArchive.TabIndex = 83;
            // 
            // ProductUpdateWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 533);
            this.Controls.Add(this.CheckArchive);
            this.Controls.Add(this.CheckBlandModel);
            this.Controls.Add(this.LUEModel);
            this.Controls.Add(this.LUEBland);
            this.Controls.Add(this.CBEPiece);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.pictureEdit7);
            this.Controls.Add(this.pictureEdit6);
            this.Controls.Add(this.pictureEdit5);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.MMEDetails);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnUpadte);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.TESalesPrice);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TEPurchasePrice);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TEYear);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TEProductName);
            this.Controls.Add(this.labelControl1);
            this.Name = "ProductUpdateWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÜRÜN BİLGİLERİNİ DÜZENLE";
            this.Load += new System.EventHandler(this.ProductUpdateWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LUEModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEBland.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBEPiece.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMEDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESalesPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPurchasePrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEYear.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBlandModel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckArchive.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit LUEModel;
        private DevExpress.XtraEditors.LookUpEdit LUEBland;
        private DevExpress.XtraEditors.ComboBoxEdit CBEPiece;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.PictureEdit pictureEdit6;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.MemoEdit MMEDetails;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnUpadte;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit TESalesPrice;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit TEPurchasePrice;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TEYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TEProductName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.CheckEdit CheckBlandModel;
        private DevExpress.XtraEditors.CheckEdit CheckArchive;
    }
}