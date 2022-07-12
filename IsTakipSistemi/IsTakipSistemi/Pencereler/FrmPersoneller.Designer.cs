
namespace IsTakipSistemi.Pencereler
{
    partial class FrmPersoneller
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
            this.GControlPersonel = new DevExpress.XtraGrid.GridControl();
            this.GViewPersonelListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GroupControlPersonel = new DevExpress.XtraEditors.GroupControl();
            this.SBtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.SbtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.TEPersonelAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TEPersonelID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TEPersonelSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TEGORSEL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TEMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.LUEDepartman = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GControlPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewPersonelListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControlPersonel)).BeginInit();
            this.GroupControlPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEPersonelAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPersonelID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPersonelSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGORSEL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEDepartman.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GControlPersonel
            // 
            this.GControlPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GControlPersonel.Location = new System.Drawing.Point(0, 0);
            this.GControlPersonel.MainView = this.GViewPersonelListe;
            this.GControlPersonel.Name = "GControlPersonel";
            this.GControlPersonel.Size = new System.Drawing.Size(678, 442);
            this.GControlPersonel.TabIndex = 4;
            this.GControlPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GViewPersonelListe});
            // 
            // GViewPersonelListe
            // 
            this.GViewPersonelListe.GridControl = this.GControlPersonel;
            this.GViewPersonelListe.Name = "GViewPersonelListe";
            this.GViewPersonelListe.OptionsView.ShowGroupPanel = false;
            this.GViewPersonelListe.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.GViewPersonelListe_FocusedRowChanged);
            // 
            // GroupControlPersonel
            // 
            this.GroupControlPersonel.Appearance.BackColor = System.Drawing.Color.White;
            this.GroupControlPersonel.Appearance.Options.UseBackColor = true;
            this.GroupControlPersonel.Controls.Add(this.LUEDepartman);
            this.GroupControlPersonel.Controls.Add(this.labelControl4);
            this.GroupControlPersonel.Controls.Add(this.TEGORSEL);
            this.GroupControlPersonel.Controls.Add(this.labelControl5);
            this.GroupControlPersonel.Controls.Add(this.TEMail);
            this.GroupControlPersonel.Controls.Add(this.labelControl6);
            this.GroupControlPersonel.Controls.Add(this.TEPersonelSoyad);
            this.GroupControlPersonel.Controls.Add(this.labelControl3);
            this.GroupControlPersonel.Controls.Add(this.SBtnGuncelle);
            this.GroupControlPersonel.Controls.Add(this.SbtnSil);
            this.GroupControlPersonel.Controls.Add(this.SBtnKaydet);
            this.GroupControlPersonel.Controls.Add(this.SBtnListele);
            this.GroupControlPersonel.Controls.Add(this.TEPersonelAd);
            this.GroupControlPersonel.Controls.Add(this.labelControl2);
            this.GroupControlPersonel.Controls.Add(this.TEPersonelID);
            this.GroupControlPersonel.Controls.Add(this.labelControl1);
            this.GroupControlPersonel.Dock = System.Windows.Forms.DockStyle.Right;
            this.GroupControlPersonel.Location = new System.Drawing.Point(678, 0);
            this.GroupControlPersonel.Name = "GroupControlPersonel";
            this.GroupControlPersonel.ShowCaption = false;
            this.GroupControlPersonel.Size = new System.Drawing.Size(232, 442);
            this.GroupControlPersonel.TabIndex = 3;
            this.GroupControlPersonel.Text = "groupControl1";
            // 
            // SBtnGuncelle
            // 
            this.SBtnGuncelle.ImageOptions.Image = global::IsTakipSistemi.Properties.Resources.pencolor_32x32;
            this.SBtnGuncelle.Location = new System.Drawing.Point(6, 207);
            this.SBtnGuncelle.Name = "SBtnGuncelle";
            this.SBtnGuncelle.Size = new System.Drawing.Size(214, 36);
            this.SBtnGuncelle.TabIndex = 7;
            this.SBtnGuncelle.Text = "Düzenle";
            this.SBtnGuncelle.Click += new System.EventHandler(this.SBtnGuncelle_Click);
            // 
            // SbtnSil
            // 
            this.SbtnSil.ImageOptions.Image = global::IsTakipSistemi.Properties.Resources.cancel_32x32;
            this.SbtnSil.Location = new System.Drawing.Point(6, 249);
            this.SbtnSil.Name = "SbtnSil";
            this.SbtnSil.Size = new System.Drawing.Size(214, 36);
            this.SbtnSil.TabIndex = 6;
            this.SbtnSil.Text = "Sil";
            this.SbtnSil.Click += new System.EventHandler(this.SbtnSil_Click);
            // 
            // SBtnKaydet
            // 
            this.SBtnKaydet.ImageOptions.Image = global::IsTakipSistemi.Properties.Resources.add_32x322;
            this.SBtnKaydet.Location = new System.Drawing.Point(6, 165);
            this.SBtnKaydet.Name = "SBtnKaydet";
            this.SBtnKaydet.Size = new System.Drawing.Size(214, 36);
            this.SBtnKaydet.TabIndex = 5;
            this.SBtnKaydet.Text = "Kaydet";
            this.SBtnKaydet.Click += new System.EventHandler(this.SBtnKaydet_Click);
            // 
            // SBtnListele
            // 
            this.SBtnListele.ImageOptions.Image = global::IsTakipSistemi.Properties.Resources.listbox_32x321;
            this.SBtnListele.Location = new System.Drawing.Point(6, 291);
            this.SBtnListele.Name = "SBtnListele";
            this.SBtnListele.Size = new System.Drawing.Size(214, 36);
            this.SBtnListele.TabIndex = 4;
            this.SBtnListele.Text = "Listele";
            this.SBtnListele.Click += new System.EventHandler(this.SBtnListele_Click);
            // 
            // TEPersonelAd
            // 
            this.TEPersonelAd.Location = new System.Drawing.Point(87, 35);
            this.TEPersonelAd.Name = "TEPersonelAd";
            this.TEPersonelAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEPersonelAd.Properties.Appearance.Options.UseFont = true;
            this.TEPersonelAd.Size = new System.Drawing.Size(133, 20);
            this.TEPersonelAd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 38);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Personel Adı:";
            // 
            // TEPersonelID
            // 
            this.TEPersonelID.Location = new System.Drawing.Point(87, 9);
            this.TEPersonelID.Name = "TEPersonelID";
            this.TEPersonelID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEPersonelID.Properties.Appearance.Options.UseFont = true;
            this.TEPersonelID.Size = new System.Drawing.Size(133, 20);
            this.TEPersonelID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(55, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Personel ID";
            // 
            // TEPersonelSoyad
            // 
            this.TEPersonelSoyad.Location = new System.Drawing.Point(87, 61);
            this.TEPersonelSoyad.Name = "TEPersonelSoyad";
            this.TEPersonelSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEPersonelSoyad.Properties.Appearance.Options.UseFont = true;
            this.TEPersonelSoyad.Size = new System.Drawing.Size(133, 20);
            this.TEPersonelSoyad.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(6, 64);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(80, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Personel Soyadı:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(6, 142);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(57, 13);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Departman:";
            // 
            // TEGORSEL
            // 
            this.TEGORSEL.Location = new System.Drawing.Point(87, 113);
            this.TEGORSEL.Name = "TEGORSEL";
            this.TEGORSEL.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEGORSEL.Properties.Appearance.Options.UseFont = true;
            this.TEGORSEL.Size = new System.Drawing.Size(133, 20);
            this.TEGORSEL.TabIndex = 13;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(6, 116);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Personel Görsel:";
            // 
            // TEMail
            // 
            this.TEMail.Location = new System.Drawing.Point(87, 87);
            this.TEMail.Name = "TEMail";
            this.TEMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TEMail.Properties.Appearance.Options.UseFont = true;
            this.TEMail.Size = new System.Drawing.Size(133, 20);
            this.TEMail.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(6, 90);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(66, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Personel Mail:";
            // 
            // LUEDepartman
            // 
            this.LUEDepartman.Location = new System.Drawing.Point(87, 139);
            this.LUEDepartman.Name = "LUEDepartman";
            this.LUEDepartman.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.LUEDepartman.Size = new System.Drawing.Size(133, 20);
            this.LUEDepartman.TabIndex = 15;
            // 
            // FrmPersoneller
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 442);
            this.Controls.Add(this.GControlPersonel);
            this.Controls.Add(this.GroupControlPersonel);
            this.Name = "FrmPersoneller";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Penceresi";
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GControlPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GViewPersonelListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupControlPersonel)).EndInit();
            this.GroupControlPersonel.ResumeLayout(false);
            this.GroupControlPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TEPersonelAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPersonelID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEPersonelSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGORSEL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LUEDepartman.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GControlPersonel;
        private DevExpress.XtraGrid.Views.Grid.GridView GViewPersonelListe;
        private DevExpress.XtraEditors.GroupControl GroupControlPersonel;
        private DevExpress.XtraEditors.SimpleButton SBtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton SbtnSil;
        private DevExpress.XtraEditors.SimpleButton SBtnKaydet;
        private DevExpress.XtraEditors.SimpleButton SBtnListele;
        private DevExpress.XtraEditors.TextEdit TEPersonelAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TEPersonelID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit LUEDepartman;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TEGORSEL;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TEMail;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TEPersonelSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}