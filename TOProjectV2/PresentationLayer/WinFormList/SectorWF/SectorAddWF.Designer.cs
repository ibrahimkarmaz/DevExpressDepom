namespace PresentationLayer.WinFormList.SectorWF
{
    partial class SectorAddWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectorAddWF));
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TESectorName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SBtnSectorListClear = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSectorRemove = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SBtnSectorListSave = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxSector = new DevExpress.XtraEditors.ListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESectorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSector)).BeginInit();
            this.SuspendLayout();
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(118, 48);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(97, 39);
            this.SBCancel.TabIndex = 32;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnSave
            // 
            this.SBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSave.ImageOptions.Image")));
            this.SBtnSave.Location = new System.Drawing.Point(221, 48);
            this.SBtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSave.Name = "SBtnSave";
            this.SBtnSave.Size = new System.Drawing.Size(130, 39);
            this.SBtnSave.TabIndex = 31;
            this.SBtnSave.Text = "Kaydet";
            this.SBtnSave.Click += new System.EventHandler(this.SBtnSave_Click);
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
            // TESectorName
            // 
            this.TESectorName.Location = new System.Drawing.Point(118, 12);
            this.TESectorName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TESectorName.Name = "TESectorName";
            this.TESectorName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TESectorName.Size = new System.Drawing.Size(233, 30);
            this.TESectorName.TabIndex = 29;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 16);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Sektör Adı:";
            // 
            // SBtnSectorListClear
            // 
            this.SBtnSectorListClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSectorListClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnBlandListClear.ImageOptions.Image")));
            this.SBtnSectorListClear.Location = new System.Drawing.Point(118, 450);
            this.SBtnSectorListClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSectorListClear.Name = "SBtnSectorListClear";
            this.SBtnSectorListClear.Size = new System.Drawing.Size(235, 39);
            this.SBtnSectorListClear.TabIndex = 39;
            this.SBtnSectorListClear.Text = "Listeyi Temizle";
            this.SBtnSectorListClear.Click += new System.EventHandler(this.SBtnSectorListClear_Click);
            // 
            // SBtnSectorRemove
            // 
            this.SBtnSectorRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSectorRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnBlandRemove.ImageOptions.Image")));
            this.SBtnSectorRemove.Location = new System.Drawing.Point(116, 405);
            this.SBtnSectorRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSectorRemove.Name = "SBtnSectorRemove";
            this.SBtnSectorRemove.Size = new System.Drawing.Size(235, 39);
            this.SBtnSectorRemove.TabIndex = 38;
            this.SBtnSectorRemove.Text = "Seçili Sektörü Sil";
            this.SBtnSectorRemove.Click += new System.EventHandler(this.SBtnSectorRemove_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(13, 138);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(26, 25);
            this.pictureEdit2.TabIndex = 37;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(47, 145);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 16);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Tür Listesi:";
            // 
            // SBtnSectorListSave
            // 
            this.SBtnSectorListSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSectorListSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnBlandlListSave.ImageOptions.Image")));
            this.SBtnSectorListSave.Location = new System.Drawing.Point(118, 360);
            this.SBtnSectorListSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSectorListSave.Name = "SBtnSectorListSave";
            this.SBtnSectorListSave.Size = new System.Drawing.Size(235, 39);
            this.SBtnSectorListSave.TabIndex = 35;
            this.SBtnSectorListSave.Text = "Sektörlerin Tümünü Kaydet";
            this.SBtnSectorListSave.Click += new System.EventHandler(this.SBtnSectorListSave_Click);
            // 
            // SBtnListAdd
            // 
            this.SBtnListAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnListAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnListAdd.ImageOptions.Image")));
            this.SBtnListAdd.Location = new System.Drawing.Point(118, 93);
            this.SBtnListAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnListAdd.Name = "SBtnListAdd";
            this.SBtnListAdd.Size = new System.Drawing.Size(233, 39);
            this.SBtnListAdd.TabIndex = 34;
            this.SBtnListAdd.Text = "Listeye Ekle";
            this.SBtnListAdd.Click += new System.EventHandler(this.SBtnListAdd_Click);
            // 
            // listBoxSector
            // 
            this.listBoxSector.Location = new System.Drawing.Point(118, 138);
            this.listBoxSector.Name = "listBoxSector";
            this.listBoxSector.Size = new System.Drawing.Size(235, 216);
            this.listBoxSector.TabIndex = 33;
            // 
            // SectorAddWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 499);
            this.Controls.Add(this.SBtnSectorListClear);
            this.Controls.Add(this.SBtnSectorRemove);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.SBtnSectorListSave);
            this.Controls.Add(this.SBtnListAdd);
            this.Controls.Add(this.listBoxSector);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnSave);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TESectorName);
            this.Controls.Add(this.labelControl1);
            this.Name = "SectorAddWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ SEKTÖR";
            this.Load += new System.EventHandler(this.SectorAddWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESectorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxSector)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnSave;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TESectorName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton SBtnSectorListClear;
        private DevExpress.XtraEditors.SimpleButton SBtnSectorRemove;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SBtnSectorListSave;
        private DevExpress.XtraEditors.SimpleButton SBtnListAdd;
        private DevExpress.XtraEditors.ListBoxControl listBoxSector;
    }
}