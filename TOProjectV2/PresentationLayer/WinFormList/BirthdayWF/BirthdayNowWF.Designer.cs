namespace PresentationLayer.WinFormList.BirthdayWF
{
	partial class BirthdayNowWF
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BirthdayNowWF));
			this.GControlBirthday = new DevExpress.XtraGrid.GridControl();
			this.GViewBirthday = new DevExpress.XtraGrid.Views.Grid.GridView();
			this.ColumnCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnCustomerName = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnSurname = new DevExpress.XtraGrid.Columns.GridColumn();
			this.ColumnBirthdayDate = new DevExpress.XtraGrid.Columns.GridColumn();
			this.SBtnSMSSeender = new DevExpress.XtraEditors.SimpleButton();
			this.SBtnMailSend = new DevExpress.XtraEditors.SimpleButton();
			this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
			((System.ComponentModel.ISupportInitialize)(this.GControlBirthday)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.GViewBirthday)).BeginInit();
			this.SuspendLayout();
			// 
			// GControlBirthday
			// 
			this.GControlBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.GControlBirthday.Location = new System.Drawing.Point(12, 12);
			this.GControlBirthday.MainView = this.GViewBirthday;
			this.GControlBirthday.Name = "GControlBirthday";
			this.GControlBirthday.Size = new System.Drawing.Size(560, 243);
			this.GControlBirthday.TabIndex = 5;
			this.GControlBirthday.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewBirthday});
			// 
			// GViewBirthday
			// 
			this.GViewBirthday.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnCustomerID,
            this.ColumnCustomerName,
            this.ColumnSurname,
            this.ColumnBirthdayDate});
			this.GViewBirthday.GridControl = this.GControlBirthday;
			this.GViewBirthday.Name = "GViewBirthday";
			this.GViewBirthday.OptionsView.ShowGroupPanel = false;
			// 
			// ColumnCustomerID
			// 
			this.ColumnCustomerID.Caption = "Customer ID";
			this.ColumnCustomerID.FieldName = "CustomerID";
			this.ColumnCustomerID.ImageOptions.Alignment = System.Drawing.StringAlignment.Far;
			this.ColumnCustomerID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerID.ImageOptions.Image")));
			this.ColumnCustomerID.Name = "ColumnCustomerID";
			this.ColumnCustomerID.Width = 97;
			// 
			// ColumnCustomerName
			// 
			this.ColumnCustomerName.Caption = "Adı";
			this.ColumnCustomerName.FieldName = "CustomerName";
			this.ColumnCustomerName.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnCustomerName.ImageOptions.Image")));
			this.ColumnCustomerName.Name = "ColumnCustomerName";
			this.ColumnCustomerName.Visible = true;
			this.ColumnCustomerName.VisibleIndex = 0;
			this.ColumnCustomerName.Width = 254;
			// 
			// ColumnSurname
			// 
			this.ColumnSurname.Caption = "Soyadı";
			this.ColumnSurname.FieldName = "CustomerSurName";
			this.ColumnSurname.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnSurname.ImageOptions.Image")));
			this.ColumnSurname.Name = "ColumnSurname";
			this.ColumnSurname.Visible = true;
			this.ColumnSurname.VisibleIndex = 1;
			this.ColumnSurname.Width = 254;
			// 
			// ColumnBirthdayDate
			// 
			this.ColumnBirthdayDate.Caption = "Doğum Günü";
			this.ColumnBirthdayDate.FieldName = "CustomerDateOfBirth";
			this.ColumnBirthdayDate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnBirthdayDate.ImageOptions.Image")));
			this.ColumnBirthdayDate.Name = "ColumnBirthdayDate";
			this.ColumnBirthdayDate.Visible = true;
			this.ColumnBirthdayDate.VisibleIndex = 2;
			this.ColumnBirthdayDate.Width = 141;
			// 
			// SBtnSMSSeender
			// 
			this.SBtnSMSSeender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SBtnSMSSeender.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBtnSMSSeender.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnSMSSeender.ImageOptions.Image")));
			this.SBtnSMSSeender.Location = new System.Drawing.Point(129, 261);
			this.SBtnSMSSeender.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBtnSMSSeender.Name = "SBtnSMSSeender";
			this.SBtnSMSSeender.Size = new System.Drawing.Size(220, 39);
			this.SBtnSMSSeender.TabIndex = 32;
			this.SBtnSMSSeender.Text = "SMS GÖNDER";
			this.SBtnSMSSeender.Click += new System.EventHandler(this.SBtnSMSSeender_Click);
			// 
			// SBtnMailSend
			// 
			this.SBtnMailSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SBtnMailSend.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBtnMailSend.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
			this.SBtnMailSend.Location = new System.Drawing.Point(352, 259);
			this.SBtnMailSend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBtnMailSend.Name = "SBtnMailSend";
			this.SBtnMailSend.Size = new System.Drawing.Size(220, 39);
			this.SBtnMailSend.TabIndex = 33;
			this.SBtnMailSend.Text = "E-POSTA GÖNDER";
			this.SBtnMailSend.Click += new System.EventHandler(this.SBtnMailSend_Click);
			// 
			// SBCancel
			// 
			this.SBCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
			this.SBCancel.Location = new System.Drawing.Point(13, 261);
			this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.SBCancel.Name = "SBCancel";
			this.SBCancel.Size = new System.Drawing.Size(108, 39);
			this.SBCancel.TabIndex = 34;
			this.SBCancel.Text = "İptal Et";
			this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
			// 
			// BirthdayNowWF
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 310);
			this.Controls.Add(this.SBCancel);
			this.Controls.Add(this.SBtnMailSend);
			this.Controls.Add(this.SBtnSMSSeender);
			this.Controls.Add(this.GControlBirthday);
			this.Name = "BirthdayNowWF";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Müşteri Doğum Günü(Bugün)";
			this.Load += new System.EventHandler(this.BirthdayNowWF_Load);
			((System.ComponentModel.ISupportInitialize)(this.GControlBirthday)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.GViewBirthday)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraGrid.GridControl GControlBirthday;
		private DevExpress.XtraGrid.Views.Grid.GridView GViewBirthday;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerID;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnCustomerName;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnSurname;
		private DevExpress.XtraGrid.Columns.GridColumn ColumnBirthdayDate;
		private DevExpress.XtraEditors.SimpleButton SBtnSMSSeender;
		private DevExpress.XtraEditors.SimpleButton SBtnMailSend;
		private DevExpress.XtraEditors.SimpleButton SBCancel;
	}
}