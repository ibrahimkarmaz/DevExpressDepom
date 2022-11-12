using BusinessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
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
    public partial class CompanySelectWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanySelectWF()
        {
            InitializeComponent();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            companySelectStatus = false;
            this.Close();
        }
        //FİRMA SEÇİMLERİ İÇİN KULLANILIYOR (BUTTONEDİT İÇİN GENELLİKLE)
        CompanyManager _companyManager = new CompanyManager(new EFCompanyDAL());
        private void CompanySelectWF_Load(object sender, EventArgs e)
        {
            GetAllCompany();
        }
        private void GetAllCompany()
        {
            GControlCompany.DataSource = _companyManager.CompanyGetList(x => x.CompanyArchive == true);
        }
        private CompanySelectDTO GetCompanyINFO()
        {
            return new CompanySelectDTO()
            {
                CompanyID = (int)GViewCompany.GetRowCellValue(GViewCompany.FocusedRowHandle, GViewCompany.Columns[0]),
                CompanyName = GViewCompany.GetRowCellValue(GViewCompany.FocusedRowHandle, GViewCompany.Columns[1]).ToString()
            };
        }
        public static CompanySelectDTO companySelect;
        public static bool companySelectStatus;
        private void SBtnSelect_Click(object sender, EventArgs e)
        {
            CommonCompany();
        }

        private void GControlCompany_DoubleClick(object sender, EventArgs e)
        {
            CommonCompany();
        }
        private void CommonCompany()
        {
            try
            {
                companySelectStatus = true;
                companySelect = GetCompanyINFO();
                this.Close();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("FİRMA SEÇİLEMEDİ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}