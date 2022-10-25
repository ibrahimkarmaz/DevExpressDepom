using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit.Model;
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
    public partial class ProductAddXWF : DevExpress.XtraEditors.XtraForm
    {
        public ProductAddXWF()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        ModelManager _modelManager = new ModelManager(new EFModelDAL());
        private void BlandGet()
        {
            LUEBland.Properties.DataSource = _blandManager.GetAllList(x=>x.BlandArchive==true);
        }
        private void ModelGetWithBlandID()
        {
            try
            {
                LUEModel.Properties.DataSource = _modelManager.GetAllList(x => x.ModelArchive == true && x.BlandID == (int)LUEBland.EditValue);
            }
            catch (Exception)
            {
            }
        }
        private void ProductPiece()
        {
            CBEPiece.Properties.Items.Clear();
            for (int i = 1; i <= 10000; i++)
            {
                CBEPiece.Properties.Items.Add(i.ToString());
            }
        }
        private void ProductAddWF_Load(object sender, EventArgs e)
        {
            BlandGet();
            ProductPiece();
        }


        private void LUEBland_EditValueChanged(object sender, EventArgs e)
        {
            ModelGetWithBlandID();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModelYear()
        {
            try
            {
                TEYear.Text = _modelManager.GetById((int)LUEModel.EditValue).ModelYear;
            }
            catch (Exception)
            {
            }
        }
        private void LUEModel_EditValueChanged(object sender, EventArgs e)
        {
            ModelYear();
        }
        Product product;
        private void SBSave_Click(object sender, EventArgs e)
        {
            try
            {
                product = new Product();
                product.ProductName = TEProductName.Text;
                product.BlandID = (int)LUEBland.EditValue;
                product.ModelID = (int)LUEModel.EditValue;
                product.ProductPiece = Convert.ToInt32(CBEPiece.SelectedItem);
                product.ProductPurchasePrice = Convert.ToDecimal(TEPurchasePrice.Text);
                product.ProductSalePrice = Convert.ToDecimal(TESalesPrice.Text);
                product.ProductDetails = MMEDetails.Text;
                if (new ProductCommonValidationControl().ProductValidatorAndMessage(product))
                {
                    _productManager.TAdd(product);
                    XtraMessageBox.Show("YENİ ÜRÜN KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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