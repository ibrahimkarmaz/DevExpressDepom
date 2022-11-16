using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using PresentationLayer.WinFormList.CompanyWF;
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
            GControlProduct.DataSource = _productManager.ProductGetList(x => x.ProductArchive == true && x.ProductPiece>=1);
        }
        private void ProductSelectWF_Load(object sender, EventArgs e)
        {
            ProductGetDTO();
        }
        private ProductSelectDTO GetProductINFO()
        {
            return new ProductSelectDTO()
            {
                ProductID = (int)GViewProduct.GetRowCellValue(GViewProduct.FocusedRowHandle, GViewProduct.Columns[0]),
                ProductName = GViewProduct.GetRowCellValue(GViewProduct.FocusedRowHandle, GViewProduct.Columns[1]).ToString(),
                ProductPiece= (int)GViewProduct.GetRowCellValue(GViewProduct.FocusedRowHandle, GViewProduct.Columns[5]),
                ProductPrice= Convert.ToDecimal(GViewProduct.GetRowCellValue(GViewProduct.FocusedRowHandle, GViewProduct.Columns[7]))
            };
        }
        public static ProductSelectDTO productSelect;
        public static bool productSelectStatus;
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CommonProduct()
        {
            try
            {
                productSelectStatus = true;
                productSelect = GetProductINFO();
                this.Close();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ÜRÜN SEÇİLEMEDİ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SBtnSelect_Click(object sender, EventArgs e)
        {
            CommonProduct();
        }

        private void GViewProduct_DoubleClick(object sender, EventArgs e)
        {
            CommonProduct();
        }
    }
}