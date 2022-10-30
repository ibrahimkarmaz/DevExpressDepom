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

namespace PresentationLayer.WinFormList.CustomerWF
{
    public partial class CustomerUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public CustomerUpdateWF()
        {
            InitializeComponent();
        }
        CountyManager _countyManager = new CountyManager(new EFCountyDAL());
        DistrictManager _districtManager = new DistrictManager(new EFDistrictDAL());
        CustomerManager _customerManager = new CustomerManager(new EFCustomerDAL());
        private void GetAllCounty()
        {
            LUECounty.Properties.DataSource = _countyManager.GetAllList();
        }
        private void GetAllDistrict()
        {
            LUEDistrict.Properties.DataSource = _districtManager.GetAllList(x => x.CountyID == (int)LUECounty.EditValue);
        }
        private void GetAllCustomerWithCustomerID()
        {//TÜM BİLGİLERİ NESNELERE YERLEŞTİRİR.
            CustomerInformationsGetById();
            TETC.Text = customer.CustomerTC;
            TEFirstName.Text = customer.CustomerName;
            TELasName.Text = customer.CustomerSurName;
            CBEGender.SelectedIndex = customer.CustomerGender == true ? 1 : 0;//CİNSİYET BELİRLEME
            TEBirthOfDate.Text = customer.CustomerDateOfBirth.ToString(); //?
            TEMobilePhone.Text = customer.CustomerMobilePhone;
            TEOfficePhone.Text = customer.CustomerOfficePhone;
            TEMail.Text = customer.CustomerMail;
            LUECounty.EditValue = customer.CountyID;
            LUEDistrict.EditValue = customer.DistrictID;
            MMEHomeAddress.Text = customer.CustomerHomeAddress;
            TETaxNumber.Text = customer.CustomerTaxNumber;
            CEArchive.Checked = (customer.CustomerArchive == true ? false : true);

        }
        private void SBtnApploval_Click(object sender, EventArgs e)
        {
            //REFERANSA EKLENEN ADRES https://tckimlik.nvi.gov.tr/Service/KPSPublic.asmx?WSDL
            if (XtraMessageBox.Show("T.C KİMLİK KONTROL SİSTEMİ İÇİN;\n-T.C\n-AD\n-SOYAD\n-DOĞUM TARİHİ\nBİLGİLERİ DOĞRU GİRİLDİĞİNDEN EMİN OLUNUZ.\n\n\nT.C KİMLİK NUMARASINI KONTROL EDİLSİN Mİ ?", "T.C KİMLİK NUMARASI KONTROL", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TCInformationControl.KPSPublicSoapClient TCCOntrol = new TCInformationControl.KPSPublicSoapClient();
                DateTime Year = Convert.ToDateTime(TEBirthOfDate.Text);
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

        private void CustomerUpdateWF_Load(object sender, EventArgs e)
        {
            CBEGender.Properties.Items.Add("BAYAN");
            CBEGender.Properties.Items.Add("BAY");
            GetAllCounty();
            GetAllCustomerWithCustomerID();
        }

        private void LUECounty_EditValueChanged(object sender, EventArgs e)
        {
            GetAllDistrict();
        }
        Customer customer;
        private void CustomerInformationsGetById()
        {//2'DEN FAZLA TEKRARLANIYOR.
            customer = _customerManager.GetById(CustomerWF.CustomerID);
        }
        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
            CustomerInformationsGetById();
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

            customer.CustomerArchive = (CEArchive.Checked ? false : true);

            if (new CustomerCommonValidationControl().CustomerValidatorAndMessage(customer))
            {
                _customerManager.TUpdate(customer);
                XtraMessageBox.Show("MÜŞTERİ BİLGİLERİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("MÜŞTERİ BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnCustomerBack_Click(object sender, EventArgs e)
        {
            GetAllCustomerWithCustomerID();
        }
    }
}
/*EK BİLGİ
 *1- TEXTEDİT'İN BÜYÜK HARFLE YAZMASI İÇİN; PROPERTİES'İN CharacterCasing UPPER YAP.
 *1 EK- TEXTEDİT MASKE YAPILABİLİR FAKAT BOŞLUK BİRAKILAMAZ.
 */