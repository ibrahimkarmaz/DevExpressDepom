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

namespace PresentationLayer.WinFormList.CompanyWF
{
    public partial class CompanyAddWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyAddWF()
        {
            InitializeComponent();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*KAYIT YAPERKEN HATA OLUŞUYOR.
         ÇÖZÜLEMEDİ.
        YAPILANLAR;
        - VERİ KONTROL
        -WACTH YAPILDI(DÜZGÜN ÇALIŞIYOR).


        NOT:VERİLERDE SORUN OLUNCA EKLEMİYOR OLABİLİR.  
         
         
         
         
         */
        CompanyManager _companyManager = new CompanyManager(new EFCompanyDAL());
        CountyManager _countyManager = new CountyManager(new EFCountyDAL());
        DistrictManager _districtManager = new DistrictManager(new EFDistrictDAL());
        SectorManager _sectorManager = new SectorManager(new EFSectorDAL());
        private void GetAllCounty()
        {
            LUECounty.Properties.DataSource = _countyManager.GetAllList();
        }
        private void GetAllDistrict()
        {
            LUEDistrict.Properties.DataSource = _districtManager.GetAllList(x => x.CountyID == (int)LUECounty.EditValue);
        }
        private void GetAllSector()
        {
            LUESector.Properties.DataSource = _sectorManager.GetAllList(x => x.SectorArchive == true);
        }
        private void CompanyAddWF_Load(object sender, EventArgs e)
        {
            GetAllCounty();
            GetAllSector();
        }

        private void LUECounty_EditValueChanged(object sender, EventArgs e)
        {
            GetAllDistrict();
        }
        Company company;
        private void SBtnSave_Click(object sender, EventArgs e)
        {
           /* try
            {*/
                company = new Company();
                company.CompanyName = TECompanyName.Text;
                if (LUESector.EditValue != null)
                {
                    company.SectorID = (int)LUESector.EditValue;
                }
                else
                {
                    company.SectorID = null;
                }
                company.CompanyOfficialTC = TETC.Text;
                company.CompanyOfficialNameSurName = TENameSurName.Text;
                company.CompanyOfficialStatus = TEStatus.Text;
                company.CompanyPhone1 = TEPhone1.Text;
                company.CompanyPhone2 = TEPhone2.Text;
                company.CompanyPhone3 = TEPhone3.Text;
                company.CompanyMail = TEMail.Text;
                company.CompanyFax = TEFax.Text;
                company.CompanyTaxOffice = TETaxOffice.Text;
                if (LUECounty.EditValue != null)
                {
                    company.CountyID = (int)LUECounty.EditValue;
                }
                else
                {
                    company.CountyID = null;
                }

                if (LUEDistrict.EditValue != null)
                {
                    company.DistrictID = (int)LUEDistrict.EditValue;
                }
                else
                {
                    company.DistrictID = null;
                }
                company.CompanyAddress = MMCompanyAddress.Text;
                company.CompanyArchive = true;
                if (new CompanyCommonValidatorControl().CompanyValidatorAndMessage(company))
                {
                    _companyManager.TAdd(company);
                    XtraMessageBox.Show("YENİ FİRMA KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
           /* }
            catch (Exception)
            {
                XtraMessageBox.Show("FİRMA BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }
    }
}