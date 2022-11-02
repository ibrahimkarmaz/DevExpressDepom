namespace PresentationLayer.WinFormList.CompanyWF
{
    partial class CompanyWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyWF));
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
            this.xtraTabCompanyControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageCompany = new DevExpress.XtraTab.XtraTabPage();
            this.GControlCompany = new DevExpress.XtraGrid.GridControl();
            this.GViewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnSectorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyNameSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnOfficialStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlCompanyProcess = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlNewCompany = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCompanyUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCompanyDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCompanyArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCompanyList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCompanyFullList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCompanyArchiveQuit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCompanyArchiveList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlCompanyGetAllList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.TabPageCompanyArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompanyArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompanyArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCompanyControl)).BeginInit();
            this.xtraTabCompanyControl.SuspendLayout();
            this.TabPageCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPageCompanyArchive
            // 
            this.TabPageCompanyArchive.Controls.Add(this.GControlCompanyArchive);
            this.TabPageCompanyArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageCustomerArchive.ImageOptions.Image")));
            this.TabPageCompanyArchive.Name = "TabPageCompanyArchive";
            this.TabPageCompanyArchive.Size = new System.Drawing.Size(968, 430);
            this.TabPageCompanyArchive.Text = "ÜRÜNLER ARŞİV LİSTESİ";
            // 
            // GControlCompanyArchive
            // 
            this.GControlCompanyArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlCompanyArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlCompanyArchive.MainView = this.GViewCompanyArchive;
            this.GControlCompanyArchive.Name = "GControlCompanyArchive";
            this.GControlCompanyArchive.Size = new System.Drawing.Size(968, 430);
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
            // xtraTabCompanyControl
            // 
            this.xtraTabCompanyControl.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Teal;
            this.xtraTabCompanyControl.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabCompanyControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabCompanyControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabCompanyControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabCompanyControl.Location = new System.Drawing.Point(250, 0);
            this.xtraTabCompanyControl.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabCompanyControl.Name = "xtraTabCompanyControl";
            this.xtraTabCompanyControl.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabCompanyControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabCompanyControl.SelectedTabPage = this.TabPageCompany;
            this.xtraTabCompanyControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabCompanyControl.Size = new System.Drawing.Size(970, 482);
            this.xtraTabCompanyControl.TabIndex = 9;
            this.xtraTabCompanyControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageCompany,
            this.TabPageCompanyArchive});
            this.xtraTabCompanyControl.Click += new System.EventHandler(this.xtraTabCompanyControl_Click);
            // 
            // TabPageCompany
            // 
            this.TabPageCompany.Controls.Add(this.GControlCompany);
            this.TabPageCompany.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageCustomer.ImageOptions.Image")));
            this.TabPageCompany.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageCompany.Name = "TabPageCompany";
            this.TabPageCompany.Size = new System.Drawing.Size(968, 430);
            this.TabPageCompany.Text = "ÜRÜNLER LİSTESİ";
            // 
            // GControlCompany
            // 
            this.GControlCompany.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlCompany.Location = new System.Drawing.Point(0, 0);
            this.GControlCompany.MainView = this.GViewCompany;
            this.GControlCompany.Name = "GControlCompany";
            this.GControlCompany.Size = new System.Drawing.Size(968, 430);
            this.GControlCompany.TabIndex = 0;
            this.GControlCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCompany});
            // 
            // GViewCompany
            // 
            this.GViewCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnCompanyID,
            this.ColumnCompanyName,
            this.ColumnSectorName,
            this.ColumnCompanyNameSurname,
            this.ColumnOfficialStatus,
            this.ColumnPhone1,
            this.ColumnCompanyMail});
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
            this.ColumnCompanyID.MinWidth = 18;
            this.ColumnCompanyID.Name = "ColumnCompanyID";
            this.ColumnCompanyID.Visible = true;
            this.ColumnCompanyID.VisibleIndex = 0;
            this.ColumnCompanyID.Width = 86;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.Caption = "Firma Adı";
            this.ColumnCompanyName.FieldName = "CompanyName";
            this.ColumnCompanyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyName.ImageOptions.Image")));
            this.ColumnCompanyName.MinWidth = 40;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.Visible = true;
            this.ColumnCompanyName.VisibleIndex = 1;
            this.ColumnCompanyName.Width = 172;
            // 
            // ColumnSectorName
            // 
            this.ColumnSectorName.Caption = "Sektör Adı";
            this.ColumnSectorName.FieldName = "SectorName";
            this.ColumnSectorName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSectorName.ImageOptions.Image")));
            this.ColumnSectorName.MinWidth = 18;
            this.ColumnSectorName.Name = "ColumnSectorName";
            this.ColumnSectorName.Visible = true;
            this.ColumnSectorName.VisibleIndex = 2;
            this.ColumnSectorName.Width = 105;
            // 
            // ColumnCompanyNameSurname
            // 
            this.ColumnCompanyNameSurname.Caption = "Yetkili";
            this.ColumnCompanyNameSurname.FieldName = "CompanyOfficialNameSurName";
            this.ColumnCompanyNameSurname.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyNameSurname.ImageOptions.Image")));
            this.ColumnCompanyNameSurname.Name = "ColumnCompanyNameSurname";
            this.ColumnCompanyNameSurname.Visible = true;
            this.ColumnCompanyNameSurname.VisibleIndex = 3;
            this.ColumnCompanyNameSurname.Width = 125;
            // 
            // ColumnOfficialStatus
            // 
            this.ColumnOfficialStatus.Caption = "Yetkili Statüsü";
            this.ColumnOfficialStatus.FieldName = "CompanyOfficialStatus";
            this.ColumnOfficialStatus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnOfficialStatus.ImageOptions.Image")));
            this.ColumnOfficialStatus.MinWidth = 15;
            this.ColumnOfficialStatus.Name = "ColumnOfficialStatus";
            this.ColumnOfficialStatus.Visible = true;
            this.ColumnOfficialStatus.VisibleIndex = 4;
            this.ColumnOfficialStatus.Width = 121;
            // 
            // ColumnPhone1
            // 
            this.ColumnPhone1.Caption = "Telefon";
            this.ColumnPhone1.FieldName = "CompanyPhone1";
            this.ColumnPhone1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPhone1.ImageOptions.Image")));
            this.ColumnPhone1.Name = "ColumnPhone1";
            this.ColumnPhone1.Visible = true;
            this.ColumnPhone1.VisibleIndex = 5;
            this.ColumnPhone1.Width = 119;
            // 
            // ColumnCompanyMail
            // 
            this.ColumnCompanyMail.Caption = "E-Posta Adresi";
            this.ColumnCompanyMail.FieldName = "CompanyMail";
            this.ColumnCompanyMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyMail.ImageOptions.Image")));
            this.ColumnCompanyMail.MinWidth = 40;
            this.ColumnCompanyMail.Name = "ColumnCompanyMail";
            this.ColumnCompanyMail.Visible = true;
            this.ColumnCompanyMail.VisibleIndex = 6;
            this.ColumnCompanyMail.Width = 210;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlCompanyProcess,
            this.accordionControlArchive});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(250, 482);
            this.accordionControl1.TabIndex = 8;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlCompanyProcess
            // 
            this.accordionControlCompanyProcess.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlNewCompany,
            this.accordionControlCompanyUpdate,
            this.accordionControlCompanyDelete,
            this.accordionControlCompanyArchive,
            this.accordionControlCompanyList,
            this.accordionControlCompanyFullList});
            this.accordionControlCompanyProcess.Expanded = true;
            this.accordionControlCompanyProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyProcess.ImageOptions.Image")));
            this.accordionControlCompanyProcess.Name = "accordionControlCompanyProcess";
            this.accordionControlCompanyProcess.Text = "FİRMA İŞLEMLERİ";
            this.accordionControlCompanyProcess.Click += new System.EventHandler(this.accordionControlCompanyProcess_Click);
            // 
            // accordionControlNewCompany
            // 
            this.accordionControlNewCompany.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlNewCompany.ImageOptions.Image")));
            this.accordionControlNewCompany.Name = "accordionControlNewCompany";
            this.accordionControlNewCompany.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlNewCompany.Text = "YENİ FİRMA";
            this.accordionControlNewCompany.Click += new System.EventHandler(this.accordionControlNewCompany_Click);
            // 
            // accordionControlCompanyUpdate
            // 
            this.accordionControlCompanyUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyUpdate.ImageOptions.Image")));
            this.accordionControlCompanyUpdate.Name = "accordionControlCompanyUpdate";
            this.accordionControlCompanyUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCompanyUpdate.Text = "FİRMA BİLGİLERİNİ DÜZENLE";
            this.accordionControlCompanyUpdate.Click += new System.EventHandler(this.accordionControlCompanyUpdate_Click);
            // 
            // accordionControlCompanyDelete
            // 
            this.accordionControlCompanyDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyDelete.ImageOptions.Image")));
            this.accordionControlCompanyDelete.Name = "accordionControlCompanyDelete";
            this.accordionControlCompanyDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCompanyDelete.Text = "FİRMA BİLGİLERİNİ SİL";
            this.accordionControlCompanyDelete.Click += new System.EventHandler(this.accordionControlCompanyDelete_Click);
            // 
            // accordionControlCompanyArchive
            // 
            this.accordionControlCompanyArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyArchive.ImageOptions.Image")));
            this.accordionControlCompanyArchive.Name = "accordionControlCompanyArchive";
            this.accordionControlCompanyArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCompanyArchive.Text = "FİRMA BİLGİLERİNİ ARŞİVLE";
            this.accordionControlCompanyArchive.Click += new System.EventHandler(this.accordionControlCompanyArchive_Click);
            // 
            // accordionControlCompanyList
            // 
            this.accordionControlCompanyList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyList.ImageOptions.Image")));
            this.accordionControlCompanyList.Name = "accordionControlCompanyList";
            this.accordionControlCompanyList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCompanyList.Text = "FİRMA LİSTESİ";
            this.accordionControlCompanyList.Click += new System.EventHandler(this.accordionControlCompanyList_Click);
            // 
            // accordionControlCompanyFullList
            // 
            this.accordionControlCompanyFullList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyFullList.ImageOptions.Image")));
            this.accordionControlCompanyFullList.Name = "accordionControlCompanyFullList";
            this.accordionControlCompanyFullList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCompanyFullList.Text = "LİSTEYİ GENİŞLET";
            this.accordionControlCompanyFullList.Click += new System.EventHandler(this.accordionControlCompanyFullList_Click);
            // 
            // accordionControlArchive
            // 
            this.accordionControlArchive.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlCompanyArchiveQuit,
            this.accordionControlCompanyArchiveList,
            this.accordionControlCompanyGetAllList});
            this.accordionControlArchive.Expanded = true;
            this.accordionControlArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchive.ImageOptions.Image")));
            this.accordionControlArchive.Name = "accordionControlArchive";
            this.accordionControlArchive.Text = "FİRMA ARŞİV İŞLEMLERİ";
            this.accordionControlArchive.Click += new System.EventHandler(this.accordionControlArchive_Click);
            // 
            // accordionControlCompanyArchiveQuit
            // 
            this.accordionControlCompanyArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyArchiveQuit.ImageOptions.Image")));
            this.accordionControlCompanyArchiveQuit.Name = "accordionControlCompanyArchiveQuit";
            this.accordionControlCompanyArchiveQuit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCompanyArchiveQuit.Text = "FİRMA ARŞİVDEN ÇIKAR";
            this.accordionControlCompanyArchiveQuit.Click += new System.EventHandler(this.accordionControlCompanyArchiveQuit_Click);
            // 
            // accordionControlCompanyArchiveList
            // 
            this.accordionControlCompanyArchiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyArchiveList.ImageOptions.Image")));
            this.accordionControlCompanyArchiveList.Name = "accordionControlCompanyArchiveList";
            this.accordionControlCompanyArchiveList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCompanyArchiveList.Text = "FİRMA ARŞİV LİSTESİ";
            this.accordionControlCompanyArchiveList.Click += new System.EventHandler(this.accordionControlCompanyArchiveList_Click);
            // 
            // accordionControlCompanyGetAllList
            // 
            this.accordionControlCompanyGetAllList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyGetAllList.ImageOptions.Image")));
            this.accordionControlCompanyGetAllList.Name = "accordionControlCompanyGetAllList";
            this.accordionControlCompanyGetAllList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlCompanyGetAllList.Text = "ARŞİV LİSTESİNİ GENİŞLET";
            this.accordionControlCompanyGetAllList.Click += new System.EventHandler(this.accordionControlCompanyGetAllList_Click);
            // 
            // CompanyWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 482);
            this.Controls.Add(this.xtraTabCompanyControl);
            this.Controls.Add(this.accordionControl1);
            this.Name = "CompanyWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİRMA İŞLEMLERİ";
            this.Load += new System.EventHandler(this.CompanyWF_Load);
            this.TabPageCompanyArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompanyArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompanyArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCompanyControl)).EndInit();
            this.xtraTabCompanyControl.ResumeLayout(false);
            this.TabPageCompany.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage TabPageCompanyArchive;
        private DevExpress.XtraTab.XtraTabControl xtraTabCompanyControl;
        private DevExpress.XtraTab.XtraTabPage TabPageCompany;
        private DevExpress.XtraGrid.GridControl GControlCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCompany;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyID;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyProcess;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlNewCompany;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyArchiveQuit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyArchiveList;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSectorName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyNameSurname;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnOfficialStatus;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyMail;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyFullList;
        private DevExpress.XtraGrid.GridControl GControlCompanyArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCompanyArchive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlCompanyGetAllList;
    }
}