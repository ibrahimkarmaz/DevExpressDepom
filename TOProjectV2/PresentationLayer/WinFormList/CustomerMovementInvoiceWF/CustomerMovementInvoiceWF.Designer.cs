namespace PresentationLayer.WinFormList.CustomerMovementInvoice
{
	partial class CustomerMovementInvoiceWF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerMovementInvoiceWF));
			DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions2 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject5 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject6 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject7 = new DevExpress.Utils.SerializableAppearanceObject();
			DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject8 = new DevExpress.Utils.SerializableAppearanceObject();
			this.GControlInvoice = new DevExpress.XtraGrid.GridControl();
			this.GViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ColumnCompanyID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnEmployeeName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnInvoiceSeries = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnCustomerMovementDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnMovementNote = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnCustomerMovementInvoiceButton = new DevExpress.XtraGrid.Columns.GridColumn();
			this.BtnEditCustomerInvoice = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
			this.groupControlExpenseHeader = new DevExpress.XtraEditors.GroupControl();
			((System.ComponentModel.ISupportInitialize)(this.GControlInvoice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GViewCustomer)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnEditCustomerInvoice)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlExpenseHeader)).BeginInit();
			this.groupControlExpenseHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// GControlInvoice
			// 
			this.GControlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
			this.GControlInvoice.Location = new System.Drawing.Point(2, 29);
			this.GControlInvoice.MainView = this.GViewCustomer;
			this.GControlInvoice.Name = "GControlInvoice";
			this.GControlInvoice.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.BtnEditCustomerInvoice});
			this.GControlInvoice.Size = new System.Drawing.Size(1161, 470);
			this.GControlInvoice.TabIndex = 2;
			this.GControlInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewCustomer});
			// 
			// GViewCustomer
			// 
			this.GViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnCompanyID,
            this.ColumnCustomerName,
            this.ColumnEmployeeName,
            this.ColumnInvoiceSeries,
            this.ColumnCustomerMovementDate,
            this.ColumnMovementNote,
            this.ColumnCustomerMovementInvoiceButton});
			this.GViewCustomer.DetailHeight = 303;
			this.GViewCustomer.GridControl = this.GControlInvoice;
			this.GViewCustomer.Name = "GViewCustomer";
			this.GViewCustomer.OptionsView.ShowGroupPanel = false;
			// 
			// ColumnCompanyID
			// 
			this.ColumnCompanyID.Caption = "ID";
			this.ColumnCompanyID.FieldName = "InvoiceID";
			this.ColumnCompanyID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCompanyID.ImageOptions.Image")));
			this.ColumnCompanyID.MinWidth = 18;
			this.ColumnCompanyID.Name = "ColumnCompanyID";
			this.ColumnCompanyID.OptionsColumn.ReadOnly = true;
			this.ColumnCompanyID.Visible = true;
			this.ColumnCompanyID.VisibleIndex = 0;
			this.ColumnCompanyID.Width = 133;
			// 
			// ColumnCustomerName
			// 
			this.ColumnCustomerName.Caption = "Müşteri";
			this.ColumnCustomerName.FieldName = "CustomerName";
			this.ColumnCustomerName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerName.ImageOptions.Image")));
			this.ColumnCustomerName.MinWidth = 40;
			this.ColumnCustomerName.Name = "ColumnCustomerName";
			this.ColumnCustomerName.OptionsColumn.ReadOnly = true;
			this.ColumnCustomerName.Visible = true;
			this.ColumnCustomerName.VisibleIndex = 2;
			this.ColumnCustomerName.Width = 273;
			// 
			// ColumnEmployeeName
			// 
			this.ColumnEmployeeName.Caption = "Personel";
			this.ColumnEmployeeName.FieldName = "EmployeeNameSurName";
			this.ColumnEmployeeName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnEmployeeName.ImageOptions.Image")));
			this.ColumnEmployeeName.MinWidth = 18;
			this.ColumnEmployeeName.Name = "ColumnEmployeeName";
			this.ColumnEmployeeName.OptionsColumn.ReadOnly = true;
			this.ColumnEmployeeName.Visible = true;
			this.ColumnEmployeeName.VisibleIndex = 3;
			this.ColumnEmployeeName.Width = 166;
			// 
			// ColumnInvoiceSeries
			// 
			this.ColumnInvoiceSeries.Caption = "Fatura No";
			this.ColumnInvoiceSeries.FieldName = "InvoiceSeries";
			this.ColumnInvoiceSeries.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnInvoiceSeries.ImageOptions.Image")));
			this.ColumnInvoiceSeries.Name = "ColumnInvoiceSeries";
			this.ColumnInvoiceSeries.OptionsColumn.ReadOnly = true;
			this.ColumnInvoiceSeries.Visible = true;
			this.ColumnInvoiceSeries.VisibleIndex = 1;
			this.ColumnInvoiceSeries.Width = 172;
			// 
			// ColumnCustomerMovementDate
			// 
			this.ColumnCustomerMovementDate.Caption = "Tarih";
			this.ColumnCustomerMovementDate.FieldName = "CustomerMovementDate";
			this.ColumnCustomerMovementDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerMovementDate.ImageOptions.Image")));
			this.ColumnCustomerMovementDate.MinWidth = 15;
			this.ColumnCustomerMovementDate.Name = "ColumnCustomerMovementDate";
			this.ColumnCustomerMovementDate.OptionsColumn.ReadOnly = true;
			this.ColumnCustomerMovementDate.Visible = true;
			this.ColumnCustomerMovementDate.VisibleIndex = 4;
			this.ColumnCustomerMovementDate.Width = 192;
			// 
			// ColumnMovementNote
			// 
			this.ColumnMovementNote.Caption = "Not";
			this.ColumnMovementNote.FieldName = "CustomerMovemenNote";
			this.ColumnMovementNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnMovementNote.ImageOptions.Image")));
			this.ColumnMovementNote.Name = "ColumnMovementNote";
			this.ColumnMovementNote.OptionsColumn.ReadOnly = true;
			this.ColumnMovementNote.Visible = true;
			this.ColumnMovementNote.VisibleIndex = 5;
			this.ColumnMovementNote.Width = 197;
			// 
			// ColumnCustomerMovementInvoiceButton
			// 
			this.ColumnCustomerMovementInvoiceButton.ColumnEdit = this.BtnEditCustomerInvoice;
			this.ColumnCustomerMovementInvoiceButton.Name = "ColumnCustomerMovementInvoiceButton";
			this.ColumnCustomerMovementInvoiceButton.Visible = true;
			this.ColumnCustomerMovementInvoiceButton.VisibleIndex = 6;
			// 
			// BtnEditCustomerInvoice
			// 
			this.BtnEditCustomerInvoice.AutoHeight = false;
			editorButtonImageOptions2.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions2.Image")));
			this.BtnEditCustomerInvoice.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions2, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject5, serializableAppearanceObject6, serializableAppearanceObject7, serializableAppearanceObject8, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
			this.BtnEditCustomerInvoice.Name = "BtnEditCustomerInvoice";
			this.BtnEditCustomerInvoice.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
			this.BtnEditCustomerInvoice.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnEditCustomerInvoice_ButtonClick);
			// 
			// groupControlExpenseHeader
			// 
			this.groupControlExpenseHeader.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupControlExpenseHeader.AppearanceCaption.Options.UseFont = true;
			this.groupControlExpenseHeader.AppearanceCaption.Options.UseTextOptions = true;
			this.groupControlExpenseHeader.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
			this.groupControlExpenseHeader.AppearanceCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
			this.groupControlExpenseHeader.Controls.Add(this.GControlInvoice);
			this.groupControlExpenseHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupControlExpenseHeader.Location = new System.Drawing.Point(0, 0);
			this.groupControlExpenseHeader.Name = "groupControlExpenseHeader";
			this.groupControlExpenseHeader.Size = new System.Drawing.Size(1165, 501);
			this.groupControlExpenseHeader.TabIndex = 14;
			this.groupControlExpenseHeader.Text = "MÜŞTERİ HAREKETLERİ";
			// 
			// CustomerMovementInvoiceWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1165, 501);
			this.Controls.Add(this.groupControlExpenseHeader);
			this.Name = "CustomerMovementInvoiceWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MÜŞTERİ HAREKETLERİ FATURALAR";
			this.Load += new System.EventHandler(this.CustomerMovementInvoiceWF_Load);
			((System.ComponentModel.ISupportInitialize)(this.GControlInvoice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GViewCustomer)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.BtnEditCustomerInvoice)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.groupControlExpenseHeader)).EndInit();
			this.groupControlExpenseHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl GControlInvoice;
		private DevExpress.XtraGrid.Views.Grid.GridView GViewCustomer;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnCompanyID;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerName;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnEmployeeName;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnInvoiceSeries;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerMovementDate;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnMovementNote;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerMovementInvoiceButton;
		private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit BtnEditCustomerInvoice;
		private DevExpress.XtraEditors.GroupControl groupControlExpenseHeader;
	}
}