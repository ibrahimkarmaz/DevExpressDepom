namespace PopupGalleryEditKullanımı
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
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup1 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem1 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem2 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItemGroup galleryItemGroup2 = new DevExpress.XtraBars.Ribbon.GalleryItemGroup();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem3 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            DevExpress.XtraBars.Ribbon.GalleryItem galleryItem4 = new DevExpress.XtraBars.Ribbon.GalleryItem();
            this.popupGalleryEdit1 = new DevExpress.XtraEditors.PopupGalleryEdit();
            ((System.ComponentModel.ISupportInitialize)(this.popupGalleryEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // popupGalleryEdit1
            // 
            this.popupGalleryEdit1.EditValue = "";
            this.popupGalleryEdit1.Location = new System.Drawing.Point(12, 12);
            this.popupGalleryEdit1.Name = "popupGalleryEdit1";
            this.popupGalleryEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            // 
            // popupGalleryEditGallery1
            // 
            galleryItemGroup1.Caption = "Elektronik";
            galleryItem1.Caption = "Telefon";
            galleryItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            galleryItem1.Value = 0;
            galleryItem2.Caption = "Bilgisayar";
            galleryItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            galleryItem2.Value = 1;
            galleryItemGroup1.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem1,
            galleryItem2});
            galleryItemGroup2.Caption = "Kitap";
            galleryItem3.Caption = "Roman";
            galleryItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            galleryItem3.Value = 2;
            galleryItem4.Caption = "Hikayer";
            galleryItem4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            galleryItem4.Value = 3;
            galleryItemGroup2.Items.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItem[] {
            galleryItem3,
            galleryItem4});
            this.popupGalleryEdit1.Properties.Gallery.Groups.AddRange(new DevExpress.XtraBars.Ribbon.GalleryItemGroup[] {
            galleryItemGroup1,
            galleryItemGroup2});
            this.popupGalleryEdit1.Size = new System.Drawing.Size(499, 20);
            this.popupGalleryEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 225);
            this.Controls.Add(this.popupGalleryEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.popupGalleryEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PopupGalleryEdit popupGalleryEdit1;
    }
}

