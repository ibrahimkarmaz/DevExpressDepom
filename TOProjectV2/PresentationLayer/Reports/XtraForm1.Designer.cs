namespace PresentationLayer.Reports
{
	partial class XtraForm1
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
			this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
			this.SuspendLayout();
			// 
			// simpleButton2
			// 
			this.simpleButton2.Location = new System.Drawing.Point(111, 47);
			this.simpleButton2.Name = "simpleButton2";
			this.simpleButton2.Size = new System.Drawing.Size(115, 112);
			this.simpleButton2.TabIndex = 1;
			this.simpleButton2.Text = "simpleButton2";
			this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
			// 
			// XtraForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(298, 266);
			this.Controls.Add(this.simpleButton2);
			this.Name = "XtraForm1";
			this.Text = "XtraForm1";
			this.ResumeLayout(false);

		}

		#endregion

		private DevExpress.XtraEditors.SimpleButton simpleButton2;
	}
}