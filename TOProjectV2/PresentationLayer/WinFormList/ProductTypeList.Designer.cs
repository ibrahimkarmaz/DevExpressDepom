namespace PresentationLayer.WinFormList
{
    partial class ProductTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductTypeList));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandNew = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelNew = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.GViewBland = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GControlBland = new DevExpress.XtraGrid.GridControl();
            this.GControlModel = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnBlandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBlandName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlElement1,
            this.accordionControlElement7});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(260, 417);
            this.accordionControl1.TabIndex = 1;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            this.accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlBlandNew,
            this.accordionControlBlandUpdate,
            this.accordionControlBlandDelete,
            this.accordionControlBlandArchive,
            this.accordionControlBlandList});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "Marka İşlemleri";
            // 
            // accordionControlBlandNew
            // 
            this.accordionControlBlandNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandNew.ImageOptions.Image")));
            this.accordionControlBlandNew.Name = "accordionControlBlandNew";
            this.accordionControlBlandNew.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandNew.Text = "Yeni Tür";
            // 
            // accordionControlBlandUpdate
            // 
            this.accordionControlBlandUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandUpdate.ImageOptions.Image")));
            this.accordionControlBlandUpdate.Name = "accordionControlBlandUpdate";
            this.accordionControlBlandUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandUpdate.Text = "Tür Bilgisini Düzenle";
            // 
            // accordionControlBlandDelete
            // 
            this.accordionControlBlandDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandDelete.ImageOptions.Image")));
            this.accordionControlBlandDelete.Name = "accordionControlBlandDelete";
            this.accordionControlBlandDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandDelete.Text = "Tür Bilgisini Sil";
            // 
            // accordionControlBlandArchive
            // 
            this.accordionControlBlandArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandArchive.ImageOptions.Image")));
            this.accordionControlBlandArchive.Name = "accordionControlBlandArchive";
            this.accordionControlBlandArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandArchive.Text = "Tür Bilgisini Arşivle";
            // 
            // accordionControlBlandList
            // 
            this.accordionControlBlandList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandList.ImageOptions.Image")));
            this.accordionControlBlandList.Name = "accordionControlBlandList";
            this.accordionControlBlandList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandList.Text = "Tür Listesi";
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlModelNew,
            this.accordionControlModelUpdate,
            this.accordionControlModelDelete,
            this.accordionControlModelArchive,
            this.accordionControlModelList});
            this.accordionControlElement7.Expanded = true;
            this.accordionControlElement7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement7.ImageOptions.Image")));
            this.accordionControlElement7.Name = "accordionControlElement7";
            this.accordionControlElement7.Text = "Model İşlemleri";
            // 
            // accordionControlModelNew
            // 
            this.accordionControlModelNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelNew.ImageOptions.Image")));
            this.accordionControlModelNew.Name = "accordionControlModelNew";
            this.accordionControlModelNew.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelNew.Text = "Yeni Model";
            // 
            // accordionControlModelUpdate
            // 
            this.accordionControlModelUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelUpdate.ImageOptions.Image")));
            this.accordionControlModelUpdate.Name = "accordionControlModelUpdate";
            this.accordionControlModelUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelUpdate.Text = "Model Bilgilerini Düzenle";
            // 
            // accordionControlModelDelete
            // 
            this.accordionControlModelDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelDelete.ImageOptions.Image")));
            this.accordionControlModelDelete.Name = "accordionControlModelDelete";
            this.accordionControlModelDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelDelete.Text = "Model Bilgilerini Sil";
            // 
            // accordionControlModelArchive
            // 
            this.accordionControlModelArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelArchive.ImageOptions.Image")));
            this.accordionControlModelArchive.Name = "accordionControlModelArchive";
            this.accordionControlModelArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelArchive.Text = "Model Bilgilerini Arşivle";
            // 
            // accordionControlModelList
            // 
            this.accordionControlModelList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelList.ImageOptions.Image")));
            this.accordionControlModelList.Name = "accordionControlModelList";
            this.accordionControlModelList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelList.Text = "Model Listesi";
            // 
            // GViewBland
            // 
            this.GViewBland.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnBlandID,
            this.ColumnBlandName});
            this.GViewBland.GridControl = this.GControlBland;
            this.GViewBland.Name = "GViewBland";
            this.GViewBland.OptionsView.ShowGroupPanel = false;
            // 
            // GControlBland
            // 
            this.GControlBland.Dock = System.Windows.Forms.DockStyle.Left;
            this.GControlBland.Location = new System.Drawing.Point(260, 0);
            this.GControlBland.MainView = this.GViewBland;
            this.GControlBland.Name = "GControlBland";
            this.GControlBland.Size = new System.Drawing.Size(378, 417);
            this.GControlBland.TabIndex = 3;
            this.GControlBland.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewBland});
            // 
            // GControlModel
            // 
            this.GControlModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlModel.Location = new System.Drawing.Point(638, 0);
            this.GControlModel.MainView = this.gridView2;
            this.GControlModel.Name = "GControlModel";
            this.GControlModel.Size = new System.Drawing.Size(519, 417);
            this.GControlModel.TabIndex = 4;
            this.GControlModel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.GridControl = this.GControlModel;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnBlandID
            // 
            this.ColumnBlandID.Caption = "Marka ID";
            this.ColumnBlandID.FieldName = "BlandID";
            this.ColumnBlandID.Name = "ColumnBlandID";
            this.ColumnBlandID.Visible = true;
            this.ColumnBlandID.VisibleIndex = 0;
            this.ColumnBlandID.Width = 85;
            // 
            // ColumnBlandName
            // 
            this.ColumnBlandName.Caption = "Marka Adı";
            this.ColumnBlandName.FieldName = "BlandName";
            this.ColumnBlandName.Name = "ColumnBlandName";
            this.ColumnBlandName.Visible = true;
            this.ColumnBlandName.VisibleIndex = 1;
            this.ColumnBlandName.Width = 263;
            // 
            // ProductTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 417);
            this.Controls.Add(this.GControlModel);
            this.Controls.Add(this.GControlBland);
            this.Controls.Add(this.accordionControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ProductTypeList";
            this.Text = "ÜRÜN TÜRÜ";
            this.Load += new System.EventHandler(this.ProductTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBlandNew;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBlandUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBlandDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBlandArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBlandList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement7;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlModelNew;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlModelUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlModelDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlModelArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlModelList;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewBland;
        private DevExpress.XtraGrid.GridControl GControlBland;
        private DevExpress.XtraGrid.GridControl GControlModel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBlandID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBlandName;
    }
}