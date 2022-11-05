namespace PresentationLayer.WinFormList.GuidesWF
{
    partial class EmployeeGuideWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeGuideWF));
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
            this.GControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.GViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeSurName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnMobilePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemBtnMail = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnSms = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemBtnSms = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnSearch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemBtnSearch = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnSms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlEmployee
            // 
            this.GControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlEmployee.Location = new System.Drawing.Point(0, 0);
            this.GControlEmployee.MainView = this.GViewEmployee;
            this.GControlEmployee.Name = "GControlEmployee";
            this.GControlEmployee.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemBtnMail,
            this.repositoryItemBtnSms,
            this.repositoryItemBtnSearch});
            this.GControlEmployee.Size = new System.Drawing.Size(1220, 503);
            this.GControlEmployee.TabIndex = 2;
            this.GControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewEmployee});
            // 
            // GViewEmployee
            // 
            this.GViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnEmployeeID,
            this.ColumnDepartment,
            this.ColumnEmployeeName,
            this.ColumnEmployeeSurName,
            this.ColumnEmployeeGender,
            this.ColumnMobilePhone,
            this.ColumnEmployeeMail,
            this.gridColumnMail,
            this.gridColumnSms,
            this.gridColumnSearch});
            this.GViewEmployee.DetailHeight = 303;
            this.GViewEmployee.GridControl = this.GControlEmployee;
            this.GViewEmployee.Name = "GViewEmployee";
            this.GViewEmployee.OptionsView.ShowGroupPanel = false;
            this.GViewEmployee.RowHeight = 35;
            // 
            // ColumnEmployeeID
            // 
            this.ColumnEmployeeID.Caption = "ID";
            this.ColumnEmployeeID.FieldName = "EmployeeID";
            this.ColumnEmployeeID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeID.ImageOptions.Image")));
            this.ColumnEmployeeID.Name = "ColumnEmployeeID";
            this.ColumnEmployeeID.OptionsColumn.ReadOnly = true;
            this.ColumnEmployeeID.Visible = true;
            this.ColumnEmployeeID.VisibleIndex = 0;
            this.ColumnEmployeeID.Width = 120;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.Caption = "Departman Adı";
            this.ColumnDepartment.FieldName = "DepartmentName";
            this.ColumnDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDepartment.ImageOptions.Image")));
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.OptionsColumn.ReadOnly = true;
            this.ColumnDepartment.Visible = true;
            this.ColumnDepartment.VisibleIndex = 1;
            this.ColumnDepartment.Width = 170;
            // 
            // ColumnEmployeeName
            // 
            this.ColumnEmployeeName.Caption = "Adı";
            this.ColumnEmployeeName.FieldName = "EmployeeName";
            this.ColumnEmployeeName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeName.ImageOptions.Image")));
            this.ColumnEmployeeName.Name = "ColumnEmployeeName";
            this.ColumnEmployeeName.OptionsColumn.ReadOnly = true;
            this.ColumnEmployeeName.Visible = true;
            this.ColumnEmployeeName.VisibleIndex = 2;
            this.ColumnEmployeeName.Width = 158;
            // 
            // ColumnEmployeeSurName
            // 
            this.ColumnEmployeeSurName.Caption = "Soyadı";
            this.ColumnEmployeeSurName.FieldName = "EmployeeSurName";
            this.ColumnEmployeeSurName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeSurName.ImageOptions.Image")));
            this.ColumnEmployeeSurName.Name = "ColumnEmployeeSurName";
            this.ColumnEmployeeSurName.OptionsColumn.ReadOnly = true;
            this.ColumnEmployeeSurName.Visible = true;
            this.ColumnEmployeeSurName.VisibleIndex = 3;
            this.ColumnEmployeeSurName.Width = 163;
            // 
            // ColumnEmployeeGender
            // 
            this.ColumnEmployeeGender.Caption = "Cinsiyet";
            this.ColumnEmployeeGender.FieldName = "EmployeeGender";
            this.ColumnEmployeeGender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeGender.ImageOptions.Image")));
            this.ColumnEmployeeGender.Name = "ColumnEmployeeGender";
            this.ColumnEmployeeGender.OptionsColumn.ReadOnly = true;
            this.ColumnEmployeeGender.Visible = true;
            this.ColumnEmployeeGender.VisibleIndex = 4;
            this.ColumnEmployeeGender.Width = 117;
            // 
            // ColumnMobilePhone
            // 
            this.ColumnMobilePhone.Caption = "Telefon:";
            this.ColumnMobilePhone.FieldName = "EmployeePhone";
            this.ColumnMobilePhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnMobilePhone.ImageOptions.Image")));
            this.ColumnMobilePhone.Name = "ColumnMobilePhone";
            this.ColumnMobilePhone.OptionsColumn.ReadOnly = true;
            this.ColumnMobilePhone.Visible = true;
            this.ColumnMobilePhone.VisibleIndex = 5;
            this.ColumnMobilePhone.Width = 138;
            // 
            // ColumnEmployeeMail
            // 
            this.ColumnEmployeeMail.Caption = "E-Posta Adresi";
            this.ColumnEmployeeMail.FieldName = "EmployeeMail";
            this.ColumnEmployeeMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeMail.ImageOptions.Image")));
            this.ColumnEmployeeMail.Name = "ColumnEmployeeMail";
            this.ColumnEmployeeMail.OptionsColumn.ReadOnly = true;
            this.ColumnEmployeeMail.Visible = true;
            this.ColumnEmployeeMail.VisibleIndex = 6;
            this.ColumnEmployeeMail.Width = 156;
            // 
            // gridColumnMail
            // 
            this.gridColumnMail.ColumnEdit = this.repositoryItemBtnMail;
            this.gridColumnMail.MinWidth = 10;
            this.gridColumnMail.Name = "gridColumnMail";
            this.gridColumnMail.Visible = true;
            this.gridColumnMail.VisibleIndex = 7;
            this.gridColumnMail.Width = 46;
            // 
            // repositoryItemBtnMail
            // 
            this.repositoryItemBtnMail.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.repositoryItemBtnMail.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemBtnMail.Name = "repositoryItemBtnMail";
            this.repositoryItemBtnMail.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemBtnMail.Click += new System.EventHandler(this.repositoryItemButtonEdit1_Click);
            // 
            // gridColumnSms
            // 
            this.gridColumnSms.ColumnEdit = this.repositoryItemBtnSms;
            this.gridColumnSms.MinWidth = 10;
            this.gridColumnSms.Name = "gridColumnSms";
            this.gridColumnSms.Visible = true;
            this.gridColumnSms.VisibleIndex = 8;
            this.gridColumnSms.Width = 46;
            // 
            // repositoryItemBtnSms
            // 
            this.repositoryItemBtnSms.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.repositoryItemBtnSms.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemBtnSms.Name = "repositoryItemBtnSms";
            this.repositoryItemBtnSms.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // gridColumnSearch
            // 
            this.gridColumnSearch.ColumnEdit = this.repositoryItemBtnSearch;
            this.gridColumnSearch.MinWidth = 10;
            this.gridColumnSearch.Name = "gridColumnSearch";
            this.gridColumnSearch.Visible = true;
            this.gridColumnSearch.VisibleIndex = 9;
            this.gridColumnSearch.Width = 46;
            // 
            // repositoryItemBtnSearch
            // 
            this.repositoryItemBtnSearch.AutoHeight = false;
            editorButtonImageOptions3.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions3.Image")));
            this.repositoryItemBtnSearch.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions3, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject9, serializableAppearanceObject10, serializableAppearanceObject11, serializableAppearanceObject12, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemBtnSearch.Name = "repositoryItemBtnSearch";
            this.repositoryItemBtnSearch.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            // 
            // EmployeeGuideWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 503);
            this.Controls.Add(this.GControlEmployee);
            this.Name = "EmployeeGuideWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL REHBERİ";
            this.Load += new System.EventHandler(this.EmployeeGuideWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnSms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemBtnSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeSurName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeGender;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnMobilePhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeMail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMail;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBtnMail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSms;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSearch;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBtnSms;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemBtnSearch;
        public DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeID;
    }
}