using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.WinFormList.DepartmenWF;
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
    public partial class DepartmentWF : DevExpress.XtraEditors.XtraForm
    {
        public DepartmentWF()
        {
            InitializeComponent();
        }
        DepartmentManager _departmentManager = new DepartmentManager(new EFDepartmentDAL());
        private void accordionControlNewDepartment_Click(object sender, EventArgs e)
        {
            DepartmentAddWF departmentAddWF = new DepartmentAddWF();
            departmentAddWF.ShowDialog();
        }
        public static int DepartmentIDUpdate = -1;
        private void accordionControlDepartmentUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DepartmentIDUpdate = (int)GViewDepartment.GetRowCellValue(GViewDepartment.FocusedRowHandle, GViewDepartment.Columns[0]);
                DepartmentUpdateWF departmentUpdateWF = new DepartmentUpdateWF();
                departmentUpdateWF.ShowDialog();
                DepartmentGetAllList();
            }
            catch (Exception)
            {
                DepartmentIDUpdate = -1;
                XtraMessageBox.Show("LÜTFEN DEPARTMAN SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DepartmentGetAllList()
        {
            _departmentManager = new DepartmentManager(new EFDepartmentDAL());//LİSTEYİ YENİLEMİYORDU.
            GControlDepartmen.DataSource = _departmentManager.GetAllList(x => x.DepartmentArchive == true);
        }
        private void DepartmentGetAllListArchive()
        {
            _departmentManager = new DepartmentManager(new EFDepartmentDAL());//LİSTEYİ YENİLEMİYORDU.
            GControlArchive.DataSource = _departmentManager.GetAllList(x => x.DepartmentArchive == false);
        }
        private void DepartmentWF_Load(object sender, EventArgs e)
        {
            DepartmentGetAllList();
            DepartmentGetAllListArchive();
        }

        private void accordionControlDepartmentList_Click(object sender, EventArgs e)
        {
            DepartmentGetAllList();
        }

        private void accordionControlDepartmentArchiveList_Click(object sender, EventArgs e)
        {
            DepartmentGetAllListArchive();
        }

        private void accordionControlDepartmentDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                _departmentManager.TRemove(_departmentManager.GetById((int)GViewDepartment.GetRowCellValue(GViewDepartment.FocusedRowHandle, GViewDepartment.Columns[0])));
                DepartmentGetAllList();
                XtraMessageBox.Show("DEPARTMAN BİLGİLERİ SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN DEPARTMAN SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlDepartmentArchive_Click(object sender, EventArgs e)
        {
            try
            {
                Department department= _departmentManager.GetById((int)GViewDepartment.GetRowCellValue(GViewDepartment.FocusedRowHandle, GViewDepartment.Columns[0]));
                department.DepartmentArchive = false;
                _departmentManager.TUpdate(department);
                XtraMessageBox.Show("DEPARTMAN BİLGİLERİ ARŞİVLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DepartmentGetAllList();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN DEPARTMAN SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlDepartmentArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                Department department = _departmentManager.GetById((int)GViewArchive.GetRowCellValue(GViewArchive.FocusedRowHandle, GViewArchive.Columns[0]));
                department.DepartmentArchive = true;
                _departmentManager.TUpdate(department);
                XtraMessageBox.Show("DEPARTMAN BİLGİLERİ ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DepartmentGetAllListArchive();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ARŞİV LİSTESİNDEN DEPARTMAN SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}