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
            this.xtraTabCompanyControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageCompany = new DevExpress.XtraTab.XtraTabPage();
            this.GControlInvoice = new DevExpress.XtraGrid.GridControl();
            this.GViewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnInvoiceSeries = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyMovementDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnMovementNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabPageCompanyArchive = new DevExpress.XtraTab.XtraTabPage();
            this.GControlCompanyArchive = new DevExpress.XtraGrid.GridControl();
            this.GViewCompanyArchive = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCompanyControl)).BeginInit();
            this.xtraTabCompanyControl.SuspendLayout();
            this.TabPageCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).BeginInit();
            this.TabPageCompanyArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompanyArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompanyArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabCompanyControl
            // 
            this.xtraTabCompanyControl.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Teal;
            this.xtraTabCompanyControl.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabCompanyControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabCompanyControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabCompanyControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabCompanyControl.Location = new System.Drawing.Point(0, 0);
            this.xtraTabCompanyControl.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabCompanyControl.Name = "xtraTabCompanyControl";
            this.xtraTabCompanyControl.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabCompanyControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabCompanyControl.SelectedTabPage = this.TabPageCompany;
            this.xtraTabCompanyControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabCompanyControl.Size = new System.Drawing.Size(1165, 501);
            this.xtraTabCompanyControl.TabIndex = 10;
            this.xtraTabCompanyControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageCompany,
            this.TabPageCompanyArchive});
            // 
            // TabPageCompany
            // 
            this.TabPageCompany.Controls.Add(this.GControlInvoice);
            this.TabPageCompany.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageCompany.ImageOptions.Image")));
            this.TabPageCompany.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageCompany.Name = "TabPageCompany";
            this.TabPageCompany.Size = new System.Drawing.Size(1163, 449);
            this.TabPageCompany.Text = "ÜRÜNLER LİSTESİ";
            // 
            // GControlInvoice
            // 
            this.GControlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlInvoice.Location = new System.Drawing.Point(0, 0);
            this.GControlInvoice.MainView = this.GViewCompany;
            this.GControlInvoice.Name = "GControlInvoice";
            this.GControlInvoice.Size = new System.Drawing.Size(1163, 449);
            this.GControlInvoice.TabIndex = 0;
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
            this.ColumnMovementNote});
            this.GViewCompany.DetailHeight = 303;
            this.GViewCompany.GridControl = this.GControlInvoice;
            this.GViewCompany.Name = "GViewCompany";
            this.GViewCompany.OptionsBehavior.Editable = false;
            this.GViewCompany.OptionsBehavior.ReadOnly = true;
            this.GViewCompany.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnCompanyID
            // 
            this.ColumnCompanyID.Caption = "ID";
            this.ColumnCompanyID.FieldName = "CompanyID";
            this.ColumnCompanyID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyID.ImageOptions.Image")));
            this.ColumnCompanyID.MinWidth = 18;
            this.ColumnCompanyID.Name = "ColumnCompanyID";
            this.ColumnCompanyID.Visible = true;
            this.ColumnCompanyID.VisibleIndex = 0;
            this.ColumnCompanyID.Width = 133;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.Caption = "Firma Adı";
            this.ColumnCompanyName.FieldName = "CompanyName";
            this.ColumnCompanyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyName.ImageOptions.Image")));
            this.ColumnCompanyName.MinWidth = 40;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
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
            this.ColumnMovementNote.Visible = true;
            this.ColumnMovementNote.VisibleIndex = 5;
            this.ColumnMovementNote.Width = 197;
            // 
            // TabPageCompanyArchive
            // 
            this.TabPageCompanyArchive.Controls.Add(this.GControlCompanyArchive);
            this.TabPageCompanyArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageCompanyArchive.ImageOptions.Image")));
            this.TabPageCompanyArchive.Name = "TabPageCompanyArchive";
            this.TabPageCompanyArchive.Size = new System.Drawing.Size(1163, 449);
            this.TabPageCompanyArchive.Text = "ÜRÜNLER ARŞİV LİSTESİ";
            // 
            // GControlCompanyArchive
            // 
            this.GControlCompanyArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlCompanyArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlCompanyArchive.MainView = this.GViewCompanyArchive;
            this.GControlCompanyArchive.Name = "GControlCompanyArchive";
            this.GControlCompanyArchive.Size = new System.Drawing.Size(1163, 449);
            this.GControlCompanyArchive.TabIndex = 1;
            this.GControlCompanyArchive.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCompanyArchive});
            // 
            // GViewCompanyArchive
            // 
            this.GViewCompanyArchive.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7});
            this.GViewCompanyArchive.DetailHeight = 303;
            this.GViewCompanyArchive.GridControl = this.GControlCompanyArchive;
            this.GViewCompanyArchive.Name = "GViewCompanyArchive";
            this.GViewCompanyArchive.OptionsBehavior.Editable = false;
            this.GViewCompanyArchive.OptionsBehavior.ReadOnly = true;
            this.GViewCompanyArchive.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "CompanyID";
            this.gridColumn1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.ImageOptions.Image")));
            this.gridColumn1.MinWidth = 18;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 86;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Firma Adı";
            this.gridColumn2.FieldName = "CompanyName";
            this.gridColumn2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.ImageOptions.Image")));
            this.gridColumn2.MinWidth = 40;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 172;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Sektör Adı";
            this.gridColumn3.FieldName = "SectorName";
            this.gridColumn3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.ImageOptions.Image")));
            this.gridColumn3.MinWidth = 18;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 105;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Yetkili";
            this.gridColumn4.FieldName = "CompanyOfficialNameSurName";
            this.gridColumn4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn4.ImageOptions.Image")));
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 125;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Yetkili Statüsü";
            this.gridColumn5.FieldName = "CompanyOfficialStatus";
            this.gridColumn5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn5.ImageOptions.Image")));
            this.gridColumn5.MinWidth = 15;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 121;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Telefon";
            this.gridColumn6.FieldName = "CompanyPhone1";
            this.gridColumn6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn6.ImageOptions.Image")));
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 119;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "E-Posta Adresi";
            this.gridColumn7.FieldName = "CompanyMail";
            this.gridColumn7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn7.ImageOptions.Image")));
            this.gridColumn7.MinWidth = 40;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 210;
            // 
            // CompanyMovementInvoiceWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 501);
            this.Controls.Add(this.xtraTabCompanyControl);
            this.Name = "CompanyMovementInvoiceWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİRMA HAREKETLERİ FATURALAR";
            this.Load += new System.EventHandler(this.CompanyMovementInvoiceWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCompanyControl)).EndInit();
            this.xtraTabCompanyControl.ResumeLayout(false);
            this.TabPageCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).EndInit();
            this.TabPageCompanyArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompanyArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompanyArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabCompanyControl;
        private DevExpress.XtraTab.XtraTabPage TabPageCompany;
        private DevExpress.XtraGrid.GridControl GControlInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCompany;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnInvoiceSeries;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyMovementDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnMovementNote;
        private DevExpress.XtraTab.XtraTabPage TabPageCompanyArchive;
        private DevExpress.XtraGrid.GridControl GControlCompanyArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCompanyArchive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
    }
}