
namespace PictureEditKullanimi
{
    partial class PiceEditKullanim
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.SBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnResimAc = new DevExpress.XtraEditors.SimpleButton();
            this.TESoyad = new DevExpress.XtraEditors.TextEdit();
            this.TEAd = new DevExpress.XtraEditors.TextEdit();
            this.PEResim = new DevExpress.XtraEditors.PictureEdit();
            this.GC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.SBtnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnAramaYap = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TESoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEResim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(178, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(178, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Soyad:";
            // 
            // SBtnKaydet
            // 
            this.SBtnKaydet.ImageOptions.Image = global::PictureEditKullanimi.Properties.Resources.add_32x32;
            this.SBtnKaydet.Location = new System.Drawing.Point(436, 53);
            this.SBtnKaydet.Name = "SBtnKaydet";
            this.SBtnKaydet.Size = new System.Drawing.Size(139, 35);
            this.SBtnKaydet.TabIndex = 6;
            this.SBtnKaydet.Text = "Kaydet";
            this.SBtnKaydet.Click += new System.EventHandler(this.SBtnKaydet_Click);
            // 
            // SBtnResimAc
            // 
            this.SBtnResimAc.ImageOptions.Image = global::PictureEditKullanimi.Properties.Resources.loadfrom_32x32;
            this.SBtnResimAc.Location = new System.Drawing.Point(12, 178);
            this.SBtnResimAc.Name = "SBtnResimAc";
            this.SBtnResimAc.Size = new System.Drawing.Size(160, 33);
            this.SBtnResimAc.TabIndex = 5;
            this.SBtnResimAc.Text = "Resim Aç";
            this.SBtnResimAc.Click += new System.EventHandler(this.SBtnResimAc_Click);
            // 
            // TESoyad
            // 
            this.TESoyad.Location = new System.Drawing.Point(178, 76);
            this.TESoyad.Name = "TESoyad";
            this.TESoyad.Size = new System.Drawing.Size(176, 20);
            this.TESoyad.TabIndex = 4;
            // 
            // TEAd
            // 
            this.TEAd.Location = new System.Drawing.Point(178, 31);
            this.TEAd.Name = "TEAd";
            this.TEAd.Size = new System.Drawing.Size(176, 20);
            this.TEAd.TabIndex = 2;
            // 
            // PEResim
            // 
            this.PEResim.Location = new System.Drawing.Point(12, 12);
            this.PEResim.Name = "PEResim";
            this.PEResim.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PEResim.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.PEResim.Size = new System.Drawing.Size(160, 160);
            this.PEResim.TabIndex = 0;
            this.PEResim.DragDrop += new System.Windows.Forms.DragEventHandler(this.PEResim_DragDrop);
            // 
            // GC
            // 
            this.GC.Location = new System.Drawing.Point(12, 219);
            this.GC.MainView = this.gridView1;
            this.GC.Name = "GC";
            this.GC.Size = new System.Drawing.Size(563, 207);
            this.GC.TabIndex = 7;
            this.GC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.GC.DoubleClick += new System.EventHandler(this.GC_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.GC;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridView1_CustomUnboundColumnData);
            // 
            // SBtnDuzenle
            // 
            this.SBtnDuzenle.ImageOptions.Image = global::PictureEditKullanimi.Properties.Resources.reset2_32x32;
            this.SBtnDuzenle.Location = new System.Drawing.Point(436, 94);
            this.SBtnDuzenle.Name = "SBtnDuzenle";
            this.SBtnDuzenle.Size = new System.Drawing.Size(139, 35);
            this.SBtnDuzenle.TabIndex = 8;
            this.SBtnDuzenle.Text = "Düzenle";
            this.SBtnDuzenle.Click += new System.EventHandler(this.SBtnDuzenle_Click);
            // 
            // SBtnSil
            // 
            this.SBtnSil.ImageOptions.Image = global::PictureEditKullanimi.Properties.Resources.clear_32x32;
            this.SBtnSil.Location = new System.Drawing.Point(436, 135);
            this.SBtnSil.Name = "SBtnSil";
            this.SBtnSil.Size = new System.Drawing.Size(139, 35);
            this.SBtnSil.TabIndex = 9;
            this.SBtnSil.Text = "Sil";
            this.SBtnSil.Click += new System.EventHandler(this.SBtnSil_Click);
            // 
            // SBtnListele
            // 
            this.SBtnListele.ImageOptions.Image = global::PictureEditKullanimi.Properties.Resources.listbox_32x32;
            this.SBtnListele.Location = new System.Drawing.Point(436, 176);
            this.SBtnListele.Name = "SBtnListele";
            this.SBtnListele.Size = new System.Drawing.Size(139, 35);
            this.SBtnListele.TabIndex = 10;
            this.SBtnListele.Text = "Listele";
            this.SBtnListele.Click += new System.EventHandler(this.SBtnListele_Click);
            // 
            // SBtnAramaYap
            // 
            this.SBtnAramaYap.ImageOptions.Image = global::PictureEditKullanimi.Properties.Resources.find_32x32;
            this.SBtnAramaYap.Location = new System.Drawing.Point(436, 12);
            this.SBtnAramaYap.Name = "SBtnAramaYap";
            this.SBtnAramaYap.Size = new System.Drawing.Size(139, 35);
            this.SBtnAramaYap.TabIndex = 11;
            this.SBtnAramaYap.Text = "Arama Yap";
            this.SBtnAramaYap.Click += new System.EventHandler(this.SBtnAramaYap_Click);
            // 
            // PiceEditKullanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 438);
            this.Controls.Add(this.SBtnAramaYap);
            this.Controls.Add(this.SBtnListele);
            this.Controls.Add(this.SBtnSil);
            this.Controls.Add(this.SBtnDuzenle);
            this.Controls.Add(this.GC);
            this.Controls.Add(this.SBtnKaydet);
            this.Controls.Add(this.SBtnResimAc);
            this.Controls.Add(this.TESoyad);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TEAd);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.PEResim);
            this.Name = "PiceEditKullanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PİCTURE EDİT İŞLEMLERİ";
            this.Load += new System.EventHandler(this.PiceEditKullanim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TESoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PEResim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit PEResim;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TEAd;
        private DevExpress.XtraEditors.TextEdit TESoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SBtnResimAc;
        private DevExpress.XtraEditors.SimpleButton SBtnKaydet;
        private DevExpress.XtraGrid.GridControl GC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton SBtnDuzenle;
        private DevExpress.XtraEditors.SimpleButton SBtnSil;
        private DevExpress.XtraEditors.SimpleButton SBtnListele;
        private DevExpress.XtraEditors.SimpleButton SBtnAramaYap;
    }
}

