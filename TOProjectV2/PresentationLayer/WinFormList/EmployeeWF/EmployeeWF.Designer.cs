namespace PresentationLayer.WinFormList.EmployeeWF
{
    partial class EmployeeWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeWF));
            this.xtraTabEmployeeControl = new DevExpress.XtraTab.XtraTabControl();
            this.TabPageEmployee = new DevExpress.XtraTab.XtraTabPage();
            this.GControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.GViewEmployee = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeSurName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TabPageEmployeeArchive = new DevExpress.XtraTab.XtraTabPage();
            this.GControlEmployeeArchive = new DevExpress.XtraGrid.GridControl();
            this.GViewEmployeeArchive = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnSurName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.accordionControlEmployeeArchiveList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlEmployeeArchiveQuit = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlEmployeeExpandArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlEmployeeExpand = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlEmployeeyList = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlEmployeeArchive = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlEmployeeDelete = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlEmployeeUpdate = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlNewEmployee = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControlEmployeeProcess = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            this.accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.ColumnEmployeeImage = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabEmployeeControl)).BeginInit();
            this.xtraTabEmployeeControl.SuspendLayout();
            this.TabPageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewEmployee)).BeginInit();
            this.TabPageEmployeeArchive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployeeArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewEmployeeArchive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabEmployeeControl
            // 
            this.xtraTabEmployeeControl.AppearancePage.HeaderActive.BackColor = System.Drawing.Color.Teal;
            this.xtraTabEmployeeControl.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.xtraTabEmployeeControl.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.xtraTabEmployeeControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.xtraTabEmployeeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabEmployeeControl.Location = new System.Drawing.Point(250, 0);
            this.xtraTabEmployeeControl.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabEmployeeControl.Name = "xtraTabEmployeeControl";
            this.xtraTabEmployeeControl.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Center;
            this.xtraTabEmployeeControl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.xtraTabEmployeeControl.SelectedTabPage = this.TabPageEmployee;
            this.xtraTabEmployeeControl.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.xtraTabEmployeeControl.Size = new System.Drawing.Size(964, 470);
            this.xtraTabEmployeeControl.TabIndex = 11;
            this.xtraTabEmployeeControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.TabPageEmployee,
            this.TabPageEmployeeArchive});
            this.xtraTabEmployeeControl.Click += new System.EventHandler(this.xtraTabEmployeeControl_Click);
            // 
            // TabPageEmployee
            // 
            this.TabPageEmployee.Controls.Add(this.GControlEmployee);
            this.TabPageEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageCompany.ImageOptions.Image")));
            this.TabPageEmployee.ImageOptions.SvgImageColorizationMode = DevExpress.Utils.SvgImageColorizationMode.Full;
            this.TabPageEmployee.Name = "TabPageEmployee";
            this.TabPageEmployee.Size = new System.Drawing.Size(962, 426);
            this.TabPageEmployee.Text = "ÜRÜNLER LİSTESİ";
            // 
            // GControlEmployee
            // 
            this.GControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlEmployee.Location = new System.Drawing.Point(0, 0);
            this.GControlEmployee.MainView = this.GViewEmployee;
            this.GControlEmployee.Name = "GControlEmployee";
            this.GControlEmployee.Size = new System.Drawing.Size(962, 426);
            this.GControlEmployee.TabIndex = 0;
            this.GControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewEmployee});
            // 
            // GViewEmployee
            // 
            this.GViewEmployee.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnEmployeeID,
            this.ColumnEmployeeTC,
            this.ColumnEmployeeName,
            this.ColumnEmployeeSurName,
            this.ColumnEmployeeGender,
            this.ColumnPhone,
            this.ColumnEmployeeMail,
            this.gridColumn1});
            this.GViewEmployee.DetailHeight = 303;
            this.GViewEmployee.GridControl = this.GControlEmployee;
            this.GViewEmployee.Name = "GViewEmployee";
            this.GViewEmployee.OptionsBehavior.Editable = false;
            this.GViewEmployee.OptionsBehavior.ReadOnly = true;
            this.GViewEmployee.OptionsView.ShowGroupPanel = false;
            this.GViewEmployee.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.GViewEmployee_CustomUnboundColumnData);
            // 
            // ColumnEmployeeID
            // 
            this.ColumnEmployeeID.Caption = "ID";
            this.ColumnEmployeeID.FieldName = "EmployeeID";
            this.ColumnEmployeeID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeID.ImageOptions.Image")));
            this.ColumnEmployeeID.Name = "ColumnEmployeeID";
            this.ColumnEmployeeID.Visible = true;
            this.ColumnEmployeeID.VisibleIndex = 0;
            // 
            // ColumnEmployeeTC
            // 
            this.ColumnEmployeeTC.Caption = "T.C NO";
            this.ColumnEmployeeTC.FieldName = "EmployeeTC";
            this.ColumnEmployeeTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeTC.ImageOptions.Image")));
            this.ColumnEmployeeTC.Name = "ColumnEmployeeTC";
            this.ColumnEmployeeTC.Visible = true;
            this.ColumnEmployeeTC.VisibleIndex = 1;
            this.ColumnEmployeeTC.Width = 110;
            // 
            // ColumnEmployeeName
            // 
            this.ColumnEmployeeName.Caption = "Adı";
            this.ColumnEmployeeName.FieldName = "EmployeeName";
            this.ColumnEmployeeName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeName.ImageOptions.Image")));
            this.ColumnEmployeeName.Name = "ColumnEmployeeName";
            this.ColumnEmployeeName.Visible = true;
            this.ColumnEmployeeName.VisibleIndex = 2;
            this.ColumnEmployeeName.Width = 110;
            // 
            // ColumnEmployeeSurName
            // 
            this.ColumnEmployeeSurName.Caption = "Soyadı";
            this.ColumnEmployeeSurName.FieldName = "EmployeeSurName";
            this.ColumnEmployeeSurName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeSurName.ImageOptions.Image")));
            this.ColumnEmployeeSurName.Name = "ColumnEmployeeSurName";
            this.ColumnEmployeeSurName.Visible = true;
            this.ColumnEmployeeSurName.VisibleIndex = 3;
            this.ColumnEmployeeSurName.Width = 110;
            // 
            // ColumnEmployeeGender
            // 
            this.ColumnEmployeeGender.Caption = "Cinsiyet";
            this.ColumnEmployeeGender.FieldName = "EmployeeGender";
            this.ColumnEmployeeGender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeGender.ImageOptions.Image")));
            this.ColumnEmployeeGender.MinWidth = 10;
            this.ColumnEmployeeGender.Name = "ColumnEmployeeGender";
            this.ColumnEmployeeGender.Visible = true;
            this.ColumnEmployeeGender.VisibleIndex = 4;
            this.ColumnEmployeeGender.Width = 110;
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
            // ColumnEmployeeMail
            // 
            this.ColumnEmployeeMail.Caption = "E-Posta Adresi";
            this.ColumnEmployeeMail.FieldName = "EmployeeMail";
            this.ColumnEmployeeMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeMail.ImageOptions.Image")));
            this.ColumnEmployeeMail.MinWidth = 40;
            this.ColumnEmployeeMail.Name = "ColumnEmployeeMail";
            this.ColumnEmployeeMail.Visible = true;
            this.ColumnEmployeeMail.VisibleIndex = 6;
            this.ColumnEmployeeMail.Width = 307;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "EmployeeImage";
            this.gridColumn1.FieldName = "EmployeeImage";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // TabPageEmployeeArchive
            // 
            this.TabPageEmployeeArchive.Controls.Add(this.GControlEmployeeArchive);
            this.TabPageEmployeeArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("TabPageCompanyArchive.ImageOptions.Image")));
            this.TabPageEmployeeArchive.Name = "TabPageEmployeeArchive";
            this.TabPageEmployeeArchive.Size = new System.Drawing.Size(962, 426);
            this.TabPageEmployeeArchive.Text = "ÜRÜNLER ARŞİV LİSTESİ";
            // 
            // GControlEmployeeArchive
            // 
            this.GControlEmployeeArchive.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlEmployeeArchive.Location = new System.Drawing.Point(0, 0);
            this.GControlEmployeeArchive.MainView = this.GViewEmployeeArchive;
            this.GControlEmployeeArchive.Name = "GControlEmployeeArchive";
            this.GControlEmployeeArchive.Size = new System.Drawing.Size(962, 426);
            this.GControlEmployeeArchive.TabIndex = 1;
            this.GControlEmployeeArchive.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewEmployeeArchive});
            // 
            // GViewEmployeeArchive
            // 
            this.GViewEmployeeArchive.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnID,
            this.gridColumnTC,
            this.gridColumnName,
            this.gridColumnSurName,
            this.gridColumnGender,
            this.gridColumnPhone,
            this.gridColumnMail,
            this.ColumnEmployeeImage});
            this.GViewEmployeeArchive.DetailHeight = 303;
            this.GViewEmployeeArchive.GridControl = this.GControlEmployeeArchive;
            this.GViewEmployeeArchive.Name = "GViewEmployeeArchive";
            this.GViewEmployeeArchive.OptionsBehavior.Editable = false;
            this.GViewEmployeeArchive.OptionsBehavior.ReadOnly = true;
            this.GViewEmployeeArchive.OptionsView.ShowGroupPanel = false;
            this.GViewEmployeeArchive.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.GViewEmployeeArchive_CustomUnboundColumnData);
            // 
            // gridColumnID
            // 
            this.gridColumnID.Caption = "ID";
            this.gridColumnID.FieldName = "EmployeeID";
            this.gridColumnID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnID.ImageOptions.Image")));
            this.gridColumnID.MinWidth = 18;
            this.gridColumnID.Name = "gridColumnID";
            this.gridColumnID.Visible = true;
            this.gridColumnID.VisibleIndex = 0;
            // 
            // gridColumnTC
            // 
            this.gridColumnTC.Caption = "T.C NO";
            this.gridColumnTC.FieldName = "EmployeeTC";
            this.gridColumnTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnTC.ImageOptions.Image")));
            this.gridColumnTC.Name = "gridColumnTC";
            this.gridColumnTC.Visible = true;
            this.gridColumnTC.VisibleIndex = 1;
            this.gridColumnTC.Width = 110;
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Adı";
            this.gridColumnName.FieldName = "EmployeeName";
            this.gridColumnName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnName.ImageOptions.Image")));
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 2;
            this.gridColumnName.Width = 110;
            // 
            // gridColumnSurName
            // 
            this.gridColumnSurName.Caption = "Soyadı";
            this.gridColumnSurName.FieldName = "EmployeeSurName";
            this.gridColumnSurName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnSurName.ImageOptions.Image")));
            this.gridColumnSurName.Name = "gridColumnSurName";
            this.gridColumnSurName.Visible = true;
            this.gridColumnSurName.VisibleIndex = 3;
            this.gridColumnSurName.Width = 110;
            // 
            // gridColumnGender
            // 
            this.gridColumnGender.Caption = "Cinsiyet";
            this.gridColumnGender.FieldName = "EmployeeGender";
            this.gridColumnGender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnGender.ImageOptions.Image")));
            this.gridColumnGender.MinWidth = 10;
            this.gridColumnGender.Name = "gridColumnGender";
            this.gridColumnGender.Visible = true;
            this.gridColumnGender.VisibleIndex = 4;
            this.gridColumnGender.Width = 110;
            // 
            // gridColumnPhone
            // 
            this.gridColumnPhone.Caption = "Telefon";
            this.gridColumnPhone.FieldName = "EmployeePhone";
            this.gridColumnPhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnPhone.ImageOptions.Image")));
            this.gridColumnPhone.MinWidth = 15;
            this.gridColumnPhone.Name = "gridColumnPhone";
            this.gridColumnPhone.Visible = true;
            this.gridColumnPhone.VisibleIndex = 5;
            this.gridColumnPhone.Width = 110;
            // 
            // gridColumnMail
            // 
            this.gridColumnMail.Caption = "E-Posta Adresi";
            this.gridColumnMail.FieldName = "EmployeeMail";
            this.gridColumnMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumnMail.ImageOptions.Image")));
            this.gridColumnMail.MinWidth = 40;
            this.gridColumnMail.Name = "gridColumnMail";
            this.gridColumnMail.Visible = true;
            this.gridColumnMail.VisibleIndex = 6;
            this.gridColumnMail.Width = 307;
            // 
            // accordionControlEmployeeArchiveList
            // 
            this.accordionControlEmployeeArchiveList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyArchiveList.ImageOptions.Image")));
            this.accordionControlEmployeeArchiveList.Name = "accordionControlEmployeeArchiveList";
            this.accordionControlEmployeeArchiveList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlEmployeeArchiveList.Text = "PERSONEL ARŞİV LİSTESİ";
            this.accordionControlEmployeeArchiveList.Click += new System.EventHandler(this.accordionControlEmployeeArchiveList_Click);
            // 
            // accordionControlEmployeeArchiveQuit
            // 
            this.accordionControlEmployeeArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyArchiveQuit.ImageOptions.Image")));
            this.accordionControlEmployeeArchiveQuit.Name = "accordionControlEmployeeArchiveQuit";
            this.accordionControlEmployeeArchiveQuit.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlEmployeeArchiveQuit.Text = "PERSONEL ARŞİVDEN ÇIKAR";
            this.accordionControlEmployeeArchiveQuit.Click += new System.EventHandler(this.accordionControlEmployeeArchiveQuit_Click);
            // 
            // accordionControlArchive
            // 
            this.accordionControlArchive.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlEmployeeArchiveQuit,
            this.accordionControlEmployeeArchiveList,
            this.accordionControlEmployeeExpandArchive});
            this.accordionControlArchive.Expanded = true;
            this.accordionControlArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlArchive.ImageOptions.Image")));
            this.accordionControlArchive.Name = "accordionControlArchive";
            this.accordionControlArchive.Text = "FİRMA ARŞİV İŞLEMLERİ";
            this.accordionControlArchive.Click += new System.EventHandler(this.accordionControlArchive_Click);
            // 
            // accordionControlEmployeeExpandArchive
            // 
            this.accordionControlEmployeeExpandArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlEmployeeExpandArchive.ImageOptions.Image")));
            this.accordionControlEmployeeExpandArchive.Name = "accordionControlEmployeeExpandArchive";
            this.accordionControlEmployeeExpandArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlEmployeeExpandArchive.Text = "ARŞİV LİSTESİNİ GENİŞLET";
            this.accordionControlEmployeeExpandArchive.Click += new System.EventHandler(this.accordionControlEmployeeExpandArchive_Click);
            // 
            // accordionControlEmployeeExpand
            // 
            this.accordionControlEmployeeExpand.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlEmployeeExpand.ImageOptions.Image")));
            this.accordionControlEmployeeExpand.Name = "accordionControlEmployeeExpand";
            this.accordionControlEmployeeExpand.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlEmployeeExpand.Text = "LİSTEYİ GENİŞLET";
            this.accordionControlEmployeeExpand.Click += new System.EventHandler(this.accordionControlEmployeeExpand_Click);
            // 
            // accordionControlEmployeeyList
            // 
            this.accordionControlEmployeeyList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlEmployeeyList.ImageOptions.Image")));
            this.accordionControlEmployeeyList.Name = "accordionControlEmployeeyList";
            this.accordionControlEmployeeyList.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlEmployeeyList.Text = "PERSONEL LİSTESİ";
            this.accordionControlEmployeeyList.Click += new System.EventHandler(this.accordionControlEmployeeyList_Click);
            // 
            // accordionControlEmployeeArchive
            // 
            this.accordionControlEmployeeArchive.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlEmployeeArchive.ImageOptions.Image")));
            this.accordionControlEmployeeArchive.Name = "accordionControlEmployeeArchive";
            this.accordionControlEmployeeArchive.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlEmployeeArchive.Text = "PERSONEL BİLGİLERİNİ ARŞİVLE";
            this.accordionControlEmployeeArchive.Click += new System.EventHandler(this.accordionControlEmployeeArchive_Click);
            // 
            // accordionControlEmployeeDelete
            // 
            this.accordionControlEmployeeDelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlEmployeeDelete.ImageOptions.Image")));
            this.accordionControlEmployeeDelete.Name = "accordionControlEmployeeDelete";
            this.accordionControlEmployeeDelete.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlEmployeeDelete.Text = "PERSONEL BİLGİLERİNİ SİL";
            this.accordionControlEmployeeDelete.Click += new System.EventHandler(this.accordionControlEmployeeDelete_Click);
            // 
            // accordionControlEmployeeUpdate
            // 
            this.accordionControlEmployeeUpdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlEmployeeUpdate.ImageOptions.Image")));
            this.accordionControlEmployeeUpdate.Name = "accordionControlEmployeeUpdate";
            this.accordionControlEmployeeUpdate.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlEmployeeUpdate.Text = "PERSONEL BİLGİLERİNİ DÜZENLE";
            this.accordionControlEmployeeUpdate.Click += new System.EventHandler(this.accordionControlEmployeeUpdate_Click);
            // 
            // accordionControlNewEmployee
            // 
            this.accordionControlNewEmployee.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlNewEmployee.ImageOptions.Image")));
            this.accordionControlNewEmployee.Name = "accordionControlNewEmployee";
            this.accordionControlNewEmployee.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            this.accordionControlNewEmployee.Text = "YENİ PERSONEL";
            this.accordionControlNewEmployee.Click += new System.EventHandler(this.accordionControlNewEmployee_Click);
            // 
            // accordionControlEmployeeProcess
            // 
            this.accordionControlEmployeeProcess.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlNewEmployee,
            this.accordionControlEmployeeUpdate,
            this.accordionControlEmployeeDelete,
            this.accordionControlEmployeeArchive,
            this.accordionControlEmployeeyList,
            this.accordionControlEmployeeExpand});
            this.accordionControlEmployeeProcess.Expanded = true;
            this.accordionControlEmployeeProcess.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("accordionControlCompanyProcess.ImageOptions.Image")));
            this.accordionControlEmployeeProcess.Name = "accordionControlEmployeeProcess";
            this.accordionControlEmployeeProcess.Text = "FİRMA İŞLEMLERİ";
            this.accordionControlEmployeeProcess.Click += new System.EventHandler(this.accordionControlEmployeeProcess_Click);
            // 
            // accordionControl1
            // 
            this.accordionControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accordionControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] {
            this.accordionControlEmployeeProcess,
            this.accordionControlArchive});
            this.accordionControl1.Location = new System.Drawing.Point(0, 0);
            this.accordionControl1.Name = "accordionControl1";
            this.accordionControl1.RootDisplayMode = DevExpress.XtraBars.Navigation.AccordionControlRootDisplayMode.Footer;
            this.accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Fluent;
            this.accordionControl1.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always;
            this.accordionControl1.Size = new System.Drawing.Size(250, 470);
            this.accordionControl1.TabIndex = 10;
            this.accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // ColumnEmployeeImage
            // 
            this.ColumnEmployeeImage.Caption = "ImagePath";
            this.ColumnEmployeeImage.FieldName = "EmployeeImage";
            this.ColumnEmployeeImage.Name = "ColumnEmployeeImage";
            // 
            // EmployeeWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 470);
            this.Controls.Add(this.xtraTabEmployeeControl);
            this.Controls.Add(this.accordionControl1);
            this.Name = "EmployeeWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel İşlemleri";
            this.Load += new System.EventHandler(this.EmployeeWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabEmployeeControl)).EndInit();
            this.xtraTabEmployeeControl.ResumeLayout(false);
            this.TabPageEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewEmployee)).EndInit();
            this.TabPageEmployeeArchive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployeeArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewEmployeeArchive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabEmployeeControl;
        private DevExpress.XtraTab.XtraTabPage TabPageEmployee;
        private DevExpress.XtraGrid.GridControl GControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewEmployee;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeTC;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeSurName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeGender;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeMail;
        private DevExpress.XtraTab.XtraTabPage TabPageEmployeeArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeArchiveList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeArchiveQuit;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeExpandArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeExpand;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeyList;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeArchive;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeDelete;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeUpdate;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlNewEmployee;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlEmployeeProcess;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraGrid.GridControl GControlEmployeeArchive;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewEmployeeArchive;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnID;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnSurName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnGender;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnPhone;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnMail;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeImage;
    }
}