using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using EntityLayer.Mapping;
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

namespace PresentationLayer.WinFormList.DepartmenWF
{
    public partial class DepartmentAddWF : DevExpress.XtraEditors.XtraForm
    {
        public DepartmentAddWF()
        {
            InitializeComponent();
        }
        DepartmentManager _departmentManager = new DepartmentManager(new EFDepartmentDAL());
        private void DepartmentAddWF_Load(object sender, EventArgs e)
        {

        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Department department;
        private void SBtnSave_Click(object sender, EventArgs e)
        {
            department = new Department();
            department.DepartmentName = TEDepartmentName.Text;
            department.DepartmentArchive = true;
            if (new DepartmentCommonValidatorControl().DepartmentValidatorAndMessage(department))
            {
                _departmentManager.TAdd(department);
                XtraMessageBox.Show("YENİ DEPARTMAN KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void SBtnListAdd_Click(object sender, EventArgs e)
        {
            department = new Department();
            department.DepartmentName = TEDepartmentName.Text;
            department.DepartmentArchive = true;
            if (new DepartmentCommonValidatorControl().DepartmentValidatorAndMessage(department))
            {
                if (listBoxDepartment.Items.IndexOf(TEDepartmentName.Text) == -1)
                {
                    listBoxDepartment.Items.Add(TEDepartmentName.Text);
                    TEDepartmentName.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("DEPARTMAN LİSTEDE MEVCUTTUR.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SBtnDepartmentRemove_Click(object sender, EventArgs e)
        {
            if (listBoxDepartment.SelectedIndex != -1)
            {
                listBoxDepartment.Items.RemoveAt(listBoxDepartment.SelectedIndex);
            }
        }

        private void SBtnDepartmentListClear_Click(object sender, EventArgs e)
        {
            listBoxDepartment.Items.Clear();
        }

        private void SBtnDepartmentListSave_Click(object sender, EventArgs e)
        {
            foreach (var departmentNameAndArchive in listBoxDepartment.Items)
            {
                department = new Department();
                department.DepartmentName = departmentNameAndArchive.ToString();
                department.DepartmentArchive = true;
                 _departmentManager.TAdd(department);
                this.Close();
            }
            XtraMessageBox.Show("YENİ DEPARTMAN LİSTESİ KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}