
namespace Ders7_RibbonControlKullanimi
{
    partial class PncOgrenciler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PncOgrenciler));
            this.label1 = new System.Windows.Forms.Label();
            this.TxeID = new DevExpress.XtraEditors.TextEdit();
            this.Txe_Ad = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.TxeSoyad = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TxeNumara = new DevExpress.XtraEditors.TextEdit();
            this.labelNumara = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.TxeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txe_Ad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxeSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxeNumara.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // TxeID
            // 
            this.TxeID.Location = new System.Drawing.Point(81, 14);
            this.TxeID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxeID.Name = "TxeID";
            this.TxeID.Size = new System.Drawing.Size(154, 20);
            this.TxeID.TabIndex = 1;
            // 
            // Txe_Ad
            // 
            this.Txe_Ad.Location = new System.Drawing.Point(81, 44);
            this.Txe_Ad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Txe_Ad.Name = "Txe_Ad";
            this.Txe_Ad.Size = new System.Drawing.Size(154, 20);
            this.Txe_Ad.TabIndex = 3;
            this.Txe_Ad.EditValueChanged += new System.EventHandler(this.Txe_Ad_EditValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD:";
            // 
            // TxeSoyad
            // 
            this.TxeSoyad.Location = new System.Drawing.Point(81, 74);
            this.TxeSoyad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxeSoyad.Name = "TxeSoyad";
            this.TxeSoyad.Size = new System.Drawing.Size(154, 20);
            this.TxeSoyad.TabIndex = 5;
            this.TxeSoyad.EditValueChanged += new System.EventHandler(this.TxeSoyad_EditValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "SOYAD:";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.simpleButton1.Location = new System.Drawing.Point(17, 132);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(219, 69);
            this.simpleButton1.TabIndex = 6;
            this.simpleButton1.Text = "Temizle";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.Options.UseFont = true;
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.Controls.Add(this.TxeNumara);
            this.panelControl1.Controls.Add(this.labelNumara);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Controls.Add(this.TxeID);
            this.panelControl1.Controls.Add(this.TxeSoyad);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.label3);
            this.panelControl1.Controls.Add(this.Txe_Ad);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl1.Location = new System.Drawing.Point(729, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(248, 419);
            this.panelControl1.TabIndex = 7;
            // 
            // TxeNumara
            // 
            this.TxeNumara.Location = new System.Drawing.Point(81, 104);
            this.TxeNumara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxeNumara.Name = "TxeNumara";
            this.TxeNumara.Size = new System.Drawing.Size(154, 20);
            this.TxeNumara.TabIndex = 8;
            this.TxeNumara.EditValueChanged += new System.EventHandler(this.TxeNumara_EditValueChanged);
            // 
            // labelNumara
            // 
            this.labelNumara.AutoSize = true;
            this.labelNumara.Location = new System.Drawing.Point(12, 104);
            this.labelNumara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNumara.Name = "labelNumara";
            this.labelNumara.Size = new System.Drawing.Size(48, 13);
            this.labelNumara.TabIndex = 7;
            this.labelNumara.Text = "Numara:";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView2;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(729, 419);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.gridView2.Appearance.Row.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Appearance.Row.Options.UseBorderColor = true;
            this.gridView2.GridControl = this.gridControl1;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // PncOgrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 419);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PncOgrenciler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PncOgrenciler";
            this.Load += new System.EventHandler(this.PncOgrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Txe_Ad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxeSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxeNumara.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxeID;
        private DevExpress.XtraEditors.TextEdit Txe_Ad;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxeSoyad;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraEditors.TextEdit TxeNumara;
        private System.Windows.Forms.Label labelNumara;
    }
}