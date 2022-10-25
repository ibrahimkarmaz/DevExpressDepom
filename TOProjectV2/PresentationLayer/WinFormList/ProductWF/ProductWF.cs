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

namespace PresentationLayer.WinFormList.ProductWF
{
    public partial class ProductWF : DevExpress.XtraEditors.XtraForm
    {
        public ProductWF()
        {
            InitializeComponent();
        }

        private void ProductWF_Load(object sender, EventArgs e)
        {

        }

        private void accordionControlProductNewAdd_Click(object sender, EventArgs e)
        {
            ProductAddXWF productAdd = new ProductAddXWF();
            productAdd.ShowDialog();
        }
    }
}