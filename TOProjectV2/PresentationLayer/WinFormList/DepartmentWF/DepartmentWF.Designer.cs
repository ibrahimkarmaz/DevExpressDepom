namespace PresentationLayer.WinFormList.DepartmentWF
{
    partial class DepartmentWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentWF));
            this.xtraTabCustomerControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageDepartment = new DevExpress.XtraTab.XtraTabPage();
            this.GControlDepartmen = new DevExpress.XtraGrid.GridControl();
            this.GViewDepartment = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnDepartmanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDepartmanName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabPageDepartmentArchive = new DevExpress.XtraTab.XtraTabPage();
            this.GControlArchive = new DevExpress.XtraGrid.GridControl();
            this.GViewArchive = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlDepartmentProcess = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlNewDepartment = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDepartmentUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDepartmentDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDepartmentArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDepartmentList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDepartmentArchiveQuit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlDepartmentArchiveList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCustomerControl)).BeginInit();
            this.xtraTabCustomerControl.SuspendLayout();
            this.TabPageDepartment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlDepartmen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewDepartment)).BeginInit();
            this.TabPageDepartmentArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
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
            this.xtraTabCustomerControl.SelectedTabPage = this.TabPageDepartment;
            this.xtraTabCustomerControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabCustomerControl.Size = new System.Drawing.Size(976, 494);
            this.xtraTabCustomerControl.TabIndex = 13;
            this.xtraTabCustomerControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageDepartment,
            this.TabPageDepartmentArchive});
            // 
            // TabPageDepartment
            // 
            this.TabPageDepartment.Controls.Add(this.GControlDepartmen);
            this.TabPageDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageDepartment.ImageOptions.Image")));
            this.TabPageDepartment.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageDepartment.Name = "TabPageDepartment";
            this.TabPageDepartment.Size = new System.Drawing.Size(974, 450);
            this.TabPageDepartment.Text = "ÜRÜNLER LİSTESİ";
            // 
            // GControlDepartmen
            // 
            this.GControlDepartmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlDepartmen.Location = new System.Drawing.Point(0, 0);
            this.GControlDepartmen.MainView = this.GViewDepartment;
            this.GControlDepartmen.Name = "GControlDepartmen";
            this.GControlDepartmen.Size = new System.Drawing.Size(974, 450);
            this.GControlDepartmen.TabIndex = 0;
            this.GControlDepartmen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewDepartment});
            // 
            // GViewDepartment
            // 
            this.GViewDepartment.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnDepartmanID,
            this.ColumnDepartmanName});
            this.GViewDepartment.DetailHeight = 303;
            this.GViewDepartment.GridControl = this.GControlDepartmen;
            this.GViewDepartment.Name = "GViewDepartment";
            this.GViewDepartment.OptionsBehavior.Editable = false;
            this.GViewDepartment.OptionsBehavior.ReadOnly = true;
            this.GViewDepartment.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnDepartmanID
            // 
            this.ColumnDepartmanID.Caption = "ID";
            this.ColumnDepartmanID.FieldName = "DepartmentID";
            this.ColumnDepartmanID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDepartmanID.ImageOptions.Image")));
            this.ColumnDepartmanID.Name = "ColumnDepartmanID";
            this.ColumnDepartmanID.Visible = true;
            this.ColumnDepartmanID.VisibleIndex = 0;
            this.ColumnDepartmanID.Width = 76;
            // 
            // ColumnDepartmanName
            // 
            this.ColumnDepartmanName.Caption = "Departman Adı";
            this.ColumnDepartmanName.FieldName = "DepartmentName";
            this.ColumnDepartmanName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDepartmanName.ImageOptions.Image")));
            this.ColumnDepartmanName.Name = "ColumnDepartmanName";
            this.ColumnDepartmanName.Visible = true;
            this.ColumnDepartmanName.VisibleIndex = 1;
            this.ColumnDepartmanName.Width = 746;
            // 
            // TabPageDepartmentArchive
            // 
            this.TabPageDepartmentArchive.Controls.Add(this.GControlArchive);
            this.TabPageDepartmentArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageDepartmentArchive.ImageOptions.Image")));
            this.TabPageDepartmentArchive.Name = "TabPageDepartmentArchive";
            this.TabPageDepartmentArchive.Size = new System.Drawing.Size(967, 457);
            this.TabPageDepartmentArchive.Text = "ÜRÜNLER ARŞİV LİSTESİ";
            // 
            // GControlArchive
            // 
            this.GControlArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlArchive.MainView = this.GViewArchive;
            this.GControlArchive.Name = "GControlArchive";
            this.GControlArchive.Size = new System.Drawing.Size(967, 457);
            this.GControlArchive.TabIndex = 1;
            this.GControlArchive.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewArchive});
            // 
            // GViewArchive
            // 
            this.GViewArchive.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2});
            this.GViewArchive.DetailHeight = 303;
            this.GViewArchive.GridControl = this.GControlArchive;
            this.GViewArchive.Name = "GViewArchive";
            this.GViewArchive.OptionsBehavior.Editable = false;
            this.GViewArchive.OptionsBehavior.ReadOnly = true;
            this.GViewArchive.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ID";
            this.gridColumn1.FieldName = "DepartmentID";
            this.gridColumn1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn1.ImageOptions.Image")));
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 76;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Departman Adı";
            this.gridColumn2.FieldName = "DepartmentName";
            this.gridColumn2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn2.ImageOptions.Image")));
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 746;
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlDepartmentProcess,
            this.accordionControlArchive});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(260, 494);
            this.accordionControl1.TabIndex = 12;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlDepartmentProcess
            // 
            this.accordionControlDepartmentProcess.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlNewDepartment,
            this.accordionControlDepartmentUpdate,
            this.accordionControlDepartmentDelete,
            this.accordionControlDepartmentArchive,
            this.accordionControlDepartmentList});
            this.accordionControlDepartmentProcess.Expanded = true;
            this.accordionControlDepartmentProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDepartmentProcess.ImageOptions.Image")));
            this.accordionControlDepartmentProcess.Name = "accordionControlDepartmentProcess";
            this.accordionControlDepartmentProcess.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // accordionControlNewDepartment
            // 
            this.accordionControlNewDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlNewDepartment.ImageOptions.Image")));
            this.accordionControlNewDepartment.Name = "accordionControlNewDepartment";
            this.accordionControlNewDepartment.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlNewDepartment.Text = "YENİ DEPARTMAN";
            this.accordionControlNewDepartment.Click += new System.EventHandler(this.accordionControlNewDepartment_Click);
            // 
            // accordionControlDepartmentUpdate
            // 
            this.accordionControlDepartmentUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDepartmentUpdate.ImageOptions.Image")));
            this.accordionControlDepartmentUpdate.Name = "accordionControlDepartmentUpdate";
            this.accordionControlDepartmentUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDepartmentUpdate.Text = "DEPARTMAN BİLGİSİNİ DÜZENLE";
            this.accordionControlDepartmentUpdate.Click += new System.EventHandler(this.accordionControlDepartmentUpdate_Click);
            // 
            // accordionControlDepartmentDelete
            // 
            this.accordionControlDepartmentDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDepartmentDelete.ImageOptions.Image")));
            this.accordionControlDepartmentDelete.Name = "accordionControlDepartmentDelete";
            this.accordionControlDepartmentDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDepartmentDelete.Text = "DEPARTMAN BİLGİSİNİ SİL";
            this.accordionControlDepartmentDelete.Click += new System.EventHandler(this.accordionControlDepartmentDelete_Click);
            // 
            // accordionControlDepartmentArchive
            // 
            this.accordionControlDepartmentArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDepartmentArchive.ImageOptions.Image")));
            this.accordionControlDepartmentArchive.Name = "accordionControlDepartmentArchive";
            this.accordionControlDepartmentArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDepartmentArchive.Text = "DEPARTMAN BİLGİSİNİ ARŞİVLE";
            this.accordionControlDepartmentArchive.Click += new System.EventHandler(this.accordionControlDepartmentArchive_Click);
            // 
            // accordionControlDepartmentList
            // 
            this.accordionControlDepartmentList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDepartmentList.ImageOptions.Image")));
            this.accordionControlDepartmentList.Name = "accordionControlDepartmentList";
            this.accordionControlDepartmentList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDepartmentList.Text = "DEPARTMAN LİSTESİ";
            this.accordionControlDepartmentList.Click += new System.EventHandler(this.accordionControlDepartmentList_Click);
            // 
            // accordionControlArchive
            // 
            this.accordionControlArchive.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlDepartmentArchiveQuit,
            this.accordionControlDepartmentArchiveList});
            this.accordionControlArchive.Expanded = true;
            this.accordionControlArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchive.ImageOptions.Image")));
            this.accordionControlArchive.Name = "accordionControlArchive";
            this.accordionControlArchive.Text = "MÜŞTERİ ARŞİV İŞLEMLERİ";
            // 
            // accordionControlDepartmentArchiveQuit
            // 
            this.accordionControlDepartmentArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDepartmentArchiveQuit.ImageOptions.Image")));
            this.accordionControlDepartmentArchiveQuit.Name = "accordionControlDepartmentArchiveQuit";
            this.accordionControlDepartmentArchiveQuit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDepartmentArchiveQuit.Text = "DEPARTMAN ARŞİVDEN ÇIKAR";
            this.accordionControlDepartmentArchiveQuit.Click += new System.EventHandler(this.accordionControlDepartmentArchiveQuit_Click);
            // 
            // accordionControlDepartmentArchiveList
            // 
            this.accordionControlDepartmentArchiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDepartmentArchiveList.ImageOptions.Image")));
            this.accordionControlDepartmentArchiveList.Name = "accordionControlDepartmentArchiveList";
            this.accordionControlDepartmentArchiveList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlDepartmentArchiveList.Text = "DEPARTMAN  ARŞİV LİSTESİ";
            this.accordionControlDepartmentArchiveList.Click += new System.EventHandler(this.accordionControlDepartmentArchiveList_Click);
            // 
            // DepartmentWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 494);
            this.Controls.Add(this.xtraTabCustomerControl);
            this.Controls.Add(this.accordionControl1);
            this.Name = "DepartmentWF";
            this.Text = "DepartmentWF";
            this.Load += new System.EventHandler(this.DepartmentWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabCustomerControl)).EndInit();
            this.xtraTabCustomerControl.ResumeLayout(false);
            this.TabPageDepartment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlDepartmen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewDepartment)).EndInit();
            this.TabPageDepartmentArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabCustomerControl;
        private DevExpress.XtraTab.XtraTabPage TabPageDepartment;
        private DevExpress.XtraGrid.GridControl GControlDepartmen;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewDepartment;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDepartmanID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDepartmanName;
        private DevExpress.XtraTab.XtraTabPage TabPageDepartmentArchive;
        private DevExpress.XtraGrid.GridControl GControlArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewArchive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDepartmentProcess;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlNewDepartment;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDepartmentUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDepartmentDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDepartmentArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDepartmentList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDepartmentArchiveQuit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDepartmentArchiveList;
    }
}