using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
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
    public partial class ProductStockUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public ProductStockUpdateWF()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        private void ProductPiece()
        {
            CBEPiece.Properties.Items.Clear();
            for (int i = 1; i <= 10000; i++)
            {
                CBEPiece.Properties.Items.Add(i.ToString());
            }
        }
        Product DATA;
        public void ProductGetAndLoad()
        {
            DATA = _productManager.GetById(ProductWF.ProductID);
            TEProductName.Text = DATA.ProductName;
            CBEPiece.SelectedIndex = DATA.ProductPiece - 1;
            MMEDetails.Text = DATA.ProductDetails;
            if (DATA.ProductArchive)
            {
                CheckArchive.Checked = false;
            }
            else
            {
                CheckArchive.Checked = true;
            }
        }
        private void ProductStockUpdateWF_Load(object sender, EventArgs e)
        {
            ProductPiece();
            ProductGetAndLoad();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Product product;
        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                product = _productManager.GetById(ProductWF.ProductID);
                product.ProductPiece = Convert.ToInt32(CBEPiece.SelectedItem);
                product.ProductDetails = MMEDetails.Text;
                if (CheckArchive.Checked)
                {
                    product.ProductArchive = false;
                }
                else
                {
                    product.ProductArchive = true;
                }
                if (new ProductCommonValidationControl().ProductValidatorAndMessage(product))
                {
                    _productManager.TUpdate(product);
                    XtraMessageBox.Show("ÜRÜN STOK BİLGİLERİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ÜRÜN BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}