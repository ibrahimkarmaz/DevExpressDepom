
namespace KatmanliMimariyleMusteriTakipSistemi
{
    partial class Form1
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TEAD = new DevExpress.XtraEditors.TextEdit();
            this.TESOYAD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TETELEFON = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TEMAIL = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.DETARIH = new DevExpress.XtraEditors.DateEdit();
            this.BTNGUNCELLE = new DevExpress.XtraEditors.SimpleButton();
            this.BTNKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.BTNLISTELE = new DevExpress.XtraEditors.SimpleButton();
            this.BTNSIL = new DevExpress.XtraEditors.SimpleButton();
            this.CINSIYET = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESOYAD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TETELEFON.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMAIL.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DETARIH.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DETARIH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CINSIYET.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(12, 12);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(639, 268);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 286);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(65, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Adınızı Giriniz:";
            // 
            // TEAD
            // 
            this.TEAD.Location = new System.Drawing.Point(12, 305);
            this.TEAD.Name = "TEAD";
            this.TEAD.Size = new System.Drawing.Size(195, 20);
            this.TEAD.TabIndex = 2;
            // 
            // TESOYAD
            // 
            this.TESOYAD.Location = new System.Drawing.Point(12, 347);
            this.TESOYAD.Name = "TESOYAD";
            this.TESOYAD.Size = new System.Drawing.Size(195, 20);
            this.TESOYAD.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 328);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Soyad:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 371);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Cinsiyet:";
            // 
            // TETELEFON
            // 
            this.TETELEFON.Location = new System.Drawing.Point(213, 305);
            this.TETELEFON.Name = "TETELEFON";
            this.TETELEFON.Size = new System.Drawing.Size(195, 20);
            this.TETELEFON.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(213, 286);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Telefon:";
            // 
            // TEMAIL
            // 
            this.TEMAIL.Location = new System.Drawing.Point(213, 347);
            this.TEMAIL.Name = "TEMAIL";
            this.TEMAIL.Size = new System.Drawing.Size(195, 20);
            this.TEMAIL.TabIndex = 10;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(213, 328);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(22, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Mail:";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(213, 371);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(28, 13);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Tarih:";
            // 
            // DETARIH
            // 
            this.DETARIH.EditValue = null;
            this.DETARIH.Location = new System.Drawing.Point(213, 390);
            this.DETARIH.Name = "DETARIH";
            this.DETARIH.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DETARIH.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DETARIH.Size = new System.Drawing.Size(195, 20);
            this.DETARIH.TabIndex = 14;
            // 
            // BTNGUNCELLE
            // 
            this.BTNGUNCELLE.Location = new System.Drawing.Point(656, 90);
            this.BTNGUNCELLE.Name = "BTNGUNCELLE";
            this.BTNGUNCELLE.Size = new System.Drawing.Size(194, 33);
            this.BTNGUNCELLE.TabIndex = 15;
            this.BTNGUNCELLE.Text = "Güncelle";
            this.BTNGUNCELLE.Click += new System.EventHandler(this.BTNGUNCELLE_Click);
            // 
            // BTNKAYDET
            // 
            this.BTNKAYDET.Location = new System.Drawing.Point(656, 51);
            this.BTNKAYDET.Name = "BTNKAYDET";
            this.BTNKAYDET.Size = new System.Drawing.Size(194, 33);
            this.BTNKAYDET.TabIndex = 16;
            this.BTNKAYDET.Text = "Kaydet";
            this.BTNKAYDET.Click += new System.EventHandler(this.BTNKAYDET_Click);
            // 
            // BTNLISTELE
            // 
            this.BTNLISTELE.Location = new System.Drawing.Point(656, 12);
            this.BTNLISTELE.Name = "BTNLISTELE";
            this.BTNLISTELE.Size = new System.Drawing.Size(194, 33);
            this.BTNLISTELE.TabIndex = 17;
            this.BTNLISTELE.Text = "Listele";
            this.BTNLISTELE.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BTNSIL
            // 
            this.BTNSIL.Location = new System.Drawing.Point(656, 129);
            this.BTNSIL.Name = "BTNSIL";
            this.BTNSIL.Size = new System.Drawing.Size(194, 33);
            this.BTNSIL.TabIndex = 18;
            this.BTNSIL.Text = "Sil";
            this.BTNSIL.Click += new System.EventHandler(this.BTNSIL_Click);
            // 
            // CINSIYET
            // 
            this.CINSIYET.Location = new System.Drawing.Point(12, 390);
            this.CINSIYET.Name = "CINSIYET";
            this.CINSIYET.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CINSIYET.Size = new System.Drawing.Size(195, 20);
            this.CINSIYET.TabIndex = 19;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(457, 286);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(194, 33);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Arama Yap";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 428);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.CINSIYET);
            this.Controls.Add(this.BTNSIL);
            this.Controls.Add(this.BTNLISTELE);
            this.Controls.Add(this.BTNKAYDET);
            this.Controls.Add(this.BTNGUNCELLE);
            this.Controls.Add(this.DETARIH);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.TEMAIL);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.TETELEFON);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.TESOYAD);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.TEAD);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TESOYAD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TETELEFON.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEMAIL.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DETARIH.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DETARIH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CINSIYET.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TEAD;
        private DevExpress.XtraEditors.TextEdit TESOYAD;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TETELEFON;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TEMAIL;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit DETARIH;
        private DevExpress.XtraEditors.SimpleButton BTNGUNCELLE;
        private DevExpress.XtraEditors.SimpleButton BTNKAYDET;
        private DevExpress.XtraEditors.SimpleButton BTNLISTELE;
        private DevExpress.XtraEditors.SimpleButton BTNSIL;
        private DevExpress.XtraEditors.ComboBoxEdit CINSIYET;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}

