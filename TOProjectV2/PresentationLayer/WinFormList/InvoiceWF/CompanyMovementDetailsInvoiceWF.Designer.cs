namespace PresentationLayer.WinFormList.InvoiceWF
{
    partial class CompanyMovementDetailsInvoiceWF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanyMovementDetailsInvoiceWF));
			this.GroupControlFin = new DevExpress.XtraEditors.GroupControl();
			this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
			this.SBtnInvoiceShow = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
			this.GControlCompanyMovementDetail = new DevExpress.XtraGrid.GridControl();
			this.GViewCompanyMovementDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnProductName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnBlandName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnModelName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnPiece = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnProductID = new DevExpress.XtraGrid.Columns.GridColumn();
			((System.ComponentModel.ISupportInitialize)(this.GroupControlFin)).BeginInit();
			this.GroupControlFin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GControlCompanyMovementDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GViewCompanyMovementDetail)).BeginInit();
			this.SuspendLayout();
			// 
			// GroupControlFin
			// 
			this.GroupControlFin.Controls.Add(this.SBCancel);
			this.GroupControlFin.Controls.Add(this.SBtnInvoiceShow);
			this.GroupControlFin.Controls.Add(this.simpleButton5);
			this.GroupControlFin.Controls.Add(this.simpleButton6);
			this.GroupControlFin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GroupControlFin.Location = new System.Drawing.Point(0, 389);
			this.GroupControlFin.Name = "GroupControlFin";
			this.GroupControlFin.Size = new System.Drawing.Size(1058, 76);
			this.GroupControlFin.TabIndex = 23;
			this.GroupControlFin.Text = "FATURA İŞLEMLERİ";
			// 
			// SBCancel
			// 
			this.SBCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
			this.SBCancel.Location = new System.Drawing.Point(733, 32);
			this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBCancel.Name = "SBCancel";
			this.SBCancel.Size = new System.Drawing.Size(97, 39);
			this.SBCancel.TabIndex = 263;
			this.SBCancel.Text = "İptal Et";
			this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
			// 
			// SBtnInvoiceShow
			// 
			this.SBtnInvoiceShow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SBtnInvoiceShow.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBtnInvoiceShow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnInvoiceCreate.ImageOptions.Image")));
			this.SBtnInvoiceShow.Location = new System.Drawing.Point(838, 32);
			this.SBtnInvoiceShow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBtnInvoiceShow.Name = "SBtnInvoiceShow";
			this.SBtnInvoiceShow.Size = new System.Drawing.Size(214, 39);
			this.SBtnInvoiceShow.TabIndex = 262;
			this.SBtnInvoiceShow.Text = "Fatura Göster";
			this.SBtnInvoiceShow.Click += new System.EventHandler(this.SBtnInvoiceCreate_Click);
			// 
			// simpleButton5
			// 
			this.simpleButton5.Cursor = System.Windows.Forms.Cursors.Hand;
			this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
			this.simpleButton5.Location = new System.Drawing.Point(562, 292);
			this.simpleButton5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.simpleButton5.Name = "simpleButton5";
			this.simpleButton5.Size = new System.Drawing.Size(97, 39);
			this.simpleButton5.TabIndex = 261;
			this.simpleButton5.Text = "İptal Et";
			// 
			// simpleButton6
			// 
			this.simpleButton6.Cursor = System.Windows.Forms.Cursors.Hand;
			this.simpleButton6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
			this.simpleButton6.Location = new System.Drawing.Point(665, 292);
			this.simpleButton6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.simpleButton6.Name = "simpleButton6";
			this.simpleButton6.Size = new System.Drawing.Size(130, 39);
			this.simpleButton6.TabIndex = 260;
			this.simpleButton6.Text = "Kaydet";
			// 
			// GControlCompanyMovementDetail
			// 
			this.GControlCompanyMovementDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GControlCompanyMovementDetail.Location = new System.Drawing.Point(0, 0);
			this.GControlCompanyMovementDetail.MainView = this.GViewCompanyMovementDetail;
			this.GControlCompanyMovementDetail.Name = "GControlCompanyMovementDetail";
			this.GControlCompanyMovementDetail.Size = new System.Drawing.Size(1058, 389);
			this.GControlCompanyMovementDetail.TabIndex = 24;
			this.GControlCompanyMovementDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCompanyMovementDetail});
			// 
			// GViewCompanyMovementDetail
			// 
			this.GViewCompanyMovementDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnID,
            this.ColumnProductName,
            this.ColumnBlandName,
            this.ColumnModelName,
            this.ColumnPiece,
            this.ColumnPrice,
            this.ColumnTotalPrice,
            this.ColumnProductID});
			this.GViewCompanyMovementDetail.DetailHeight = 303;
			this.GViewCompanyMovementDetail.GridControl = this.GControlCompanyMovementDetail;
			this.GViewCompanyMovementDetail.Name = "GViewCompanyMovementDetail";
			this.GViewCompanyMovementDetail.OptionsBehavior.Editable = false;
			this.GViewCompanyMovementDetail.OptionsBehavior.ReadOnly = true;
			this.GViewCompanyMovementDetail.OptionsView.ShowFooter = true;
			this.GViewCompanyMovementDetail.OptionsView.ShowGroupPanel = false;
			// 
			// ColumnID
			// 
			this.ColumnID.Caption = "ID";
			this.ColumnID.FieldName = "CompanyMovementDetailID";
			this.ColumnID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnID.ImageOptions.Image")));
			this.ColumnID.Name = "ColumnID";
			this.ColumnID.Visible = true;
			this.ColumnID.VisibleIndex = 0;
			// 
			// ColumnProductName
			// 
			this.ColumnProductName.Caption = "Ürün Adı";
			this.ColumnProductName.FieldName = "ProductName";
			this.ColumnProductName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnProductName.ImageOptions.Image")));
			this.ColumnProductName.Name = "ColumnProductName";
			this.ColumnProductName.Visible = true;
			this.ColumnProductName.VisibleIndex = 1;
			// 
			// ColumnBlandName
			// 
			this.ColumnBlandName.Caption = "Marka Adı";
			this.ColumnBlandName.FieldName = "BlandName";
			this.ColumnBlandName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBlandName.ImageOptions.Image")));
			this.ColumnBlandName.Name = "ColumnBlandName";
			this.ColumnBlandName.Visible = true;
			this.ColumnBlandName.VisibleIndex = 2;
			// 
			// ColumnModelName
			// 
			this.ColumnModelName.Caption = "Model Adı";
			this.ColumnModelName.FieldName = "ModelName";
			this.ColumnModelName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnModelName.ImageOptions.Image")));
			this.ColumnModelName.Name = "ColumnModelName";
			this.ColumnModelName.Visible = true;
			this.ColumnModelName.VisibleIndex = 3;
			// 
			// ColumnPiece
			// 
			this.ColumnPiece.Caption = "Adet";
			this.ColumnPiece.FieldName = "CompanyMovementDetailPiece";
			this.ColumnPiece.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPiece.ImageOptions.Image")));
			this.ColumnPiece.Name = "ColumnPiece";
			this.ColumnPiece.Visible = true;
			this.ColumnPiece.VisibleIndex = 4;
			// 
			// ColumnPrice
			// 
			this.ColumnPrice.Caption = "Ürün Fiyati";
			this.ColumnPrice.FieldName = "CompanyMovementDetailPrice";
			this.ColumnPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPrice.ImageOptions.Image")));
			this.ColumnPrice.Name = "ColumnPrice";
			this.ColumnPrice.UnboundDataType = typeof(decimal);
			this.ColumnPrice.Visible = true;
			this.ColumnPrice.VisibleIndex = 5;
			// 
			// ColumnTotalPrice
			// 
			this.ColumnTotalPrice.Caption = "Toplam Fiyat";
			this.ColumnTotalPrice.FieldName = "CompanyMovementDetailTotalPrice";
			this.ColumnTotalPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnTotalPrice.ImageOptions.Image")));
			this.ColumnTotalPrice.Name = "ColumnTotalPrice";
			this.ColumnTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CompanyMovementDetailTotalPrice", "Toplam={0:C2}")});
			this.ColumnTotalPrice.UnboundDataType = typeof(decimal);
			this.ColumnTotalPrice.Visible = true;
			this.ColumnTotalPrice.VisibleIndex = 6;
			// 
			// ColumnProductID
			// 
			this.ColumnProductID.Caption = "ProductID";
			this.ColumnProductID.FieldName = "ProductID";
			this.ColumnProductID.Name = "ColumnProductID";
			// 
			// CompanyMovementDetailsInvoiceWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1058, 465);
			this.Controls.Add(this.GControlCompanyMovementDetail);
			this.Controls.Add(this.GroupControlFin);
			this.Name = "CompanyMovementDetailsInvoiceWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FİRMA HAREKET DETAYLARI";
			this.Load += new System.EventHandler(this.CompanyMovementDetailsInvoiceWF_Load);
			((System.ComponentModel.ISupportInitialize)(this.GroupControlFin)).EndInit();
			this.GroupControlFin.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.GControlCompanyMovementDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GViewCompanyMovementDetail)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupControlFin;
        private DevExpress.XtraEditors.SimpleButton SBtnInvoiceShow;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraGrid.GridControl GControlCompanyMovementDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCompanyMovementDetail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnProductName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBlandName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPiece;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnTotalPrice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnProductID;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
    }
}