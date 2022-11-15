namespace PresentationLayer.WinFormList.EmployeeWF
{
    partial class EmployeeSelectWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeSelectWF));
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSelect = new DevExpress.XtraEditors.SimpleButton();
            this.GControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.GViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnSurName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutView1 = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.layoutViewColumn1 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn2 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn3 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn3 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn4 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn4 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn5 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn5 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn6 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn6 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn7 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn7 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewColumn8 = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_layoutViewColumn8 = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard2 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.item1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.item2 = new DevExpress.XtraLayout.SimpleLabelItem();
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            this.SuspendLayout();
            // 
            // SBCancel
            // 
            this.SBCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(747, 411);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(100, 40);
            this.SBCancel.TabIndex = 24;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnSelect
            // 
            this.SBtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSelect.ImageOptions.Image")));
            this.SBtnSelect.Location = new System.Drawing.Point(855, 411);
            this.SBtnSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSelect.Name = "SBtnSelect";
            this.SBtnSelect.Size = new System.Drawing.Size(150, 40);
            this.SBtnSelect.TabIndex = 23;
            this.SBtnSelect.Text = "Personel Seç";
            this.SBtnSelect.Click += new System.EventHandler(this.SBtnSelect_Click);
            // 
            // GControlEmployee
            // 
            this.GControlEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GControlEmployee.Location = new System.Drawing.Point(12, 12);
            this.GControlEmployee.MainView = this.GViewEmployee;
            this.GControlEmployee.Name = "GControlEmployee";
            this.GControlEmployee.Size = new System.Drawing.Size(993, 393);
            this.GControlEmployee.TabIndex = 25;
            this.GControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewEmployee,
            this.layoutView1});
            this.GControlEmployee.DoubleClick += new System.EventHandler(this.GControlEmployee_DoubleClick);
            // 
            // GViewEmployee
            // 
            this.GViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnEmployeeID,
            this.ColumnTC,
            this.ColumnName,
            this.ColumnSurName,
            this.ColumnGender,
            this.ColumnPhone,
            this.ColumnEMail,
            this.ColumnImage});
            this.GViewEmployee.DetailHeight = 303;
            this.GViewEmployee.GridControl = this.GControlEmployee;
            this.GViewEmployee.Name = "GViewEmployee";
            this.GViewEmployee.OptionsBehavior.Editable = false;
            this.GViewEmployee.OptionsBehavior.ReadOnly = true;
            this.GViewEmployee.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnEmployeeID
            // 
            this.ColumnEmployeeID.Caption = "ID";
            this.ColumnEmployeeID.FieldName = "EmployeeID";
            this.ColumnEmployeeID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeID.ImageOptions.Image")));
            this.ColumnEmployeeID.MinWidth = 18;
            this.ColumnEmployeeID.Name = "ColumnEmployeeID";
            this.ColumnEmployeeID.Visible = true;
            this.ColumnEmployeeID.VisibleIndex = 0;
            // 
            // ColumnTC
            // 
            this.ColumnTC.Caption = "T.C NO";
            this.ColumnTC.FieldName = "EmployeeTC";
            this.ColumnTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnTC.ImageOptions.Image")));
            this.ColumnTC.Name = "ColumnTC";
            this.ColumnTC.Visible = true;
            this.ColumnTC.VisibleIndex = 1;
            this.ColumnTC.Width = 110;
            // 
            // ColumnName
            // 
            this.ColumnName.Caption = "Adı";
            this.ColumnName.FieldName = "EmployeeName";
            this.ColumnName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnName.ImageOptions.Image")));
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.Visible = true;
            this.ColumnName.VisibleIndex = 2;
            this.ColumnName.Width = 110;
            // 
            // ColumnSurName
            // 
            this.ColumnSurName.Caption = "Soyadı";
            this.ColumnSurName.FieldName = "EmployeeSurName";
            this.ColumnSurName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSurName.ImageOptions.Image")));
            this.ColumnSurName.Name = "ColumnSurName";
            this.ColumnSurName.Visible = true;
            this.ColumnSurName.VisibleIndex = 3;
            this.ColumnSurName.Width = 110;
            // 
            // ColumnGender
            // 
            this.ColumnGender.Caption = "Cinsiyet";
            this.ColumnGender.FieldName = "EmployeeGender";
            this.ColumnGender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnGender.ImageOptions.Image")));
            this.ColumnGender.MinWidth = 10;
            this.ColumnGender.Name = "ColumnGender";
            this.ColumnGender.Visible = true;
            this.ColumnGender.VisibleIndex = 4;
            this.ColumnGender.Width = 110;
            // 
            // ColumnPhone
            // 
            this.ColumnPhone.Caption = "Telefon";
            this.ColumnPhone.FieldName = "EmployeePhone";
            this.ColumnPhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPhone.ImageOptions.Image")));
            this.ColumnPhone.MinWidth = 15;
            this.ColumnPhone.Name = "ColumnPhone";
            this.ColumnPhone.Visible = true;
            this.ColumnPhone.VisibleIndex = 5;
            this.ColumnPhone.Width = 110;
            // 
            // ColumnEMail
            // 
            this.ColumnEMail.Caption = "E-Posta Adresi";
            this.ColumnEMail.FieldName = "EmployeeMail";
            this.ColumnEMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEMail.ImageOptions.Image")));
            this.ColumnEMail.MinWidth = 40;
            this.ColumnEMail.Name = "ColumnEMail";
            this.ColumnEMail.Visible = true;
            this.ColumnEMail.VisibleIndex = 6;
            this.ColumnEMail.Width = 307;
            // 
            // ColumnImage
            // 
            this.ColumnImage.Caption = "ImagePath";
            this.ColumnImage.FieldName = "EmployeeImage";
            this.ColumnImage.Name = "ColumnImage";
            // 
            // layoutView1
            // 
            this.layoutView1.CardHorzInterval = 3;
            this.layoutView1.CardMinSize = new System.Drawing.Size(331, 348);
            this.layoutView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.layoutViewColumn1,
            this.layoutViewColumn2,
            this.layoutViewColumn3,
            this.layoutViewColumn4,
            this.layoutViewColumn5,
            this.layoutViewColumn6,
            this.layoutViewColumn7,
            this.layoutViewColumn8});
            this.layoutView1.DetailHeight = 303;
            this.layoutView1.GridControl = this.GControlEmployee;
            this.layoutView1.Name = "layoutView1";
            this.layoutView1.OptionsBehavior.Editable = false;
            this.layoutView1.OptionsBehavior.ReadOnly = true;
            this.layoutView1.OptionsBehavior.ScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            this.layoutView1.OptionsView.ShowCardLines = false;
            this.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiRow;
            this.layoutView1.TemplateCard = this.layoutViewCard2;
            // 
            // layoutViewColumn1
            // 
            this.layoutViewColumn1.Caption = "ID";
            this.layoutViewColumn1.FieldName = "EmployeeID";
            this.layoutViewColumn1.LayoutViewField = this.layoutViewField_layoutViewColumn1;
            this.layoutViewColumn1.MinWidth = 18;
            this.layoutViewColumn1.Name = "layoutViewColumn1";
            // 
            // layoutViewField_layoutViewColumn1
            // 
            this.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 134;
            this.layoutViewField_layoutViewColumn1.Location = new System.Drawing.Point(0, 21);
            this.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1";
            this.layoutViewField_layoutViewColumn1.Size = new System.Drawing.Size(271, 36);
            this.layoutViewField_layoutViewColumn1.TextSize = new System.Drawing.Size(126, 15);
            // 
            // layoutViewColumn2
            // 
            this.layoutViewColumn2.Caption = "T.C NO";
            this.layoutViewColumn2.FieldName = "EmployeeTC";
            this.layoutViewColumn2.LayoutViewField = this.layoutViewField_layoutViewColumn2;
            this.layoutViewColumn2.Name = "layoutViewColumn2";
            this.layoutViewColumn2.Width = 110;
            // 
            // layoutViewField_layoutViewColumn2
            // 
            this.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 134;
            this.layoutViewField_layoutViewColumn2.Location = new System.Drawing.Point(0, 57);
            this.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2";
            this.layoutViewField_layoutViewColumn2.Size = new System.Drawing.Size(271, 36);
            this.layoutViewField_layoutViewColumn2.TextSize = new System.Drawing.Size(126, 15);
            // 
            // layoutViewColumn3
            // 
            this.layoutViewColumn3.Caption = "Adı";
            this.layoutViewColumn3.FieldName = "EmployeeName";
            this.layoutViewColumn3.LayoutViewField = this.layoutViewField_layoutViewColumn3;
            this.layoutViewColumn3.Name = "layoutViewColumn3";
            this.layoutViewColumn3.Width = 110;
            // 
            // layoutViewField_layoutViewColumn3
            // 
            this.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 134;
            this.layoutViewField_layoutViewColumn3.Location = new System.Drawing.Point(0, 93);
            this.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3";
            this.layoutViewField_layoutViewColumn3.Size = new System.Drawing.Size(271, 36);
            this.layoutViewField_layoutViewColumn3.TextSize = new System.Drawing.Size(126, 15);
            // 
            // layoutViewColumn4
            // 
            this.layoutViewColumn4.Caption = "Soyadı";
            this.layoutViewColumn4.FieldName = "EmployeeSurName";
            this.layoutViewColumn4.LayoutViewField = this.layoutViewField_layoutViewColumn4;
            this.layoutViewColumn4.Name = "layoutViewColumn4";
            this.layoutViewColumn4.Width = 110;
            // 
            // layoutViewField_layoutViewColumn4
            // 
            this.layoutViewField_layoutViewColumn4.EditorPreferredWidth = 134;
            this.layoutViewField_layoutViewColumn4.Location = new System.Drawing.Point(0, 129);
            this.layoutViewField_layoutViewColumn4.Name = "layoutViewField_layoutViewColumn4";
            this.layoutViewField_layoutViewColumn4.Size = new System.Drawing.Size(271, 36);
            this.layoutViewField_layoutViewColumn4.TextSize = new System.Drawing.Size(126, 15);
            // 
            // layoutViewColumn5
            // 
            this.layoutViewColumn5.Caption = "Cinsiyet";
            this.layoutViewColumn5.FieldName = "EmployeeGender";
            this.layoutViewColumn5.LayoutViewField = this.layoutViewField_layoutViewColumn5;
            this.layoutViewColumn5.MinWidth = 10;
            this.layoutViewColumn5.Name = "layoutViewColumn5";
            this.layoutViewColumn5.Width = 110;
            // 
            // layoutViewField_layoutViewColumn5
            // 
            this.layoutViewField_layoutViewColumn5.EditorPreferredWidth = 134;
            this.layoutViewField_layoutViewColumn5.Location = new System.Drawing.Point(0, 165);
            this.layoutViewField_layoutViewColumn5.Name = "layoutViewField_layoutViewColumn5";
            this.layoutViewField_layoutViewColumn5.Size = new System.Drawing.Size(271, 36);
            this.layoutViewField_layoutViewColumn5.TextSize = new System.Drawing.Size(126, 15);
            // 
            // layoutViewColumn6
            // 
            this.layoutViewColumn6.Caption = "Telefon";
            this.layoutViewColumn6.FieldName = "EmployeePhone";
            this.layoutViewColumn6.LayoutViewField = this.layoutViewField_layoutViewColumn6;
            this.layoutViewColumn6.MinWidth = 15;
            this.layoutViewColumn6.Name = "layoutViewColumn6";
            this.layoutViewColumn6.Width = 110;
            // 
            // layoutViewField_layoutViewColumn6
            // 
            this.layoutViewField_layoutViewColumn6.EditorPreferredWidth = 134;
            this.layoutViewField_layoutViewColumn6.Location = new System.Drawing.Point(0, 201);
            this.layoutViewField_layoutViewColumn6.Name = "layoutViewField_layoutViewColumn6";
            this.layoutViewField_layoutViewColumn6.Size = new System.Drawing.Size(271, 36);
            this.layoutViewField_layoutViewColumn6.TextSize = new System.Drawing.Size(126, 15);
            // 
            // layoutViewColumn7
            // 
            this.layoutViewColumn7.Caption = "E-Posta Adresi";
            this.layoutViewColumn7.FieldName = "EmployeeMail";
            this.layoutViewColumn7.LayoutViewField = this.layoutViewField_layoutViewColumn7;
            this.layoutViewColumn7.MinWidth = 40;
            this.layoutViewColumn7.Name = "layoutViewColumn7";
            this.layoutViewColumn7.Width = 307;
            // 
            // layoutViewField_layoutViewColumn7
            // 
            this.layoutViewField_layoutViewColumn7.EditorPreferredWidth = 134;
            this.layoutViewField_layoutViewColumn7.Location = new System.Drawing.Point(0, 237);
            this.layoutViewField_layoutViewColumn7.Name = "layoutViewField_layoutViewColumn7";
            this.layoutViewField_layoutViewColumn7.Size = new System.Drawing.Size(271, 36);
            this.layoutViewField_layoutViewColumn7.TextSize = new System.Drawing.Size(126, 15);
            // 
            // layoutViewColumn8
            // 
            this.layoutViewColumn8.Caption = "ImagePath";
            this.layoutViewColumn8.FieldName = "EmployeeImage";
            this.layoutViewColumn8.LayoutViewField = this.layoutViewField_layoutViewColumn8;
            this.layoutViewColumn8.Name = "layoutViewColumn8";
            // 
            // layoutViewField_layoutViewColumn8
            // 
            this.layoutViewField_layoutViewColumn8.EditorPreferredWidth = 134;
            this.layoutViewField_layoutViewColumn8.Location = new System.Drawing.Point(0, 273);
            this.layoutViewField_layoutViewColumn8.Name = "layoutViewField_layoutViewColumn8";
            this.layoutViewField_layoutViewColumn8.Size = new System.Drawing.Size(271, 36);
            this.layoutViewField_layoutViewColumn8.TextSize = new System.Drawing.Size(126, 15);
            // 
            // layoutViewCard2
            // 
            this.layoutViewCard2.CustomizationFormText = "TemplateCard";
            this.layoutViewCard2.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_layoutViewColumn1,
            this.layoutViewField_layoutViewColumn2,
            this.layoutViewField_layoutViewColumn3,
            this.layoutViewField_layoutViewColumn4,
            this.layoutViewField_layoutViewColumn5,
            this.layoutViewField_layoutViewColumn6,
            this.layoutViewField_layoutViewColumn7,
            this.layoutViewField_layoutViewColumn8,
            this.item1,
            this.item2});
            this.layoutViewCard2.Name = "layoutViewCard2";
            this.layoutViewCard2.OptionsItemText.TextToControlDistance = 5;
            this.layoutViewCard2.Text = "TemplateCard";
            // 
            // item1
            // 
            this.item1.AllowHotTrack = false;
            this.item1.CustomizationFormText = "item1";
            this.item1.Location = new System.Drawing.Point(0, 0);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(135, 21);
            this.item1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // item2
            // 
            this.item2.AllowHotTrack = false;
            this.item2.CustomizationFormText = "PERSONEL BİLGİLERİ";
            this.item2.Location = new System.Drawing.Point(135, 0);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(136, 21);
            this.item2.Text = "PERSONEL BİLGİLERİ";
            this.item2.TextSize = new System.Drawing.Size(126, 15);
            // 
            // EmployeeSelectWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 463);
            this.Controls.Add(this.GControlEmployee);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnSelect);
            this.Name = "EmployeeSelectWF";
            this.Text = "PERSONEL SEÇİN";
            this.Load += new System.EventHandler(this.EmployeeSelectWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_layoutViewColumn8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnSelect;
        private DevExpress.XtraGrid.GridControl GControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnTC;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSurName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnGender;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnImage;
        private DevExpress.XtraGrid.Views.Layout.LayoutView layoutView1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn1;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn2;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn2;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn3;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn3;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn4;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn4;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn5;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn5;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn6;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn6;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn7;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn7;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn layoutViewColumn8;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_layoutViewColumn8;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard2;
        private DevExpress.XtraLayout.EmptySpaceItem item1;
        private DevExpress.XtraLayout.SimpleLabelItem item2;
    }
}