namespace PresentationLayer.WinFormList.SectorWF
{
    partial class SectorWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SectorWF));
            this.TabPageSectorArchive = new DevExpress.XtraTab.XtraTabPage();
            this.GControlSectorArchive = new DevExpress.XtraGrid.GridControl();
            this.GViewSectorArchive = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnSectorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSectorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabCustomerControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageSector = new DevExpress.XtraTab.XtraTabPage();
            this.GControlSector1 = new DevExpress.XtraGrid.GridControl();
            this.GViewSector = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnSectorID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnSectorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlSectorProcess = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlNewSector = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSectorUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSectorDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSectorArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSectorList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSectorArchiveQuit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlSectorArchiveList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.TabPageSectorArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlSectorArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewSectorArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCustomerControl)).BeginInit();
            this.xtraTabCustomerControl.SuspendLayout();
            this.TabPageSector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlSector1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewSector)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabPageSectorArchive
            // 
            this.TabPageSectorArchive.Controls.Add(this.GControlSectorArchive);
            this.TabPageSectorArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageSectorArchive.ImageOptions.Image")));
            this.TabPageSectorArchive.Name = "TabPageSectorArchive";
            this.TabPageSectorArchive.Size = new System.Drawing.Size(852, 461);
            this.TabPageSectorArchive.Text = "ÜRÜNLER ARŞİV LİSTESİ";
            // 
            // GControlSectorArchive
            // 
            this.GControlSectorArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlSectorArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlSectorArchive.MainView = this.GViewSectorArchive;
            this.GControlSectorArchive.Name = "GControlSectorArchive";
            this.GControlSectorArchive.Size = new System.Drawing.Size(852, 461);
            this.GControlSectorArchive.TabIndex = 1;
            this.GControlSectorArchive.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewSectorArchive});
            // 
            // GViewSectorArchive
            // 
            this.GViewSectorArchive.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnSectorID,
            this.gridColumnSectorName});
            this.GViewSectorArchive.DetailHeight = 303;
            this.GViewSectorArchive.GridControl = this.GControlSectorArchive;
            this.GViewSectorArchive.Name = "GViewSectorArchive";
            this.GViewSectorArchive.OptionsBehavior.Editable = false;
            this.GViewSectorArchive.OptionsBehavior.ReadOnly = true;
            this.GViewSectorArchive.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnSectorID
            // 
            this.gridColumnSectorID.Caption = "ID";
            this.gridColumnSectorID.FieldName = "SectorID";
            this.gridColumnSectorID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnSectorID.ImageOptions.Image")));
            this.gridColumnSectorID.Name = "gridColumnSectorID";
            this.gridColumnSectorID.Visible = true;
            this.gridColumnSectorID.VisibleIndex = 0;
            this.gridColumnSectorID.Width = 76;
            // 
            // gridColumnSectorName
            // 
            this.gridColumnSectorName.Caption = "Sektör Adı";
            this.gridColumnSectorName.FieldName = "SectorName";
            this.gridColumnSectorName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnSectorName.ImageOptions.Image")));
            this.gridColumnSectorName.Name = "gridColumnSectorName";
            this.gridColumnSectorName.Visible = true;
            this.gridColumnSectorName.VisibleIndex = 1;
            this.gridColumnSectorName.Width = 746;
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
            this.xtraTabCustomerControl.SelectedTabPage = this.TabPageSector;
            this.xtraTabCustomerControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabCustomerControl.Size = new System.Drawing.Size(854, 505);
            this.xtraTabCustomerControl.TabIndex = 9;
            this.xtraTabCustomerControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageSector,
            this.TabPageSectorArchive});
            this.xtraTabCustomerControl.Click += new System.EventHandler(this.xtraTabCustomerControl_Click);
            // 
            // TabPageSector
            // 
            this.TabPageSector.Controls.Add(this.GControlSector1);
            this.TabPageSector.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageSector.ImageOptions.Image")));
            this.TabPageSector.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageSector.Name = "TabPageSector";
            this.TabPageSector.Size = new System.Drawing.Size(852, 461);
            this.TabPageSector.Text = "ÜRÜNLER LİSTESİ";
            // 
            // GControlSector1
            // 
            this.GControlSector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlSector1.Location = new System.Drawing.Point(0, 0);
            this.GControlSector1.MainView = this.GViewSector;
            this.GControlSector1.Name = "GControlSector1";
            this.GControlSector1.Size = new System.Drawing.Size(852, 461);
            this.GControlSector1.TabIndex = 0;
            this.GControlSector1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewSector});
            // 
            // GViewSector
            // 
            this.GViewSector.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnSectorID,
            this.ColumnSectorName});
            this.GViewSector.DetailHeight = 303;
            this.GViewSector.GridControl = this.GControlSector1;
            this.GViewSector.Name = "GViewSector";
            this.GViewSector.OptionsBehavior.Editable = false;
            this.GViewSector.OptionsBehavior.ReadOnly = true;
            this.GViewSector.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnSectorID
            // 
            this.ColumnSectorID.Caption = "ID";
            this.ColumnSectorID.FieldName = "SectorID";
            this.ColumnSectorID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSectorID.ImageOptions.Image")));
            this.ColumnSectorID.Name = "ColumnSectorID";
            this.ColumnSectorID.Visible = true;
            this.ColumnSectorID.VisibleIndex = 0;
            this.ColumnSectorID.Width = 76;
            // 
            // ColumnSectorName
            // 
            this.ColumnSectorName.Caption = "Sektör Adı";
            this.ColumnSectorName.FieldName = "SectorName";
            this.ColumnSectorName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSectorName.ImageOptions.Image")));
            this.ColumnSectorName.Name = "ColumnSectorName";
            this.ColumnSectorName.Visible = true;
            this.ColumnSectorName.VisibleIndex = 1;
            this.ColumnSectorName.Width = 746;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSectorProcess,
            this.accordionControlArchive});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(260, 505);
            this.accordionControl1.TabIndex = 8;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlSectorProcess
            // 
            this.accordionControlSectorProcess.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlNewSector,
            this.accordionControlSectorUpdate,
            this.accordionControlSectorDelete,
            this.accordionControlSectorArchive,
            this.accordionControlSectorList});
            this.accordionControlSectorProcess.Expanded = true;
            this.accordionControlSectorProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSectorProcess.ImageOptions.Image")));
            this.accordionControlSectorProcess.Name = "accordionControlSectorProcess";
            this.accordionControlSectorProcess.Text = "MÜŞTERİ İŞLEMLERİ";
            this.accordionControlSectorProcess.Click += new System.EventHandler(this.accordionControlSectorProcess_Click);
            // 
            // accordionControlNewSector
            // 
            this.accordionControlNewSector.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlNewSector.ImageOptions.Image")));
            this.accordionControlNewSector.Name = "accordionControlNewSector";
            this.accordionControlNewSector.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlNewSector.Text = "YENİ SEKTÖR";
            this.accordionControlNewSector.Click += new System.EventHandler(this.accordionControlNewSector_Click);
            // 
            // accordionControlSectorUpdate
            // 
            this.accordionControlSectorUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSectorUpdate.ImageOptions.Image")));
            this.accordionControlSectorUpdate.Name = "accordionControlSectorUpdate";
            this.accordionControlSectorUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSectorUpdate.Text = "SEKTÖR BİLGİSİNİ DÜZENLE";
            this.accordionControlSectorUpdate.Click += new System.EventHandler(this.accordionControlSectorUpdate_Click);
            // 
            // accordionControlSectorDelete
            // 
            this.accordionControlSectorDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSectorDelete.ImageOptions.Image")));
            this.accordionControlSectorDelete.Name = "accordionControlSectorDelete";
            this.accordionControlSectorDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSectorDelete.Text = "SEKTÖR BİLGİSİNİ SİL";
            this.accordionControlSectorDelete.Click += new System.EventHandler(this.accordionControlSectorDelete_Click);
            // 
            // accordionControlSectorArchive
            // 
            this.accordionControlSectorArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSectorArchive.ImageOptions.Image")));
            this.accordionControlSectorArchive.Name = "accordionControlSectorArchive";
            this.accordionControlSectorArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSectorArchive.Text = "SEKTÖR BİLGİSİNİ ARŞİVLE";
            this.accordionControlSectorArchive.Click += new System.EventHandler(this.accordionControlSectorArchive_Click);
            // 
            // accordionControlSectorList
            // 
            this.accordionControlSectorList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSectorList.ImageOptions.Image")));
            this.accordionControlSectorList.Name = "accordionControlSectorList";
            this.accordionControlSectorList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSectorList.Text = "SEKTÖR LİSTESİ";
            this.accordionControlSectorList.Click += new System.EventHandler(this.accordionControlSectorList_Click);
            // 
            // accordionControlArchive
            // 
            this.accordionControlArchive.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlSectorArchiveQuit,
            this.accordionControlSectorArchiveList});
            this.accordionControlArchive.Expanded = true;
            this.accordionControlArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchive.ImageOptions.Image")));
            this.accordionControlArchive.Name = "accordionControlArchive";
            this.accordionControlArchive.Text = "MÜŞTERİ ARŞİV İŞLEMLERİ";
            this.accordionControlArchive.Click += new System.EventHandler(this.accordionControlArchive_Click);
            // 
            // accordionControlSectorArchiveQuit
            // 
            this.accordionControlSectorArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSectorArchiveQuit.ImageOptions.Image")));
            this.accordionControlSectorArchiveQuit.Name = "accordionControlSectorArchiveQuit";
            this.accordionControlSectorArchiveQuit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSectorArchiveQuit.Text = "SEKTÖR ARŞİVDEN ÇIKAR";
            this.accordionControlSectorArchiveQuit.Click += new System.EventHandler(this.accordionControlSectorArchiveQuit_Click);
            // 
            // accordionControlSectorArchiveList
            // 
            this.accordionControlSectorArchiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlSectorArchiveList.ImageOptions.Image")));
            this.accordionControlSectorArchiveList.Name = "accordionControlSectorArchiveList";
            this.accordionControlSectorArchiveList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlSectorArchiveList.Text = "SEKTÖR ARŞİV LİSTESİ";
            this.accordionControlSectorArchiveList.Click += new System.EventHandler(this.accordionControlSectorArchiveList_Click);
            // 
            // SectorWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 505);
            this.Controls.Add(this.xtraTabCustomerControl);
            this.Controls.Add(this.accordionControl1);
            this.Name = "SectorWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEKTÖR İŞLEMLERİ";
            this.Load += new System.EventHandler(this.SectorWF_Load);
            this.TabPageSectorArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlSectorArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewSectorArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCustomerControl)).EndInit();
            this.xtraTabCustomerControl.ResumeLayout(false);
            this.TabPageSector.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlSector1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewSector)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraTab.XtraTabPage TabPageSectorArchive;
        private DevExpress.XtraTab.XtraTabControl xtraTabCustomerControl;
        private DevExpress.XtraTab.XtraTabPage TabPageSector;
        private DevExpress.XtraGrid.GridControl GControlSector1;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewSector;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSectorID;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSectorProcess;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlNewSector;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSectorUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSectorDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSectorArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSectorList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSectorArchiveQuit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlSectorArchiveList;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSectorName;
        private DevExpress.XtraGrid.GridControl GControlSectorArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewSectorArchive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSectorID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSectorName;
    }
}