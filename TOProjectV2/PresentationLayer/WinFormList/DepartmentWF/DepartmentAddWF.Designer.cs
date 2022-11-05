namespace PresentationLayer.WinFormList.DepartmenWF
{
    partial class DepartmentAddWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentAddWF));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxDepartment = new DevExpress.XtraEditors.ListBoxControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SBtnDepartmentListClear = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnDepartmentRemove = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.SBtnDepartmentListSave = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnListAdd = new DevExpress.XtraEditors.SimpleButton();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.TEDepartmentName = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEDepartmentName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(47, 145);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(47, 16);
            this.labelControl2.TabIndex = 48;
            this.labelControl2.Text = "D. Liste:";
            // 
            // listBoxDepartment
            // 
            this.listBoxDepartment.Location = new System.Drawing.Point(118, 138);
            this.listBoxDepartment.Name = "listBoxDepartment";
            this.listBoxDepartment.Size = new System.Drawing.Size(235, 216);
            this.listBoxDepartment.TabIndex = 45;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(45, 19);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 16);
            this.labelControl1.TabIndex = 40;
            this.labelControl1.Text = "D. Adı:";
            // 
            // SBtnDepartmentListClear
            // 
            this.SBtnDepartmentListClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnDepartmentListClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnDepartmentListClear.ImageOptions.Image")));
            this.SBtnDepartmentListClear.Location = new System.Drawing.Point(118, 450);
            this.SBtnDepartmentListClear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnDepartmentListClear.Name = "SBtnDepartmentListClear";
            this.SBtnDepartmentListClear.Size = new System.Drawing.Size(235, 39);
            this.SBtnDepartmentListClear.TabIndex = 51;
            this.SBtnDepartmentListClear.Text = "Listeyi Temizle";
            this.SBtnDepartmentListClear.Click += new System.EventHandler(this.SBtnDepartmentListClear_Click);
            // 
            // SBtnDepartmentRemove
            // 
            this.SBtnDepartmentRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnDepartmentRemove.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnDepartmentRemove.ImageOptions.Image")));
            this.SBtnDepartmentRemove.Location = new System.Drawing.Point(116, 405);
            this.SBtnDepartmentRemove.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnDepartmentRemove.Name = "SBtnDepartmentRemove";
            this.SBtnDepartmentRemove.Size = new System.Drawing.Size(235, 39);
            this.SBtnDepartmentRemove.TabIndex = 50;
            this.SBtnDepartmentRemove.Text = "Seçili Departmani Sil";
            this.SBtnDepartmentRemove.Click += new System.EventHandler(this.SBtnDepartmentRemove_Click);
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(13, 140);
            this.pictureEdit2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(26, 25);
            this.pictureEdit2.TabIndex = 49;
            // 
            // SBtnDepartmentListSave
            // 
            this.SBtnDepartmentListSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnDepartmentListSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnDepartmentListSave.ImageOptions.Image")));
            this.SBtnDepartmentListSave.Location = new System.Drawing.Point(118, 360);
            this.SBtnDepartmentListSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnDepartmentListSave.Name = "SBtnDepartmentListSave";
            this.SBtnDepartmentListSave.Size = new System.Drawing.Size(235, 39);
            this.SBtnDepartmentListSave.TabIndex = 47;
            this.SBtnDepartmentListSave.Text = "Departmanların Tümünü Kaydet";
            this.SBtnDepartmentListSave.Click += new System.EventHandler(this.SBtnDepartmentListSave_Click);
            // 
            // SBtnListAdd
            // 
            this.SBtnListAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnListAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnListAdd.ImageOptions.Image")));
            this.SBtnListAdd.Location = new System.Drawing.Point(118, 93);
            this.SBtnListAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnListAdd.Name = "SBtnListAdd";
            this.SBtnListAdd.Size = new System.Drawing.Size(233, 39);
            this.SBtnListAdd.TabIndex = 46;
            this.SBtnListAdd.Text = "Listeye Ekle";
            this.SBtnListAdd.Click += new System.EventHandler(this.SBtnListAdd_Click);
            // 
            // SBCancel
            // 
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(118, 48);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(97, 39);
            this.SBCancel.TabIndex = 44;
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
            this.SBtnSave.TabIndex = 43;
            this.SBtnSave.Text = "Kaydet";
            this.SBtnSave.Click += new System.EventHandler(this.SBtnSave_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(13, 13);
            this.pictureEdit1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(24, 25);
            this.pictureEdit1.TabIndex = 42;
            // 
            // TEDepartmentName
            // 
            this.TEDepartmentName.Location = new System.Drawing.Point(118, 12);
            this.TEDepartmentName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TEDepartmentName.Name = "TEDepartmentName";
            this.TEDepartmentName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TEDepartmentName.Size = new System.Drawing.Size(233, 30);
            this.TEDepartmentName.TabIndex = 41;
            // 
            // DepartmentAddWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 499);
            this.Controls.Add(this.SBtnDepartmentListClear);
            this.Controls.Add(this.SBtnDepartmentRemove);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.SBtnDepartmentListSave);
            this.Controls.Add(this.SBtnListAdd);
            this.Controls.Add(this.listBoxDepartment);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnSave);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.TEDepartmentName);
            this.Controls.Add(this.labelControl1);
            this.Name = "DepartmentAddWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YENİ DEPARTMAN";
            this.Load += new System.EventHandler(this.DepartmentAddWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEDepartmentName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SBtnDepartmentListClear;
        private DevExpress.XtraEditors.SimpleButton SBtnDepartmentRemove;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SBtnDepartmentListSave;
        private DevExpress.XtraEditors.SimpleButton SBtnListAdd;
        private DevExpress.XtraEditors.ListBoxControl listBoxDepartment;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnSave;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit TEDepartmentName;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}