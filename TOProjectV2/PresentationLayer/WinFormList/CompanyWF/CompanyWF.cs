using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
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
    public partial class CompanyWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyWF()
        {
            InitializeComponent();
        }
        CompanyManager _companyManager = new CompanyManager(new EFCompanyDAL());
        private void accordionControlNewCompany_Click(object sender, EventArgs e)
        {
            CompanyAddWF companyAdd = new CompanyAddWF();
            companyAdd.ShowDialog();

        }

        private void GetAllCompany()
        {
            GControlCompany.DataSource = _companyManager.CompanyGetList(x=>x.CompanyArchive==true);
        }
        private void GetAllCompanyArchive()
        {
            GControlCompanyArchive.DataSource = _companyManager.CompanyGetList(x => x.CompanyArchive == false);
        }
        private void CompanyWF_Load(object sender, EventArgs e)
        {
            GetAllCompany();
        }

        private void accordionControlCompanyList_Click(object sender, EventArgs e)
        {
            GetAllCompany();
        }
        public static bool CompanyArchive = true;
        private void accordionControlCompanyFullList_Click(object sender, EventArgs e)
        {
            CompanyArchive = true;
            CompanyGetAllListWF companyGetAllListWF = new CompanyGetAllListWF();
            companyGetAllListWF.ShowDialog();
        }

        private void accordionControlCompanyGetAllList_Click(object sender, EventArgs e)
        {
            CompanyArchive = false;
            CompanyGetAllListWF companyGetAllListWF = new CompanyGetAllListWF();
            companyGetAllListWF.ShowDialog();
        }

        private void accordionControlCompanyArchiveList_Click(object sender, EventArgs e)
        {
            GetAllCompanyArchive();
        }
        public static int CompanyIDUpdate = -1;
        private void accordionControlCompanyUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                CompanyIDUpdate = (int)GViewCompany.GetRowCellValue(GViewCompany.FocusedRowHandle, GViewCompany.Columns[0]);
                CompanyUpdateWF companyUpdateWF = new CompanyUpdateWF();
                companyUpdateWF.ShowDialog();
            }
            catch (Exception)
            {
                CompanyIDUpdate = -1;
                XtraMessageBox.Show("FİRMA SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlCompanyDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _companyManager.TRemove(_companyManager.GetById((int)GViewCompany.GetRowCellValue(GViewCompany.FocusedRowHandle, GViewCompany.Columns[0])));
                XtraMessageBox.Show("FİRMA BİLGİLERİ SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("FİRMA SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Company company;
        private void accordionControlCompanyArchive_Click(object sender, EventArgs e)
        {
            try
            {
                company = _companyManager.GetById((int)GViewCompany.GetRowCellValue(GViewCompany.FocusedRowHandle, GViewCompany.Columns[0]));
                company.CompanyArchive = false;
                _companyManager.TUpdate(company);
                XtraMessageBox.Show("FİRMA BİLGİLERİ ARŞİVLENDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("FİRMA SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlCompanyArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                company = _companyManager.GetById((int)GViewCompanyArchive.GetRowCellValue(GViewCompanyArchive.FocusedRowHandle, GViewCompanyArchive.Columns[0]));
                company.CompanyArchive = true;
                _companyManager.TUpdate(company);
                XtraMessageBox.Show("FİRMA BİLGİLERİ ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ARŞİV LİSTESİNDEN FİRMA SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlCompanyProcess_Click(object sender, EventArgs e)
        {
            xtraTabCompanyControl.SelectedTabPage = TabPageCompany;
        }

        private void accordionControlArchive_Click(object sender, EventArgs e)
        {
            xtraTabCompanyControl.SelectedTabPage = TabPageCompanyArchive;
        }

        private void xtraTabCompanyControl_Click(object sender, EventArgs e)
        {
            if (xtraTabCompanyControl.SelectedTabPage==TabPageCompanyArchive)
            {
                accordionControl1.ActiveGroup = accordionControlArchive;
            }
            else
            {
                accordionControl1.ActiveGroup = accordionControlCompanyProcess;
            }
        }
    }
}