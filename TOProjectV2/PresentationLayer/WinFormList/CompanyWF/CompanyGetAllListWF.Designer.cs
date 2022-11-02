namespace PresentationLayer.WinFormList.CompanyWF
{
    partial class CompanyGetAllListWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyGetAllListWF));
            this.GControlCompany = new DevExpress.XtraGrid.GridControl();
            this.GViewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnSectorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyNameSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnOfficialStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPhone2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPhone3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyFax = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyTaxOffice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCountyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDistrictName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlCompany
            // 
            this.GControlCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlCompany.Location = new System.Drawing.Point(0, 0);
            this.GControlCompany.MainView = this.GViewCompany;
            this.GControlCompany.Name = "GControlCompany";
            this.GControlCompany.Size = new System.Drawing.Size(1214, 483);
            this.GControlCompany.TabIndex = 1;
            this.GControlCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCompany});
            // 
            // GViewCompany
            // 
            this.GViewCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnCompanyID,
            this.ColumnCompanyName,
            this.ColumnSectorName,
            this.ColumnCompanyTC,
            this.ColumnCompanyNameSurname,
            this.ColumnOfficialStatus,
            this.ColumnPhone1,
            this.ColumnPhone2,
            this.ColumnPhone3,
            this.ColumnCompanyMail,
            this.ColumnCompanyFax,
            this.ColumnCompanyTaxOffice,
            this.ColumnCountyName,
            this.ColumnDistrictName,
            this.ColumnCompanyAddress});
            this.GViewCompany.DetailHeight = 303;
            this.GViewCompany.GridControl = this.GControlCompany;
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
            this.ColumnCompanyID.Name = "ColumnCompanyID";
            this.ColumnCompanyID.Visible = true;
            this.ColumnCompanyID.VisibleIndex = 0;
            this.ColumnCompanyID.Width = 46;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.Caption = "Firma Adı";
            this.ColumnCompanyName.FieldName = "CompanyName";
            this.ColumnCompanyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyName.ImageOptions.Image")));
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.Visible = true;
            this.ColumnCompanyName.VisibleIndex = 1;
            // 
            // ColumnSectorName
            // 
            this.ColumnSectorName.Caption = "Sektör Adı";
            this.ColumnSectorName.FieldName = "SectorName";
            this.ColumnSectorName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSectorName.ImageOptions.Image")));
            this.ColumnSectorName.Name = "ColumnSectorName";
            this.ColumnSectorName.Visible = true;
            this.ColumnSectorName.VisibleIndex = 2;
            // 
            // ColumnCompanyTC
            // 
            this.ColumnCompanyTC.Caption = "Yetkili T.C";
            this.ColumnCompanyTC.FieldName = "CompanyOfficialTC";
            this.ColumnCompanyTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyTC.ImageOptions.Image")));
            this.ColumnCompanyTC.Name = "ColumnCompanyTC";
            this.ColumnCompanyTC.Visible = true;
            this.ColumnCompanyTC.VisibleIndex = 3;
            // 
            // ColumnCompanyNameSurname
            // 
            this.ColumnCompanyNameSurname.Caption = "Yetkili";
            this.ColumnCompanyNameSurname.FieldName = "CompanyOfficialNameSurName";
            this.ColumnCompanyNameSurname.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyNameSurname.ImageOptions.Image")));
            this.ColumnCompanyNameSurname.Name = "ColumnCompanyNameSurname";
            this.ColumnCompanyNameSurname.Visible = true;
            this.ColumnCompanyNameSurname.VisibleIndex = 4;
            // 
            // ColumnOfficialStatus
            // 
            this.ColumnOfficialStatus.Caption = "Yetkili Statüsü";
            this.ColumnOfficialStatus.FieldName = "CompanyOfficialStatus";
            this.ColumnOfficialStatus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnOfficialStatus.ImageOptions.Image")));
            this.ColumnOfficialStatus.Name = "ColumnOfficialStatus";
            this.ColumnOfficialStatus.Visible = true;
            this.ColumnOfficialStatus.VisibleIndex = 5;
            // 
            // ColumnPhone1
            // 
            this.ColumnPhone1.Caption = "Telefon(1)";
            this.ColumnPhone1.FieldName = "CompanyPhone1";
            this.ColumnPhone1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPhone1.ImageOptions.Image")));
            this.ColumnPhone1.Name = "ColumnPhone1";
            this.ColumnPhone1.Visible = true;
            this.ColumnPhone1.VisibleIndex = 6;
            // 
            // ColumnPhone2
            // 
            this.ColumnPhone2.Caption = "Telefon(2)";
            this.ColumnPhone2.FieldName = "CompanyPhone2";
            this.ColumnPhone2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPhone2.ImageOptions.Image")));
            this.ColumnPhone2.Name = "ColumnPhone2";
            this.ColumnPhone2.Visible = true;
            this.ColumnPhone2.VisibleIndex = 7;
            // 
            // ColumnPhone3
            // 
            this.ColumnPhone3.Caption = "Telefon(3)";
            this.ColumnPhone3.FieldName = "CompanyPhone3";
            this.ColumnPhone3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPhone3.ImageOptions.Image")));
            this.ColumnPhone3.Name = "ColumnPhone3";
            this.ColumnPhone3.Visible = true;
            this.ColumnPhone3.VisibleIndex = 8;
            // 
            // ColumnCompanyMail
            // 
            this.ColumnCompanyMail.Caption = "E-Posta Adresi";
            this.ColumnCompanyMail.FieldName = "CompanyMail";
            this.ColumnCompanyMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyMail.ImageOptions.Image")));
            this.ColumnCompanyMail.Name = "ColumnCompanyMail";
            this.ColumnCompanyMail.Visible = true;
            this.ColumnCompanyMail.VisibleIndex = 9;
            // 
            // ColumnCompanyFax
            // 
            this.ColumnCompanyFax.Caption = "Fax Adresi";
            this.ColumnCompanyFax.FieldName = "CompanyFax";
            this.ColumnCompanyFax.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyFax.ImageOptions.Image")));
            this.ColumnCompanyFax.Name = "ColumnCompanyFax";
            this.ColumnCompanyFax.Visible = true;
            this.ColumnCompanyFax.VisibleIndex = 10;
            // 
            // ColumnCompanyTaxOffice
            // 
            this.ColumnCompanyTaxOffice.Caption = "Vergi Dairesi";
            this.ColumnCompanyTaxOffice.FieldName = "CompanyTaxOffice";
            this.ColumnCompanyTaxOffice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyTaxOffice.ImageOptions.Image")));
            this.ColumnCompanyTaxOffice.Name = "ColumnCompanyTaxOffice";
            this.ColumnCompanyTaxOffice.Visible = true;
            this.ColumnCompanyTaxOffice.VisibleIndex = 11;
            // 
            // ColumnCountyName
            // 
            this.ColumnCountyName.Caption = "İl";
            this.ColumnCountyName.FieldName = "CountyName";
            this.ColumnCountyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCountyName.ImageOptions.Image")));
            this.ColumnCountyName.Name = "ColumnCountyName";
            this.ColumnCountyName.Visible = true;
            this.ColumnCountyName.VisibleIndex = 12;
            // 
            // ColumnDistrictName
            // 
            this.ColumnDistrictName.Caption = "İlçe";
            this.ColumnDistrictName.FieldName = "DistrictName";
            this.ColumnDistrictName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDistrictName.ImageOptions.Image")));
            this.ColumnDistrictName.Name = "ColumnDistrictName";
            this.ColumnDistrictName.Visible = true;
            this.ColumnDistrictName.VisibleIndex = 13;
            // 
            // ColumnCompanyAddress
            // 
            this.ColumnCompanyAddress.Caption = "Firma Adresi";
            this.ColumnCompanyAddress.FieldName = "CompanyAddress";
            this.ColumnCompanyAddress.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyAddress.ImageOptions.Image")));
            this.ColumnCompanyAddress.Name = "ColumnCompanyAddress";
            this.ColumnCompanyAddress.Visible = true;
            this.ColumnCompanyAddress.VisibleIndex = 14;
            // 
            // CompanyGetAllListWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 483);
            this.Controls.Add(this.GControlCompany);
            this.Name = "CompanyGetAllListWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TÜM FİRMA BİLGİLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CompanyGetAllListWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControlCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCompany;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSectorName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyTC;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyNameSurname;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnOfficialStatus;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPhone2;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPhone3;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyFax;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyTaxOffice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCountyName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDistrictName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyAddress;
    }
}