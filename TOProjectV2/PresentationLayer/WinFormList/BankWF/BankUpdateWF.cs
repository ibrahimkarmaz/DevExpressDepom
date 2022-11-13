using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.ClipboardSource.SpreadsheetML;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.JointTransactions;
using PresentationLayer.WinFormList.CompanyWF;
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

namespace PresentationLayer.WinFormList.BankWF
{
    public partial class BankUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public BankUpdateWF()
        {
            InitializeComponent();
        }
        BankManager _bankManager = new BankManager(new EFBankDAL());
        CompanyManager _companyManager = new CompanyManager(new EFCompanyDAL());
        CountyManager _countyManager = new CountyManager(new EFCountyDAL());
        DistrictManager _districtManager = new DistrictManager(new EFDistrictDAL());
        private void GetAllCounty()
        {
            LUECounty.Properties.DataSource = _countyManager.GetAllList();
        }
        private void GetAllDistrict()
        {
            LUEDistrict.Properties.DataSource = _districtManager.GetAllList(x => x.CountyID == (int)LUECounty.EditValue);
        }
        Bank DATA;
        private void BankGetBy()
        {
            DATA = _bankManager.GetById(BankID);
            LUEBankName.EditValue = DATA.BankName.ToString();
            LUECounty.EditValue = DATA.CountyID;
            LUEDistrict.EditValue = DATA.DistrictID;
            TEBankBranch.Text = DATA.BankBranch;
            TEIBAN.Text = DATA.IBAN;
            TEBankAccountNo.Text = DATA.BankAccountNo;
            TEBankOfficial.Text = DATA.BankOfficial;
            TEBankPhone.Text = DATA.BankPhone;
            TECreateDate.Text = DATA.BankDate.ToString();
            CBEType.Text = DATA.BankAccountType;
            GetExtraData();
            CEArchive.Checked = DATA.BankArchive ? false : true;
        }
        private void GetExtraData()
        {
            Company EXTRADATA = _companyManager.GetById((int)DATA.CompanyID);
            companySelect = new CompanySelectDTO();
            companySelect.CompanyID = EXTRADATA.CompanyID;
            companySelect.CompanyName = EXTRADATA.CompanyName;
            BECompany.Text = companySelect.CompanyName;
        }
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static int BankID;
        private void BankUpdateWF_Load(object sender, EventArgs e)
        {
            GetAllCounty();
            CBEType.Properties.Items.AddRange(new AccountType().GetAllTypeList());
            LUEBankName.Properties.DataSource = new BankName().GetAllBankName();
            BankGetBy();
        }

        private void LUECounty_EditValueChanged(object sender, EventArgs e)
        {
            GetAllDistrict();
        }
        CompanySelectDTO companySelect;
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

        private void SBtnBankBack_Click(object sender, EventArgs e)
        {
            BankGetBy();
        }
        Bank bank;
        bool Error = false;
        private void BankInfomationReadyANDSave()
        {
            try
            {
                Error = false;
                bank = _bankManager.GetById(BankID);
                bank.BankName = LUEBankName.Text;
                if (LUECounty.EditValue != null)//İL SEÇİLMEMESİ DURUMUNDA ÇALIŞIR
                {
                    bank.CountyID = (int)LUECounty.EditValue;
                }
                else
                {
                    bank.CountyID = null;
                }

                if (LUEDistrict.EditValue != null)//İLÇE SEÇİLMEMESİ DURUMUNDA ÇALIŞIR
                {
                    bank.DistrictID = (int)LUEDistrict.EditValue;
                }
                else
                {
                    bank.DistrictID = null;
                }

                bank.BankBranch = TEBankBranch.Text;
                bank.IBAN = TEIBAN.Text;
                bank.BankAccountNo = TEBankAccountNo.Text;
                bank.BankOfficial = TEBankOfficial.Text;
                bank.BankPhone = TEBankPhone.Text;

                if (TECreateDate.Text != "")//TE DATETİMEPİCKER SEÇİLDİĞİNDE NULL GELMEZ.
                {
                    bank.BankDate = Convert.ToDateTime(TECreateDate.Text);
                }
                else
                {
                    bank.BankDate = null;
                }

                bank.BankAccountType = CBEType.Text;
                try
                {
                    bank.CompanyID = companySelect.CompanyID;
                    Error = false;
                }
                catch (Exception)
                {
                    Error = true;
                    bank.CompanyID = null;
                }

                bank.BankArchive = CEArchive.Checked? false:true;

                if (new BankCommonValidatorControl().BankValidatorAndMessage(bank))
                {
                    if (Error == false)
                    {
                        _bankManager.TUpdate(bank);
                        XtraMessageBox.Show("BANKA BİLGİLERİ DÜZENLENDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        XtraMessageBox.Show("FİRMA BOŞ GEÇİLEMEZ.", "BAŞARISIZ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("BANKA BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            BankInfomationReadyANDSave();
        }
    }
}