using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.WinFormList.CompanyMovement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.ProductWF.ProductMovementWF
{
    public partial class ProductMovementUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public ProductMovementUpdateWF()
        {
            InitializeComponent();
        }
        CompanyMovementDetailManager _companyMovementDetailManager = new CompanyMovementDetailManager(new EFCompanyMovementDetailDAL());
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        

        private void CBEPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            TETotalPrice.Text = (Convert.ToInt32(CBEPiece.SelectedItem) * product.ProductSalePrice).ToString();
        }

        CompanyMovementDetail DATA;
        Product product;
        private void GetByCompanyMovementDetail()
        {
            DATA = _companyMovementDetailManager.GetById(CompanyMovementWF.CompanyMovementDetailID);
            product = _productManager.GetById((int)DATA.ProductID);
            TEPrice.Text = DATA.CompanyMovementDetailPrice.ToString();
            TETotalPrice.Text= DATA.CompanyMovementDetailTotalPrice.ToString();
            PieceComboboxUpdate();
            CBEPiece.SelectedIndex = (Convert.ToInt32(DATA.CompanyMovementDetailPiece) - 1);
        }
        private void PieceComboboxUpdate()
        {
            try
            {
                CBEPiece.Properties.Items.Clear();
                for (int i = 1; i <= (DATA.CompanyMovementDetailPiece+product.ProductPiece); i++)
                {
                    CBEPiece.Properties.Items.Add(i);
                }
                if (CBEPiece.Properties.Items.Count > 0)
                {
                    CBEPiece.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {//HATA ENGELLEME :)
                CBEPiece.Properties.Items.Clear();
            }
        }

        private void ProductMovementUpdateWF_Load(object sender, EventArgs e)
        {
            GetByCompanyMovementDetail();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnUpdate_Click(object sender, EventArgs e)
        {/*SADECE DEĞİŞEN KISIMLAR ALINDI.*/
            try
            {
                CompanyMovementDetail companyMovementDetail = _companyMovementDetailManager.GetById(DATA.CompanyMovementDetailID);

                if (CBEPiece.Text != null)
                {
                    companyMovementDetail.CompanyMovementDetailPiece = (int)CBEPiece.SelectedItem;
                }
                else
                {
                    companyMovementDetail.CompanyMovementDetailPiece = null;
                }

                if (TETotalPrice.Text != null)
                {
                    companyMovementDetail.CompanyMovementDetailTotalPrice = Convert.ToDecimal(TETotalPrice.Text.Replace('.', ','));
                }
                else
                {
                    companyMovementDetail.CompanyMovementDetailTotalPrice = null;
                }

                Product product;
                if (new CompanyMovementDetailCommonValidatorControl().CompanyMovementDetailValidatorAndMessage(companyMovementDetail))
                {
                    _companyMovementDetailManager.TUpdate(companyMovementDetail);
                    product = _productManager.GetById((int)companyMovementDetail.ProductID);
                    product.ProductPiece = ((int)(CBEPiece.Properties.Items.Count-Convert.ToInt32(CBEPiece.SelectedItem)));
                    _productManager.TUpdate(product);
                    XtraMessageBox.Show("ÜRÜN ADET BİLGİSİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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