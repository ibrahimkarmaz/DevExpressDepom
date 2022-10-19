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
using PresentationLayer.WinFormList;

namespace PresentationLayer.WinFormList
{
    public partial class ProductWF : DevExpress.XtraEditors.XtraForm
    {
        public ProductWF()
        {
            InitializeComponent();
        }
        private void accordionControlProductNewAdd_Click(object sender, EventArgs e)
        {
            ProductAddWF productAddWF = new ProductAddWF();
            productAddWF.ShowDialog();
        }
    }
}