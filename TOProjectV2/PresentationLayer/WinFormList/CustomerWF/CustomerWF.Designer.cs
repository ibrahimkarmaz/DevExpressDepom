namespace PresentationLayer.WinFormList.CustomerWF
{
    partial class CustomerWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerWF));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlCustomerProcess = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlNewCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCustomerUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCustomerDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCustomerArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCustomerList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCustomerArchiveQuit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCustomerArchiveList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.xtraTabCustomerControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageCustomer = new DevExpress.XtraTab.XtraTabPage();
            this.GControlCustomer = new DevExpress.XtraGrid.GridControl();
            this.GViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerSurName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnMobilePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnOfficePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCustomerMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCounty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnHomeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnTaxNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabPageCustomerArchive = new DevExpress.XtraTab.XtraTabPage();
            this.GControlCustomerArchive = new DevExpress.XtraGrid.GridControl();
            this.GViewCustomerArchive = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCustomerControl)).BeginInit();
            this.xtraTabCustomerControl.SuspendLayout();
            this.TabPageCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCustomer)).BeginInit();
            this.TabPageCustomerArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlCustomerArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCustomerArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlCustomerProcess,
            this.accordionControlArchive});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(260, 486);
            this.accordionControl1.TabIndex = 5;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlCustomerProcess
            // 
            this.accordionControlCustomerProcess.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlNewCustomer,
            this.accordionControlCustomerUpdate,
            this.accordionControlCustomerDelete,
            this.accordionControlCustomerArchive,
            this.accordionControlCustomerList});
            this.accordionControlCustomerProcess.Expanded = true;
            this.accordionControlCustomerProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCustomerProcess.ImageOptions.Image")));
            this.accordionControlCustomerProcess.Name = "accordionControlCustomerProcess";
            this.accordionControlCustomerProcess.Text = "MÜŞTERİ İŞLEMLERİ";
            this.accordionControlCustomerProcess.Click += new System.EventHandler(this.accordionControlCustomerProcess_Click);
            // 
            // accordionControlNewCustomer
            // 
            this.accordionControlNewCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlNewCustomer.ImageOptions.Image")));
            this.accordionControlNewCustomer.Name = "accordionControlNewCustomer";
            this.accordionControlNewCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlNewCustomer.Text = "YENİ MÜŞTERİ";
            this.accordionControlNewCustomer.Click += new System.EventHandler(this.accordionControlNewCustomer_Click);
            // 
            // accordionControlCustomerUpdate
            // 
            this.accordionControlCustomerUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCustomerUpdate.ImageOptions.Image")));
            this.accordionControlCustomerUpdate.Name = "accordionControlCustomerUpdate";
            this.accordionControlCustomerUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCustomerUpdate.Text = "MÜŞTERİ BİLGİLERİNİ DÜZENLE";
            this.accordionControlCustomerUpdate.Click += new System.EventHandler(this.accordionControlCustomerUpdate_Click);
            // 
            // accordionControlCustomerDelete
            // 
            this.accordionControlCustomerDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCustomerDelete.ImageOptions.Image")));
            this.accordionControlCustomerDelete.Name = "accordionControlCustomerDelete";
            this.accordionControlCustomerDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCustomerDelete.Text = "MÜŞTERİ BİLGİLERİNİ SİL";
            this.accordionControlCustomerDelete.Click += new System.EventHandler(this.accordionControlCustomerDelete_Click);
            // 
            // accordionControlCustomerArchive
            // 
            this.accordionControlCustomerArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCustomerArchive.ImageOptions.Image")));
            this.accordionControlCustomerArchive.Name = "accordionControlCustomerArchive";
            this.accordionControlCustomerArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCustomerArchive.Text = "ÜRÜN BİLGİLERİNİ ARŞİVLE";
            this.accordionControlCustomerArchive.Click += new System.EventHandler(this.accordionControlCustomerArchive_Click);
            // 
            // accordionControlCustomerList
            // 
            this.accordionControlCustomerList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCustomerList.ImageOptions.Image")));
            this.accordionControlCustomerList.Name = "accordionControlCustomerList";
            this.accordionControlCustomerList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCustomerList.Text = "MÜŞTERİ LİSTESİ";
            this.accordionControlCustomerList.Click += new System.EventHandler(this.accordionControlCustomerList_Click);
            // 
            // accordionControlArchive
            // 
            this.accordionControlArchive.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlCustomerArchiveQuit,
            this.accordionControlCustomerArchiveList});
            this.accordionControlArchive.Expanded = true;
            this.accordionControlArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchive.ImageOptions.Image")));
            this.accordionControlArchive.Name = "accordionControlArchive";
            this.accordionControlArchive.Text = "MÜŞTERİ ARŞİV İŞLEMLERİ";
            this.accordionControlArchive.Click += new System.EventHandler(this.accordionControlArchive_Click);
            // 
            // accordionControlCustomerArchiveQuit
            // 
            this.accordionControlCustomerArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCustomerArchiveQuit.ImageOptions.Image")));
            this.accordionControlCustomerArchiveQuit.Name = "accordionControlCustomerArchiveQuit";
            this.accordionControlCustomerArchiveQuit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCustomerArchiveQuit.Text = "MÜŞTERİYİ ARŞİVDEN ÇIKAR";
            this.accordionControlCustomerArchiveQuit.Click += new System.EventHandler(this.accordionControlCustomerArchiveQuit_Click);
            // 
            // accordionControlCustomerArchiveList
            // 
            this.accordionControlCustomerArchiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCustomerArchiveList.ImageOptions.Image")));
            this.accordionControlCustomerArchiveList.Name = "accordionControlCustomerArchiveList";
            this.accordionControlCustomerArchiveList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCustomerArchiveList.Text = "MÜŞTERİ ARŞİV LİSTESİ";
            this.accordionControlCustomerArchiveList.Click += new System.EventHandler(this.accordionControlCustomerArchiveList_Click);
            // 
            // xtraTabCustomerControl
            // 
            this.xtraTabCustomerControl.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Teal;
            this.xtraTabCustomerControl.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabCustomerControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabCustomerControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabCustomerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabCustomerControl.Location = new System.Drawing.Point(260, 0);
            this.xtraTabCustomerControl.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabCustomerControl.Name = "xtraTabCustomerControl";
            this.xtraTabCustomerControl.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabCustomerControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabCustomerControl.SelectedTabPage = this.TabPageCustomer;
            this.xtraTabCustomerControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabCustomerControl.Size = new System.Drawing.Size(908, 486);
            this.xtraTabCustomerControl.TabIndex = 7;
            this.xtraTabCustomerControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageCustomer,
            this.TabPageCustomerArchive});
            this.xtraTabCustomerControl.Click += new System.EventHandler(this.xtraTabCustomerControl_Click);
            // 
            // TabPageCustomer
            // 
            this.TabPageCustomer.Controls.Add(this.GControlCustomer);
            this.TabPageCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageCustomer.ImageOptions.Image")));
            this.TabPageCustomer.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageCustomer.Name = "TabPageCustomer";
            this.TabPageCustomer.Size = new System.Drawing.Size(906, 442);
            this.TabPageCustomer.Text = "ÜRÜNLER LİSTESİ";
            // 
            // GControlCustomer
            // 
            this.GControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlCustomer.Location = new System.Drawing.Point(0, 0);
            this.GControlCustomer.MainView = this.GViewCustomer;
            this.GControlCustomer.Name = "GControlCustomer";
            this.GControlCustomer.Size = new System.Drawing.Size(906, 442);
            this.GControlCustomer.TabIndex = 0;
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
            this.ColumnCustomerDateOfBirth,
            this.ColumnMobilePhone,
            this.ColumnOfficePhone,
            this.ColumnCustomerMail,
            this.ColumnCounty,
            this.ColumnDistrict,
            this.ColumnHomeAddress,
            this.ColumnTaxNumber});
            this.GViewCustomer.DetailHeight = 303;
            this.GViewCustomer.GridControl = this.GControlCustomer;
            this.GViewCustomer.Name = "GViewCustomer";
            this.GViewCustomer.OptionsBehavior.Editable = false;
            this.GViewCustomer.OptionsBehavior.ReadOnly = true;
            this.GViewCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnCustomerID
            // 
            this.ColumnCustomerID.Caption = "ID";
            this.ColumnCustomerID.FieldName = "CustomerID";
            this.ColumnCustomerID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerID.ImageOptions.Image")));
            this.ColumnCustomerID.Name = "ColumnCustomerID";
            this.ColumnCustomerID.Visible = true;
            this.ColumnCustomerID.VisibleIndex = 0;
            this.ColumnCustomerID.Width = 46;
            // 
            // ColumnCustomerTC
            // 
            this.ColumnCustomerTC.Caption = "T.C KİMLİK NO";
            this.ColumnCustomerTC.FieldName = "CustomerTC";
            this.ColumnCustomerTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerTC.ImageOptions.Image")));
            this.ColumnCustomerTC.Name = "ColumnCustomerTC";
            this.ColumnCustomerTC.Visible = true;
            this.ColumnCustomerTC.VisibleIndex = 1;
            this.ColumnCustomerTC.Width = 66;
            // 
            // ColumnCustomerName
            // 
            this.ColumnCustomerName.Caption = "Adı";
            this.ColumnCustomerName.FieldName = "CustomerName";
            this.ColumnCustomerName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerName.ImageOptions.Image")));
            this.ColumnCustomerName.Name = "ColumnCustomerName";
            this.ColumnCustomerName.Visible = true;
            this.ColumnCustomerName.VisibleIndex = 2;
            this.ColumnCustomerName.Width = 66;
            // 
            // ColumnCustomerSurName
            // 
            this.ColumnCustomerSurName.Caption = "Soyadı";
            this.ColumnCustomerSurName.FieldName = "CustomerSurName";
            this.ColumnCustomerSurName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerSurName.ImageOptions.Image")));
            this.ColumnCustomerSurName.Name = "ColumnCustomerSurName";
            this.ColumnCustomerSurName.Visible = true;
            this.ColumnCustomerSurName.VisibleIndex = 3;
            this.ColumnCustomerSurName.Width = 65;
            // 
            // ColumnCustomerGender
            // 
            this.ColumnCustomerGender.Caption = "Cinsiyet";
            this.ColumnCustomerGender.FieldName = "CustomerGender";
            this.ColumnCustomerGender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerGender.ImageOptions.Image")));
            this.ColumnCustomerGender.Name = "ColumnCustomerGender";
            this.ColumnCustomerGender.Visible = true;
            this.ColumnCustomerGender.VisibleIndex = 4;
            this.ColumnCustomerGender.Width = 63;
            // 
            // ColumnCustomerDateOfBirth
            // 
            this.ColumnCustomerDateOfBirth.Caption = "Doğum Tarihi";
            this.ColumnCustomerDateOfBirth.FieldName = "CustomerDateOfBirth";
            this.ColumnCustomerDateOfBirth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerDateOfBirth.ImageOptions.Image")));
            this.ColumnCustomerDateOfBirth.Name = "ColumnCustomerDateOfBirth";
            this.ColumnCustomerDateOfBirth.Visible = true;
            this.ColumnCustomerDateOfBirth.VisibleIndex = 5;
            this.ColumnCustomerDateOfBirth.Width = 63;
            // 
            // ColumnMobilePhone
            // 
            this.ColumnMobilePhone.Caption = "Cep Telefonu";
            this.ColumnMobilePhone.FieldName = "CustomerMobilePhone";
            this.ColumnMobilePhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnMobilePhone.ImageOptions.Image")));
            this.ColumnMobilePhone.Name = "ColumnMobilePhone";
            this.ColumnMobilePhone.Visible = true;
            this.ColumnMobilePhone.VisibleIndex = 6;
            this.ColumnMobilePhone.Width = 63;
            // 
            // ColumnOfficePhone
            // 
            this.ColumnOfficePhone.Caption = "İş Telefonu";
            this.ColumnOfficePhone.FieldName = "CustomerOfficePhone";
            this.ColumnOfficePhone.Name = "ColumnOfficePhone";
            this.ColumnOfficePhone.Visible = true;
            this.ColumnOfficePhone.VisibleIndex = 7;
            this.ColumnOfficePhone.Width = 63;
            // 
            // ColumnCustomerMail
            // 
            this.ColumnCustomerMail.Caption = "E-Posta Adresi";
            this.ColumnCustomerMail.FieldName = "CustomerMail";
            this.ColumnCustomerMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerMail.ImageOptions.Image")));
            this.ColumnCustomerMail.Name = "ColumnCustomerMail";
            this.ColumnCustomerMail.Visible = true;
            this.ColumnCustomerMail.VisibleIndex = 8;
            this.ColumnCustomerMail.Width = 63;
            // 
            // ColumnCounty
            // 
            this.ColumnCounty.Caption = "İl";
            this.ColumnCounty.FieldName = "CountyName";
            this.ColumnCounty.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCounty.ImageOptions.Image")));
            this.ColumnCounty.Name = "ColumnCounty";
            this.ColumnCounty.Visible = true;
            this.ColumnCounty.VisibleIndex = 9;
            this.ColumnCounty.Width = 63;
            // 
            // ColumnDistrict
            // 
            this.ColumnDistrict.Caption = "İlçe";
            this.ColumnDistrict.FieldName = "DistrictName";
            this.ColumnDistrict.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDistrict.ImageOptions.Image")));
            this.ColumnDistrict.Name = "ColumnDistrict";
            this.ColumnDistrict.Visible = true;
            this.ColumnDistrict.VisibleIndex = 10;
            this.ColumnDistrict.Width = 63;
            // 
            // ColumnHomeAddress
            // 
            this.ColumnHomeAddress.Caption = "Ev Adresi";
            this.ColumnHomeAddress.FieldName = "CustomerHomeAddress";
            this.ColumnHomeAddress.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnHomeAddress.ImageOptions.Image")));
            this.ColumnHomeAddress.Name = "ColumnHomeAddress";
            this.ColumnHomeAddress.Visible = true;
            this.ColumnHomeAddress.VisibleIndex = 11;
            this.ColumnHomeAddress.Width = 63;
            // 
            // ColumnTaxNumber
            // 
            this.ColumnTaxNumber.Caption = "Vergi Numarası";
            this.ColumnTaxNumber.FieldName = "CustomerTaxNumber";
            this.ColumnTaxNumber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnTaxNumber.ImageOptions.Image")));
            this.ColumnTaxNumber.Name = "ColumnTaxNumber";
            this.ColumnTaxNumber.Visible = true;
            this.ColumnTaxNumber.VisibleIndex = 12;
            this.ColumnTaxNumber.Width = 129;
            // 
            // TabPageCustomerArchive
            // 
            this.TabPageCustomerArchive.Controls.Add(this.GControlCustomerArchive);
            this.TabPageCustomerArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageCustomerArchive.ImageOptions.Image")));
            this.TabPageCustomerArchive.Name = "TabPageCustomerArchive";
            this.TabPageCustomerArchive.Size = new System.Drawing.Size(906, 442);
            this.TabPageCustomerArchive.Text = "ÜRÜNLER ARŞİV LİSTESİ";
            // 
            // GControlCustomerArchive
            // 
            this.GControlCustomerArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlCustomerArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlCustomerArchive.MainView = this.GViewCustomerArchive;
            this.GControlCustomerArchive.Name = "GControlCustomerArchive";
            this.GControlCustomerArchive.Size = new System.Drawing.Size(906, 442);
            this.GControlCustomerArchive.TabIndex = 1;
            this.GControlCustomerArchive.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCustomerArchive});
            // 
            // GViewCustomerArchive
            // 
            this.GViewCustomerArchive.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12,
            this.gridColumn13});
            this.GViewCustomerArchive.DetailHeight = 303;
            this.GViewCustomerArchive.GridControl = this.GControlCustomerArchive;
            this.GViewCustomerArchive.Name = "GViewCustomerArchive";
            this.GViewCustomerArchive.OptionsBehavior.Editable = false;
            this.GViewCustomerArchive.OptionsBehavior.ReadOnly = true;
            this.GViewCustomerArchive.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "CustomerID";
            this.gridColumn1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.ImageOptions.Image")));
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 46;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "T.C KİMLİK NO";
            this.gridColumn2.FieldName = "CustomerTC";
            this.gridColumn2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.ImageOptions.Image")));
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 66;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Adı";
            this.gridColumn3.FieldName = "CustomerName";
            this.gridColumn3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.ImageOptions.Image")));
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 66;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Soyadı";
            this.gridColumn4.FieldName = "CustomerSurName";
            this.gridColumn4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn4.ImageOptions.Image")));
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 65;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cinsiyet";
            this.gridColumn5.FieldName = "CustomerGender";
            this.gridColumn5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn5.ImageOptions.Image")));
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 63;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Doğum Tarihi";
            this.gridColumn6.FieldName = "CustomerDateOfBirth";
            this.gridColumn6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn6.ImageOptions.Image")));
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 63;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Cep Telefonu";
            this.gridColumn7.FieldName = "CustomerMobilePhone";
            this.gridColumn7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn7.ImageOptions.Image")));
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 63;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "İş Telefonu";
            this.gridColumn8.FieldName = "CustomerOfficePhone";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 63;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "E-Posta Adresi";
            this.gridColumn9.FieldName = "CustomerMail";
            this.gridColumn9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn9.ImageOptions.Image")));
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 63;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "İl";
            this.gridColumn10.FieldName = "CountyName";
            this.gridColumn10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn10.ImageOptions.Image")));
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 9;
            this.gridColumn10.Width = 63;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "İlçe";
            this.gridColumn11.FieldName = "DistrictName";
            this.gridColumn11.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn11.ImageOptions.Image")));
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 10;
            this.gridColumn11.Width = 63;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Ev Adresi";
            this.gridColumn12.FieldName = "CustomerHomeAddress";
            this.gridColumn12.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn12.ImageOptions.Image")));
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 11;
            this.gridColumn12.Width = 63;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Vergi Numarası";
            this.gridColumn13.FieldName = "CustomerTaxNumber";
            this.gridColumn13.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn13.ImageOptions.Image")));
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 12;
            this.gridColumn13.Width = 129;
            // 
            // CustomerWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 486);
            this.Controls.Add(this.xtraTabCustomerControl);
            this.Controls.Add(this.accordionControl1);
            this.Name = "CustomerWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ PENCERESİ";
            this.Load += new System.EventHandler(this.CustomerWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCustomerControl)).EndInit();
            this.xtraTabCustomerControl.ResumeLayout(false);
            this.TabPageCustomer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCustomer)).EndInit();
            this.TabPageCustomerArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlCustomerArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCustomerArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomerProcess;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlNewCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomerUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomerDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomerArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomerList;
        private DevExpress.XtraTab.XtraTabControl xtraTabCustomerControl;
        private DevExpress.XtraTab.XtraTabPage TabPageCustomer;
        private DevExpress.XtraGrid.GridControl GControlCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCustomer;
        private DevExpress.XtraTab.XtraTabPage TabPageCustomerArchive;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerTC;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerSurName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerGender;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnMobilePhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnOfficePhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnHomeAddress;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnTaxNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCounty;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDistrict;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchive;
        private DevExpress.XtraGrid.GridControl GControlCustomerArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCustomerArchive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomerArchiveQuit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCustomerArchiveList;
    }
}