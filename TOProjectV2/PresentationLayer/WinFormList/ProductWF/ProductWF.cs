using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
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
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        private void ProductWF_Load(object sender, EventArgs e)
        {
            ProductGetDTO();
            ProductGetAndStoctLimitsDTO();
            ProductGetArchiveDTO();
        }
        private void ProductGetDTO()
        {
            GControlProduct.DataSource = _productManager.ProductGetList(x=>x.ProductArchive==true);
        }
        private void ProductGetAndStoctLimitsDTO()
        {
            GControlProductStock.DataSource = _productManager.ProductGetList(x => x.ProductArchive == true && x.ProductPiece<=20);
        }
        private void ProductGetArchiveDTO()
        {
            GControlProductArchive.DataSource = _productManager.ProductGetList(x => x.ProductArchive == false);
        }
        private void accordionControlProductNewAdd_Click(object sender, EventArgs e)
        {
            ProductAddXWF productAdd = new ProductAddXWF();
            productAdd.ShowDialog();
            ProductGetDTO();

        }

        private void accordionControlProductList_Click(object sender, EventArgs e)
        {
            ProductGetDTO();
        }
        public static int ProductID = -1;
        private void accordionControlProductUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ProductID =(int)GViewProduct.GetRowCellValue(GViewProduct.FocusedRowHandle, GViewProduct.Columns[0]);
                ProductUpdateWF productUpdateWF = new ProductUpdateWF();
                productUpdateWF.ShowDialog();
                ProductGetDTO();
            }
            catch (Exception)
            {
                ProductID = -1;
                XtraMessageBox.Show("ÜRÜN SEÇİNİZ","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void accordionControlProductArchive_Click(object sender, EventArgs e)
        {
            try
            {
                Product DATA = _productManager.GetById((int)GViewProduct.GetRowCellValue(GViewProduct.FocusedRowHandle, GViewProduct.Columns[0]));
                DATA.ProductArchive = false;
                _productManager.TUpdate(DATA);
                ProductGetDTO();
                XtraMessageBox.Show("ÜRÜN BİLGİLERİ ARŞİVLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ÜRÜN SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlProductPieceUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                ProductID = (int)GViewProductStock.GetRowCellValue(GViewProductStock.FocusedRowHandle, GViewProductStock.Columns[0]);
                ProductStockUpdateWF productStockUpdate = new ProductStockUpdateWF();
                productStockUpdate.ShowDialog();
            }
            catch (Exception)
            {
                ProductID = -1;
                XtraMessageBox.Show("ÜRÜN SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void accordionControlProductStockList_Click(object sender, EventArgs e)
        {
            ProductGetAndStoctLimitsDTO();
        }

        private void accordionControlArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                Product DATA = _productManager.GetById((int)GViewProductArchive.GetRowCellValue(GViewProductArchive.FocusedRowHandle, GViewProductArchive.Columns[0]));
                DATA.ProductArchive = true;
                _productManager.TUpdate(DATA);
                ProductGetArchiveDTO();
                XtraMessageBox.Show("ÜRÜN ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ÜRÜN SEÇİNİZ", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlProductArchiveList_Click(object sender, EventArgs e)
        {
            ProductGetArchiveDTO();
        }
    }
}