namespace PresentationLayer.WinFormList.ExpenseWF
{
    partial class ExpenseHeaderArchiveINExpenseContentWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseHeaderArchiveINExpenseContentWF));
            this.GControlExpenseContent = new DevExpress.XtraGrid.GridControl();
            this.GViewExpenseContent = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnExpenseContentID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExpenseContentTitle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExpenseContentType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExpenseContentPeceiptNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExpenseContentPeceiptPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnExpenseContentNote = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnImage = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GControlExpenseContent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewExpenseContent)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlExpenseContent
            // 
            this.GControlExpenseContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlExpenseContent.Location = new System.Drawing.Point(0, 0);
            this.GControlExpenseContent.MainView = this.GViewExpenseContent;
            this.GControlExpenseContent.Name = "GControlExpenseContent";
            this.GControlExpenseContent.Size = new System.Drawing.Size(1184, 484);
            this.GControlExpenseContent.TabIndex = 16;
            this.GControlExpenseContent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewExpenseContent});
            // 
            // GViewExpenseContent
            // 
            this.GViewExpenseContent.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnExpenseContentID,
            this.ColumnExpenseContentTitle,
            this.ColumnExpenseContentType,
            this.ColumnExpenseContentPeceiptNumber,
            this.ColumnExpenseContentPeceiptPrice,
            this.ColumnExpenseContentNote,
            this.ColumnImage});
            this.GViewExpenseContent.DetailHeight = 303;
            this.GViewExpenseContent.GridControl = this.GControlExpenseContent;
            this.GViewExpenseContent.Name = "GViewExpenseContent";
            this.GViewExpenseContent.OptionsBehavior.Editable = false;
            this.GViewExpenseContent.OptionsBehavior.ReadOnly = true;
            this.GViewExpenseContent.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnExpenseContentID
            // 
            this.ColumnExpenseContentID.Caption = "ID";
            this.ColumnExpenseContentID.FieldName = "ExpenseContentID";
            this.ColumnExpenseContentID.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExpenseContentID.ImageOptions.Image")));
            this.ColumnExpenseContentID.Name = "ColumnExpenseContentID";
            this.ColumnExpenseContentID.Visible = true;
            this.ColumnExpenseContentID.VisibleIndex = 0;
            this.ColumnExpenseContentID.Width = 61;
            // 
            // ColumnExpenseContentTitle
            // 
            this.ColumnExpenseContentTitle.Caption = "Gider Adı";
            this.ColumnExpenseContentTitle.FieldName = "ExpenseContentTitle";
            this.ColumnExpenseContentTitle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExpenseContentTitle.ImageOptions.Image")));
            this.ColumnExpenseContentTitle.Name = "ColumnExpenseContentTitle";
            this.ColumnExpenseContentTitle.Visible = true;
            this.ColumnExpenseContentTitle.VisibleIndex = 1;
            this.ColumnExpenseContentTitle.Width = 165;
            // 
            // ColumnExpenseContentType
            // 
            this.ColumnExpenseContentType.Caption = "Gider Türü";
            this.ColumnExpenseContentType.FieldName = "ExpenseContentType";
            this.ColumnExpenseContentType.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExpenseContentType.ImageOptions.Image")));
            this.ColumnExpenseContentType.Name = "ColumnExpenseContentType";
            this.ColumnExpenseContentType.Visible = true;
            this.ColumnExpenseContentType.VisibleIndex = 2;
            this.ColumnExpenseContentType.Width = 165;
            // 
            // ColumnExpenseContentPeceiptNumber
            // 
            this.ColumnExpenseContentPeceiptNumber.Caption = "Fiş Numarası";
            this.ColumnExpenseContentPeceiptNumber.FieldName = "ExpenseContentPeceiptNumber";
            this.ColumnExpenseContentPeceiptNumber.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExpenseContentPeceiptNumber.ImageOptions.Image")));
            this.ColumnExpenseContentPeceiptNumber.Name = "ColumnExpenseContentPeceiptNumber";
            this.ColumnExpenseContentPeceiptNumber.Visible = true;
            this.ColumnExpenseContentPeceiptNumber.VisibleIndex = 3;
            this.ColumnExpenseContentPeceiptNumber.Width = 100;
            // 
            // ColumnExpenseContentPeceiptPrice
            // 
            this.ColumnExpenseContentPeceiptPrice.Caption = "Fiş Fiyati";
            this.ColumnExpenseContentPeceiptPrice.FieldName = "ExpenseContentPeceiptPrice";
            this.ColumnExpenseContentPeceiptPrice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExpenseContentPeceiptPrice.ImageOptions.Image")));
            this.ColumnExpenseContentPeceiptPrice.Name = "ColumnExpenseContentPeceiptPrice";
            this.ColumnExpenseContentPeceiptPrice.Visible = true;
            this.ColumnExpenseContentPeceiptPrice.VisibleIndex = 4;
            this.ColumnExpenseContentPeceiptPrice.Width = 120;
            // 
            // ColumnExpenseContentNote
            // 
            this.ColumnExpenseContentNote.Caption = "Ekstra Not";
            this.ColumnExpenseContentNote.FieldName = "ExpenseContentNote";
            this.ColumnExpenseContentNote.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("ColumnExpenseContentNote.ImageOptions.Image")));
            this.ColumnExpenseContentNote.Name = "ColumnExpenseContentNote";
            this.ColumnExpenseContentNote.Visible = true;
            this.ColumnExpenseContentNote.VisibleIndex = 5;
            this.ColumnExpenseContentNote.Width = 264;
            // 
            // ColumnImage
            // 
            this.ColumnImage.Caption = "ImagePath";
            this.ColumnImage.FieldName = "ExpenseContentPeceiptImage";
            this.ColumnImage.Name = "ColumnImage";
            this.ColumnImage.Width = 150;
            // 
            // ExpenseHeaderArchiveINExpenseContentWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 484);
            this.Controls.Add(this.GControlExpenseContent);
            this.Name = "ExpenseHeaderArchiveINExpenseContentWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARŞİVLENMİŞ GİDER BAŞLIKLARI İÇERİKLERİ";
            this.Load += new System.EventHandler(this.ExpenseHeaderArchiveINExpenseContentWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlExpenseContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewExpenseContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl GControlExpenseContent;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewExpenseContent;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExpenseContentID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExpenseContentTitle;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExpenseContentType;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExpenseContentPeceiptNumber;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExpenseContentPeceiptPrice;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnExpenseContentNote;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnImage;
    }
}