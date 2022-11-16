namespace PresentationLayer.WinFormList.ProductWF
{
    partial class ProductSelectWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSelectWF));
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSelect = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.GControlProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // SBCancel
            // 
            this.SBCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(740, 391);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(100, 40);
            this.SBCancel.TabIndex = 21;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnSelect
            // 
            this.SBtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSelect.ImageOptions.Image")));
            this.SBtnSelect.Location = new System.Drawing.Point(848, 391);
            this.SBtnSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSelect.Name = "SBtnSelect";
            this.SBtnSelect.Size = new System.Drawing.Size(150, 40);
            this.SBtnSelect.TabIndex = 20;
            this.SBtnSelect.Text = "Personel Seç";
            this.SBtnSelect.Click += new System.EventHandler(this.SBtnSelect_Click);
            // 
            // GControlProduct
            // 
            this.GControlProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GControlProduct.Location = new System.Drawing.Point(12, 12);
            this.GControlProduct.MainView = this.GViewProduct;
            this.GControlProduct.Name = "GControlProduct";
            this.GControlProduct.Size = new System.Drawing.Size(986, 373);
            this.GControlProduct.TabIndex = 22;
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
            this.GViewProduct.DoubleClick += new System.EventHandler(this.GViewProduct_DoubleClick);
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
            // ProductSelectWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 443);
            this.Controls.Add(this.GControlProduct);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnSelect);
            this.Name = "ProductSelectWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PERSONEL SEÇİN";
            this.Load += new System.EventHandler(this.ProductSelectWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnSelect;
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
    }
}