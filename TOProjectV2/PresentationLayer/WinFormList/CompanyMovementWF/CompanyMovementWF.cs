using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.WinFormList.CompanyWF;
using PresentationLayer.WinFormList.EmployeeWF;
using PresentationLayer.WinFormList.ProductWF;
using PresentationLayer.WinFormList.ProductWF.ProductMovementWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer.WinFormList.CompanyMovement
{
    public partial class CompanyMovementWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyMovementWF()
        {
            InitializeComponent();
        }
        CompanyMovementManager _companyMovementManager = new CompanyMovementManager(new EFCompanyMovementDAL());
        CompanyMovementDetailManager _companyMovementDetailManager = new CompanyMovementDetailManager(new EFCompanyMovementDetailDAL());
        CompanySelectDTO companySelect=new CompanySelectDTO();
        private void BECompany_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            CompanySelectWF.companySelectStatus = false;
            CompanySelectWF.companySelect = null;
            CompanySelectWF companySelectWF = new CompanySelectWF();
            companySelectWF.ShowDialog();
            companySelect = CompanySelectWF.companySelect;
            if (CompanySelectWF.companySelectStatus)
            {

                //Console.WriteLine(companySelect.CompanyID);
                BECompany.Text = companySelect.CompanyName;
            }
        }
        EmployeeSelectDTO employeeSelect=new EmployeeSelectDTO();
        private void BEEmployee_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            EmployeeSelectWF.EmployeeSelectStatus = false;
            employeeSelect = null;
            EmployeeSelectWF employeeSelectWF = new EmployeeSelectWF();
            employeeSelectWF.ShowDialog();
            employeeSelect = EmployeeSelectWF.employeeSelect;
            if (EmployeeSelectWF.EmployeeSelectStatus)
            {
                BEEmployee.Text = employeeSelect.EmployeeNameSurName;
            }
        }

        public static int CompanyMovementIDINFO;
        private void SBtnCompanyMovement_Click(object sender, EventArgs e)
        {/*CompanyMovement Bu dosya ismi olduğu için direk kullanamadık.*/
            
            try
            {
                EntityLayer.Concrete.CompanyMovement companyMovement = new EntityLayer.Concrete.CompanyMovement();
                if (employeeSelect.EmployeeID!=null)
                {
                    companyMovement.EmployeeID = employeeSelect.EmployeeID;
                }
                else
                {
                    companyMovement.EmployeeID = null;
                }

                if (companySelect.CompanyID!=null)
                {
                    companyMovement.CompanyID = companySelect.CompanyID;
                }
                else
                {
                    companyMovement.CompanyID = null;
                }
                if (TECreateDate.Text!="")
                {
                    companyMovement.CompanyMovementDate = Convert.ToDateTime(TECreateDate.Text);
                }
                else
                {
                    companyMovement.CompanyMovementDate = null;
                }
               
               
                companyMovement.CompanyMovemenNote = MMENote.Text;
                companyMovement.CompanyMovemenArchive = true;
                if (new CompanyMovementCommonValidatorControl().CompanyMovementValidatorAndMessage(companyMovement))
                {
                    _companyMovementManager.TAdd(companyMovement);
                    XtraMessageBox.Show("YENİ FİRMA HAREKETİ OLUŞTURULDU.\nÜRÜN BİLGİSİ İŞLEMLERİNİ UYGULAYABİLİRSİNİZ.\nVE RAPOR OLUŞTURABİLİRSİNİZ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    accordionControlProduct.Enabled = true;
                    GControlCompanyMovementDetail.Enabled = true;
                    GroupControlFin.Enabled = true;
                    SBtnCompanyMovement.Text = "Firma Hareketini Bilgisini Düzenle";
                    CompanyMovementIDINFO = _companyMovementManager.RecentlyAddedMovementID();//SON HAREKET ID'SI
                    GetAllCompanyMovementDetails();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("FİRMA HAREKETİ BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void GetAllCompanyMovementDetails()
        {
            GControlCompanyMovementDetail.DataSource = _companyMovementDetailManager.GetAllCompanyMovementDetail(x=>x.CompanyMovementID== CompanyMovementIDINFO);
        }
        private void accordionControlAdd_Click(object sender, EventArgs e)
        {
            ProductMovementAddWF productMovementAddWF = new ProductMovementAddWF();
            productMovementAddWF.ShowDialog();
            GetAllCompanyMovementDetails();
        }

        private void GControlCompanyMovement_Click(object sender, EventArgs e)
        {
          
        }

        public static int CompanyMovementDetailID;
        private void accordionControlUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyMovementDetailID = (int)GViewCompanyMovementDetail.GetRowCellValue(GViewCompanyMovementDetail.FocusedRowHandle, GViewCompanyMovementDetail.Columns[0]);
                ProductMovementUpdateWF productMovementUpdateWF = new ProductMovementUpdateWF();
                productMovementUpdateWF.ShowDialog();
                GetAllCompanyMovementDetails();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ÜRÜN SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Product product;
        CompanyMovementDetail companyMovementDetail;
        ProductManager _productManager = new ProductManager(new EFProductDAL());
        private void accordionControlDelete_Click(object sender, EventArgs e)
        {
            try
            {
                companyMovementDetail = _companyMovementDetailManager.GetById((int)GViewCompanyMovementDetail.GetRowCellValue(GViewCompanyMovementDetail.FocusedRowHandle, GViewCompanyMovementDetail.Columns[0]));
                product = _productManager.GetById((int)companyMovementDetail.ProductID);
                product.ProductPiece = (int)(product.ProductPiece + companyMovementDetail.CompanyMovementDetailPiece);
                _productManager.TUpdate(product);
                _companyMovementDetailManager.TRemove(companyMovementDetail);
                GetAllCompanyMovementDetails();
                XtraMessageBox.Show("ÜRÜN BİLGİSİ SİLİNDİ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ÜRÜN SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}