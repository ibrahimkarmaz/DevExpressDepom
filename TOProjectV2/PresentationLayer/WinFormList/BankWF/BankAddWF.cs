using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.CommonValidationControls;
using PresentationLayer.JointTransactions;
using PresentationLayer.WinFormList.CompanyWF;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PresentationLayer.WinFormList.BankWF
{
    public partial class BankAddWF : DevExpress.XtraEditors.XtraForm
    {
        public BankAddWF()
        {
            InitializeComponent();
        }
        BankManager _bankManager = new BankManager(new EFBankDAL());
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
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnSave_Click(object sender, EventArgs e)
        {
            BankInfomationReadyANDSave();
        }
        Bank bank;
        bool Error = false;
        private void BankInfomationReadyANDSave()
        {
            try
            {
                Error = false;
                bank = new Bank();
                bank.BankName = LUEBankName.Text;
                Console.WriteLine(LUEBankName.Text);
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

                bank.BankArchive = true;

                if (new BankCommonValidatorControl().BankValidatorAndMessage(bank))
                {
                    if (Error==false)
                    {
                        _bankManager.TAdd(bank);
                        XtraMessageBox.Show("YENİ BANKA KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        CompanySelectDTO companySelect;
        private void BECompany_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
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

        private void BankAddWF_Load(object sender, EventArgs e)
        {
            GetAllCounty();
            CBEType.Properties.Items.AddRange(new AccountType().GetAllTypeList());
            LUEBankName.Properties.DataSource = new BankName().GetAllBankName();
        }

        private void LUECounty_EditValueChanged(object sender, EventArgs e)
        {
            GetAllDistrict();
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}