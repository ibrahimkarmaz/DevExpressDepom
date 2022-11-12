namespace PresentationLayer.WinFormList.BankWF
{
    partial class BankExpandWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankExpandWF));
            this.GControlBank = new DevExpress.XtraGrid.GridControl();
            this.GViewBank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnBankID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCountyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDistrinct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBankBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnIBAN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBankAccountNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnOfficial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBankPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCreateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnAccountType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBank)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlBank
            // 
            this.GControlBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlBank.Location = new System.Drawing.Point(0, 0);
            this.GControlBank.MainView = this.GViewBank;
            this.GControlBank.Name = "GControlBank";
            this.GControlBank.Size = new System.Drawing.Size(1270, 498);
            this.GControlBank.TabIndex = 1;
            this.GControlBank.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewBank});
            // 
            // GViewBank
            // 
            this.GViewBank.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnBankID,
            this.ColumnBankName,
            this.ColumnCountyName,
            this.ColumnDistrinct,
            this.ColumnBankBranch,
            this.ColumnIBAN,
            this.ColumnBankAccountNumber,
            this.ColumnOfficial,
            this.ColumnBankPhone,
            this.ColumnCreateDate,
            this.ColumnAccountType,
            this.ColumnCompanyName});
            this.GViewBank.DetailHeight = 303;
            this.GViewBank.GridControl = this.GControlBank;
            this.GViewBank.Name = "GViewBank";
            this.GViewBank.OptionsBehavior.Editable = false;
            this.GViewBank.OptionsBehavior.ReadOnly = true;
            this.GViewBank.OptionsView.ColumnAutoWidth = false;
            this.GViewBank.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnBankID
            // 
            this.ColumnBankID.Caption = "ID";
            this.ColumnBankID.FieldName = "BankID";
            this.ColumnBankID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBankID.ImageOptions.Image")));
            this.ColumnBankID.MinWidth = 18;
            this.ColumnBankID.Name = "ColumnBankID";
            this.ColumnBankID.Visible = true;
            this.ColumnBankID.VisibleIndex = 0;
            this.ColumnBankID.Width = 60;
            // 
            // ColumnBankName
            // 
            this.ColumnBankName.Caption = "Banka Adı";
            this.ColumnBankName.FieldName = "BankName";
            this.ColumnBankName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBankName.ImageOptions.Image")));
            this.ColumnBankName.MinWidth = 40;
            this.ColumnBankName.Name = "ColumnBankName";
            this.ColumnBankName.Visible = true;
            this.ColumnBankName.VisibleIndex = 1;
            this.ColumnBankName.Width = 200;
            // 
            // ColumnCountyName
            // 
            this.ColumnCountyName.Caption = "İL";
            this.ColumnCountyName.FieldName = "CountyName";
            this.ColumnCountyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCountyName.ImageOptions.Image")));
            this.ColumnCountyName.MinWidth = 18;
            this.ColumnCountyName.Name = "ColumnCountyName";
            this.ColumnCountyName.Visible = true;
            this.ColumnCountyName.VisibleIndex = 2;
            this.ColumnCountyName.Width = 80;
            // 
            // ColumnDistrinct
            // 
            this.ColumnDistrinct.Caption = "İLÇE";
            this.ColumnDistrinct.FieldName = "DistrictName";
            this.ColumnDistrinct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDistrinct.ImageOptions.Image")));
            this.ColumnDistrinct.Name = "ColumnDistrinct";
            this.ColumnDistrinct.Visible = true;
            this.ColumnDistrinct.VisibleIndex = 3;
            this.ColumnDistrinct.Width = 80;
            // 
            // ColumnBankBranch
            // 
            this.ColumnBankBranch.Caption = "Banka Şübesi";
            this.ColumnBankBranch.FieldName = "BankBranch";
            this.ColumnBankBranch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBankBranch.ImageOptions.Image")));
            this.ColumnBankBranch.MinWidth = 15;
            this.ColumnBankBranch.Name = "ColumnBankBranch";
            this.ColumnBankBranch.Visible = true;
            this.ColumnBankBranch.VisibleIndex = 4;
            this.ColumnBankBranch.Width = 150;
            // 
            // ColumnIBAN
            // 
            this.ColumnIBAN.Caption = "IBAN";
            this.ColumnIBAN.FieldName = "IBAN";
            this.ColumnIBAN.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnIBAN.ImageOptions.Image")));
            this.ColumnIBAN.Name = "ColumnIBAN";
            this.ColumnIBAN.Visible = true;
            this.ColumnIBAN.VisibleIndex = 5;
            this.ColumnIBAN.Width = 150;
            // 
            // ColumnBankAccountNumber
            // 
            this.ColumnBankAccountNumber.Caption = "Hesap No";
            this.ColumnBankAccountNumber.FieldName = "BankAccountNo";
            this.ColumnBankAccountNumber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBankAccountNumber.ImageOptions.Image")));
            this.ColumnBankAccountNumber.MinWidth = 40;
            this.ColumnBankAccountNumber.Name = "ColumnBankAccountNumber";
            this.ColumnBankAccountNumber.Visible = true;
            this.ColumnBankAccountNumber.VisibleIndex = 6;
            this.ColumnBankAccountNumber.Width = 150;
            // 
            // ColumnOfficial
            // 
            this.ColumnOfficial.Caption = "Banka Yetkili";
            this.ColumnOfficial.FieldName = "BankOfficial";
            this.ColumnOfficial.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnOfficial.ImageOptions.Image")));
            this.ColumnOfficial.Name = "ColumnOfficial";
            this.ColumnOfficial.Visible = true;
            this.ColumnOfficial.VisibleIndex = 7;
            this.ColumnOfficial.Width = 100;
            // 
            // ColumnBankPhone
            // 
            this.ColumnBankPhone.Caption = "Banka Telefonu";
            this.ColumnBankPhone.FieldName = "BankPhone";
            this.ColumnBankPhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBankPhone.ImageOptions.Image")));
            this.ColumnBankPhone.Name = "ColumnBankPhone";
            this.ColumnBankPhone.Visible = true;
            this.ColumnBankPhone.VisibleIndex = 8;
            this.ColumnBankPhone.Width = 100;
            // 
            // ColumnCreateDate
            // 
            this.ColumnCreateDate.Caption = "Oluşturma Tarihi";
            this.ColumnCreateDate.FieldName = "BankDate";
            this.ColumnCreateDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCreateDate.ImageOptions.Image")));
            this.ColumnCreateDate.Name = "ColumnCreateDate";
            this.ColumnCreateDate.Visible = true;
            this.ColumnCreateDate.VisibleIndex = 9;
            this.ColumnCreateDate.Width = 110;
            // 
            // ColumnAccountType
            // 
            this.ColumnAccountType.Caption = "Hesap Türü";
            this.ColumnAccountType.FieldName = "BankAccountType";
            this.ColumnAccountType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnAccountType.ImageOptions.Image")));
            this.ColumnAccountType.Name = "ColumnAccountType";
            this.ColumnAccountType.Visible = true;
            this.ColumnAccountType.VisibleIndex = 10;
            this.ColumnAccountType.Width = 110;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.Caption = "Firma Adı";
            this.ColumnCompanyName.FieldName = "CompanyName";
            this.ColumnCompanyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyName.ImageOptions.Image")));
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.Visible = true;
            this.ColumnCompanyName.VisibleIndex = 11;
            this.ColumnCompanyName.Width = 180;
            // 
            // BankExpandWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 498);
            this.Controls.Add(this.GControlBank);
            this.Name = "BankExpandWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANKA  BİLGİLERİ";
            this.Load += new System.EventHandler(this.BankExpandWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControlBank;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewBank;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBankID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBankName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCountyName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDistrinct;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBankBranch;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnIBAN;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBankAccountNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnOfficial;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBankPhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCreateDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnAccountType;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyName;
    }
}