using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    public partial class ProductSelectWF : DevExpress.XtraEditors.XtraForm
    {
        public ProductSelectWF()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        private void ProductGetDTO()
        {
            GControlProduct.DataSource = _productManager.ProductGetList(x => x.ProductArchive == true);
        }
        private void ProductSelectWF_Load(object sender, EventArgs e)
        {
            ProductGetDTO();
        }
    }
}