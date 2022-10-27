using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    public partial class ProductUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public ProductUpdateWF()
        {
            InitializeComponent();
        }
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        ModelManager _modelManager = new ModelManager(new EFModelDAL());
        private void BlandGet()
        {
            LUEBland.Properties.DataSource = _blandManager.GetAllList();
        }
        private void ModelGetWithBlandID()
        {
            try
            {
                LUEModel.Properties.DataSource = _modelManager.GetAllList(x=>x.BlandID == (int)LUEBland.EditValue);
            }
            catch (Exception)
            {
            }
        }

        private void BlandGetArchiveTrue()
        {
            LUEBland.Properties.DataSource = _blandManager.GetAllList(x=>x.BlandArchive==true);
        }
        private void ModelGetWithBlandIDtArchiveTrue()
        {
            try
            {
                LUEModel.Properties.DataSource = _modelManager.GetAllList(x =>x.ModelArchive==true && x.BlandID == (int)LUEBland.EditValue);
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
        private void ProductUpdateWF_Load(object sender, EventArgs e)
        {
            ProductPiece();
            BlandGet();
            ProductGetAndLoad();
        }
        Product DATA;
        public void ProductGetAndLoad()
        {
            DATA = _productManager.GetById(ProductWF.ProductID);
            TEProductName.Text = DATA.ProductName;
            LUEBland.EditValue = DATA.BlandID;
            LUEModel.EditValue = DATA.ModelID;
            CBEPiece.SelectedIndex =DATA.ProductPiece-1;
            TEPurchasePrice.Text = DATA.ProductPurchasePrice.ToString();
            TESalesPrice.Text = DATA.ProductSalePrice.ToString();
            if (DATA.ProductArchive)
            {
                CheckArchive.Checked = false;
            }
            else
            {
                CheckArchive.Checked = true;
            }
        }
        private void LUEModel_EditValueChanged(object sender, EventArgs e)
        {
            TEYear.Text = _modelManager.GetById((int)LUEModel.EditValue).ModelYear;
        }

        private void CheckBlandModel_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBlandModel.Checked)
            {
                LUEBland.Enabled = true;
                LUEModel.Enabled = true;
                BlandGetArchiveTrue();
            }
            else
            {
                LUEBland.Enabled = false;
                LUEModel.Enabled = false;
                BlandGet();
                LUEBland.EditValue = DATA.BlandID;
                LUEModel.EditValue = DATA.ModelID;
            }
        }

        private void LUEBland_EditValueChanged(object sender, EventArgs e)
        {
            if (CheckBlandModel.Checked)
            {
                ModelGetWithBlandIDtArchiveTrue();
            }
            else
            {
                ModelGetWithBlandID();
            }
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Product product;
        private void SBtnUpadte_Click(object sender, EventArgs e)
        {
            try
            {
                product = _productManager.GetById(ProductWF.ProductID);
                product.ProductName = TEProductName.Text;
                if (CheckBlandModel.Checked)
                {
                    product.BlandID = (int)LUEBland.EditValue;
                    product.ModelID = (int)LUEModel.EditValue;
                }
                product.ProductPiece = Convert.ToInt32(CBEPiece.SelectedItem);
                product.ProductPurchasePrice = Convert.ToDecimal(TEPurchasePrice.Text.Replace('.', ','));
                product.ProductSalePrice = Convert.ToDecimal(TESalesPrice.Text.Replace('.', ','));
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
                    XtraMessageBox.Show("ÜRÜN BİLGİLERİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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