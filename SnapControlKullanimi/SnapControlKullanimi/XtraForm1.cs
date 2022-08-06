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
using DevExpress.Snap;
using DevExpress.Snap.Core.API;

namespace SnapControlKullanimi
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {
        public XtraForm1()
        {
            InitializeComponent();
        }

        private void XtraForm1_Load(object sender, EventArgs e)
        {
            snapControl1.LoadDocument(@"C:\Users\ibrah\OneDrive\Masaüstü\RaporDeneme.snx", SnapDocumentFormat.Snap);
        }
    }
}