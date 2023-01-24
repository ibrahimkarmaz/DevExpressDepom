namespace PresentationLayer.WinFormList.CustomerMovementWF
{
    partial class CustomerMovementWF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMovementWF));
			this.ColumnTotalPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.accordionControlUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.accordionControlDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.SBtnCustomerInvoiceCreate = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
			this.simpleButton6 = new DevExpress.XtraEditors.SimpleButton();
			this.accordionControlAdd = new DevExpress.XtraBars.Navigation.AccordionControlElement();
			this.GControlCustomerMovementDetail = new DevExpress.XtraGrid.GridControl();
			this.GViewCustomerMovementDetail = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnProductName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnBlandName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnModelName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnPiece = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnPrice = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnProductID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.GroupControlFin = new DevExpress.XtraEditors.GroupControl();
			this.accordionControlProduct = new DevExpress.XtraBars.Navigation.AccordionControl();
			this.GroupControlCustomerMovement = new DevExpress.XtraEditors.GroupControl();
			this.SBtnCancel = new DevExpress.XtraEditors.SimpleButton();
			this.pictureEdit8 = new DevExpress.XtraEditors.PictureEdit();
			this.SBtnCustomerMovement = new DevExpress.XtraEditors.SimpleButton();
			this.MMENote = new DevExpress.XtraEditors.MemoEdit();
			this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
			this.BEEmployee = new DevExpress.XtraEditors.ButtonEdit();
			this.pictureEdit7 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
			this.BECustomer = new DevExpress.XtraEditors.ButtonEdit();
			this.pictureEdit17 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl17 = new DevExpress.XtraEditors.LabelControl();
			this.pictureEdit5 = new DevExpress.XtraEditors.PictureEdit();
			this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
			this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
			this.SBtnSave = new DevExpress.XtraEditors.SimpleButton();
			this.TECreateDate = new DevExpress.XtraEditors.DateEdit();
			((System.ComponentModel.ISupportInitialize)(this.GControlCustomerMovementDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GViewCustomerMovementDetail)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GroupControlFin)).BeginInit();
			this.GroupControlFin.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.accordionControlProduct)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GroupControlCustomerMovement)).BeginInit();
			this.GroupControlCustomerMovement.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.MMENote.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BEEmployee.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BECustomer.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit17.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TECreateDate.Properties.CalendarTimeProperties)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.TECreateDate.Properties)).BeginInit();
			this.SuspendLayout();
			// 
			// ColumnTotalPrice
			// 
			this.ColumnTotalPrice.Caption = "Toplam Fiyat";
			this.ColumnTotalPrice.FieldName = "CustomerMovementDetailTotalPrice";
			this.ColumnTotalPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnTotalPrice.ImageOptions.Image")));
			this.ColumnTotalPrice.Name = "ColumnTotalPrice";
			this.ColumnTotalPrice.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "CustomerMovementDetailTotalPrice", "Toplam={0:C2}")});
			this.ColumnTotalPrice.UnboundDataType = typeof(decimal);
			this.ColumnTotalPrice.Visible = true;
			this.ColumnTotalPrice.VisibleIndex = 6;
			// 
			// accordionControlUpdate
			// 
			this.accordionControlUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlUpdate.ImageOptions.Image")));
			this.accordionControlUpdate.Name = "accordionControlUpdate";
			this.accordionControlUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlUpdate.Text = "ÜRÜN ADET BİLGİSİNİ DÜZENLE";
			this.accordionControlUpdate.Click += new System.EventHandler(this.accordionControlUpdate_Click);
			// 
			// accordionControlDelete
			// 
			this.accordionControlDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlDelete.ImageOptions.Image")));
			this.accordionControlDelete.Name = "accordionControlDelete";
			this.accordionControlDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlDelete.Text = "ÜRÜN BİLGİLERİNİ SİL";
			this.accordionControlDelete.Click += new System.EventHandler(this.accordionControlDelete_Click);
			// 
			// SBtnCustomerInvoiceCreate
			// 
			this.SBtnCustomerInvoiceCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SBtnCustomerInvoiceCreate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBtnCustomerInvoiceCreate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnCustomerInvoiceCreate.ImageOptions.Image")));
			this.SBtnCustomerInvoiceCreate.Location = new System.Drawing.Point(762, 32);
			this.SBtnCustomerInvoiceCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBtnCustomerInvoiceCreate.Name = "SBtnCustomerInvoiceCreate";
			this.SBtnCustomerInvoiceCreate.Size = new System.Drawing.Size(214, 39);
			this.SBtnCustomerInvoiceCreate.TabIndex = 262;
			this.SBtnCustomerInvoiceCreate.Text = "Fatura Oluştur";
			this.SBtnCustomerInvoiceCreate.Click += new System.EventHandler(this.SBtnCustomerInvoiceCreate_Click);
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
			// accordionControlAdd
			// 
			this.accordionControlAdd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlAdd.ImageOptions.Image")));
			this.accordionControlAdd.Name = "accordionControlAdd";
			this.accordionControlAdd.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
			this.accordionControlAdd.Text = "YENİ ÜRÜN ";
			this.accordionControlAdd.Click += new System.EventHandler(this.accordionControlAdd_Click);
			// 
			// GControlCustomerMovementDetail
			// 
			this.GControlCustomerMovementDetail.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GControlCustomerMovementDetail.Enabled = false;
			this.GControlCustomerMovementDetail.Location = new System.Drawing.Point(250, 142);
			this.GControlCustomerMovementDetail.MainView = this.GViewCustomerMovementDetail;
			this.GControlCustomerMovementDetail.Name = "GControlCustomerMovementDetail";
			this.GControlCustomerMovementDetail.Size = new System.Drawing.Size(982, 286);
			this.GControlCustomerMovementDetail.TabIndex = 25;
			this.GControlCustomerMovementDetail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCustomerMovementDetail});
			// 
			// GViewCustomerMovementDetail
			// 
			this.GViewCustomerMovementDetail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnID,
            this.ColumnProductName,
            this.ColumnBlandName,
            this.ColumnModelName,
            this.ColumnPiece,
            this.ColumnPrice,
            this.ColumnTotalPrice,
            this.ColumnProductID});
			this.GViewCustomerMovementDetail.DetailHeight = 303;
			this.GViewCustomerMovementDetail.GridControl = this.GControlCustomerMovementDetail;
			this.GViewCustomerMovementDetail.Name = "GViewCustomerMovementDetail";
			this.GViewCustomerMovementDetail.OptionsBehavior.Editable = false;
			this.GViewCustomerMovementDetail.OptionsBehavior.ReadOnly = true;
			this.GViewCustomerMovementDetail.OptionsView.ShowFooter = true;
			this.GViewCustomerMovementDetail.OptionsView.ShowGroupPanel = false;
			// 
			// ColumnID
			// 
			this.ColumnID.Caption = "ID";
			this.ColumnID.FieldName = "CustomerMovementDetailID";
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
			this.ColumnPiece.FieldName = "CustomerMovementDetailPiece";
			this.ColumnPiece.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPiece.ImageOptions.Image")));
			this.ColumnPiece.Name = "ColumnPiece";
			this.ColumnPiece.Visible = true;
			this.ColumnPiece.VisibleIndex = 4;
			// 
			// ColumnPrice
			// 
			this.ColumnPrice.Caption = "Ürün Fiyati";
			this.ColumnPrice.FieldName = "CustomerMovementDetailPrice";
			this.ColumnPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPrice.ImageOptions.Image")));
			this.ColumnPrice.Name = "ColumnPrice";
			this.ColumnPrice.UnboundDataType = typeof(decimal);
			this.ColumnPrice.Visible = true;
			this.ColumnPrice.VisibleIndex = 5;
			// 
			// ColumnProductID
			// 
			this.ColumnProductID.Caption = "ProductID";
			this.ColumnProductID.FieldName = "ProductID";
			this.ColumnProductID.Name = "ColumnProductID";
			// 
			// GroupControlFin
			// 
			this.GroupControlFin.Controls.Add(this.SBtnCustomerInvoiceCreate);
			this.GroupControlFin.Controls.Add(this.simpleButton5);
			this.GroupControlFin.Controls.Add(this.simpleButton6);
			this.GroupControlFin.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GroupControlFin.Enabled = false;
			this.GroupControlFin.Location = new System.Drawing.Point(250, 428);
			this.GroupControlFin.Name = "GroupControlFin";
			this.GroupControlFin.Size = new System.Drawing.Size(982, 76);
			this.GroupControlFin.TabIndex = 24;
			this.GroupControlFin.Text = "SONUÇLANDIRMA İŞLEMLERİ";
			// 
			// accordionControlProduct
			// 
			this.accordionControlProduct.Cursor = System.Windows.Forms.Cursors.Hand;
			this.accordionControlProduct.Dock = System.Windows.Forms.DockStyle.Left;
			this.accordionControlProduct.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlAdd,
            this.accordionControlUpdate,
            this.accordionControlDelete});
			this.accordionControlProduct.Enabled = false;
			this.accordionControlProduct.Location = new System.Drawing.Point(0, 142);
			this.accordionControlProduct.Name = "accordionControlProduct";
			this.accordionControlProduct.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
			this.accordionControlProduct.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
			this.accordionControlProduct.Size = new System.Drawing.Size(250, 362);
			this.accordionControlProduct.TabIndex = 23;
			this.accordionControlProduct.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
			// 
			// GroupControlCustomerMovement
			// 
			this.GroupControlCustomerMovement.Controls.Add(this.SBtnCancel);
			this.GroupControlCustomerMovement.Controls.Add(this.pictureEdit8);
			this.GroupControlCustomerMovement.Controls.Add(this.SBtnCustomerMovement);
			this.GroupControlCustomerMovement.Controls.Add(this.MMENote);
			this.GroupControlCustomerMovement.Controls.Add(this.labelControl8);
			this.GroupControlCustomerMovement.Controls.Add(this.BEEmployee);
			this.GroupControlCustomerMovement.Controls.Add(this.pictureEdit7);
			this.GroupControlCustomerMovement.Controls.Add(this.labelControl7);
			this.GroupControlCustomerMovement.Controls.Add(this.BECustomer);
			this.GroupControlCustomerMovement.Controls.Add(this.pictureEdit17);
			this.GroupControlCustomerMovement.Controls.Add(this.labelControl17);
			this.GroupControlCustomerMovement.Controls.Add(this.pictureEdit5);
			this.GroupControlCustomerMovement.Controls.Add(this.labelControl5);
			this.GroupControlCustomerMovement.Controls.Add(this.SBCancel);
			this.GroupControlCustomerMovement.Controls.Add(this.SBtnSave);
			this.GroupControlCustomerMovement.Controls.Add(this.TECreateDate);
			this.GroupControlCustomerMovement.Dock = System.Windows.Forms.DockStyle.Top;
			this.GroupControlCustomerMovement.Location = new System.Drawing.Point(0, 0);
			this.GroupControlCustomerMovement.Name = "GroupControlCustomerMovement";
			this.GroupControlCustomerMovement.Size = new System.Drawing.Size(1232, 142);
			this.GroupControlCustomerMovement.TabIndex = 22;
			this.GroupControlCustomerMovement.Text = "MÜŞTERİ HAREKETLERİ";
			// 
			// SBtnCancel
			// 
			this.SBtnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SBtnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBtnCancel.Enabled = false;
			this.SBtnCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnCancel.ImageOptions.Image")));
			this.SBtnCancel.Location = new System.Drawing.Point(863, 32);
			this.SBtnCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBtnCancel.Name = "SBtnCancel";
			this.SBtnCancel.Size = new System.Drawing.Size(97, 23);
			this.SBtnCancel.TabIndex = 231;
			this.SBtnCancel.Text = "İptal Et";
			this.SBtnCancel.Click += new System.EventHandler(this.SBtnCancel_Click);
			// 
			// pictureEdit8
			// 
			this.pictureEdit8.EditValue = ((object)(resources.GetObject("pictureEdit8.EditValue")));
			this.pictureEdit8.Location = new System.Drawing.Point(442, 32);
			this.pictureEdit8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureEdit8.Name = "pictureEdit8";
			this.pictureEdit8.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit8.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit8.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit8.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit8.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit8.Size = new System.Drawing.Size(24, 25);
			this.pictureEdit8.TabIndex = 271;
			// 
			// SBtnCustomerMovement
			// 
			this.SBtnCustomerMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SBtnCustomerMovement.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBtnCustomerMovement.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnCustomerMovement.ImageOptions.Image")));
			this.SBtnCustomerMovement.Location = new System.Drawing.Point(968, 32);
			this.SBtnCustomerMovement.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBtnCustomerMovement.Name = "SBtnCustomerMovement";
			this.SBtnCustomerMovement.Size = new System.Drawing.Size(251, 23);
			this.SBtnCustomerMovement.TabIndex = 230;
			this.SBtnCustomerMovement.Text = "Müşteri Hareketi Oluştur";
			this.SBtnCustomerMovement.Click += new System.EventHandler(this.SBtnCustomerMovement_Click);
			// 
			// MMENote
			// 
			this.MMENote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.MMENote.EditValue = "";
			this.MMENote.Location = new System.Drawing.Point(442, 61);
			this.MMENote.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MMENote.Name = "MMENote";
			this.MMENote.Properties.NullText = "Firma Hareketleri İçin Bilgi Girebilirsiniz.";
			this.MMENote.Properties.NullValuePrompt = "Firma Hareketleri İçin Bilgi Girebilirsiniz.";
			this.MMENote.Properties.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
			this.MMENote.Size = new System.Drawing.Size(778, 73);
			this.MMENote.TabIndex = 269;
			// 
			// labelControl8
			// 
			this.labelControl8.Location = new System.Drawing.Point(481, 37);
			this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.labelControl8.Name = "labelControl8";
			this.labelControl8.Size = new System.Drawing.Size(22, 15);
			this.labelControl8.TabIndex = 270;
			this.labelControl8.Text = "Not:";
			// 
			// BEEmployee
			// 
			this.BEEmployee.EditValue = "";
			this.BEEmployee.Location = new System.Drawing.Point(105, 32);
			this.BEEmployee.Name = "BEEmployee";
			this.BEEmployee.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
			this.BEEmployee.Properties.NullText = "Personel Bilgisi Seçiniz";
			this.BEEmployee.Properties.NullValuePrompt = "Personel Bilgisi Seçiniz";
			this.BEEmployee.Properties.ReadOnly = true;
			this.BEEmployee.Size = new System.Drawing.Size(330, 30);
			this.BEEmployee.TabIndex = 266;
			this.BEEmployee.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BEEmployee_ButtonClick);
			this.BEEmployee.EditValueChanged += new System.EventHandler(this.BEEmployee_EditValueChanged);
			// 
			// pictureEdit7
			// 
			this.pictureEdit7.EditValue = ((object)(resources.GetObject("pictureEdit7.EditValue")));
			this.pictureEdit7.Location = new System.Drawing.Point(7, 32);
			this.pictureEdit7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureEdit7.Name = "pictureEdit7";
			this.pictureEdit7.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit7.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit7.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit7.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit7.Size = new System.Drawing.Size(24, 25);
			this.pictureEdit7.TabIndex = 268;
			// 
			// labelControl7
			// 
			this.labelControl7.Location = new System.Drawing.Point(46, 39);
			this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.labelControl7.Name = "labelControl7";
			this.labelControl7.Size = new System.Drawing.Size(52, 15);
			this.labelControl7.TabIndex = 267;
			this.labelControl7.Text = "Personel:";
			// 
			// BECustomer
			// 
			this.BECustomer.Location = new System.Drawing.Point(105, 68);
			this.BECustomer.Name = "BECustomer";
			this.BECustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search)});
			this.BECustomer.Properties.NullText = "Müşteri Bilgisini Seçiniz.";
			this.BECustomer.Properties.NullValuePrompt = "Müşteri Bilgisini Seçiniz.";
			this.BECustomer.Properties.ReadOnly = true;
			this.BECustomer.Size = new System.Drawing.Size(330, 30);
			this.BECustomer.TabIndex = 259;
			this.BECustomer.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BECustomer_ButtonClick);
			// 
			// pictureEdit17
			// 
			this.pictureEdit17.EditValue = ((object)(resources.GetObject("pictureEdit17.EditValue")));
			this.pictureEdit17.Location = new System.Drawing.Point(7, 68);
			this.pictureEdit17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureEdit17.Name = "pictureEdit17";
			this.pictureEdit17.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit17.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit17.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit17.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit17.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit17.Size = new System.Drawing.Size(24, 25);
			this.pictureEdit17.TabIndex = 265;
			// 
			// labelControl17
			// 
			this.labelControl17.Location = new System.Drawing.Point(46, 75);
			this.labelControl17.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.labelControl17.Name = "labelControl17";
			this.labelControl17.Size = new System.Drawing.Size(44, 15);
			this.labelControl17.TabIndex = 264;
			this.labelControl17.Text = "Müşteri:";
			// 
			// pictureEdit5
			// 
			this.pictureEdit5.EditValue = ((object)(resources.GetObject("pictureEdit5.EditValue")));
			this.pictureEdit5.Location = new System.Drawing.Point(6, 108);
			this.pictureEdit5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.pictureEdit5.Name = "pictureEdit5";
			this.pictureEdit5.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
			this.pictureEdit5.Properties.Appearance.Options.UseBackColor = true;
			this.pictureEdit5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
			this.pictureEdit5.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
			this.pictureEdit5.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
			this.pictureEdit5.Size = new System.Drawing.Size(24, 25);
			this.pictureEdit5.TabIndex = 263;
			// 
			// labelControl5
			// 
			this.labelControl5.Location = new System.Drawing.Point(46, 111);
			this.labelControl5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.labelControl5.Name = "labelControl5";
			this.labelControl5.Size = new System.Drawing.Size(31, 15);
			this.labelControl5.TabIndex = 262;
			this.labelControl5.Text = "Tarih:";
			// 
			// SBCancel
			// 
			this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
			this.SBCancel.Location = new System.Drawing.Point(562, 292);
			this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBCancel.Name = "SBCancel";
			this.SBCancel.Size = new System.Drawing.Size(97, 39);
			this.SBCancel.TabIndex = 261;
			this.SBCancel.Text = "İptal Et";
			// 
			// SBtnSave
			// 
			this.SBtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSave.ImageOptions.Image")));
			this.SBtnSave.Location = new System.Drawing.Point(665, 292);
			this.SBtnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBtnSave.Name = "SBtnSave";
			this.SBtnSave.Size = new System.Drawing.Size(130, 39);
			this.SBtnSave.TabIndex = 260;
			this.SBtnSave.Text = "Kaydet";
			// 
			// TECreateDate
			// 
			this.TECreateDate.EditValue = null;
			this.TECreateDate.Location = new System.Drawing.Point(105, 104);
			this.TECreateDate.Name = "TECreateDate";
			this.TECreateDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.TECreateDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
			this.TECreateDate.Properties.DisplayFormat.FormatString = "";
			this.TECreateDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.TECreateDate.Properties.EditFormat.FormatString = "";
			this.TECreateDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
			this.TECreateDate.Properties.MaskSettings.Set("mask", "");
			this.TECreateDate.Properties.NullText = "Tarih Seçiniz";
			this.TECreateDate.Properties.NullValuePrompt = "Tarih Seçiniz";
			this.TECreateDate.Size = new System.Drawing.Size(330, 30);
			this.TECreateDate.TabIndex = 258;
			// 
			// CustomerMovementWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1232, 504);
			this.Controls.Add(this.GControlCustomerMovementDetail);
			this.Controls.Add(this.GroupControlFin);
			this.Controls.Add(this.accordionControlProduct);
			this.Controls.Add(this.GroupControlCustomerMovement);
			this.Name = "CustomerMovementWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MÜŞTERİ HAREKETLERİ";
			this.Load += new System.EventHandler(this.CustomerMovementWF_Load);
			((System.ComponentModel.ISupportInitialize)(this.GControlCustomerMovementDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GViewCustomerMovementDetail)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GroupControlFin)).EndInit();
			this.GroupControlFin.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.accordionControlProduct)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GroupControlCustomerMovement)).EndInit();
			this.GroupControlCustomerMovement.ResumeLayout(false);
			this.GroupControlCustomerMovement.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit8.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.MMENote.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BEEmployee.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit7.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BECustomer.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit17.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureEdit5.Properties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TECreateDate.Properties.CalendarTimeProperties)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.TECreateDate.Properties)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn ColumnTotalPrice;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlDelete;
        private DevExpress.XtraEditors.SimpleButton SBtnCustomerInvoiceCreate;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton6;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlAdd;
        private DevExpress.XtraGrid.GridControl GControlCustomerMovementDetail;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCustomerMovementDetail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnProductName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBlandName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPiece;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPrice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnProductID;
        private DevExpress.XtraEditors.GroupControl GroupControlFin;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControlProduct;
        private DevExpress.XtraEditors.GroupControl GroupControlCustomerMovement;
        private DevExpress.XtraEditors.SimpleButton SBtnCancel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit8;
        private DevExpress.XtraEditors.SimpleButton SBtnCustomerMovement;
        private DevExpress.XtraEditors.MemoEdit MMENote;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.ButtonEdit BEEmployee;
        private DevExpress.XtraEditors.PictureEdit pictureEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ButtonEdit BECustomer;
        private DevExpress.XtraEditors.PictureEdit pictureEdit17;
        private DevExpress.XtraEditors.LabelControl labelControl17;
        private DevExpress.XtraEditors.PictureEdit pictureEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnSave;
        private DevExpress.XtraEditors.DateEdit TECreateDate;
    }
}