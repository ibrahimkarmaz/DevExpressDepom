namespace PresentationLayer.WinFormList
{
    partial class BlandArchiveListWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlandArchiveListWF));
            this.GroupControlBland = new DevExpress.XtraEditors.GroupControl();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnArchiveQuit = new DevExpress.XtraEditors.SimpleButton();
            this.GControlBland = new DevExpress.XtraGrid.GridControl();
            this.GViewBland = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnBlandID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnBlandName = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControlBland)).BeginInit();
            this.GroupControlBland.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlBland)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBland)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupControlBland
            // 
            this.GroupControlBland.Controls.Add(this.SBCancel);
            this.GroupControlBland.Controls.Add(this.SBtnArchiveQuit);
            this.GroupControlBland.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupControlBland.Location = new System.Drawing.Point(0, 390);
            this.GroupControlBland.Name = "GroupControlBland";
            this.GroupControlBland.Size = new System.Drawing.Size(554, 80);
            this.GroupControlBland.TabIndex = 1;
            this.GroupControlBland.Text = "Arşiv İşlemleri";
            // 
            // SBCancel
            // 
            this.SBCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(232, 33);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(97, 39);
            this.SBCancel.TabIndex = 29;
            this.SBCancel.Text = "İptal Et";
            this.SBCancel.Click += new System.EventHandler(this.SBCancel_Click);
            // 
            // SBtnArchiveQuit
            // 
            this.SBtnArchiveQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBtnArchiveQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnArchiveQuit.ImageOptions.Image")));
            this.SBtnArchiveQuit.Location = new System.Drawing.Point(337, 33);
            this.SBtnArchiveQuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnArchiveQuit.Name = "SBtnArchiveQuit";
            this.SBtnArchiveQuit.Size = new System.Drawing.Size(211, 39);
            this.SBtnArchiveQuit.TabIndex = 28;
            this.SBtnArchiveQuit.Text = "Markayı Arşivden Çıkar";
            this.SBtnArchiveQuit.Click += new System.EventHandler(this.SBtnArchiveQuit_Click);
            // 
            // GControlBland
            // 
            this.GControlBland.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlBland.Location = new System.Drawing.Point(0, 0);
            this.GControlBland.MainView = this.GViewBland;
            this.GControlBland.Name = "GControlBland";
            this.GControlBland.Size = new System.Drawing.Size(554, 390);
            this.GControlBland.TabIndex = 2;
            this.GControlBland.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewBland});
            // 
            // GViewBland
            // 
            this.GViewBland.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnBlandID,
            this.ColumnBlandName});
            this.GViewBland.GridControl = this.GControlBland;
            this.GViewBland.Name = "GViewBland";
            this.GViewBland.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnBlandID
            // 
            this.ColumnBlandID.Caption = "Marka ID";
            this.ColumnBlandID.FieldName = "BlandID";
            this.ColumnBlandID.Name = "ColumnBlandID";
            this.ColumnBlandID.Visible = true;
            this.ColumnBlandID.VisibleIndex = 0;
            this.ColumnBlandID.Width = 126;
            // 
            // ColumnBlandName
            // 
            this.ColumnBlandName.Caption = "Marka Adı";
            this.ColumnBlandName.FieldName = "BlandName";
            this.ColumnBlandName.Name = "ColumnBlandName";
            this.ColumnBlandName.Visible = true;
            this.ColumnBlandName.VisibleIndex = 1;
            this.ColumnBlandName.Width = 398;
            // 
            // BlandArchiveListWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 470);
            this.Controls.Add(this.GControlBland);
            this.Controls.Add(this.GroupControlBland);
            this.Name = "BlandArchiveListWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MARKA ARŞİV LİSTESİ";
            this.Load += new System.EventHandler(this.BlandArchiveListWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControlBland)).EndInit();
            this.GroupControlBland.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlBland)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBland)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupControlBland;
        private DevExpress.XtraGrid.GridControl GControlBland;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewBland;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBlandID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnBlandName;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnArchiveQuit;
    }
}