namespace PresentationLayer.WinFormList.GuidesWF
{
    partial class SMSSenderWF
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMSSenderWF));
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.SBtnIptalEt = new DevExpress.XtraEditors.SimpleButton();
            this.SBtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.MMSmsContent = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.MMSmsContent.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl2.Location = new System.Drawing.Point(12, 122);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 15);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "0/150";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 15);
            this.labelControl1.TabIndex = 33;
            this.labelControl1.Text = "SMS İÇERİĞİ:";
            // 
            // SBtnIptalEt
            // 
            this.SBtnIptalEt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBtnIptalEt.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnIptalEt.ImageOptions.Image")));
            this.SBtnIptalEt.Location = new System.Drawing.Point(157, 123);
            this.SBtnIptalEt.Name = "SBtnIptalEt";
            this.SBtnIptalEt.Size = new System.Drawing.Size(111, 35);
            this.SBtnIptalEt.TabIndex = 35;
            this.SBtnIptalEt.Text = "İptal Et";
            this.SBtnIptalEt.Click += new System.EventHandler(this.SBtnIptalEt_Click);
            // 
            // SBtnGonder
            // 
            this.SBtnGonder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SBtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("SBtnGonder.ImageOptions.Image")));
            this.SBtnGonder.Location = new System.Drawing.Point(274, 122);
            this.SBtnGonder.Name = "SBtnGonder";
            this.SBtnGonder.Size = new System.Drawing.Size(132, 35);
            this.SBtnGonder.TabIndex = 34;
            this.SBtnGonder.Text = "Gönder";
            this.SBtnGonder.Click += new System.EventHandler(this.SBtnGonder_Click);
            // 
            // MMSmsContent
            // 
            this.MMSmsContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MMSmsContent.Location = new System.Drawing.Point(12, 31);
            this.MMSmsContent.Name = "MMSmsContent";
            this.MMSmsContent.Properties.MaxLength = 150;
            this.MMSmsContent.Size = new System.Drawing.Size(394, 85);
            this.MMSmsContent.TabIndex = 32;
            this.MMSmsContent.EditValueChanged += new System.EventHandler(this.MMSmsIcerigi_EditValueChanged);
            // 
            // SMSSenderWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 168);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.SBtnIptalEt);
            this.Controls.Add(this.SBtnGonder);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.MMSmsContent);
            this.Name = "SMSSenderWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS GÖNDER";
            this.Load += new System.EventHandler(this.SMSSenderWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MMSmsContent.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton SBtnIptalEt;
        private DevExpress.XtraEditors.SimpleButton SBtnGonder;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MemoEdit MMSmsContent;
    }
}