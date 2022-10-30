using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.CustomerWF
{
    public partial class CustomerAddWF : DevExpress.XtraEditors.XtraForm
    {
        public CustomerAddWF()
        {
            InitializeComponent();
        }
        CountyManager _countyManager = new CountyManager(new EFCountyDAL());
        DistrictManager _districtManager = new DistrictManager(new EFDistrictDAL());
        CustomerManager _customerManager = new CustomerManager(new EFCustomerDAL());
        private void SBtnApploval_Click(object sender, EventArgs e)
        {//REFERANSA EKLENEN ADRES https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?WSDL
            if (XtraMessageBox.Show("T.C KİMLİK KONTROL SİSTEMİ İÇİN;\n-T.C\n-AD\n-SOYAD\n-DOĞUM TARİHİ\nBİLGİLERİ DOĞRU GİRİLDİĞİNDEN EMİN OLUNUZ.\n\n\nT.C KİMLİK NUMARASINI KONTROL EDİLSİN Mİ ?", "T.C KİMLİK NUMARASI KONTROL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TCInformationControl.KPSPublicSoapClient TCCOntrol = new TCInformationControl.KPSPublicSoapClient();
                DateTime Year =Convert.ToDateTime(TEBirthOfDate.Text);
                if (TCCOntrol.TCKimlikNoDogrula(long.Parse(TETC.Text), TEFirstName.Text, TELasName.Text, int.Parse(Year.Year.ToString())))
                {
                    XtraMessageBox.Show("T.C KİMLİK NUMARASI DOĞRULANDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("T.C KİMLİK NUMARASI BULUNAMADI.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GetAllCounty()
        {
            LUECounty.Properties.DataSource = _countyManager.GetAllList();
        }
        private void GetAllDistrict()
        {
            LUEDistrict.Properties.DataSource = _districtManager.GetAllList(x => x.CountyID == (int)LUECounty.EditValue);
        }
        private void CustomerAddWF_Load(object sender, EventArgs e)
        {
            CBEGender.Properties.Items.Add("BAYAN");
            CBEGender.Properties.Items.Add("BAY");
            GetAllCounty();
        }

        private void LUECounty_EditValueChanged(object sender, EventArgs e)
        {
            GetAllDistrict();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Customer customer;
        private void SBtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                customer = new Customer();
                customer.CustomerTC = TETC.Text;
                customer.CustomerName = TEFirstName.Text;
                customer.CustomerSurName = TELasName.Text;
                if (CBEGender.SelectedIndex == 1 || CBEGender.SelectedIndex == 0)//2 CİNSİYET İÇİN KONTROL
                {
                    customer.CustomerGender = Convert.ToBoolean(CBEGender.SelectedIndex);
                }
                else
                {
                    customer.CustomerGender = null;
                }
                if (TEBirthOfDate.Text != "")//TE DATETİMEPİCKER SEÇİLDİĞİNDE NULL GELMEZ.
                {
                    customer.CustomerDateOfBirth = Convert.ToDateTime(TEBirthOfDate.Text);
                }
                else
                {
                    customer.CustomerDateOfBirth = null;
                }
                customer.CustomerMobilePhone = TEMobilePhone.Text;
                customer.CustomerOfficePhone = TEOfficePhone.Text;
                customer.CustomerMail = TEMail.Text;
                customer.CustomerHomeAddress = MMEHomeAddress.Text;
                customer.CustomerTaxNumber = TETaxNumber.Text;

                if (LUECounty.EditValue != null)//İL SEÇİLMEMESİ DURUMUNDA ÇALIŞIR
                {
                    customer.CountyID = (int)LUECounty.EditValue;
                }
                else
                {
                    customer.CountyID = null;
                }
                if (LUEDistrict.EditValue != null)//İLÇE SEÇİLMEMESİ DURUMUNDA ÇALIŞIR
                {
                    customer.DistrictID = (int)LUEDistrict.EditValue;
                }
                else
                {
                    customer.DistrictID = null;
                }

                customer.CustomerArchive = true;
                if (new CustomerCommonValidationControl().CustomerValidatorAndMessage(customer))
                {
                    _customerManager.TAdd(customer);
                    XtraMessageBox.Show("YENİ MÜŞTERİ KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("MÜŞTERİ BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}




/*EK BİLGİ
 *1- TEXTEDİT'İN BÜYÜK HARFLE YAZMASI İÇİN; PROPERTİES'İN CharacterCasing UPPER YAP.
 *1 EK- TEXTEDİT MASKE YAPILABİLİR FAKAT BOŞLUK BİRAKILAMAZ.
 * 
 */