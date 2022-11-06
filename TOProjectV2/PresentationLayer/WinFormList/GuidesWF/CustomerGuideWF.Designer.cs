namespace PresentationLayer.WinFormList.GuidesWF
{
    partial class CustomerGuideWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGuideWF));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions3 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject9 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject10 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject11 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject12 = new DevExpress.Utils.SerializableAppearanceObject();
            this.GControlCustomer = new DevExpress.XtraGrid.GridControl();
            this.GViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerSurName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnMobilePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnOfficePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemBtnMail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ColumnSMS = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemBtnSms = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ColumnSMS2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemBtnSms2 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnSms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnSms2)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlCustomer
            // 
            this.GControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlCustomer.Location = new System.Drawing.Point(0, 0);
            this.GControlCustomer.MainView = this.GViewCustomer;
            this.GControlCustomer.Name = "GControlCustomer";
            this.GControlCustomer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemBtnMail,
            this.repositoryItemBtnSms,
            this.repositoryItemBtnSms2});
            this.GControlCustomer.Size = new System.Drawing.Size(1108, 472);
            this.GControlCustomer.TabIndex = 1;
            this.GControlCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCustomer});
            // 
            // GViewCustomer
            // 
            this.GViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnCustomerID,
            this.ColumnCustomerTC,
            this.ColumnCustomerName,
            this.ColumnCustomerSurName,
            this.ColumnCustomerGender,
            this.ColumnMobilePhone,
            this.ColumnOfficePhone,
            this.ColumnCustomerMail,
            this.ColumnMAIL,
            this.ColumnSMS,
            this.ColumnSMS2});
            this.GViewCustomer.DetailHeight = 303;
            this.GViewCustomer.GridControl = this.GControlCustomer;
            this.GViewCustomer.Name = "GViewCustomer";
            this.GViewCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnCustomerID
            // 
            this.ColumnCustomerID.Caption = "ID";
            this.ColumnCustomerID.FieldName = "CustomerID";
            this.ColumnCustomerID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerID.ImageOptions.Image")));
            this.ColumnCustomerID.Name = "ColumnCustomerID";
            this.ColumnCustomerID.OptionsColumn.ReadOnly = true;
            this.ColumnCustomerID.Visible = true;
            this.ColumnCustomerID.VisibleIndex = 0;
            this.ColumnCustomerID.Width = 83;
            // 
            // ColumnCustomerTC
            // 
            this.ColumnCustomerTC.Caption = "T.C KİMLİK NO";
            this.ColumnCustomerTC.FieldName = "CustomerTC";
            this.ColumnCustomerTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerTC.ImageOptions.Image")));
            this.ColumnCustomerTC.Name = "ColumnCustomerTC";
            this.ColumnCustomerTC.OptionsColumn.ReadOnly = true;
            this.ColumnCustomerTC.Visible = true;
            this.ColumnCustomerTC.VisibleIndex = 1;
            this.ColumnCustomerTC.Width = 122;
            // 
            // ColumnCustomerName
            // 
            this.ColumnCustomerName.Caption = "Adı";
            this.ColumnCustomerName.FieldName = "CustomerName";
            this.ColumnCustomerName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerName.ImageOptions.Image")));
            this.ColumnCustomerName.Name = "ColumnCustomerName";
            this.ColumnCustomerName.OptionsColumn.ReadOnly = true;
            this.ColumnCustomerName.Visible = true;
            this.ColumnCustomerName.VisibleIndex = 2;
            this.ColumnCustomerName.Width = 122;
            // 
            // ColumnCustomerSurName
            // 
            this.ColumnCustomerSurName.Caption = "Soyadı";
            this.ColumnCustomerSurName.FieldName = "CustomerSurName";
            this.ColumnCustomerSurName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerSurName.ImageOptions.Image")));
            this.ColumnCustomerSurName.Name = "ColumnCustomerSurName";
            this.ColumnCustomerSurName.OptionsColumn.ReadOnly = true;
            this.ColumnCustomerSurName.Visible = true;
            this.ColumnCustomerSurName.VisibleIndex = 3;
            this.ColumnCustomerSurName.Width = 119;
            // 
            // ColumnCustomerGender
            // 
            this.ColumnCustomerGender.Caption = "Cinsiyet";
            this.ColumnCustomerGender.FieldName = "CustomerGender";
            this.ColumnCustomerGender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerGender.ImageOptions.Image")));
            this.ColumnCustomerGender.Name = "ColumnCustomerGender";
            this.ColumnCustomerGender.OptionsColumn.ReadOnly = true;
            this.ColumnCustomerGender.Visible = true;
            this.ColumnCustomerGender.VisibleIndex = 4;
            this.ColumnCustomerGender.Width = 116;
            // 
            // ColumnMobilePhone
            // 
            this.ColumnMobilePhone.Caption = "Cep Telefonu";
            this.ColumnMobilePhone.FieldName = "CustomerMobilePhone";
            this.ColumnMobilePhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnMobilePhone.ImageOptions.Image")));
            this.ColumnMobilePhone.Name = "ColumnMobilePhone";
            this.ColumnMobilePhone.OptionsColumn.ReadOnly = true;
            this.ColumnMobilePhone.Visible = true;
            this.ColumnMobilePhone.VisibleIndex = 5;
            this.ColumnMobilePhone.Width = 116;
            // 
            // ColumnOfficePhone
            // 
            this.ColumnOfficePhone.Caption = "İş Telefonu";
            this.ColumnOfficePhone.FieldName = "CustomerOfficePhone";
            this.ColumnOfficePhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnOfficePhone.ImageOptions.Image")));
            this.ColumnOfficePhone.Name = "ColumnOfficePhone";
            this.ColumnOfficePhone.OptionsColumn.ReadOnly = true;
            this.ColumnOfficePhone.Visible = true;
            this.ColumnOfficePhone.VisibleIndex = 7;
            this.ColumnOfficePhone.Width = 116;
            // 
            // ColumnCustomerMail
            // 
            this.ColumnCustomerMail.Caption = "E-Posta Adresi";
            this.ColumnCustomerMail.FieldName = "CustomerMail";
            this.ColumnCustomerMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerMail.ImageOptions.Image")));
            this.ColumnCustomerMail.Name = "ColumnCustomerMail";
            this.ColumnCustomerMail.OptionsColumn.ReadOnly = true;
            this.ColumnCustomerMail.Visible = true;
            this.ColumnCustomerMail.VisibleIndex = 9;
            this.ColumnCustomerMail.Width = 129;
            // 
            // ColumnMAIL
            // 
            this.ColumnMAIL.ColumnEdit = this.repositoryItemBtnMail;
            this.ColumnMAIL.Name = "ColumnMAIL";
            this.ColumnMAIL.Visible = true;
            this.ColumnMAIL.VisibleIndex = 10;
            this.ColumnMAIL.Width = 60;
            // 
            // repositoryItemBtnMail
            // 
            this.repositoryItemBtnMail.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemBtnMail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemBtnMail.Name = "repositoryItemBtnMail";
            this.repositoryItemBtnMail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemBtnMail.Click += new System.EventHandler(this.repositoryItemBtnMail_Click);
            // 
            // ColumnSMS
            // 
            this.ColumnSMS.ColumnEdit = this.repositoryItemBtnSms;
            this.ColumnSMS.Name = "ColumnSMS";
            this.ColumnSMS.Visible = true;
            this.ColumnSMS.VisibleIndex = 6;
            this.ColumnSMS.Width = 45;
            // 
            // repositoryItemBtnSms
            // 
            this.repositoryItemBtnSms.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemBtnSms.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemBtnSms.Name = "repositoryItemBtnSms";
            this.repositoryItemBtnSms.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemBtnSms.Click += new System.EventHandler(this.repositoryItemBtnSms_Click);
            // 
            // ColumnSMS2
            // 
            this.ColumnSMS2.ColumnEdit = this.repositoryItemBtnSms2;
            this.ColumnSMS2.Name = "ColumnSMS2";
            this.ColumnSMS2.Visible = true;
            this.ColumnSMS2.VisibleIndex = 8;
            this.ColumnSMS2.Width = 50;
            // 
            // repositoryItemBtnSms2
            // 
            this.repositoryItemBtnSms2.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemBtnSms2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemBtnSms2.Name = "repositoryItemBtnSms2";
            this.repositoryItemBtnSms2.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemBtnSms2.Click += new System.EventHandler(this.repositoryItemBtnSms2_Click);
            // 
            // CustomerGuideWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 472);
            this.Controls.Add(this.GControlCustomer);
            this.Name = "CustomerGuideWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ REHBERİ";
            this.Load += new System.EventHandler(this.CustomerGuideWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnSms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnSms2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControlCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerTC;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerSurName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerGender;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnMobilePhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnOfficePhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnMAIL;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBtnMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSMS;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBtnSms;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSMS2;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBtnSms2;
    }
}