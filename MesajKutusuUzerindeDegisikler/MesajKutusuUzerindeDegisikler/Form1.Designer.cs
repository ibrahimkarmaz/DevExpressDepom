namespace MesajKutusuUzerindeDegisikler
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(12, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(439, 50);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Süreli Mesaj Kutusu";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(12, 68);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(439, 50);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Resimli Mesaj Kutusu";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // svgImageCollection1
            // 
            this.svgImageCollection1.Add("lifesaver-svgrepo-com (1)", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.lifesaver-svgrepo-com (1)"))));
            this.svgImageCollection1.Add("lifesaver-svgrepo-com", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.lifesaver-svgrepo-com"))));
            this.svgImageCollection1.Add("save-icon-svgrepo-com", ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageCollection1.save-icon-svgrepo-com"))));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 142);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yeni Mesaj Kutus";
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
    }
}

