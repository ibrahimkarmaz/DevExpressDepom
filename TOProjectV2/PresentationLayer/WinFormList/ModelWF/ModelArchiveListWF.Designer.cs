namespace PresentationLayer.WinFormList.ModelWF
{
    partial class ModelArchiveListWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelArchiveListWF));
            this.GroupControlModel = new DevExpress.XtraEditors.GroupControl();
            this.SBCancel = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnArchiveQuit = new DevExpress.XtraEditors.SimpleButton();
            this.LabelBland = new DevExpress.XtraEditors.LabelControl();
            this.GControlModel = new DevExpress.XtraGrid.GridControl();
            this.GViewBland = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColumnModelID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnModelName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColumnModelYear = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControlModel)).BeginInit();
            this.GroupControlModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GControlModel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBland)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupControlModel
            // 
            this.GroupControlModel.Controls.Add(this.SBCancel);
            this.GroupControlModel.Controls.Add(this.SBtnArchiveQuit);
            this.GroupControlModel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupControlModel.Location = new System.Drawing.Point(0, 390);
            this.GroupControlModel.Name = "GroupControlModel";
            this.GroupControlModel.Size = new System.Drawing.Size(553, 80);
            this.GroupControlModel.TabIndex = 3;
            this.GroupControlModel.Text = "Arşiv İşlemleri";
            // 
            // SBCancel
            // 
            this.SBCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBCancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBCancel.ImageOptions.Image")));
            this.SBCancel.Location = new System.Drawing.Point(231, 33);
            this.SBCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBCancel.Name = "SBCancel";
            this.SBCancel.Size = new System.Drawing.Size(97, 39);
            this.SBCancel.TabIndex = 29;
            this.SBCancel.Text = "İptal Et";
            // 
            // SBtnArchiveQuit
            // 
            this.SBtnArchiveQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBtnArchiveQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SBtnArchiveQuit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnArchiveQuit.ImageOptions.Image")));
            this.SBtnArchiveQuit.Location = new System.Drawing.Point(336, 33);
            this.SBtnArchiveQuit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SBtnArchiveQuit.Name = "SBtnArchiveQuit";
            this.SBtnArchiveQuit.Size = new System.Drawing.Size(211, 39);
            this.SBtnArchiveQuit.TabIndex = 28;
            this.SBtnArchiveQuit.Text = "Modeli Arşivden Çıkar";
            // 
            // LabelBland
            // 
            this.LabelBland.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LabelBland.Appearance.Options.UseFont = true;
            this.LabelBland.Appearance.Options.UseTextOptions = true;
            this.LabelBland.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LabelBland.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.LabelBland.Dock = System.Windows.Forms.DockStyle.Top;
            this.LabelBland.Location = new System.Drawing.Point(0, 0);
            this.LabelBland.Name = "LabelBland";
            this.LabelBland.Size = new System.Drawing.Size(553, 51);
            this.LabelBland.TabIndex = 7;
            this.LabelBland.Text = "X MODEL ARŞİVİ";
            // 
            // GControlModel
            // 
            this.GControlModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlModel.Location = new System.Drawing.Point(0, 51);
            this.GControlModel.MainView = this.GViewBland;
            this.GControlModel.Name = "GControlModel";
            this.GControlModel.Size = new System.Drawing.Size(553, 339);
            this.GControlModel.TabIndex = 8;
            this.GControlModel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewBland});
            // 
            // GViewBland
            // 
            this.GViewBland.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColumnModelID,
            this.ColumnModelName,
            this.ColumnModelYear});
            this.GViewBland.GridControl = this.GControlModel;
            this.GViewBland.Name = "GViewBland";
            this.GViewBland.OptionsView.ShowGroupPanel = false;
            // 
            // ColumnModelID
            // 
            this.ColumnModelID.Caption = "Model ID";
            this.ColumnModelID.Name = "ColumnModelID";
            this.ColumnModelID.Visible = true;
            this.ColumnModelID.VisibleIndex = 0;
            this.ColumnModelID.Width = 86;
            // 
            // ColumnModelName
            // 
            this.ColumnModelName.Caption = "Model Adı";
            this.ColumnModelName.Name = "ColumnModelName";
            this.ColumnModelName.Visible = true;
            this.ColumnModelName.VisibleIndex = 1;
            this.ColumnModelName.Width = 274;
            // 
            // ColumnModelYear
            // 
            this.ColumnModelYear.Caption = "Model Yılı";
            this.ColumnModelYear.Name = "ColumnModelYear";
            this.ColumnModelYear.Visible = true;
            this.ColumnModelYear.VisibleIndex = 2;
            this.ColumnModelYear.Width = 108;
            // 
            // ModelArchiveListWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 470);
            this.Controls.Add(this.GControlModel);
            this.Controls.Add(this.LabelBland);
            this.Controls.Add(this.GroupControlModel);
            this.Name = "ModelArchiveListWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ModelArchiveListWF";
            ((System.ComponentModel.ISupportInitialize)(this.GroupControlModel)).EndInit();
            this.GroupControlModel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GControlModel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewBland)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupControlModel;
        private DevExpress.XtraEditors.SimpleButton SBCancel;
        private DevExpress.XtraEditors.SimpleButton SBtnArchiveQuit;
        private DevExpress.XtraEditors.LabelControl LabelBland;
        private DevExpress.XtraGrid.GridControl GControlModel;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewBland;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelID;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelName;
        private DevExpress.XtraGrid.Columns.GridColumn ColumnModelYear;
    }
}