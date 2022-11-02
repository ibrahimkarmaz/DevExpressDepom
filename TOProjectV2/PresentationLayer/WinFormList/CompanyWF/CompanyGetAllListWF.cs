using BusinessLayer.Concrete;
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
    public partial class CompanyGetAllListWF : DevExpress.XtraEditors.XtraForm
    {
        public CompanyGetAllListWF()
        {
            InitializeComponent();
        }
        CompanyManager _companyManager = new CompanyManager(new EFCompanyDAL());
        private void GetAllCompany()
        {
            GControlCompany.DataSource = _companyManager.CompanyGetList(x=>x.CompanyArchive==CompanyWF.CompanyArchive);
        }
        private void CompanyGetAllListWF_Load(object sender, EventArgs e)
        {
            if (CompanyWF.CompanyArchive!=true)
            {
                this.Text = "TÜM ARŞİV FİRMA BİLGİLERİ";
            }
                    
            GetAllCompany();
        }
    }
}