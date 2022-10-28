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
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlNewCustomer = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlProductUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement3 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlProductArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlProductList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageProduct = new DevExpress.XtraTab.XtraTabPage();
            this.GControlProduct = new DevExpress.XtraGrid.GridControl();
            this.GViewProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnProductID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBland = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnModelYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnProductPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPurchasePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.GControlProductStock = new DevExpress.XtraGrid.GridControl();
            this.GViewProductStock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProductName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBlandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnModelYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProductPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProductPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProductSalePrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.GControlProductArchive = new DevExpress.XtraGrid.GridControl();
            this.GViewProductArchive = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnPID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnBName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMYear = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumPPiece = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPDetails = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.TabPageProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewProduct)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlProductStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewProductStock)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlProductArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewProductArchive)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(260, 486);
            this.accordionControl1.TabIndex = 5;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlNewCustomer,
            this.accordionControlProductUpdate,
            this.accordionControlElement3,
            this.accordionControlProductArchive,
            this.accordionControlProductList});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "ÜRÜN İŞLEMLERİ";
            // 
            // accordionControlNewCustomer
            // 
            this.accordionControlNewCustomer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlProductNewAdd.ImageOptions.Image")));
            this.accordionControlNewCustomer.Name = "accordionControlNewCustomer";
            this.accordionControlNewCustomer.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlNewCustomer.Text = "YENİ MÜŞTERİ";
            this.accordionControlNewCustomer.Click += new System.EventHandler(this.accordionControlNewCustomer_Click);
            // 
            // accordionControlProductUpdate
            // 
            this.accordionControlProductUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlProductUpdate.ImageOptions.Image")));
            this.accordionControlProductUpdate.Name = "accordionControlProductUpdate";
            this.accordionControlProductUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlProductUpdate.Text = "MÜŞTERİ BİLGİLERİNİ DÜZENLE";
            // 
            // accordionControlElement3
            // 
            this.accordionControlElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement3.ImageOptions.Image")));
            this.accordionControlElement3.Name = "accordionControlElement3";
            this.accordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlElement3.Text = "MÜŞTERİ BİLGİLERİNİ SİL";
            // 
            // accordionControlProductArchive
            // 
            this.accordionControlProductArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlProductArchive.ImageOptions.Image")));
            this.accordionControlProductArchive.Name = "accordionControlProductArchive";
            this.accordionControlProductArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlProductArchive.Text = "ÜRÜN BİLGİLERİNİ ARŞİVLE";
            // 
            // accordionControlProductList
            // 
            this.accordionControlProductList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlProductList.ImageOptions.Image")));
            this.accordionControlProductList.Name = "accordionControlProductList";
            this.accordionControlProductList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlProductList.Text = "MÜŞTERİ LİSTESİ";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Teal;
            this.xtraTabControl1.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(260, 0);
            this.xtraTabControl1.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabControl1.SelectedTabPage = this.TabPageProduct;
            this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabControl1.Size = new System.Drawing.Size(908, 486);
            this.xtraTabControl1.TabIndex = 7;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageProduct,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // TabPageProduct
            // 
            this.TabPageProduct.Controls.Add(this.GControlProduct);
            this.TabPageProduct.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageProduct.ImageOptions.Image")));
            this.TabPageProduct.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageProduct.Name = "TabPageProduct";
            this.TabPageProduct.Size = new System.Drawing.Size(906, 442);
            this.TabPageProduct.Text = "ÜRÜNLER LİSTESİ";
            // 
            // GControlProduct
            // 
            this.GControlProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlProduct.Location = new System.Drawing.Point(0, 0);
            this.GControlProduct.MainView = this.GViewProduct;
            this.GControlProduct.Name = "GControlProduct";
            this.GControlProduct.Size = new System.Drawing.Size(906, 442);
            this.GControlProduct.TabIndex = 0;
            this.GControlProduct.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewProduct});
            // 
            // GViewProduct
            // 
            this.GViewProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnProductID,
            this.ColumnProductName,
            this.ColumnBland,
            this.ColumnModelName,
            this.ColumnModelYear,
            this.ColumnProductPiece,
            this.ColumnPurchasePrice,
            this.ColumnSalePrice,
            this.ColumnDetails});
            this.GViewProduct.DetailHeight = 303;
            this.GViewProduct.GridControl = this.GControlProduct;
            this.GViewProduct.Name = "GViewProduct";
            this.GViewProduct.OptionsBehavior.Editable = false;
            this.GViewProduct.OptionsBehavior.ReadOnly = true;
            this.GViewProduct.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnProductID
            // 
            this.ColumnProductID.Caption = "ID";
            this.ColumnProductID.FieldName = "ProductID";
            this.ColumnProductID.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnProductID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnProductID.ImageOptions.Image")));
            this.ColumnProductID.MinWidth = 10;
            this.ColumnProductID.Name = "ColumnProductID";
            this.ColumnProductID.Visible = true;
            this.ColumnProductID.VisibleIndex = 0;
            this.ColumnProductID.Width = 53;
            // 
            // ColumnProductName
            // 
            this.ColumnProductName.Caption = "Ürün Adı";
            this.ColumnProductName.FieldName = "ProductName";
            this.ColumnProductName.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnProductName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnProductName.ImageOptions.Image")));
            this.ColumnProductName.Name = "ColumnProductName";
            this.ColumnProductName.Visible = true;
            this.ColumnProductName.VisibleIndex = 1;
            this.ColumnProductName.Width = 146;
            // 
            // ColumnBland
            // 
            this.ColumnBland.Caption = "Marka Adı";
            this.ColumnBland.FieldName = "BlandName";
            this.ColumnBland.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnBland.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBland.ImageOptions.Image")));
            this.ColumnBland.Name = "ColumnBland";
            this.ColumnBland.Visible = true;
            this.ColumnBland.VisibleIndex = 2;
            this.ColumnBland.Width = 98;
            // 
            // ColumnModelName
            // 
            this.ColumnModelName.Caption = "Model Adı";
            this.ColumnModelName.FieldName = "ModelName";
            this.ColumnModelName.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnModelName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnModelName.ImageOptions.Image")));
            this.ColumnModelName.Name = "ColumnModelName";
            this.ColumnModelName.Visible = true;
            this.ColumnModelName.VisibleIndex = 3;
            this.ColumnModelName.Width = 97;
            // 
            // ColumnModelYear
            // 
            this.ColumnModelYear.Caption = "Model Yılı";
            this.ColumnModelYear.FieldName = "ModelYear";
            this.ColumnModelYear.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnModelYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnModelYear.ImageOptions.Image")));
            this.ColumnModelYear.Name = "ColumnModelYear";
            this.ColumnModelYear.Visible = true;
            this.ColumnModelYear.VisibleIndex = 4;
            this.ColumnModelYear.Width = 91;
            // 
            // ColumnProductPiece
            // 
            this.ColumnProductPiece.Caption = "Ürün Adeti";
            this.ColumnProductPiece.FieldName = "ProductPiece";
            this.ColumnProductPiece.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnProductPiece.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnProductPiece.ImageOptions.Image")));
            this.ColumnProductPiece.Name = "ColumnProductPiece";
            this.ColumnProductPiece.Visible = true;
            this.ColumnProductPiece.VisibleIndex = 5;
            this.ColumnProductPiece.Width = 89;
            // 
            // ColumnPurchasePrice
            // 
            this.ColumnPurchasePrice.Caption = "Alış Fiyati";
            this.ColumnPurchasePrice.FieldName = "ProductPurchasePrice";
            this.ColumnPurchasePrice.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnPurchasePrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPurchasePrice.ImageOptions.Image")));
            this.ColumnPurchasePrice.Name = "ColumnPurchasePrice";
            this.ColumnPurchasePrice.Visible = true;
            this.ColumnPurchasePrice.VisibleIndex = 6;
            this.ColumnPurchasePrice.Width = 89;
            // 
            // ColumnSalePrice
            // 
            this.ColumnSalePrice.Caption = "Satış Fiyati";
            this.ColumnSalePrice.FieldName = "ProductSalePrice";
            this.ColumnSalePrice.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnSalePrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSalePrice.ImageOptions.Image")));
            this.ColumnSalePrice.Name = "ColumnSalePrice";
            this.ColumnSalePrice.Visible = true;
            this.ColumnSalePrice.VisibleIndex = 7;
            this.ColumnSalePrice.Width = 89;
            // 
            // ColumnDetails
            // 
            this.ColumnDetails.Caption = "Detaylar";
            this.ColumnDetails.FieldName = "ProductDetails";
            this.ColumnDetails.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.ColumnDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDetails.ImageOptions.Image")));
            this.ColumnDetails.Name = "ColumnDetails";
            this.ColumnDetails.Visible = true;
            this.ColumnDetails.VisibleIndex = 8;
            this.ColumnDetails.Width = 139;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.GControlProductStock);
            this.xtraTabPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage2.ImageOptions.Image")));
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(906, 442);
            this.xtraTabPage2.Text = "DÜŞÜK STOK LİSTESİ";
            // 
            // GControlProductStock
            // 
            this.GControlProductStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GControlProductStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlProductStock.Location = new System.Drawing.Point(0, 0);
            this.GControlProductStock.MainView = this.GViewProductStock;
            this.GControlProductStock.Name = "GControlProductStock";
            this.GControlProductStock.Size = new System.Drawing.Size(906, 442);
            this.GControlProductStock.TabIndex = 1;
            this.GControlProductStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewProductStock});
            // 
            // GViewProductStock
            // 
            this.GViewProductStock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnProductName,
            this.gridColumnBlandName,
            this.gridColumnModelName,
            this.gridColumnModelYear,
            this.gridColumnProductPiece,
            this.gridColumnProductPrice,
            this.gridColumnProductSalePrice,
            this.gridColumnDetails});
            this.GViewProductStock.DetailHeight = 303;
            this.GViewProductStock.GridControl = this.GControlProductStock;
            this.GViewProductStock.Name = "GViewProductStock";
            this.GViewProductStock.OptionsBehavior.Editable = false;
            this.GViewProductStock.OptionsBehavior.ReadOnly = true;
            this.GViewProductStock.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "ProductID";
            this.gridColumnID.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnID.ImageOptions.Image")));
            this.gridColumnID.MinWidth = 10;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Visible = true;
            this.gridColumnID.VisibleIndex = 0;
            this.gridColumnID.Width = 58;
            // 
            // gridColumnProductName
            // 
            this.gridColumnProductName.Caption = "Ürün Adı";
            this.gridColumnProductName.FieldName = "ProductName";
            this.gridColumnProductName.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnProductName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnProductName.ImageOptions.Image")));
            this.gridColumnProductName.Name = "gridColumnProductName";
            this.gridColumnProductName.Visible = true;
            this.gridColumnProductName.VisibleIndex = 1;
            this.gridColumnProductName.Width = 158;
            // 
            // gridColumnBlandName
            // 
            this.gridColumnBlandName.Caption = "Marka Adı";
            this.gridColumnBlandName.FieldName = "BlandName";
            this.gridColumnBlandName.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnBlandName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnBlandName.ImageOptions.Image")));
            this.gridColumnBlandName.Name = "gridColumnBlandName";
            this.gridColumnBlandName.Visible = true;
            this.gridColumnBlandName.VisibleIndex = 2;
            this.gridColumnBlandName.Width = 106;
            // 
            // gridColumnModelName
            // 
            this.gridColumnModelName.Caption = "Model Adı";
            this.gridColumnModelName.FieldName = "ModelName";
            this.gridColumnModelName.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnModelName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnModelName.ImageOptions.Image")));
            this.gridColumnModelName.Name = "gridColumnModelName";
            this.gridColumnModelName.Visible = true;
            this.gridColumnModelName.VisibleIndex = 3;
            this.gridColumnModelName.Width = 105;
            // 
            // gridColumnModelYear
            // 
            this.gridColumnModelYear.Caption = "Model Yılı";
            this.gridColumnModelYear.FieldName = "ModelYear";
            this.gridColumnModelYear.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnModelYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnModelYear.ImageOptions.Image")));
            this.gridColumnModelYear.Name = "gridColumnModelYear";
            this.gridColumnModelYear.Visible = true;
            this.gridColumnModelYear.VisibleIndex = 4;
            this.gridColumnModelYear.Width = 98;
            // 
            // gridColumnProductPiece
            // 
            this.gridColumnProductPiece.Caption = "Ürün Adeti";
            this.gridColumnProductPiece.FieldName = "ProductPiece";
            this.gridColumnProductPiece.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnProductPiece.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnProductPiece.ImageOptions.Image")));
            this.gridColumnProductPiece.Name = "gridColumnProductPiece";
            this.gridColumnProductPiece.Visible = true;
            this.gridColumnProductPiece.VisibleIndex = 5;
            this.gridColumnProductPiece.Width = 96;
            // 
            // gridColumnProductPrice
            // 
            this.gridColumnProductPrice.Caption = "Alış Fiyati";
            this.gridColumnProductPrice.FieldName = "ProductPurchasePrice";
            this.gridColumnProductPrice.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnProductPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnProductPrice.ImageOptions.Image")));
            this.gridColumnProductPrice.Name = "gridColumnProductPrice";
            this.gridColumnProductPrice.Visible = true;
            this.gridColumnProductPrice.VisibleIndex = 6;
            this.gridColumnProductPrice.Width = 96;
            // 
            // gridColumnProductSalePrice
            // 
            this.gridColumnProductSalePrice.Caption = "Satış Fiyati";
            this.gridColumnProductSalePrice.FieldName = "ProductSalePrice";
            this.gridColumnProductSalePrice.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnProductSalePrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnProductSalePrice.ImageOptions.Image")));
            this.gridColumnProductSalePrice.Name = "gridColumnProductSalePrice";
            this.gridColumnProductSalePrice.Visible = true;
            this.gridColumnProductSalePrice.VisibleIndex = 7;
            this.gridColumnProductSalePrice.Width = 96;
            // 
            // gridColumnDetails
            // 
            this.gridColumnDetails.Caption = "Detaylar";
            this.gridColumnDetails.FieldName = "ProductDetails";
            this.gridColumnDetails.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnDetails.ImageOptions.Image")));
            this.gridColumnDetails.Name = "gridColumnDetails";
            this.gridColumnDetails.Visible = true;
            this.gridColumnDetails.VisibleIndex = 8;
            this.gridColumnDetails.Width = 164;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.GControlProductArchive);
            this.xtraTabPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabPage3.ImageOptions.Image")));
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(906, 442);
            this.xtraTabPage3.Text = "ÜRÜNLER ARŞİV LİSTESİ";
            // 
            // GControlProductArchive
            // 
            this.GControlProductArchive.Cursor = System.Windows.Forms.Cursors.Default;
            this.GControlProductArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlProductArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlProductArchive.MainView = this.GViewProductArchive;
            this.GControlProductArchive.Name = "GControlProductArchive";
            this.GControlProductArchive.Size = new System.Drawing.Size(906, 442);
            this.GControlProductArchive.TabIndex = 2;
            this.GControlProductArchive.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewProductArchive});
            // 
            // GViewProductArchive
            // 
            this.GViewProductArchive.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnPID,
            this.gridColumnPName,
            this.gridColumnBName,
            this.gridColumnMName,
            this.gridColumnMYear,
            this.gridColumPPiece,
            this.gridColumnPPrice,
            this.gridColumnSPrice,
            this.gridColumnPDetails});
            this.GViewProductArchive.DetailHeight = 303;
            this.GViewProductArchive.GridControl = this.GControlProductArchive;
            this.GViewProductArchive.Name = "GViewProductArchive";
            this.GViewProductArchive.OptionsBehavior.Editable = false;
            this.GViewProductArchive.OptionsBehavior.ReadOnly = true;
            this.GViewProductArchive.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumnPID
            // 
            this.gridColumnPID.Caption = "ID";
            this.gridColumnPID.FieldName = "ProductID";
            this.gridColumnPID.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnPID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnPID.ImageOptions.Image")));
            this.gridColumnPID.MinWidth = 10;
            this.gridColumnPID.Name = "gridColumnPID";
            this.gridColumnPID.Visible = true;
            this.gridColumnPID.VisibleIndex = 0;
            this.gridColumnPID.Width = 58;
            // 
            // gridColumnPName
            // 
            this.gridColumnPName.Caption = "Ürün Adı";
            this.gridColumnPName.FieldName = "ProductName";
            this.gridColumnPName.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnPName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnPName.ImageOptions.Image")));
            this.gridColumnPName.Name = "gridColumnPName";
            this.gridColumnPName.Visible = true;
            this.gridColumnPName.VisibleIndex = 1;
            this.gridColumnPName.Width = 158;
            // 
            // gridColumnBName
            // 
            this.gridColumnBName.Caption = "Marka Adı";
            this.gridColumnBName.FieldName = "BlandName";
            this.gridColumnBName.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnBName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnBName.ImageOptions.Image")));
            this.gridColumnBName.Name = "gridColumnBName";
            this.gridColumnBName.Visible = true;
            this.gridColumnBName.VisibleIndex = 2;
            this.gridColumnBName.Width = 106;
            // 
            // gridColumnMName
            // 
            this.gridColumnMName.Caption = "Model Adı";
            this.gridColumnMName.FieldName = "ModelName";
            this.gridColumnMName.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnMName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnMName.ImageOptions.Image")));
            this.gridColumnMName.Name = "gridColumnMName";
            this.gridColumnMName.Visible = true;
            this.gridColumnMName.VisibleIndex = 3;
            this.gridColumnMName.Width = 105;
            // 
            // gridColumnMYear
            // 
            this.gridColumnMYear.Caption = "Model Yılı";
            this.gridColumnMYear.FieldName = "ModelYear";
            this.gridColumnMYear.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnMYear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnMYear.ImageOptions.Image")));
            this.gridColumnMYear.Name = "gridColumnMYear";
            this.gridColumnMYear.Visible = true;
            this.gridColumnMYear.VisibleIndex = 4;
            this.gridColumnMYear.Width = 98;
            // 
            // gridColumPPiece
            // 
            this.gridColumPPiece.Caption = "Ürün Adeti";
            this.gridColumPPiece.FieldName = "ProductPiece";
            this.gridColumPPiece.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumPPiece.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumPPiece.ImageOptions.Image")));
            this.gridColumPPiece.Name = "gridColumPPiece";
            this.gridColumPPiece.Visible = true;
            this.gridColumPPiece.VisibleIndex = 5;
            this.gridColumPPiece.Width = 96;
            // 
            // gridColumnPPrice
            // 
            this.gridColumnPPrice.Caption = "Alış Fiyati";
            this.gridColumnPPrice.FieldName = "ProductPurchasePrice";
            this.gridColumnPPrice.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnPPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnPPrice.ImageOptions.Image")));
            this.gridColumnPPrice.Name = "gridColumnPPrice";
            this.gridColumnPPrice.Visible = true;
            this.gridColumnPPrice.VisibleIndex = 6;
            this.gridColumnPPrice.Width = 96;
            // 
            // gridColumnSPrice
            // 
            this.gridColumnSPrice.Caption = "Satış Fiyati";
            this.gridColumnSPrice.FieldName = "ProductSalePrice";
            this.gridColumnSPrice.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnSPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnSPrice.ImageOptions.Image")));
            this.gridColumnSPrice.Name = "gridColumnSPrice";
            this.gridColumnSPrice.Visible = true;
            this.gridColumnSPrice.VisibleIndex = 7;
            this.gridColumnSPrice.Width = 96;
            // 
            // gridColumnPDetails
            // 
            this.gridColumnPDetails.Caption = "Detaylar";
            this.gridColumnPDetails.FieldName = "ProductDetails";
            this.gridColumnPDetails.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
            this.gridColumnPDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnPDetails.ImageOptions.Image")));
            this.gridColumnPDetails.Name = "gridColumnPDetails";
            this.gridColumnPDetails.Visible = true;
            this.gridColumnPDetails.VisibleIndex = 8;
            this.gridColumnPDetails.Width = 164;
            // 
            // CustomerWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 486);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.accordionControl1);
            this.Name = "CustomerWF";
            this.Text = "CustomerWF";
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.TabPageProduct.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewProduct)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlProductStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewProductStock)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlProductArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewProductArchive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlNewCustomer;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlProductUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement3;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlProductArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlProductList;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage TabPageProduct;
        private DevExpress.XtraGrid.GridControl GControlProduct;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewProduct;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnProductID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnProductName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBland;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelYear;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnProductPiece;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPurchasePrice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDetails;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl GControlProductStock;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewProductStock;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBlandName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModelName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnModelYear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductPiece;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProductSalePrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDetails;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl GControlProductArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewProductArchive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnBName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMYear;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumPPiece;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPDetails;
    }
}