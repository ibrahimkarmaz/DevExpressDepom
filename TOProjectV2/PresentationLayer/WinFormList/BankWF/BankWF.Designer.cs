namespace PresentationLayer.WinFormList.BankWF
{
    partial class BankWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankWF));
            this.xtraTabBankControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageBank = new DevExpress.XtraTab.XtraTabPage();
            this.GControlBank = new DevExpress.XtraGrid.GridControl();
            this.GViewBank = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnBankID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBankName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCountyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDistrinct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBankBranch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabPageBankArchive = new DevExpress.XtraTab.XtraTabPage();
            this.accordionControlBankArchiveList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBankArchiveQuit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBankGetAllList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBankFullList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBankList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBankArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBankDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBankUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlNewBank = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBankProcess = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.GControlBankArchive = new DevExpress.XtraGrid.GridControl();
            this.GViewBankArchive = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabBankControl)).BeginInit();
            this.xtraTabBankControl.SuspendLayout();
            this.TabPageBank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBank)).BeginInit();
            this.TabPageBankArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBankArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBankArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabBankControl
            // 
            this.xtraTabBankControl.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Teal;
            this.xtraTabBankControl.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabBankControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabBankControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabBankControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabBankControl.Location = new System.Drawing.Point(250, 0);
            this.xtraTabBankControl.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabBankControl.Name = "xtraTabBankControl";
            this.xtraTabBankControl.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabBankControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabBankControl.SelectedTabPage = this.TabPageBank;
            this.xtraTabBankControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabBankControl.Size = new System.Drawing.Size(985, 491);
            this.xtraTabBankControl.TabIndex = 11;
            this.xtraTabBankControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageBank,
            this.TabPageBankArchive});
            this.xtraTabBankControl.Click += new System.EventHandler(this.xtraTabCompanyControl_Click);
            // 
            // TabPageBank
            // 
            this.TabPageBank.Controls.Add(this.GControlBank);
            this.TabPageBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageBank.ImageOptions.Image")));
            this.TabPageBank.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageBank.Name = "TabPageBank";
            this.TabPageBank.Size = new System.Drawing.Size(983, 447);
            this.TabPageBank.Text = "ÜRÜNLER LİSTESİ";
            // 
            // GControlBank
            // 
            this.GControlBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlBank.Location = new System.Drawing.Point(0, 0);
            this.GControlBank.MainView = this.GViewBank;
            this.GControlBank.Name = "GControlBank";
            this.GControlBank.Size = new System.Drawing.Size(983, 447);
            this.GControlBank.TabIndex = 2;
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
            this.ColumnCompanyName});
            this.GViewBank.DetailHeight = 303;
            this.GViewBank.GridControl = this.GControlBank;
            this.GViewBank.Name = "GViewBank";
            this.GViewBank.OptionsBehavior.Editable = false;
            this.GViewBank.OptionsBehavior.ReadOnly = true;
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
            this.ColumnBankName.VisibleIndex = 2;
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
            this.ColumnCountyName.VisibleIndex = 3;
            this.ColumnCountyName.Width = 80;
            // 
            // ColumnDistrinct
            // 
            this.ColumnDistrinct.Caption = "İLÇE";
            this.ColumnDistrinct.FieldName = "DistrictName";
            this.ColumnDistrinct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDistrinct.ImageOptions.Image")));
            this.ColumnDistrinct.Name = "ColumnDistrinct";
            this.ColumnDistrinct.Visible = true;
            this.ColumnDistrinct.VisibleIndex = 4;
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
            this.ColumnBankBranch.VisibleIndex = 5;
            this.ColumnBankBranch.Width = 150;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.Caption = "Firma Adı";
            this.ColumnCompanyName.FieldName = "CompanyName";
            this.ColumnCompanyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyName.ImageOptions.Image")));
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.Visible = true;
            this.ColumnCompanyName.VisibleIndex = 1;
            this.ColumnCompanyName.Width = 180;
            // 
            // TabPageBankArchive
            // 
            this.TabPageBankArchive.Controls.Add(this.GControlBankArchive);
            this.TabPageBankArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageBankArchive.ImageOptions.Image")));
            this.TabPageBankArchive.Name = "TabPageBankArchive";
            this.TabPageBankArchive.Size = new System.Drawing.Size(983, 447);
            this.TabPageBankArchive.Text = "ÜRÜNLER ARŞİV LİSTESİ";
            // 
            // accordionControlBankArchiveList
            // 
            this.accordionControlBankArchiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankArchiveList.ImageOptions.Image")));
            this.accordionControlBankArchiveList.Name = "accordionControlBankArchiveList";
            this.accordionControlBankArchiveList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBankArchiveList.Text = "BANKA ARŞİV LİSTESİ";
            this.accordionControlBankArchiveList.Click += new System.EventHandler(this.accordionControlBankArchiveList_Click);
            // 
            // accordionControlBankArchiveQuit
            // 
            this.accordionControlBankArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankArchiveQuit.ImageOptions.Image")));
            this.accordionControlBankArchiveQuit.Name = "accordionControlBankArchiveQuit";
            this.accordionControlBankArchiveQuit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBankArchiveQuit.Text = "BANKA ARŞİVDEN ÇIKAR";
            this.accordionControlBankArchiveQuit.Click += new System.EventHandler(this.accordionControlBankArchiveQuit_Click);
            // 
            // accordionControlArchive
            // 
            this.accordionControlArchive.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlBankArchiveQuit,
            this.accordionControlBankArchiveList,
            this.accordionControlBankGetAllList});
            this.accordionControlArchive.Expanded = true;
            this.accordionControlArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchive.ImageOptions.Image")));
            this.accordionControlArchive.Name = "accordionControlArchive";
            this.accordionControlArchive.Text = "FİRMA ARŞİV İŞLEMLERİ";
            this.accordionControlArchive.Click += new System.EventHandler(this.accordionControlArchive_Click);
            // 
            // accordionControlBankGetAllList
            // 
            this.accordionControlBankGetAllList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankGetAllList.ImageOptions.Image")));
            this.accordionControlBankGetAllList.Name = "accordionControlBankGetAllList";
            this.accordionControlBankGetAllList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBankGetAllList.Text = "ARŞİV LİSTESİNİ GENİŞLET";
            this.accordionControlBankGetAllList.Click += new System.EventHandler(this.accordionControlBankGetAllList_Click);
            // 
            // accordionControlBankFullList
            // 
            this.accordionControlBankFullList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankFullList.ImageOptions.Image")));
            this.accordionControlBankFullList.Name = "accordionControlBankFullList";
            this.accordionControlBankFullList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBankFullList.Text = "LİSTEYİ GENİŞLET";
            this.accordionControlBankFullList.Click += new System.EventHandler(this.accordionControlBankFullList_Click);
            // 
            // accordionControlBankList
            // 
            this.accordionControlBankList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankList.ImageOptions.Image")));
            this.accordionControlBankList.Name = "accordionControlBankList";
            this.accordionControlBankList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBankList.Text = "BANKA LİSTESİ";
            this.accordionControlBankList.Click += new System.EventHandler(this.accordionControlBankList_Click);
            // 
            // accordionControlBankArchive
            // 
            this.accordionControlBankArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankArchive.ImageOptions.Image")));
            this.accordionControlBankArchive.Name = "accordionControlBankArchive";
            this.accordionControlBankArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBankArchive.Text = "BANKA BİLGİLERİNİ ARŞİVLE";
            this.accordionControlBankArchive.Click += new System.EventHandler(this.accordionControlBankArchive_Click);
            // 
            // accordionControlBankDelete
            // 
            this.accordionControlBankDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankDelete.ImageOptions.Image")));
            this.accordionControlBankDelete.Name = "accordionControlBankDelete";
            this.accordionControlBankDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBankDelete.Text = "BANKA BİLGİLERİNİ SİL";
            this.accordionControlBankDelete.Click += new System.EventHandler(this.accordionControlBankDelete_Click);
            // 
            // accordionControlBankUpdate
            // 
            this.accordionControlBankUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankUpdate.ImageOptions.Image")));
            this.accordionControlBankUpdate.Name = "accordionControlBankUpdate";
            this.accordionControlBankUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBankUpdate.Text = "BANKA BİLGİLERİNİ DÜZENLE";
            this.accordionControlBankUpdate.Click += new System.EventHandler(this.accordionControlBankUpdate_Click);
            // 
            // accordionControlNewBank
            // 
            this.accordionControlNewBank.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlNewBank.ImageOptions.Image")));
            this.accordionControlNewBank.Name = "accordionControlNewBank";
            this.accordionControlNewBank.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlNewBank.Text = "YENİ BANKA";
            this.accordionControlNewBank.Click += new System.EventHandler(this.accordionControlNewBank_Click);
            // 
            // accordionControlBankProcess
            // 
            this.accordionControlBankProcess.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlNewBank,
            this.accordionControlBankUpdate,
            this.accordionControlBankDelete,
            this.accordionControlBankArchive,
            this.accordionControlBankList,
            this.accordionControlBankFullList});
            this.accordionControlBankProcess.Expanded = true;
            this.accordionControlBankProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBankProcess.ImageOptions.Image")));
            this.accordionControlBankProcess.Name = "accordionControlBankProcess";
            this.accordionControlBankProcess.Text = "FİRMA İŞLEMLERİ";
            this.accordionControlBankProcess.Click += new System.EventHandler(this.accordionControlBankProcess_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlBankProcess,
            this.accordionControlArchive});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(250, 491);
            this.accordionControl1.TabIndex = 10;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // GControlBankArchive
            // 
            this.GControlBankArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlBankArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlBankArchive.MainView = this.GViewBankArchive;
            this.GControlBankArchive.Name = "GControlBankArchive";
            this.GControlBankArchive.Size = new System.Drawing.Size(983, 447);
            this.GControlBankArchive.TabIndex = 3;
            this.GControlBankArchive.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewBankArchive});
            // 
            // GViewBankArchive
            // 
            this.GViewBankArchive.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.GViewBankArchive.DetailHeight = 303;
            this.GViewBankArchive.GridControl = this.GControlBankArchive;
            this.GViewBankArchive.Name = "GViewBankArchive";
            this.GViewBankArchive.OptionsBehavior.Editable = false;
            this.GViewBankArchive.OptionsBehavior.ReadOnly = true;
            this.GViewBankArchive.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "BankID";
            this.gridColumn1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.ImageOptions.Image")));
            this.gridColumn1.MinWidth = 18;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 60;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Banka Adı";
            this.gridColumn2.FieldName = "BankName";
            this.gridColumn2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.ImageOptions.Image")));
            this.gridColumn2.MinWidth = 40;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 200;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "İL";
            this.gridColumn3.FieldName = "CountyName";
            this.gridColumn3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.ImageOptions.Image")));
            this.gridColumn3.MinWidth = 18;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 80;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "İLÇE";
            this.gridColumn4.FieldName = "DistrictName";
            this.gridColumn4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn4.ImageOptions.Image")));
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 80;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Banka Şübesi";
            this.gridColumn5.FieldName = "BankBranch";
            this.gridColumn5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn5.ImageOptions.Image")));
            this.gridColumn5.MinWidth = 15;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 150;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Firma Adı";
            this.gridColumn6.FieldName = "CompanyName";
            this.gridColumn6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn6.ImageOptions.Image")));
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            this.gridColumn6.Width = 180;
            // 
            // BankWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 491);
            this.Controls.Add(this.xtraTabBankControl);
            this.Controls.Add(this.accordionControl1);
            this.Name = "BankWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANKA İŞLEMLERİ";
            this.Load += new System.EventHandler(this.BankWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabBankControl)).EndInit();
            this.xtraTabBankControl.ResumeLayout(false);
            this.TabPageBank.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBank)).EndInit();
            this.TabPageBankArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBankArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBankArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabBankControl;
        private DevExpress.XtraTab.XtraTabPage TabPageBank;
        private DevExpress.XtraTab.XtraTabPage TabPageBankArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankArchiveList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankArchiveQuit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankGetAllList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankFullList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlNewBank;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBankProcess;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraGrid.GridControl GControlBank;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewBank;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBankID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBankName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCountyName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDistrinct;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBankBranch;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyName;
        private DevExpress.XtraGrid.GridControl GControlBankArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewBankArchive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}