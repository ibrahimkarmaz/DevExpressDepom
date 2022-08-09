using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadialMenuKullanimi
{
    public partial class RadialMenuKullanimix : DevExpress.XtraEditors.XtraForm
    {
        public RadialMenuKullanimix()
        {
            InitializeComponent();
        }

        private void RadialMenuKullanimix_Load(object sender, EventArgs e)
        {
            Point a = new Point(100,100);
            radialMenu1.ShowPopup(a);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
                Console.WriteLine("GFASFSD");
                Point a = new Point(100, 100);
                radialMenu1.ShowPopup(a);

        }
    }
}