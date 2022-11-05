namespace PresentationLayer.WinFormList.EmployeeWF
{
    partial class EmployeeExpandWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeExpandWF));
            this.GControlEmployee = new DevExpress.XtraGrid.GridControl();
            this.GViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDepartment = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeTC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeSurName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeGender = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeDateOfBirth = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnMobilePhone = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnEmployeeMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnCounty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnDistrict = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnHomeAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlEmployee
            // 
            this.GControlEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlEmployee.Location = new System.Drawing.Point(0, 0);
            this.GControlEmployee.MainView = this.GViewCustomer;
            this.GControlEmployee.Name = "GControlEmployee";
            this.GControlEmployee.Size = new System.Drawing.Size(1246, 497);
            this.GControlEmployee.TabIndex = 1;
            this.GControlEmployee.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCustomer});
            // 
            // GViewCustomer
            // 
            this.GViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnEmployeeID,
            this.ColumnDepartment,
            this.ColumnEmployeeTC,
            this.ColumnEmployeeName,
            this.ColumnEmployeeSurName,
            this.ColumnEmployeeGender,
            this.ColumnEmployeeDateOfBirth,
            this.ColumnMobilePhone,
            this.ColumnEmployeeMail,
            this.ColumnCounty,
            this.ColumnDistrict,
            this.ColumnHomeAddress});
            this.GViewCustomer.DetailHeight = 303;
            this.GViewCustomer.GridControl = this.GControlEmployee;
            this.GViewCustomer.Name = "GViewCustomer";
            this.GViewCustomer.OptionsBehavior.Editable = false;
            this.GViewCustomer.OptionsBehavior.ReadOnly = true;
            this.GViewCustomer.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnEmployeeID
            // 
            this.ColumnEmployeeID.Caption = "ID";
            this.ColumnEmployeeID.FieldName = "EmployeeID";
            this.ColumnEmployeeID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeID.ImageOptions.Image")));
            this.ColumnEmployeeID.Name = "ColumnEmployeeID";
            this.ColumnEmployeeID.Visible = true;
            this.ColumnEmployeeID.VisibleIndex = 0;
            this.ColumnEmployeeID.Width = 46;
            // 
            // ColumnDepartment
            // 
            this.ColumnDepartment.Caption = "Departman Adı";
            this.ColumnDepartment.FieldName = "DepartmentName";
            this.ColumnDepartment.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDepartment.ImageOptions.Image")));
            this.ColumnDepartment.Name = "ColumnDepartment";
            this.ColumnDepartment.Visible = true;
            this.ColumnDepartment.VisibleIndex = 1;
            // 
            // ColumnEmployeeTC
            // 
            this.ColumnEmployeeTC.Caption = "T.C KİMLİK NO";
            this.ColumnEmployeeTC.FieldName = "EmployeeTC";
            this.ColumnEmployeeTC.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeTC.ImageOptions.Image")));
            this.ColumnEmployeeTC.Name = "ColumnEmployeeTC";
            this.ColumnEmployeeTC.Visible = true;
            this.ColumnEmployeeTC.VisibleIndex = 2;
            this.ColumnEmployeeTC.Width = 66;
            // 
            // ColumnEmployeeName
            // 
            this.ColumnEmployeeName.Caption = "Adı";
            this.ColumnEmployeeName.FieldName = "EmployeeName";
            this.ColumnEmployeeName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeName.ImageOptions.Image")));
            this.ColumnEmployeeName.Name = "ColumnEmployeeName";
            this.ColumnEmployeeName.Visible = true;
            this.ColumnEmployeeName.VisibleIndex = 3;
            this.ColumnEmployeeName.Width = 66;
            // 
            // ColumnEmployeeSurName
            // 
            this.ColumnEmployeeSurName.Caption = "Soyadı";
            this.ColumnEmployeeSurName.FieldName = "EmployeeSurName";
            this.ColumnEmployeeSurName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeSurName.ImageOptions.Image")));
            this.ColumnEmployeeSurName.Name = "ColumnEmployeeSurName";
            this.ColumnEmployeeSurName.Visible = true;
            this.ColumnEmployeeSurName.VisibleIndex = 4;
            this.ColumnEmployeeSurName.Width = 65;
            // 
            // ColumnEmployeeGender
            // 
            this.ColumnEmployeeGender.Caption = "Cinsiyet";
            this.ColumnEmployeeGender.FieldName = "EmployeeGender";
            this.ColumnEmployeeGender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeGender.ImageOptions.Image")));
            this.ColumnEmployeeGender.Name = "ColumnEmployeeGender";
            this.ColumnEmployeeGender.Visible = true;
            this.ColumnEmployeeGender.VisibleIndex = 5;
            this.ColumnEmployeeGender.Width = 63;
            // 
            // ColumnEmployeeDateOfBirth
            // 
            this.ColumnEmployeeDateOfBirth.Caption = "Doğum Tarihi";
            this.ColumnEmployeeDateOfBirth.FieldName = "EmployeeDateOfBirth";
            this.ColumnEmployeeDateOfBirth.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeDateOfBirth.ImageOptions.Image")));
            this.ColumnEmployeeDateOfBirth.Name = "ColumnEmployeeDateOfBirth";
            this.ColumnEmployeeDateOfBirth.Visible = true;
            this.ColumnEmployeeDateOfBirth.VisibleIndex = 6;
            this.ColumnEmployeeDateOfBirth.Width = 63;
            // 
            // ColumnMobilePhone
            // 
            this.ColumnMobilePhone.Caption = "Telefon:";
            this.ColumnMobilePhone.FieldName = "EmployeePhone";
            this.ColumnMobilePhone.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnMobilePhone.ImageOptions.Image")));
            this.ColumnMobilePhone.Name = "ColumnMobilePhone";
            this.ColumnMobilePhone.Visible = true;
            this.ColumnMobilePhone.VisibleIndex = 7;
            this.ColumnMobilePhone.Width = 63;
            // 
            // ColumnEmployeeMail
            // 
            this.ColumnEmployeeMail.Caption = "E-Posta Adresi";
            this.ColumnEmployeeMail.FieldName = "EmployeeMail";
            this.ColumnEmployeeMail.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeMail.ImageOptions.Image")));
            this.ColumnEmployeeMail.Name = "ColumnEmployeeMail";
            this.ColumnEmployeeMail.Visible = true;
            this.ColumnEmployeeMail.VisibleIndex = 8;
            this.ColumnEmployeeMail.Width = 63;
            // 
            // ColumnCounty
            // 
            this.ColumnCounty.Caption = "İl";
            this.ColumnCounty.FieldName = "CountyName";
            this.ColumnCounty.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCounty.ImageOptions.Image")));
            this.ColumnCounty.Name = "ColumnCounty";
            this.ColumnCounty.Visible = true;
            this.ColumnCounty.VisibleIndex = 9;
            this.ColumnCounty.Width = 63;
            // 
            // ColumnDistrict
            // 
            this.ColumnDistrict.Caption = "İlçe";
            this.ColumnDistrict.FieldName = "DistrictName";
            this.ColumnDistrict.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnDistrict.ImageOptions.Image")));
            this.ColumnDistrict.Name = "ColumnDistrict";
            this.ColumnDistrict.Visible = true;
            this.ColumnDistrict.VisibleIndex = 10;
            this.ColumnDistrict.Width = 63;
            // 
            // ColumnHomeAddress
            // 
            this.ColumnHomeAddress.Caption = "Ev Adresi";
            this.ColumnHomeAddress.FieldName = "EmployeeHomeAddress";
            this.ColumnHomeAddress.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnHomeAddress.ImageOptions.Image")));
            this.ColumnHomeAddress.Name = "ColumnHomeAddress";
            this.ColumnHomeAddress.Visible = true;
            this.ColumnHomeAddress.VisibleIndex = 11;
            this.ColumnHomeAddress.Width = 63;
            // 
            // EmployeeExpandWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 497);
            this.Controls.Add(this.GControlEmployee);
            this.Name = "EmployeeExpandWF";
            this.Text = "EmployeeExpandWF";
            this.Load += new System.EventHandler(this.EmployeeExpandWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControlEmployee;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeTC;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeSurName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeGender;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeDateOfBirth;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnMobilePhone;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeMail;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnCounty;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDistrict;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnHomeAddress;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnDepartment;
    }
}