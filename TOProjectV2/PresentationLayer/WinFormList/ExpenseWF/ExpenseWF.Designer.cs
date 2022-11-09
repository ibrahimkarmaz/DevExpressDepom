namespace PresentationLayer.WinFormList.ExpenseWF
{
    partial class ExpenseWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseWF));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlExpenseHeaderProcess = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlNewExpenseHeader = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlExpenseHeaderUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlExpenseHeaderDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlExpenseHeaderrArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlExpenseHeaderList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchiveQuit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlExpenseHeaderArchiveList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.TabPageExpenseHeaderArchive = new DevExpress.XtraTab.XtraTabPage();
            this.GControlArchive = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GViewArchive = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnStopDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabPageExpenseHeader = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.GViewExpenseHeader = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnExprenseHeaderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExprenseHeaderName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExprenseHeaderStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExprenseHeaderStopDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExprenseHeaderDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GControlExpenseHeader = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.TabPageExpenseHeaderArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewArchive)).BeginInit();
            this.TabPageExpenseHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GViewExpenseHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlExpenseHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlExpenseHeaderProcess,
            this.accordionControlArchive});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(260, 494);
            this.accordionControl1.TabIndex = 8;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlExpenseHeaderProcess
            // 
            this.accordionControlExpenseHeaderProcess.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlNewExpenseHeader,
            this.accordionControlExpenseHeaderUpdate,
            this.accordionControlExpenseHeaderDelete,
            this.accordionControlExpenseHeaderrArchive,
            this.accordionControlExpenseHeaderList});
            this.accordionControlExpenseHeaderProcess.Expanded = true;
            this.accordionControlExpenseHeaderProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlExpenseHeaderProcess.ImageOptions.Image")));
            this.accordionControlExpenseHeaderProcess.Name = "accordionControlExpenseHeaderProcess";
            this.accordionControlExpenseHeaderProcess.Text = "GİDER BAŞLIĞI İŞLEMLERİ";
            this.accordionControlExpenseHeaderProcess.Click += new System.EventHandler(this.accordionControlExpenseHeaderProcess_Click);
            // 
            // accordionControlNewExpenseHeader
            // 
            this.accordionControlNewExpenseHeader.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlNewExpenseHeader.ImageOptions.Image")));
            this.accordionControlNewExpenseHeader.Name = "accordionControlNewExpenseHeader";
            this.accordionControlNewExpenseHeader.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlNewExpenseHeader.Text = "YENİ GİDER BAŞLIĞI";
            this.accordionControlNewExpenseHeader.Click += new System.EventHandler(this.accordionControlNewExpenseHeader_Click);
            // 
            // accordionControlExpenseHeaderUpdate
            // 
            this.accordionControlExpenseHeaderUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlExpenseHeaderUpdate.ImageOptions.Image")));
            this.accordionControlExpenseHeaderUpdate.Name = "accordionControlExpenseHeaderUpdate";
            this.accordionControlExpenseHeaderUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlExpenseHeaderUpdate.Text = "GİDER BAŞLIĞI BİLGİLERİNİ DÜZENLE";
            this.accordionControlExpenseHeaderUpdate.Click += new System.EventHandler(this.accordionControlExpenseHeaderUpdate_Click);
            // 
            // accordionControlExpenseHeaderDelete
            // 
            this.accordionControlExpenseHeaderDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlExpenseHeaderDelete.ImageOptions.Image")));
            this.accordionControlExpenseHeaderDelete.Name = "accordionControlExpenseHeaderDelete";
            this.accordionControlExpenseHeaderDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlExpenseHeaderDelete.Text = "GİDER BAŞLIĞI BİLGİLERİNİ SİL";
            this.accordionControlExpenseHeaderDelete.Click += new System.EventHandler(this.accordionControlExpenseHeaderDelete_Click);
            // 
            // accordionControlExpenseHeaderrArchive
            // 
            this.accordionControlExpenseHeaderrArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlExpenseHeaderrArchive.ImageOptions.Image")));
            this.accordionControlExpenseHeaderrArchive.Name = "accordionControlExpenseHeaderrArchive";
            this.accordionControlExpenseHeaderrArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlExpenseHeaderrArchive.Text = "GİDER BAŞLIĞI BİLGİLERİNİ ARŞİVLE";
            this.accordionControlExpenseHeaderrArchive.Click += new System.EventHandler(this.accordionControlExpenseHeaderrArchive_Click);
            // 
            // accordionControlExpenseHeaderList
            // 
            this.accordionControlExpenseHeaderList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlExpenseHeaderList.ImageOptions.Image")));
            this.accordionControlExpenseHeaderList.Name = "accordionControlExpenseHeaderList";
            this.accordionControlExpenseHeaderList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlExpenseHeaderList.Text = "GİDER BAŞLIĞI LİSTESİ";
            this.accordionControlExpenseHeaderList.Click += new System.EventHandler(this.accordionControlExpenseHeaderList_Click);
            // 
            // accordionControlArchive
            // 
            this.accordionControlArchive.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlArchiveQuit,
            this.accordionControlExpenseHeaderArchiveList});
            this.accordionControlArchive.Expanded = true;
            this.accordionControlArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchive.ImageOptions.Image")));
            this.accordionControlArchive.Name = "accordionControlArchive";
            this.accordionControlArchive.Text = "GİDER BAŞLIĞI ARŞİV İŞLEMLERİ";
            this.accordionControlArchive.Click += new System.EventHandler(this.accordionControlArchive_Click);
            // 
            // accordionControlArchiveQuit
            // 
            this.accordionControlArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchiveQuit.ImageOptions.Image")));
            this.accordionControlArchiveQuit.Name = "accordionControlArchiveQuit";
            this.accordionControlArchiveQuit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlArchiveQuit.Text = "GİDER BAŞLIĞI ARŞİVDEN ÇIKAR";
            this.accordionControlArchiveQuit.Click += new System.EventHandler(this.accordionControlArchiveQuit_Click);
            // 
            // accordionControlExpenseHeaderArchiveList
            // 
            this.accordionControlExpenseHeaderArchiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlExpenseHeaderArchiveList.ImageOptions.Image")));
            this.accordionControlExpenseHeaderArchiveList.Name = "accordionControlExpenseHeaderArchiveList";
            this.accordionControlExpenseHeaderArchiveList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlExpenseHeaderArchiveList.Text = "GİDER BAŞLIĞI ARŞİV LİSTESİ";
            this.accordionControlExpenseHeaderArchiveList.Click += new System.EventHandler(this.accordionControlExpenseHeaderArchiveList_Click);
            // 
            // TabPageExpenseHeaderArchive
            // 
            this.TabPageExpenseHeaderArchive.Controls.Add(this.GControlArchive);
            this.TabPageExpenseHeaderArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageExpenseHeaderArchive.ImageOptions.Image")));
            this.TabPageExpenseHeaderArchive.Name = "TabPageExpenseHeaderArchive";
            this.TabPageExpenseHeaderArchive.Size = new System.Drawing.Size(962, 450);
            this.TabPageExpenseHeaderArchive.Text = "GİDER BAŞLIĞI ARŞİV LİSTESİ";
            // 
            // GControlArchive
            // 
            this.GControlArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlArchive.MainView = this.GViewArchive;
            this.GControlArchive.Name = "GControlArchive";
            this.GControlArchive.Size = new System.Drawing.Size(962, 450);
            this.GControlArchive.TabIndex = 10;
            this.GControlArchive.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewArchive});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GControlArchive;
            this.gridView1.Name = "gridView1";
            // 
            // GViewArchive
            // 
            this.GViewArchive.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnID,
            this.ColumnName,
            this.ColumnStartDate,
            this.ColumnStopDate,
            this.ColumnDetails});
            this.GViewArchive.DetailHeight = 303;
            this.GViewArchive.GridControl = this.GControlArchive;
            this.GViewArchive.Name = "GViewArchive";
            this.GViewArchive.OptionsBehavior.Editable = false;
            this.GViewArchive.OptionsBehavior.ReadOnly = true;
            this.GViewArchive.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnID
            // 
            this.ColumnID.Caption = "ID";
            this.ColumnID.FieldName = "ExprenseHeaderID";
            this.ColumnID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnID.ImageOptions.Image")));
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.Visible = true;
            this.ColumnID.VisibleIndex = 0;
            this.ColumnID.Width = 50;
            // 
            // ColumnName
            // 
            this.ColumnName.Caption = "Gider Başlığı";
            this.ColumnName.FieldName = "ExprenseHeaderName";
            this.ColumnName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnName.ImageOptions.Image")));
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Visible = true;
            this.ColumnName.VisibleIndex = 1;
            this.ColumnName.Width = 120;
            // 
            // ColumnStartDate
            // 
            this.ColumnStartDate.Caption = "Başlangıç Tarihi";
            this.ColumnStartDate.FieldName = "ExprenseHeaderStartDate";
            this.ColumnStartDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnStartDate.ImageOptions.Image")));
            this.ColumnStartDate.Name = "ColumnStartDate";
            this.ColumnStartDate.Visible = true;
            this.ColumnStartDate.VisibleIndex = 2;
            this.ColumnStartDate.Width = 120;
            // 
            // ColumnStopDate
            // 
            this.ColumnStopDate.Caption = "Bitiş Tarihi";
            this.ColumnStopDate.FieldName = "ExprenseHeaderStopDate";
            this.ColumnStopDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnStopDate.ImageOptions.Image")));
            this.ColumnStopDate.Name = "ColumnStopDate";
            this.ColumnStopDate.Visible = true;
            this.ColumnStopDate.VisibleIndex = 3;
            this.ColumnStopDate.Width = 120;
            // 
            // ColumnDetails
            // 
            this.ColumnDetails.Caption = "Detaylar";
            this.ColumnDetails.FieldName = "ExprenseHeaderDetail";
            this.ColumnDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDetails.ImageOptions.Image")));
            this.ColumnDetails.Name = "ColumnDetails";
            this.ColumnDetails.Visible = true;
            this.ColumnDetails.VisibleIndex = 4;
            this.ColumnDetails.Width = 150;
            // 
            // TabPageExpenseHeader
            // 
            this.TabPageExpenseHeader.Controls.Add(this.GControlExpenseHeader);
            this.TabPageExpenseHeader.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageExpenseHeader.ImageOptions.Image")));
            this.TabPageExpenseHeader.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageExpenseHeader.Name = "TabPageExpenseHeader";
            this.TabPageExpenseHeader.Size = new System.Drawing.Size(962, 450);
            this.TabPageExpenseHeader.Text = "GİDER BAŞLIĞI LİSTESİ";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Teal;
            this.xtraTabControl.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(260, 0);
            this.xtraTabControl.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabControl.SelectedTabPage = this.TabPageExpenseHeader;
            this.xtraTabControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl.Size = new System.Drawing.Size(964, 494);
            this.xtraTabControl.TabIndex = 10;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageExpenseHeader,
            this.TabPageExpenseHeaderArchive});
            this.xtraTabControl.Click += new System.EventHandler(this.xtraTabControl_Click);
            // 
            // GViewExpenseHeader
            // 
            this.GViewExpenseHeader.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnExprenseHeaderID,
            this.ColumnExprenseHeaderName,
            this.ColumnExprenseHeaderStartDate,
            this.ColumnExprenseHeaderStopDate,
            this.ColumnExprenseHeaderDetail});
            this.GViewExpenseHeader.DetailHeight = 303;
            this.GViewExpenseHeader.GridControl = this.GControlExpenseHeader;
            this.GViewExpenseHeader.Name = "GViewExpenseHeader";
            this.GViewExpenseHeader.OptionsBehavior.Editable = false;
            this.GViewExpenseHeader.OptionsBehavior.ReadOnly = true;
            this.GViewExpenseHeader.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnExprenseHeaderID
            // 
            this.ColumnExprenseHeaderID.Caption = "ID";
            this.ColumnExprenseHeaderID.FieldName = "ExprenseHeaderID";
            this.ColumnExprenseHeaderID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExprenseHeaderID.ImageOptions.Image")));
            this.ColumnExprenseHeaderID.Name = "ColumnExprenseHeaderID";
            this.ColumnExprenseHeaderID.Visible = true;
            this.ColumnExprenseHeaderID.VisibleIndex = 0;
            this.ColumnExprenseHeaderID.Width = 50;
            // 
            // ColumnExprenseHeaderName
            // 
            this.ColumnExprenseHeaderName.Caption = "Gider Başlığı";
            this.ColumnExprenseHeaderName.FieldName = "ExprenseHeaderName";
            this.ColumnExprenseHeaderName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExprenseHeaderName.ImageOptions.Image")));
            this.ColumnExprenseHeaderName.Name = "ColumnExprenseHeaderName";
            this.ColumnExprenseHeaderName.Visible = true;
            this.ColumnExprenseHeaderName.VisibleIndex = 1;
            this.ColumnExprenseHeaderName.Width = 120;
            // 
            // ColumnExprenseHeaderStartDate
            // 
            this.ColumnExprenseHeaderStartDate.Caption = "Başlangıç Tarihi";
            this.ColumnExprenseHeaderStartDate.FieldName = "ExprenseHeaderStartDate";
            this.ColumnExprenseHeaderStartDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExprenseHeaderStartDate.ImageOptions.Image")));
            this.ColumnExprenseHeaderStartDate.Name = "ColumnExprenseHeaderStartDate";
            this.ColumnExprenseHeaderStartDate.Visible = true;
            this.ColumnExprenseHeaderStartDate.VisibleIndex = 2;
            this.ColumnExprenseHeaderStartDate.Width = 120;
            // 
            // ColumnExprenseHeaderStopDate
            // 
            this.ColumnExprenseHeaderStopDate.Caption = "Bitiş Tarihi";
            this.ColumnExprenseHeaderStopDate.FieldName = "ExprenseHeaderStopDate";
            this.ColumnExprenseHeaderStopDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExprenseHeaderStopDate.ImageOptions.Image")));
            this.ColumnExprenseHeaderStopDate.Name = "ColumnExprenseHeaderStopDate";
            this.ColumnExprenseHeaderStopDate.Visible = true;
            this.ColumnExprenseHeaderStopDate.VisibleIndex = 3;
            this.ColumnExprenseHeaderStopDate.Width = 120;
            // 
            // ColumnExprenseHeaderDetail
            // 
            this.ColumnExprenseHeaderDetail.Caption = "Detaylar";
            this.ColumnExprenseHeaderDetail.FieldName = "ExprenseHeaderDetail";
            this.ColumnExprenseHeaderDetail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExprenseHeaderDetail.ImageOptions.Image")));
            this.ColumnExprenseHeaderDetail.Name = "ColumnExprenseHeaderDetail";
            this.ColumnExprenseHeaderDetail.Visible = true;
            this.ColumnExprenseHeaderDetail.VisibleIndex = 4;
            this.ColumnExprenseHeaderDetail.Width = 150;
            // 
            // GControlExpenseHeader
            // 
            this.GControlExpenseHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlExpenseHeader.Location = new System.Drawing.Point(0, 0);
            this.GControlExpenseHeader.MainView = this.GViewExpenseHeader;
            this.GControlExpenseHeader.Name = "GControlExpenseHeader";
            this.GControlExpenseHeader.Size = new System.Drawing.Size(962, 450);
            this.GControlExpenseHeader.TabIndex = 9;
            this.GControlExpenseHeader.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewExpenseHeader});
            this.GControlExpenseHeader.Click += new System.EventHandler(this.GControlCustomer_Click);
            // 
            // ExpenseWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 494);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.accordionControl1);
            this.Name = "ExpenseWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİDER BAŞLIĞI İŞLEMLERİ";
            this.Load += new System.EventHandler(this.ExpenseWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.TabPageExpenseHeaderArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewArchive)).EndInit();
            this.TabPageExpenseHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GViewExpenseHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlExpenseHeader)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlExpenseHeaderProcess;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlNewExpenseHeader;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlExpenseHeaderUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlExpenseHeaderDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlExpenseHeaderrArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlExpenseHeaderList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchiveQuit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlExpenseHeaderArchiveList;
        private DevExpress.XtraTab.XtraTabPage TabPageExpenseHeaderArchive;
        private DevExpress.XtraGrid.GridControl GControlArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewArchive;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnStopDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDetails;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraTab.XtraTabPage TabPageExpenseHeader;
        private DevExpress.XtraGrid.GridControl GControlExpenseHeader;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewExpenseHeader;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExprenseHeaderID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExprenseHeaderName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExprenseHeaderStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExprenseHeaderStopDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExprenseHeaderDetail;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
    }
}