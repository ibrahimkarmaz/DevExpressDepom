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

namespace PresentationLayer.WinFormList.DepartmentWF
{
    public partial class DepartmentUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public DepartmentUpdateWF()
        {
            InitializeComponent();
        }
        DepartmentManager _departmentManager = new DepartmentManager(new EFDepartmentDAL());
        Department value;
        private void GetByName()
        {
             value = _departmentManager.GetById(DepartmentWF.DepartmentIDUpdate);
            TEDepartmentName.Text = value.DepartmentName;
            if (value.DepartmentArchive)
            {
                CheckEArchive.Checked = false;
            }
            else
            {
                CheckEArchive.Checked = true;
            }
        }
        private void DepartmentUpdateWF_Load(object sender, EventArgs e)
        {
            GetByName();
        }

        private void SBtnDepartmentNameBack_Click(object sender, EventArgs e)
        {
            GetByName();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            value = _departmentManager.GetById(DepartmentWF.DepartmentIDUpdate);
            value.DepartmentName = TEDepartmentName.Text;
            if (CheckEArchive.Checked)//TEK TRUE İSE VERİTABANINDA FALSE
            {
                value.DepartmentArchive = false;
            }
            else
            {
                value.DepartmentArchive = true;
            }
            if (new DepartmentCommonValidatorControl().DepartmentValidatorAndMessage(value))
            {
                _departmentManager.TUpdate(value);
                this.Close();
                XtraMessageBox.Show("DEPARTMAN BİLGİSİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}