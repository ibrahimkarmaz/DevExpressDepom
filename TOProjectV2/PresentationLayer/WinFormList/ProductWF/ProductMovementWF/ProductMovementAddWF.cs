using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.WinFormList.CompanyMovement;
using PresentationLayer.WinFormList.CompanyWF;
using PresentationLayer.WinFormList.CustomerMovementWF;
using PresentationLayer.WinFormList.EmployeeWF;
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
    public partial class ProductMovementAddWF : DevExpress.XtraEditors.XtraForm
    {
		/*NOT:DÜZELTME YAPILACAK BURADA BİR ÜRÜN ALINDIĞINDA KODLARLA İŞLEM YAPILIP VERİTABANİNA KAYDEDİLİYOR.
		 BU İŞLEMİ VERİTABANİ TARAFINDA TRİGGER İLE OTOMATİKLEŞTİRİLECEK.*/
        public ProductMovementAddWF()
        {
            InitializeComponent();
        }

        private void ProductMovementAddWF_Load(object sender, EventArgs e)
        {

        }
        ProductSelectDTO productSelect = new ProductSelectDTO();
        public static bool CustomerMovementCame;//****TRUE İSE MÜŞTERİ HAREKETLERİNDEN GELDİĞİ BELLİ EDER. (NOT:AÇARKEN TRUE SONRA KAPANDIĞINDA FALSE YAPILMALI.)
        private void BEProduct_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            ProductSelectWF.productSelectStatus = false;
            productSelect = null;
            ProductSelectWF productSelectWF = new ProductSelectWF();
            productSelectWF.ShowDialog();
            productSelect = ProductSelectWF.productSelect;
            if (ProductSelectWF.productSelectStatus)
            {
                BEProduct.Text = productSelect.ProductName;
                TEPrice.Text = productSelect.ProductPrice.ToString();
                PieceCombobox();
            }
        }
       private void PieceCombobox()
        {
            try
            {
                //ADET İŞLEMLERİ;
                //TÜM ADET BİLGİSİNİ SİLER
                //ÜRÜNLERDEN ÇEKİLEN BİLGİ ADETİ KADAR COMBOBOX DOLDURULUR.
                //EĞER 1'DEN FAZLA VARSA SEÇİM YAPAR (BURASI İÇİN HER ZAMAN 1'DEN FAZLA OLMASINI SAĞLAMAK İÇİN PRODUCT ÇEKERKEN EN AZ 1 ÜRÜN OLMASI ŞARTI KONULACAK.)
                CBEPiece.Properties.Items.Clear();
                for (int i = 1; i <= productSelect.ProductPiece; i++)
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
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CompanyMovementDetailManager _companyMovementDetailManager = new CompanyMovementDetailManager(new EFCompanyMovementDetailDAL());
		CustomerMovementDetailManager _customerMovementDetailManager = new CustomerMovementDetailManager(new EFCustomerMovementDetailDAL());
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        private void SBSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CustomerMovementCame)//EĞER MÜŞTERİ HAREKETLERDEN GELİYORSA İLK KISMA GİRER.
                {
                    CustomerMovementDetail customerMovementDetail = new CustomerMovementDetail();
					if (productSelect.ProductID != null)
					{
						customerMovementDetail.ProductID = productSelect.ProductID;
					}
					else
					{
						customerMovementDetail.ProductID = null;
					}

					if (CBEPiece.Text != null)
					{
						customerMovementDetail.CustomerMovementDetailPiece = (int)CBEPiece.SelectedItem;
					}
					else
					{
						customerMovementDetail.CustomerMovementDetailPiece = null;
					}

					if (productSelect.ProductPrice != null)
					{
						customerMovementDetail.CustomerMovementDetailPrice = Convert.ToDecimal(TEPrice.Text.Replace('.', ','));
					}
					else
					{
						customerMovementDetail.CustomerMovementDetailPrice = null;
					}
					if (TETotalPrice.Text != null)
					{
						customerMovementDetail.CustomerMovementDetailTotalPrice = Convert.ToDecimal(TETotalPrice.Text.Replace('.', ','));
					}
					else
					{
						customerMovementDetail.CustomerMovementDetailTotalPrice = null;
					}

					customerMovementDetail.CustomerMovementID = CustomerMovementWF.CustomerMovementWF.CustomerrMovementIDINFO;

					Product product;
					if (new CustomerMovementDetailCommonValidatorControl().CustomerMovementDetailValidatorAndMessage(customerMovementDetail))
					{

						_customerMovementDetailManager.TAdd(customerMovementDetail);
						product = _productManager.GetById((int)productSelect.ProductID);
						product.ProductPiece = (product.ProductPiece - ((int)CBEPiece.SelectedItem));
						_productManager.TUpdate(product);
						XtraMessageBox.Show("YENİ ÜRÜN EKLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}

				}
                else
                {
					CompanyMovementDetail companyMovementDetail = new CompanyMovementDetail();

					if (productSelect.ProductID != null)
					{
						companyMovementDetail.ProductID = productSelect.ProductID;
					}
					else
					{
						companyMovementDetail.ProductID = null;
					}

					if (CBEPiece.Text != null)
					{
						companyMovementDetail.CompanyMovementDetailPiece = (int)CBEPiece.SelectedItem;
					}
					else
					{
						companyMovementDetail.CompanyMovementDetailPiece = null;
					}

					if (productSelect.ProductPrice != null)
					{
						companyMovementDetail.CompanyMovementDetailPrice = Convert.ToDecimal(TEPrice.Text.Replace('.', ','));
					}
					else
					{
						companyMovementDetail.CompanyMovementDetailPrice = null;
					}
					if (TETotalPrice.Text != null)
					{
						companyMovementDetail.CompanyMovementDetailTotalPrice = Convert.ToDecimal(TETotalPrice.Text.Replace('.', ','));
					}
					else
					{
						companyMovementDetail.CompanyMovementDetailTotalPrice = null;
					}

					companyMovementDetail.CompanyMovementID = CompanyMovementWF.CompanyMovementIDINFO;

					Product product;
					if (new CompanyMovementDetailCommonValidatorControl().CompanyMovementDetailValidatorAndMessage(companyMovementDetail))
					{
						_companyMovementDetailManager.TAdd(companyMovementDetail);
						product = _productManager.GetById((int)productSelect.ProductID);
						product.ProductPiece = (product.ProductPiece - ((int)CBEPiece.SelectedItem));
						_productManager.TUpdate(product);
						XtraMessageBox.Show("YENİ ÜRÜN EKLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
						this.Close();
					}
				}
              
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ÜRÜN BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
    }

        private void CBEPiece_SelectedIndexChanged(object sender, EventArgs e)
        {
            TETotalPrice.Text = (Convert.ToInt32(CBEPiece.SelectedItem) * productSelect.ProductPrice).ToString();
        }
    }
}