namespace PresentationLayer.WinFormList
{
    partial class BlandTypeList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlandTypeList));
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandNew = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlBlandArchiveList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlElement7 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelNew = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlModelList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.GViewBland = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnBlandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBlandName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GControlBland = new DevExpress.XtraGrid.GridControl();
            this.GControlModel = new DevExpress.XtraGrid.GridControl();
            this.GViewModel = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnModelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnModelYear = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewModel)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.accordionControlBlandList,
            this.accordionControlBlandArchiveList});
            this.accordionControlElement1.Expanded = true;
            this.accordionControlElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlElement1.ImageOptions.Image")));
            this.accordionControlElement1.Name = "accordionControlElement1";
            this.accordionControlElement1.Text = "MARKA İŞLEMLERİ";
            // 
            // accordionControlBlandNew
            // 
            this.accordionControlBlandNew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandNew.ImageOptions.Image")));
            this.accordionControlBlandNew.Name = "accordionControlBlandNew";
            this.accordionControlBlandNew.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandNew.Text = "YENİ MARKA";
            this.accordionControlBlandNew.Click += new System.EventHandler(this.accordionControlBlandNew_Click_1);
            // 
            // accordionControlBlandUpdate
            // 
            this.accordionControlBlandUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandUpdate.ImageOptions.Image")));
            this.accordionControlBlandUpdate.Name = "accordionControlBlandUpdate";
            this.accordionControlBlandUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandUpdate.Text = "MARKA BİLGİSİNİ DÜZENLE";
            this.accordionControlBlandUpdate.Click += new System.EventHandler(this.accordionControlBlandUpdate_Click);
            // 
            // accordionControlBlandDelete
            // 
            this.accordionControlBlandDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandDelete.ImageOptions.Image")));
            this.accordionControlBlandDelete.Name = "accordionControlBlandDelete";
            this.accordionControlBlandDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandDelete.Text = "MARKA BİLGİSİNİ SİL";
            this.accordionControlBlandDelete.Click += new System.EventHandler(this.accordionControlBlandDelete_Click);
            // 
            // accordionControlBlandArchive
            // 
            this.accordionControlBlandArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandArchive.ImageOptions.Image")));
            this.accordionControlBlandArchive.Name = "accordionControlBlandArchive";
            this.accordionControlBlandArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandArchive.Text = "MARKA BİLGİSİNİ ARŞİVLE";
            this.accordionControlBlandArchive.Click += new System.EventHandler(this.accordionControlBlandArchive_Click);
            // 
            // accordionControlBlandList
            // 
            this.accordionControlBlandList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandList.ImageOptions.Image")));
            this.accordionControlBlandList.Name = "accordionControlBlandList";
            this.accordionControlBlandList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandList.Text = "MARKA LİSTESİ";
            this.accordionControlBlandList.Click += new System.EventHandler(this.accordionControlBlandList_Click);
            // 
            // accordionControlBlandArchiveList
            // 
            this.accordionControlBlandArchiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlBlandArchiveList.ImageOptions.Image")));
            this.accordionControlBlandArchiveList.Name = "accordionControlBlandArchiveList";
            this.accordionControlBlandArchiveList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlBlandArchiveList.Text = "MARKA ARŞİV LİSTESİ";
            this.accordionControlBlandArchiveList.Click += new System.EventHandler(this.accordionControlBlandArchiveList_Click);
            // 
            // accordionControlElement7
            // 
            this.accordionControlElement7.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlModelNew,
            this.accordionControlModelUpdate,
            this.accordionControlModelDelete,
            this.accordionControlModelArchive,
            this.accordionControlModelList,
            this.accordionControlArchive});
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
            this.accordionControlModelNew.Text = "YENİ MODEL";
            this.accordionControlModelNew.Click += new System.EventHandler(this.accordionControlModelNew_Click);
            // 
            // accordionControlModelUpdate
            // 
            this.accordionControlModelUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelUpdate.ImageOptions.Image")));
            this.accordionControlModelUpdate.Name = "accordionControlModelUpdate";
            this.accordionControlModelUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelUpdate.Text = "MODEL BİLGİLERİNİ DÜZENLE";
            this.accordionControlModelUpdate.Click += new System.EventHandler(this.accordionControlModelUpdate_Click);
            // 
            // accordionControlModelDelete
            // 
            this.accordionControlModelDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelDelete.ImageOptions.Image")));
            this.accordionControlModelDelete.Name = "accordionControlModelDelete";
            this.accordionControlModelDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelDelete.Text = "MODEL BİLGİLERİNİ SİL";
            this.accordionControlModelDelete.Click += new System.EventHandler(this.accordionControlModelDelete_Click);
            // 
            // accordionControlModelArchive
            // 
            this.accordionControlModelArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelArchive.ImageOptions.Image")));
            this.accordionControlModelArchive.Name = "accordionControlModelArchive";
            this.accordionControlModelArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelArchive.Text = "MODEL BİLGİLERİNİ ARŞİVLE";
            this.accordionControlModelArchive.Click += new System.EventHandler(this.accordionControlModelArchive_Click);
            // 
            // accordionControlModelList
            // 
            this.accordionControlModelList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlModelList.ImageOptions.Image")));
            this.accordionControlModelList.Name = "accordionControlModelList";
            this.accordionControlModelList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlModelList.Text = "MODEL LİSTESİ";
            this.accordionControlModelList.Click += new System.EventHandler(this.accordionControlModelList_Click);
            // 
            // accordionControlArchive
            // 
            this.accordionControlArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchive.ImageOptions.Image")));
            this.accordionControlArchive.Name = "accordionControlArchive";
            this.accordionControlArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlArchive.Text = "MODEL ARŞİV LİSTESİ";
            this.accordionControlArchive.Click += new System.EventHandler(this.accordionControlArchive_Click);
            // 
            // GViewBland
            // 
            this.GViewBland.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnBlandID,
            this.ColumnBlandName});
            this.GViewBland.GridControl = this.GControlBland;
            this.GViewBland.Name = "GViewBland";
            this.GViewBland.OptionsView.ShowGroupPanel = false;
            this.GViewBland.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GViewBland_RowClick);
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
            this.GControlModel.MainView = this.GViewModel;
            this.GControlModel.Name = "GControlModel";
            this.GControlModel.Size = new System.Drawing.Size(519, 417);
            this.GControlModel.TabIndex = 4;
            this.GControlModel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewModel});
            // 
            // GViewModel
            // 
            this.GViewModel.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnModelID,
            this.ColumnModelName,
            this.ColumnModelYear});
            this.GViewModel.GridControl = this.GControlModel;
            this.GViewModel.Name = "GViewModel";
            this.GViewModel.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnModelID
            // 
            this.ColumnModelID.Caption = "Model ID";
            this.ColumnModelID.FieldName = "ModelID";
            this.ColumnModelID.Name = "ColumnModelID";
            this.ColumnModelID.Visible = true;
            this.ColumnModelID.VisibleIndex = 0;
            this.ColumnModelID.Width = 97;
            // 
            // ColumnModelName
            // 
            this.ColumnModelName.Caption = "Model Adı";
            this.ColumnModelName.FieldName = "ModelName";
            this.ColumnModelName.Name = "ColumnModelName";
            this.ColumnModelName.Visible = true;
            this.ColumnModelName.VisibleIndex = 1;
            this.ColumnModelName.Width = 194;
            // 
            // ColumnModelYear
            // 
            this.ColumnModelYear.Caption = "Model Yılı";
            this.ColumnModelYear.FieldName = "ModelYear";
            this.ColumnModelYear.Name = "ColumnModelYear";
            this.ColumnModelYear.Visible = true;
            this.ColumnModelYear.VisibleIndex = 2;
            this.ColumnModelYear.Width = 198;
            // 
            // BlandTypeList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 417);
            this.Controls.Add(this.GControlModel);
            this.Controls.Add(this.GControlBland);
            this.Controls.Add(this.accordionControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BlandTypeList";
            this.Text = "ÜRÜN TÜRÜ";
            this.Load += new System.EventHandler(this.ProductTypeList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewModel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
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
        private DevExpress.XtraGrid.Views.Grid.GridView GViewModel;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBlandID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBlandName;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBlandNew;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlBlandArchiveList;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelYear;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchive;
    }
}