namespace PresentationLayer.WinFormList
{
    partial class NewBlandWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBlandWF));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TEBlandName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxBland = new DevExpress.XtraEditors.ListBoxControl();
            this.SBtnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnBlandlListSave = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnBlandRemove = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnBlandListClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEBlandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxBland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
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
            this.pictureEdit1.TabIndex = 19;
            // 
            // TEBlandName
            // 
            this.TEBlandName.Location = new System.Drawing.Point(107, 12);
            this.TEBlandName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEBlandName.Name = "TEBlandName";
            this.TEBlandName.Size = new System.Drawing.Size(233, 30);
            this.TEBlandName.TabIndex = 18;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(46, 16);
            this.labelControl1.TabIndex = 17;
            this.labelControl1.Text = "Tür Adı:";
            // 
            // listBoxBland
            // 
            this.listBoxBland.Location = new System.Drawing.Point(109, 144);
            this.listBoxBland.Name = "listBoxBland";
            this.listBoxBland.Size = new System.Drawing.Size(233, 216);
            this.listBoxBland.TabIndex = 20;
            // 
            // SBtnListAdd
            // 
            this.SBtnListAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnListAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnListAdd.ImageOptions.Image")));
            this.SBtnListAdd.Location = new System.Drawing.Point(109, 99);
            this.SBtnListAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnListAdd.Name = "SBtnListAdd";
            this.SBtnListAdd.Size = new System.Drawing.Size(231, 39);
            this.SBtnListAdd.TabIndex = 21;
            this.SBtnListAdd.Text = "Listeye Ekle";
            this.SBtnListAdd.Click += new System.EventHandler(this.SBtnListAdd_Click);
            // 
            // SBtnBlandlListSave
            // 
            this.SBtnBlandlListSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnBlandlListSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnBlandlListSave.ImageOptions.Image")));
            this.SBtnBlandlListSave.Location = new System.Drawing.Point(109, 366);
            this.SBtnBlandlListSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnBlandlListSave.Name = "SBtnBlandlListSave";
            this.SBtnBlandlListSave.Size = new System.Drawing.Size(233, 39);
            this.SBtnBlandlListSave.TabIndex = 22;
            this.SBtnBlandlListSave.Text = "Markaların Tümünü Kaydet";
            this.SBtnBlandlListSave.Click += new System.EventHandler(this.SBtnBlandlListSave_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(13, 144);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit2.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(45, 151);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 24;
            this.labelControl2.Text = "Tür Listesi:";
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(107, 48);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(97, 39);
            this.SBCancel.TabIndex = 27;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnSave
            // 
            this.SBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSave.ImageOptions.Image")));
            this.SBtnSave.Location = new System.Drawing.Point(210, 48);
            this.SBtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSave.Name = "SBtnSave";
            this.SBtnSave.Size = new System.Drawing.Size(130, 39);
            this.SBtnSave.TabIndex = 26;
            this.SBtnSave.Text = "Kaydet";
            this.SBtnSave.Click += new System.EventHandler(this.SBtnSave_Click);
            // 
            // SBtnBlandRemove
            // 
            this.SBtnBlandRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnBlandRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnBlandRemove.ImageOptions.Image")));
            this.SBtnBlandRemove.Location = new System.Drawing.Point(107, 411);
            this.SBtnBlandRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnBlandRemove.Name = "SBtnBlandRemove";
            this.SBtnBlandRemove.Size = new System.Drawing.Size(233, 39);
            this.SBtnBlandRemove.TabIndex = 28;
            this.SBtnBlandRemove.Text = "Seçili Markayı Sil";
            this.SBtnBlandRemove.Click += new System.EventHandler(this.SBtnBlandRemove_Click);
            // 
            // SBtnBlandListClear
            // 
            this.SBtnBlandListClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnBlandListClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnBlandListClear.ImageOptions.Image")));
            this.SBtnBlandListClear.Location = new System.Drawing.Point(109, 456);
            this.SBtnBlandListClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnBlandListClear.Name = "SBtnBlandListClear";
            this.SBtnBlandListClear.Size = new System.Drawing.Size(233, 39);
            this.SBtnBlandListClear.TabIndex = 29;
            this.SBtnBlandListClear.Text = "Listeyi Temizle";
            this.SBtnBlandListClear.Click += new System.EventHandler(this.SBtnBlandListClear_Click);
            // 
            // NewBlandWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 507);
            this.Controls.Add(this.SBtnBlandListClear);
            this.Controls.Add(this.SBtnBlandRemove);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnSave);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.SBtnBlandlListSave);
            this.Controls.Add(this.SBtnListAdd);
            this.Controls.Add(this.listBoxBland);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TEBlandName);
            this.Controls.Add(this.labelControl1);
            this.Name = "NewBlandWF";
            this.Text = "YENİ MARKA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEBlandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxBland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TEBlandName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxBland;
        private DevExpress.XtraEditors.SimpleButton SBtnListAdd;
        private DevExpress.XtraEditors.SimpleButton SBtnBlandlListSave;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnSave;
        private DevExpress.XtraEditors.SimpleButton SBtnBlandRemove;
        private DevExpress.XtraEditors.SimpleButton SBtnBlandListClear;
    }
}