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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseHeaderArchiveINExpenseContentWF));
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            this.tileControl1 = new DevExpress.XtraEditors.TileControl();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
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
            // tileControl1
            // 
            this.tileControl1.AllowDrag = false;
            this.tileControl1.AllowDragTilesBetweenGroups = false;
            this.tileControl1.AllowItemHover = true;
            this.tileControl1.AllowSelectedItem = true;
            this.tileControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tileControl1.Groups.Add(this.tileGroup1);
            this.tileControl1.Location = new System.Drawing.Point(0, 0);
            this.tileControl1.MaxId = 3;
            this.tileControl1.Name = "tileControl1";
            this.tileControl1.Size = new System.Drawing.Size(292, 484);
            this.tileControl1.TabIndex = 22;
            this.tileControl1.Text = "tileControl1";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Items.Add(this.tileItem1);
            this.tileGroup1.Items.Add(this.tileItem2);
            this.tileGroup1.Name = "tileGroup1";
            this.tileGroup1.Text = "tileGroup1";
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.tileItem1.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileItem1.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileItem1.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            tileItemElement1.Appearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tileItemElement1.Appearance.Normal.Options.UseFont = true;
            tileItemElement1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            tileItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement1.ImageOptions.ImageBorderColor = System.Drawing.Color.Red;
            tileItemElement1.Text = "GİDER LİSTESİ";
            tileItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft;
            tileItemElement2.Text = "TÜMÜ";
            tileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItem1.Elements.Add(tileItemElement1);
            this.tileItem1.Elements.Add(tileItemElement2);
            this.tileItem1.Id = 0;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            this.tileItem1.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem1_ItemClick);
            // 
            // tileItem2
            // 
            this.tileItem2.AppearanceItem.Selected.BackColor = System.Drawing.Color.Red;
            this.tileItem2.AppearanceItem.Selected.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.tileItem2.AppearanceItem.Selected.BorderColor = System.Drawing.Color.Lime;
            this.tileItem2.AppearanceItem.Selected.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Selected.Options.UseBorderColor = true;
            this.tileItem2.ContentAnimation = DevExpress.XtraEditors.TileItemContentAnimationType.ScrollTop;
            tileItemElement3.Appearance.Normal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            tileItemElement3.Appearance.Normal.Options.UseFont = true;
            tileItemElement3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            tileItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomRight;
            tileItemElement3.Text = "ARŞİV GİDER LİSTESİ";
            tileItemElement4.Text = "TÜMÜ";
            tileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomLeft;
            this.tileItem2.Elements.Add(tileItemElement3);
            this.tileItem2.Elements.Add(tileItemElement4);
            this.tileItem2.Id = 1;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem2.Name = "tileItem2";
            this.tileItem2.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileItem2_ItemClick);
            // 
            // GControlExpenseContent
            // 
            this.GControlExpenseContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlExpenseContent.Location = new System.Drawing.Point(292, 0);
            this.GControlExpenseContent.MainView = this.GViewExpenseContent;
            this.GControlExpenseContent.Name = "GControlExpenseContent";
            this.GControlExpenseContent.Size = new System.Drawing.Size(892, 484);
            this.GControlExpenseContent.TabIndex = 23;
            this.GControlExpenseContent.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewExpenseContent});
            // 
            // GViewExpenseContent
            // 
            this.GViewExpenseContent.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.GViewExpenseContent.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.GViewExpenseContent.Appearance.Row.Options.UseBackColor = true;
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
            this.GViewExpenseContent.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.GViewExpenseContent_CustomUnboundColumnData);
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
            this.Controls.Add(this.tileControl1);
            this.Name = "ExpenseHeaderArchiveINExpenseContentWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARŞİVLENMİŞ GİDER BAŞLIKLARI İÇERİKLERİ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ExpenseHeaderArchiveINExpenseContentWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlExpenseContent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewExpenseContent)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem2;
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