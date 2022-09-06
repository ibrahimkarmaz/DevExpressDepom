namespace MailGondermeUygulamasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TEGondericiAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.TEGondericiMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TEGondericiParola = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BEEk = new DevExpress.XtraEditors.ButtonEdit();
            this.MMIcerik = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TEAlici = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TEBaslik = new DevExpress.XtraEditors.TextEdit();
            this.SBtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnIptalEt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TEGondericiAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGondericiMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGondericiParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BEEk.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMIcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAlici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEBaslik.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(6, 32);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Gönderici Ad Soyad:";
            // 
            // TEGondericiAdSoyad
            // 
            this.TEGondericiAdSoyad.Location = new System.Drawing.Point(6, 55);
            this.TEGondericiAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.TEGondericiAdSoyad.Name = "TEGondericiAdSoyad";
            this.TEGondericiAdSoyad.Size = new System.Drawing.Size(293, 24);
            this.TEGondericiAdSoyad.TabIndex = 1;
            // 
            // TEGondericiMail
            // 
            this.TEGondericiMail.Location = new System.Drawing.Point(6, 111);
            this.TEGondericiMail.Margin = new System.Windows.Forms.Padding(4);
            this.TEGondericiMail.Name = "TEGondericiMail";
            this.TEGondericiMail.Size = new System.Drawing.Size(293, 24);
            this.TEGondericiMail.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(6, 87);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 16);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Gönderici Mail:";
            // 
            // TEGondericiParola
            // 
            this.TEGondericiParola.Location = new System.Drawing.Point(6, 166);
            this.TEGondericiParola.Margin = new System.Windows.Forms.Padding(4);
            this.TEGondericiParola.Name = "TEGondericiParola";
            this.TEGondericiParola.Size = new System.Drawing.Size(293, 24);
            this.TEGondericiParola.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(6, 143);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(98, 16);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Gönderici Parola:";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.TEGondericiParola);
            this.groupControl1.Controls.Add(this.TEGondericiAdSoyad);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TEGondericiMail);
            this.groupControl1.Location = new System.Drawing.Point(330, 13);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(309, 211);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Gönderici İşlemleri";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.BEEk);
            this.groupControl2.Controls.Add(this.MMIcerik);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.TEAlici);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.TEBaslik);
            this.groupControl2.Location = new System.Drawing.Point(13, 13);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(309, 396);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "Alıcı İşlemleri";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(6, 335);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(18, 16);
            this.labelControl7.TabIndex = 7;
            this.labelControl7.Text = "Ek:";
            // 
            // BEEk
            // 
            this.BEEk.Location = new System.Drawing.Point(6, 358);
            this.BEEk.Margin = new System.Windows.Forms.Padding(4);
            this.BEEk.Name = "BEEk";
            this.BEEk.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.BEEk.Size = new System.Drawing.Size(293, 24);
            this.BEEk.TabIndex = 6;
            this.BEEk.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BEEk_ButtonClick);
            // 
            // MMIcerik
            // 
            this.MMIcerik.Location = new System.Drawing.Point(6, 166);
            this.MMIcerik.Margin = new System.Windows.Forms.Padding(4);
            this.MMIcerik.Name = "MMIcerik";
            this.MMIcerik.Size = new System.Drawing.Size(293, 161);
            this.MMIcerik.TabIndex = 5;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(6, 32);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(28, 16);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Alıcı:";
            // 
            // TEAlici
            // 
            this.TEAlici.Location = new System.Drawing.Point(6, 55);
            this.TEAlici.Margin = new System.Windows.Forms.Padding(4);
            this.TEAlici.Name = "TEAlici";
            this.TEAlici.Size = new System.Drawing.Size(293, 24);
            this.TEAlici.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(6, 143);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "İçerik:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(6, 87);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(37, 16);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Başlık:";
            // 
            // TEBaslik
            // 
            this.TEBaslik.Location = new System.Drawing.Point(6, 111);
            this.TEBaslik.Margin = new System.Windows.Forms.Padding(4);
            this.TEBaslik.Name = "TEBaslik";
            this.TEBaslik.Size = new System.Drawing.Size(293, 24);
            this.TEBaslik.TabIndex = 3;
            // 
            // SBtnGonder
            // 
            this.SBtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnGonder.ImageOptions.Image")));
            this.SBtnGonder.Location = new System.Drawing.Point(495, 367);
            this.SBtnGonder.Margin = new System.Windows.Forms.Padding(4);
            this.SBtnGonder.Name = "SBtnGonder";
            this.SBtnGonder.Size = new System.Drawing.Size(144, 42);
            this.SBtnGonder.TabIndex = 8;
            this.SBtnGonder.Text = "Gönder";
            this.SBtnGonder.Click += new System.EventHandler(this.SBtnGonder_Click);
            // 
            // SBtnIptalEt
            // 
            this.SBtnIptalEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnIptalEt.ImageOptions.Image")));
            this.SBtnIptalEt.Location = new System.Drawing.Point(375, 367);
            this.SBtnIptalEt.Margin = new System.Windows.Forms.Padding(4);
            this.SBtnIptalEt.Name = "SBtnIptalEt";
            this.SBtnIptalEt.Size = new System.Drawing.Size(115, 42);
            this.SBtnIptalEt.TabIndex = 9;
            this.SBtnIptalEt.Text = "İptal Et";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 422);
            this.Controls.Add(this.SBtnIptalEt);
            this.Controls.Add(this.SBtnGonder);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TEGondericiAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGondericiMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEGondericiParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BEEk.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MMIcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEAlici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TEBaslik.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TEGondericiAdSoyad;
        private DevExpress.XtraEditors.TextEdit TEGondericiMail;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TEGondericiParola;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.ButtonEdit BEEk;
        private DevExpress.XtraEditors.MemoEdit MMIcerik;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TEAlici;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TEBaslik;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton SBtnGonder;
        private DevExpress.XtraEditors.SimpleButton SBtnIptalEt;
    }
}

