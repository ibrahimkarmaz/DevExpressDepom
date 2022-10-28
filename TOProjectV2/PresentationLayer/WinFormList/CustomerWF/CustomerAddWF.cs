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
        private void SBtnApploval_Click(object sender, EventArgs e)
        {
            if (XtraMessageBox.Show("T.C KİMLİK KONTROL SİSTEMİ İÇİN;\n-T.C\n-AD\n-SOYAD\n-DOĞUM TARİHİ\nBİLGİLERİ DOĞRU GİRİLDİĞİNDEN EMİN OLUNUZ.\n\n\nT.C KİMLİK NUMARASINI KONTROL EDİLSİN Mİ ?", "T.C KİMLİK NUMARASI KONTROL",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                XtraMessageBox.Show("=> MODÜL YAZILACAK...");
            }
        }

        private void GetAllCounty()
        {
            LUECounty.Properties.DataSource = _countyManager.GetAllList();
        }
        private void GetAllDistrict()
        {
            LUEDistrict.Properties.DataSource = _districtManager.GetAllList(x=>x.CountyID==(int)LUECounty.EditValue);
        }
        private void CustomerAddWF_Load(object sender, EventArgs e)
        {
            CBEGender.Properties.Items.Add("BAY");
            CBEGender.Properties.Items.Add("BAYAN");
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
    }
}