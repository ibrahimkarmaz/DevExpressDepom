using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.Reports;
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
        InvoiceManager _invoiceManager = new InvoiceManager(new EFInvoiceDAL());
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

                    //SERİ NO MANTIĞI:YIL+GÜN+SAAT+DAKİKA+FİRMA HAREKET ID ÖRNEK:2022 17 18 52 23 (BİRLEŞİK AMA :))
                    DateTime Date = DateTime.Now;
                    Invoice invoiceDATA = new Invoice();
                    invoiceDATA.InvoiceSeries = Date.Year.ToString() + Date.Day.ToString() + Date.Hour + Date.Minute + CompanyMovementIDINFO.ToString();
                    invoiceDATA.CompanyMovementID = CompanyMovementIDINFO;
                    _invoiceManager.TAdd(invoiceDATA);
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

        private void CompanyMovementWF_Load(object sender, EventArgs e)
        {

           
        }

        private void SBtnInvoiceCreate_Click(object sender, EventArgs e)
        {
            try
            {
                EntityLayer.Concrete.CompanyMovement companyMovement = _companyMovementManager.GetById(CompanyMovementIDINFO);
                companyMovement.CompanyMovemenArchive = false;
                _companyMovementManager.TUpdate(companyMovement);


                CompanyMovementReport.IDInfo = CompanyMovementIDINFO.ToString();
                CompanyMovementReport companyMovementReportOpen = new CompanyMovementReport();
                companyMovementReportOpen.RequestParameters = false;
                companyMovementReportOpen.ShowPreviewDialog();
                this.Close();

            }
            catch (Exception)
            {
                // XtraMessageBox.Show("ÜRÜN SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SBtnCancel_Click(object sender, EventArgs e)
        {/*DİKKAT: DAHA İYİ BİR KOD DİZİMİ KULLANILMALI GÜVENLİK AÇISINDAN SORUN OLUŞTURABİLİR.*/
            List<CompanyMovementDetail> DetailDATA = _companyMovementDetailManager.GetByFilter(x => x.CompanyMovementID == CompanyMovementIDINFO);
            Product product;

            //ÜRÜNLERİN ADETİ İADE EDİLDİ.
            //FİRMA HAREKET DETAYLARI SİLİNDİ.
            foreach (var UpdateAndDelete in DetailDATA)
            {
                product=_productManager.GetById((int)UpdateAndDelete.ProductID);
                product.ProductPiece = (product.ProductPiece + (int)UpdateAndDelete.CompanyMovementDetailPiece);
                _productManager.TUpdate(product);
                _companyMovementDetailManager.TRemove(_companyMovementDetailManager.GetById(UpdateAndDelete.CompanyMovementDetailID));
            }

            //FATURA SİLİNDİ.
            Invoice invoiceDATA = _invoiceManager.GetById(_invoiceManager.GetAllList().Max(x=>x.InvoiceID));//EN SON EKLENEN GETİRİLDİ VE SİLİNDİ
            _invoiceManager.TRemove(invoiceDATA);

            // FİRMA HAREKETLERİ SİLİNDİ.
            EntityLayer.Concrete.CompanyMovement companyMovement = _companyMovementManager.GetById(CompanyMovementIDINFO);
            _companyMovementManager.TRemove(companyMovement);
            this.Close();
        }
    }
}
/*KAYNAKÇA
 * https://docs.devexpress.com/WindowsForms/114624/controls-and-libraries/data-grid/getting-started/walkthroughs/summaries/tutorial-total-summaries
 * 
 * 
 * 
 * 
 */