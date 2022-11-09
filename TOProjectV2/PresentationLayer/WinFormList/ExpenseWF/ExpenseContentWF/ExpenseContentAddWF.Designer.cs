namespace PresentationLayer.WinFormList.ExpenseWF.ExpenseContentWF
{
    partial class ExpenseContentAddWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseContentAddWF));
            this.LUEExpenseHeader = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.BtnImageSelect = new DevExpress.XtraEditors.SimpleButton();
            this.PEExpense = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit9 = new DevExpress.XtraEditors.PictureEdit();
            this.TETitle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
            this.MMExpenseNote = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit4 = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CBEType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.TEPeceiptNumber = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.TEPeceiptPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.LUEExpenseHeader.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEExpense.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TETitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMExpenseNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBEType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPeceiptNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPeceiptPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LUEExpenseHeader
            // 
            this.LUEExpenseHeader.Location = new System.Drawing.Point(139, 8);
            this.LUEExpenseHeader.Name = "LUEExpenseHeader";
            this.LUEExpenseHeader.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEExpenseHeader.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExprenseHeaderID", "ID", 8, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ExprenseHeaderName", "Gider Başlığı")});
            this.LUEExpenseHeader.Properties.DisplayMember = "ExprenseHeaderName";
            this.LUEExpenseHeader.Properties.NullText = "Gider Başlığı Seçiniz";
            this.LUEExpenseHeader.Properties.NullValuePrompt = "Gider Başlığı Seçiniz";
            this.LUEExpenseHeader.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            this.LUEExpenseHeader.Properties.ValueMember = "ExprenseHeaderID";
            this.LUEExpenseHeader.Size = new System.Drawing.Size(233, 30);
            this.LUEExpenseHeader.TabIndex = 0;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(52, 15);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(73, 15);
            this.labelControl4.TabIndex = 190;
            this.labelControl4.Text = "Gider Başlığı:";
            // 
            // BtnImageSelect
            // 
            this.BtnImageSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnImageSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnImageSelect.ImageOptions.Image")));
            this.BtnImageSelect.Location = new System.Drawing.Point(379, 273);
            this.BtnImageSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnImageSelect.Name = "BtnImageSelect";
            this.BtnImageSelect.Size = new System.Drawing.Size(260, 21);
            this.BtnImageSelect.TabIndex = 8;
            this.BtnImageSelect.Text = "Fiş Resim Seçin";
            this.BtnImageSelect.Click += new System.EventHandler(this.BtnImageSelect_Click);
            // 
            // PEExpense
            // 
            this.PEExpense.Location = new System.Drawing.Point(379, 7);
            this.PEExpense.Name = "PEExpense";
            this.PEExpense.Properties.NullText = "Fiş Sürekle Bırak";
            this.PEExpense.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PEExpense.Properties.ShowMenu = false;
            this.PEExpense.Properties.ShowZoomSubMenu = DevExpress.Utils.DefaultBoolean.True;
            this.PEExpense.Size = new System.Drawing.Size(260, 260);
            this.PEExpense.TabIndex = 7;
            this.PEExpense.DragDrop += new System.Windows.Forms.DragEventHandler(this.PEExpense_DragDrop);
            // 
            // pictureEdit9
            // 
            this.pictureEdit9.EditValue = ((object)(resources.GetObject("pictureEdit9.EditValue")));
            this.pictureEdit9.Location = new System.Drawing.Point(13, 46);
            this.pictureEdit9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit9.Name = "pictureEdit9";
            this.pictureEdit9.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit9.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit9.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit9.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit9.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit9.TabIndex = 178;
            // 
            // TETitle
            // 
            this.TETitle.Location = new System.Drawing.Point(139, 44);
            this.TETitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TETitle.Name = "TETitle";
            this.TETitle.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TETitle.Properties.NullText = "Gider Adı Giriniz";
            this.TETitle.Properties.NullValuePrompt = "Gider Adı Giriniz";
            this.TETitle.Size = new System.Drawing.Size(233, 30);
            this.TETitle.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(52, 51);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(53, 15);
            this.labelControl9.TabIndex = 177;
            this.labelControl9.Text = "Gider Adı:";
            // 
            // pictureEdit8
            // 
            this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
            this.pictureEdit8.Location = new System.Drawing.Point(13, 185);
            this.pictureEdit8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit8.Name = "pictureEdit8";
            this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit8.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit8.TabIndex = 176;
            // 
            // MMExpenseNote
            // 
            this.MMExpenseNote.EditValue = "";
            this.MMExpenseNote.Location = new System.Drawing.Point(52, 211);
            this.MMExpenseNote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MMExpenseNote.Name = "MMExpenseNote";
            this.MMExpenseNote.Properties.NullText = "Not Giriniz";
            this.MMExpenseNote.Properties.NullValuePrompt = "Not Giriniz";
            this.MMExpenseNote.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.MMExpenseNote.Size = new System.Drawing.Size(320, 133);
            this.MMExpenseNote.TabIndex = 6;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(52, 190);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(59, 15);
            this.labelControl8.TabIndex = 171;
            this.labelControl8.Text = "Ekstra Not:";
            // 
            // pictureEdit4
            // 
            this.pictureEdit4.EditValue = ((object)(resources.GetObject("pictureEdit4.EditValue")));
            this.pictureEdit4.Location = new System.Drawing.Point(13, 12);
            this.pictureEdit4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit4.Name = "pictureEdit4";
            this.pictureEdit4.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit4.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit4.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit4.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit4.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit4.TabIndex = 191;
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(13, 82);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit1.TabIndex = 194;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 87);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 15);
            this.labelControl1.TabIndex = 193;
            this.labelControl1.Text = "Gider Türü:";
            // 
            // CBEType
            // 
            this.CBEType.Location = new System.Drawing.Point(139, 80);
            this.CBEType.Name = "CBEType";
            this.CBEType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CBEType.Properties.NullText = "Gider Türü Seçiniz";
            this.CBEType.Properties.NullValuePrompt = "Gider Türü Seçiniz";
            this.CBEType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.CBEType.Size = new System.Drawing.Size(233, 30);
            this.CBEType.TabIndex = 3;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(13, 118);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit2.TabIndex = 198;
            // 
            // TEPeceiptNumber
            // 
            this.TEPeceiptNumber.Location = new System.Drawing.Point(139, 116);
            this.TEPeceiptNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEPeceiptNumber.Name = "TEPeceiptNumber";
            this.TEPeceiptNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.RegExpMaskManager));
            this.TEPeceiptNumber.Properties.MaskSettings.Set("mask", "\\d+");
            this.TEPeceiptNumber.Properties.NullText = "Fiş Numarası Giriniz";
            this.TEPeceiptNumber.Properties.NullValuePrompt = "Fiş Numarası Giriniz";
            this.TEPeceiptNumber.Size = new System.Drawing.Size(233, 30);
            this.TEPeceiptNumber.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(52, 123);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 15);
            this.labelControl2.TabIndex = 197;
            this.labelControl2.Text = "Fiş Numarası:";
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(13, 154);
            this.pictureEdit3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit3.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit3.TabIndex = 201;
            // 
            // TEPeceiptPrice
            // 
            this.TEPeceiptPrice.EditValue = "0";
            this.TEPeceiptPrice.Location = new System.Drawing.Point(139, 152);
            this.TEPeceiptPrice.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEPeceiptPrice.Name = "TEPeceiptPrice";
            this.TEPeceiptPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.TEPeceiptPrice.Properties.MaskSettings.Set("mask", "c");
            this.TEPeceiptPrice.Properties.NullText = "Fiş Fiyati Giriniz";
            this.TEPeceiptPrice.Properties.NullValuePrompt = "Fiş Fiyati Giriniz";
            this.TEPeceiptPrice.Size = new System.Drawing.Size(233, 30);
            this.TEPeceiptPrice.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(52, 159);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 15);
            this.labelControl3.TabIndex = 200;
            this.labelControl3.Text = "Fiş Fiyati:";
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(379, 305);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(96, 39);
            this.SBCancel.TabIndex = 10;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnSave
            // 
            this.SBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSave.ImageOptions.Image")));
            this.SBtnSave.Location = new System.Drawing.Point(483, 305);
            this.SBtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSave.Name = "SBtnSave";
            this.SBtnSave.Size = new System.Drawing.Size(156, 39);
            this.SBtnSave.TabIndex = 9;
            this.SBtnSave.Text = "Kaydet";
            this.SBtnSave.Click += new System.EventHandler(this.SBtnSave_Click);
            // 
            // ExpenseContentAddWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 359);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnSave);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.TEPeceiptPrice);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.TEPeceiptNumber);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.CBEType);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit4);
            this.Controls.Add(this.LUEExpenseHeader);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.BtnImageSelect);
            this.Controls.Add(this.PEExpense);
            this.Controls.Add(this.pictureEdit9);
            this.Controls.Add(this.TETitle);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.pictureEdit8);
            this.Controls.Add(this.MMExpenseNote);
            this.Controls.Add(this.labelControl8);
            this.Name = "ExpenseContentAddWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ GİDER";
            this.Load += new System.EventHandler(this.ExpenseContentAddWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LUEExpenseHeader.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEExpense.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TETitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMExpenseNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CBEType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPeceiptNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPeceiptPrice.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit LUEExpenseHeader;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BtnImageSelect;
        private DevExpress.XtraEditors.PictureEdit PEExpense;
        private DevExpress.XtraEditors.PictureEdit pictureEdit9;
        private DevExpress.XtraEditors.TextEdit TETitle;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.MemoEdit MMExpenseNote;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.PictureEdit pictureEdit4;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit CBEType;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.TextEdit TEPeceiptNumber;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private DevExpress.XtraEditors.TextEdit TEPeceiptPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnSave;
    }
}