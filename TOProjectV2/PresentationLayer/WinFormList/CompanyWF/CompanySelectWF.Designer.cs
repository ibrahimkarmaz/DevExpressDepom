namespace PresentationLayer.WinFormList.CompanyWF
{
    partial class CompanySelectWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompanySelectWF));
            this.GControlCompany = new DevExpress.XtraGrid.GridControl();
            this.GViewCompany = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnSectorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyNameSurname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnOfficialStatus = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPhone1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCompanyMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSelect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompany)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlCompany
            // 
            this.GControlCompany.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GControlCompany.Location = new System.Drawing.Point(12, 12);
            this.GControlCompany.MainView = this.GViewCompany;
            this.GControlCompany.Name = "GControlCompany";
            this.GControlCompany.Size = new System.Drawing.Size(979, 400);
            this.GControlCompany.TabIndex = 1;
            this.GControlCompany.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCompany});
            this.GControlCompany.DoubleClick += new System.EventHandler(this.GControlCompany_DoubleClick);
            // 
            // GViewCompany
            // 
            this.GViewCompany.Appearance.Row.BackColor = System.Drawing.Color.LightGray;
            this.GViewCompany.Appearance.Row.BackColor2 = System.Drawing.Color.LightSalmon;
            this.GViewCompany.Appearance.Row.BorderColor = System.Drawing.Color.Red;
            this.GViewCompany.Appearance.Row.Options.UseBackColor = true;
            this.GViewCompany.Appearance.Row.Options.UseBorderColor = true;
            this.GViewCompany.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnCompanyID,
            this.ColumnCompanyName,
            this.ColumnSectorName,
            this.ColumnCompanyNameSurname,
            this.ColumnOfficialStatus,
            this.ColumnPhone1,
            this.ColumnCompanyMail});
            this.GViewCompany.DetailHeight = 303;
            this.GViewCompany.GridControl = this.GControlCompany;
            this.GViewCompany.Name = "GViewCompany";
            this.GViewCompany.OptionsBehavior.Editable = false;
            this.GViewCompany.OptionsBehavior.ReadOnly = true;
            this.GViewCompany.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnCompanyID
            // 
            this.ColumnCompanyID.Caption = "ID";
            this.ColumnCompanyID.FieldName = "CompanyID";
            this.ColumnCompanyID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyID.ImageOptions.Image")));
            this.ColumnCompanyID.MinWidth = 18;
            this.ColumnCompanyID.Name = "ColumnCompanyID";
            this.ColumnCompanyID.Visible = true;
            this.ColumnCompanyID.VisibleIndex = 0;
            this.ColumnCompanyID.Width = 86;
            // 
            // ColumnCompanyName
            // 
            this.ColumnCompanyName.Caption = "Firma Adı";
            this.ColumnCompanyName.FieldName = "CompanyName";
            this.ColumnCompanyName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyName.ImageOptions.Image")));
            this.ColumnCompanyName.MinWidth = 40;
            this.ColumnCompanyName.Name = "ColumnCompanyName";
            this.ColumnCompanyName.Visible = true;
            this.ColumnCompanyName.VisibleIndex = 1;
            this.ColumnCompanyName.Width = 172;
            // 
            // ColumnSectorName
            // 
            this.ColumnSectorName.Caption = "Sektör Adı";
            this.ColumnSectorName.FieldName = "SectorName";
            this.ColumnSectorName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSectorName.ImageOptions.Image")));
            this.ColumnSectorName.MinWidth = 18;
            this.ColumnSectorName.Name = "ColumnSectorName";
            this.ColumnSectorName.Visible = true;
            this.ColumnSectorName.VisibleIndex = 2;
            this.ColumnSectorName.Width = 105;
            // 
            // ColumnCompanyNameSurname
            // 
            this.ColumnCompanyNameSurname.Caption = "Yetkili";
            this.ColumnCompanyNameSurname.FieldName = "CompanyOfficialNameSurName";
            this.ColumnCompanyNameSurname.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyNameSurname.ImageOptions.Image")));
            this.ColumnCompanyNameSurname.Name = "ColumnCompanyNameSurname";
            this.ColumnCompanyNameSurname.Visible = true;
            this.ColumnCompanyNameSurname.VisibleIndex = 3;
            this.ColumnCompanyNameSurname.Width = 125;
            // 
            // ColumnOfficialStatus
            // 
            this.ColumnOfficialStatus.Caption = "Yetkili Statüsü";
            this.ColumnOfficialStatus.FieldName = "CompanyOfficialStatus";
            this.ColumnOfficialStatus.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnOfficialStatus.ImageOptions.Image")));
            this.ColumnOfficialStatus.MinWidth = 15;
            this.ColumnOfficialStatus.Name = "ColumnOfficialStatus";
            this.ColumnOfficialStatus.Visible = true;
            this.ColumnOfficialStatus.VisibleIndex = 4;
            this.ColumnOfficialStatus.Width = 121;
            // 
            // ColumnPhone1
            // 
            this.ColumnPhone1.Caption = "Telefon";
            this.ColumnPhone1.FieldName = "CompanyPhone1";
            this.ColumnPhone1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnPhone1.ImageOptions.Image")));
            this.ColumnPhone1.Name = "ColumnPhone1";
            this.ColumnPhone1.Visible = true;
            this.ColumnPhone1.VisibleIndex = 5;
            this.ColumnPhone1.Width = 119;
            // 
            // ColumnCompanyMail
            // 
            this.ColumnCompanyMail.Caption = "E-Posta Adresi";
            this.ColumnCompanyMail.FieldName = "CompanyMail";
            this.ColumnCompanyMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyMail.ImageOptions.Image")));
            this.ColumnCompanyMail.MinWidth = 40;
            this.ColumnCompanyMail.Name = "ColumnCompanyMail";
            this.ColumnCompanyMail.Visible = true;
            this.ColumnCompanyMail.VisibleIndex = 6;
            this.ColumnCompanyMail.Width = 210;
            // 
            // SBCancel
            // 
            this.SBCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(733, 418);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(100, 40);
            this.SBCancel.TabIndex = 18;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnSelect
            // 
            this.SBtnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBtnSelect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnSelect.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSelect.ImageOptions.Image")));
            this.SBtnSelect.Location = new System.Drawing.Point(841, 418);
            this.SBtnSelect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnSelect.Name = "SBtnSelect";
            this.SBtnSelect.Size = new System.Drawing.Size(150, 40);
            this.SBtnSelect.TabIndex = 17;
            this.SBtnSelect.Text = "Firma Seç";
            this.SBtnSelect.Click += new System.EventHandler(this.SBtnSelect_Click);
            // 
            // CompanySelectWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 466);
            this.Controls.Add(this.SBCancel);
            this.Controls.Add(this.SBtnSelect);
            this.Controls.Add(this.GControlCompany);
            this.Name = "CompanySelectWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FİRMA SEÇİN";
            this.Load += new System.EventHandler(this.CompanySelectWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlCompany)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCompany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControlCompany;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCompany;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnSectorName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyNameSurname;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnOfficialStatus;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPhone1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyMail;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnSelect;
    }
}