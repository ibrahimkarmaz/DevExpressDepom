namespace PresentationLayer.WinFormList.ProductStockWF
{
	partial class ProductStocksWF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductStocksWF));
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
			this.GControlProductStock = new DevExpress.XtraGrid.GridControl();
			((System.ComponentModel.ISupportInitialize)(this.GViewProductStock)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GControlProductStock)).BeginInit();
			this.SuspendLayout();
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
			this.GViewProductStock.DoubleClick += new System.EventHandler(this.GViewProductStock_DoubleClick);
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
			// GControlProductStock
			// 
			this.GControlProductStock.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.GControlProductStock.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GControlProductStock.Location = new System.Drawing.Point(0, 0);
			this.GControlProductStock.MainView = this.GViewProductStock;
			this.GControlProductStock.Name = "GControlProductStock";
			this.GControlProductStock.Size = new System.Drawing.Size(1140, 470);
			this.GControlProductStock.TabIndex = 2;
			this.GControlProductStock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewProductStock});
			// 
			// ProductStocksWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1140, 470);
			this.Controls.Add(this.GControlProductStock);
			this.Name = "ProductStocksWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ÜRÜN AZALAN STOK BİLGİSİ";
			this.Load += new System.EventHandler(this.ProductStocksWF_Load);
			((System.ComponentModel.ISupportInitialize)(this.GViewProductStock)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GControlProductStock)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

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
		private DevExpress.XtraGrid.GridControl GControlProductStock;
	}
}