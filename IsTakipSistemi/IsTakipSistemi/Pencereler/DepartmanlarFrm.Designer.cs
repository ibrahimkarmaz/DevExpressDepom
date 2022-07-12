
namespace IsTakipSistemi.Pencereler
{
    partial class DepartmanlarFrm
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
            this.GroupControlDepartman = new DevExpress.XtraEditors.GroupControl();
            this.SBtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.SbtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.TEDepartmanAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TEDepartmanID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.GControlDepartman = new DevExpress.XtraGrid.GridControl();
            this.GViewDepartmanListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControlDepartman)).BeginInit();
            this.GroupControlDepartman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEDepartmanAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEDepartmanID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlDepartman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewDepartmanListe)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupControlDepartman
            // 
            this.GroupControlDepartman.Controls.Add(this.SBtnGuncelle);
            this.GroupControlDepartman.Controls.Add(this.SbtnSil);
            this.GroupControlDepartman.Controls.Add(this.SBtnKaydet);
            this.GroupControlDepartman.Controls.Add(this.SBtnListele);
            this.GroupControlDepartman.Controls.Add(this.TEDepartmanAd);
            this.GroupControlDepartman.Controls.Add(this.labelControl2);
            this.GroupControlDepartman.Controls.Add(this.TEDepartmanID);
            this.GroupControlDepartman.Controls.Add(this.labelControl1);
            this.GroupControlDepartman.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupControlDepartman.Location = new System.Drawing.Point(740, 0);
            this.GroupControlDepartman.Name = "GroupControlDepartman";
            this.GroupControlDepartman.ShowCaption = false;
            this.GroupControlDepartman.Size = new System.Drawing.Size(232, 480);
            this.GroupControlDepartman.TabIndex = 1;
            this.GroupControlDepartman.Text = "groupControl1";
            // 
            // SBtnGuncelle
            // 
            this.SBtnGuncelle.ImageOptions.Image = global::IsTakipSistemi.Properties.Resources.pencolor_32x32;
            this.SBtnGuncelle.Location = new System.Drawing.Point(6, 103);
            this.SBtnGuncelle.Name = "SBtnGuncelle";
            this.SBtnGuncelle.Size = new System.Drawing.Size(214, 36);
            this.SBtnGuncelle.TabIndex = 7;
            this.SBtnGuncelle.Text = "Düzenle";
            this.SBtnGuncelle.Click += new System.EventHandler(this.SBtnGuncelle_Click);
            // 
            // SbtnSil
            // 
            this.SbtnSil.ImageOptions.Image = global::IsTakipSistemi.Properties.Resources.cancel_32x32;
            this.SbtnSil.Location = new System.Drawing.Point(6, 145);
            this.SbtnSil.Name = "SbtnSil";
            this.SbtnSil.Size = new System.Drawing.Size(214, 36);
            this.SbtnSil.TabIndex = 6;
            this.SbtnSil.Text = "Sil";
            this.SbtnSil.Click += new System.EventHandler(this.SbtnSil_Click);
            // 
            // SBtnKaydet
            // 
            this.SBtnKaydet.ImageOptions.Image = global::IsTakipSistemi.Properties.Resources.add_32x322;
            this.SBtnKaydet.Location = new System.Drawing.Point(6, 61);
            this.SBtnKaydet.Name = "SBtnKaydet";
            this.SBtnKaydet.Size = new System.Drawing.Size(214, 36);
            this.SBtnKaydet.TabIndex = 5;
            this.SBtnKaydet.Text = "Kaydet";
            this.SBtnKaydet.Click += new System.EventHandler(this.SBtnKaydet_Click);
            // 
            // SBtnListele
            // 
            this.SBtnListele.ImageOptions.Image = global::IsTakipSistemi.Properties.Resources.listbox_32x321;
            this.SBtnListele.Location = new System.Drawing.Point(6, 187);
            this.SBtnListele.Name = "SBtnListele";
            this.SBtnListele.Size = new System.Drawing.Size(214, 36);
            this.SBtnListele.TabIndex = 4;
            this.SBtnListele.Text = "Listele";
            this.SBtnListele.Click += new System.EventHandler(this.SBtnListele_Click);
            // 
            // TEDepartmanAd
            // 
            this.TEDepartmanAd.Location = new System.Drawing.Point(87, 35);
            this.TEDepartmanAd.Name = "TEDepartmanAd";
            this.TEDepartmanAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEDepartmanAd.Properties.Appearance.Options.UseFont = true;
            this.TEDepartmanAd.Size = new System.Drawing.Size(133, 20);
            this.TEDepartmanAd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Departman Adı:";
            // 
            // TEDepartmanID
            // 
            this.TEDepartmanID.Location = new System.Drawing.Point(87, 9);
            this.TEDepartmanID.Name = "TEDepartmanID";
            this.TEDepartmanID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEDepartmanID.Properties.Appearance.Options.UseFont = true;
            this.TEDepartmanID.Size = new System.Drawing.Size(133, 20);
            this.TEDepartmanID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Departman ID:";
            // 
            // GControlDepartman
            // 
            this.GControlDepartman.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlDepartman.Location = new System.Drawing.Point(0, 0);
            this.GControlDepartman.MainView = this.GViewDepartmanListe;
            this.GControlDepartman.Name = "GControlDepartman";
            this.GControlDepartman.Size = new System.Drawing.Size(740, 480);
            this.GControlDepartman.TabIndex = 2;
            this.GControlDepartman.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewDepartmanListe});
            // 
            // GViewDepartmanListe
            // 
            this.GViewDepartmanListe.GridControl = this.GControlDepartman;
            this.GViewDepartmanListe.Name = "GViewDepartmanListe";
            this.GViewDepartmanListe.OptionsView.ShowGroupPanel = false;
            this.GViewDepartmanListe.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GViewDepartmanListe_FocusedRowChanged);
            // 
            // DepartmanlarFrm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 480);
            this.Controls.Add(this.GControlDepartman);
            this.Controls.Add(this.GroupControlDepartman);
            this.Name = "DepartmanlarFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departman Penceresi";
            this.Load += new System.EventHandler(this.DepartmanlarFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GroupControlDepartman)).EndInit();
            this.GroupControlDepartman.ResumeLayout(false);
            this.GroupControlDepartman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEDepartmanAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEDepartmanID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlDepartman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewDepartmanListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl GroupControlDepartman;
        private DevExpress.XtraGrid.GridControl GControlDepartman;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewDepartmanListe;
        private DevExpress.XtraEditors.TextEdit TEDepartmanAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TEDepartmanID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton SBtnListele;
        private DevExpress.XtraEditors.SimpleButton SBtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton SbtnSil;
        private DevExpress.XtraEditors.SimpleButton SBtnKaydet;
    }
}