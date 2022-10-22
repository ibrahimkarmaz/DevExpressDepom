using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
using EntityLayer.Concrete;
using FluentValidation.Results;
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

namespace PresentationLayer.WinFormList
{
    public partial class BlandUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public BlandUpdateWF()
        {
            InitializeComponent();
        }
        BlandManager _blandManager = new BlandManager(new EFBlandDAL()); 
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GetByName()
        {
            Bland value = _blandManager.GetById(BlandTypeList.blandIDUpdate);
            TEBlandName.Text = value.BlandName;
            if (value.BlandArchive)
            {
                CheckEArchive.Checked = false;
            }
            else
            {
                CheckEArchive.Checked = true;
            }
        }
        private void BlandUpdateWF_Load(object sender, EventArgs e)
        {
            GetByName();
        }

        private void SBtnBlandNameBack_Click(object sender, EventArgs e)
        {
            GetByName();
        }
        Bland bland;
        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            bland = new Bland();
            bland = _blandManager.GetById(BlandTypeList.blandIDUpdate);
            bland.BlandName = TEBlandName.Text;
            if (CheckEArchive.Checked)//TEK TRUE İSE VERİTABANINDA FALSE
            {
                bland.BlandArchive = false;
            }
            else
            {
                bland.BlandArchive = true;
            }
            if (new BlandCommonValidationControl().BlandValidatorAndMessage(bland,TEBlandName.Text))
            {
                _blandManager.TUpdate(bland);
                this.Close();
                XtraMessageBox.Show("MARKA BİLGİSİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}