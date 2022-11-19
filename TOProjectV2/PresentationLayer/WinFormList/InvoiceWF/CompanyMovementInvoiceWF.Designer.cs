namespace PresentationLayer.WinFormList.InvoiceWF
{
    partial class CompanyMovementInvoiceWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyMovementInvoiceWF));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
            this.groupControlExpenseHeader = new DevExpress.XtraEditors.GroupControl();
            this.GControlInvoice = new DevExpress.XtraGrid.GridControl();
            this.GViewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnInvoiceSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyMovementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnMovementNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyMovementInvoiceButton = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BtnEditCompanyInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlExpenseHeader)).BeginInit();
            this.groupControlExpenseHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditCompanyInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControlExpenseHeader
            // 
            this.groupControlExpenseHeader.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControlExpenseHeader.AppearanceCaption.Options.UseFont = true;
            this.groupControlExpenseHeader.AppearanceCaption.Options.UseTextOptions = true;
            this.groupControlExpenseHeader.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.groupControlExpenseHeader.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.groupControlExpenseHeader.Controls.Add(this.GControlInvoice);
            this.groupControlExpenseHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlExpenseHeader.Location = new System.Drawing.Point(0, 0);
            this.groupControlExpenseHeader.Name = "groupControlExpenseHeader";
            this.groupControlExpenseHeader.Size = new System.Drawing.Size(1165, 501);
            this.groupControlExpenseHeader.TabIndex = 13;
            this.groupControlExpenseHeader.Text = "FİRMA HAREKETLERİ";
            // 
            // GControlInvoice
            // 
            this.GControlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlInvoice.Location = new System.Drawing.Point(2, 29);
            this.GControlInvoice.MainView = this.GViewCompany;
            this.GControlInvoice.Name = "GControlInvoice";
            this.GControlInvoice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnEditCompanyInvoice});
            this.GControlInvoice.Size = new System.Drawing.Size(1161, 470);
            this.GControlInvoice.TabIndex = 2;
            this.GControlInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCompany});
            // 
            // GViewCompany
            // 
            this.GViewCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnCompanyID,
            this.ColumnCompanyName,
            this.ColumnEmployeeName,
            this.ColumnInvoiceSeries,
            this.ColumnCompanyMovementDate,
            this.ColumnMovementNote,
            this.ColumnCompanyMovementInvoiceButton});
            this.GViewCompany.DetailHeight = 303;
            this.GViewCompany.GridControl = this.GControlInvoice;
            this.GViewCompany.Name = "GViewCompany";
            this.GViewCompany.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnCompanyID
            // 
            this.ColumnCompanyID.Caption = "ID";
            this.ColumnCompanyID.FieldName = "InvoiceID";
            this.ColumnCompanyID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyID.ImageOptions.Image")));
            this.ColumnCompanyID.MinWidth = 18;
            this.ColumnCompanyID.Name = "ColumnCompanyID";
            this.ColumnCompanyID.OptionsColumn.ReadOnly = true;
            this.ColumnCompanyID.Visible = true;
            this.ColumnCompanyID.VisibleIndex = 0;
            this.ColumnCompanyID.Width = 133;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.Caption = "Firma";
            this.ColumnCompanyName.FieldName = "CompanyName";
            this.ColumnCompanyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyName.ImageOptions.Image")));
            this.ColumnCompanyName.MinWidth = 40;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.OptionsColumn.ReadOnly = true;
            this.ColumnCompanyName.Visible = true;
            this.ColumnCompanyName.VisibleIndex = 2;
            this.ColumnCompanyName.Width = 273;
            // 
            // ColumnEmployeeName
            // 
            this.ColumnEmployeeName.Caption = "Personel";
            this.ColumnEmployeeName.FieldName = "EmployeeNameSurName";
            this.ColumnEmployeeName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeName.ImageOptions.Image")));
            this.ColumnEmployeeName.MinWidth = 18;
            this.ColumnEmployeeName.Name = "ColumnEmployeeName";
            this.ColumnEmployeeName.OptionsColumn.ReadOnly = true;
            this.ColumnEmployeeName.Visible = true;
            this.ColumnEmployeeName.VisibleIndex = 3;
            this.ColumnEmployeeName.Width = 166;
            // 
            // ColumnInvoiceSeries
            // 
            this.ColumnInvoiceSeries.Caption = "Fatura No";
            this.ColumnInvoiceSeries.FieldName = "InvoiceSeries";
            this.ColumnInvoiceSeries.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnInvoiceSeries.ImageOptions.Image")));
            this.ColumnInvoiceSeries.Name = "ColumnInvoiceSeries";
            this.ColumnInvoiceSeries.OptionsColumn.ReadOnly = true;
            this.ColumnInvoiceSeries.Visible = true;
            this.ColumnInvoiceSeries.VisibleIndex = 1;
            this.ColumnInvoiceSeries.Width = 172;
            // 
            // ColumnCompanyMovementDate
            // 
            this.ColumnCompanyMovementDate.Caption = "Tarih";
            this.ColumnCompanyMovementDate.FieldName = "CompanyMovementDate";
            this.ColumnCompanyMovementDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyMovementDate.ImageOptions.Image")));
            this.ColumnCompanyMovementDate.MinWidth = 15;
            this.ColumnCompanyMovementDate.Name = "ColumnCompanyMovementDate";
            this.ColumnCompanyMovementDate.OptionsColumn.ReadOnly = true;
            this.ColumnCompanyMovementDate.Visible = true;
            this.ColumnCompanyMovementDate.VisibleIndex = 4;
            this.ColumnCompanyMovementDate.Width = 192;
            // 
            // ColumnMovementNote
            // 
            this.ColumnMovementNote.Caption = "Not";
            this.ColumnMovementNote.FieldName = "CompanyMovementNote";
            this.ColumnMovementNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnMovementNote.ImageOptions.Image")));
            this.ColumnMovementNote.Name = "ColumnMovementNote";
            this.ColumnMovementNote.OptionsColumn.ReadOnly = true;
            this.ColumnMovementNote.Visible = true;
            this.ColumnMovementNote.VisibleIndex = 5;
            this.ColumnMovementNote.Width = 197;
            // 
            // ColumnCompanyMovementInvoiceButton
            // 
            this.ColumnCompanyMovementInvoiceButton.ColumnEdit = this.BtnEditCompanyInvoice;
            this.ColumnCompanyMovementInvoiceButton.Name = "ColumnCompanyMovementInvoiceButton";
            this.ColumnCompanyMovementInvoiceButton.Visible = true;
            this.ColumnCompanyMovementInvoiceButton.VisibleIndex = 6;
            // 
            // BtnEditCompanyInvoice
            // 
            this.BtnEditCompanyInvoice.AutoHeight = false;
            editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
            this.BtnEditCompanyInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.BtnEditCompanyInvoice.Name = "BtnEditCompanyInvoice";
            this.BtnEditCompanyInvoice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.BtnEditCompanyInvoice.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnEditCompanyInvoice_ButtonClick);
            // 
            // CompanyMovementInvoiceWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 501);
            this.Controls.Add(this.groupControlExpenseHeader);
            this.Name = "CompanyMovementInvoiceWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİRMA HAREKETLERİ FATURALAR";
            this.Load += new System.EventHandler(this.CompanyMovementInvoiceWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControlExpenseHeader)).EndInit();
            this.groupControlExpenseHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEditCompanyInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControlExpenseHeader;
        private DevExpress.XtraGrid.GridControl GControlInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCompany;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnInvoiceSeries;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyMovementDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnMovementNote;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyMovementInvoiceButton;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnEditCompanyInvoice;
    }
}