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
using PresentationLayer.WinFormList.CustomerWF;
using PresentationLayer.WinFormList.ProductWF;

namespace PresentationLayer
{
    public partial class CommercialAutomation : Form
    {
        public CommercialAutomation()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        ProductWF productWF;
        private void barProducts_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productWF==null || productWF.IsDisposed)
            {
                productWF = new ProductWF();
                productWF.MdiParent = this;
                productWF.Show();
            }
           
        }
        BlandTypeList productTypeList;
        private void barProductTypeList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (productTypeList==null || productTypeList.IsDisposed)
            {
                productTypeList = new BlandTypeList();
                productTypeList.MdiParent = this;
                productTypeList.Show();
            }
        }
        CustomerWF customerWF;
        private void barCustomers_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (customerWF==null || customerWF.IsDisposed)
            {
                customerWF = new CustomerWF();
                customerWF.MdiParent = this;
                customerWF.Show();
            }
        }
    }
}
