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

namespace PresentationLayer.WinFormList.ModelWF
{
    public partial class ModelUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public ModelUpdateWF()
        {
            InitializeComponent();
        }
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        ModelManager _modelManager = new ModelManager(new EFModelDAL());
        private void BlandLookUpEditAdd()
        {
            _blandManager = new BlandManager(new EFBlandDAL());
            LUEBlandName.Properties.DataSource = _blandManager.GetAllList(x => x.BlandArchive == true);
        }
        private void ModelEditProcess()
        {
            MODELID = -1;
            _modelManager = new ModelManager(new EFModelDAL());
            Model DATA = _modelManager.GetAllList(x=>x.ModelID==BlandTypeList.ModelID && x.ModelArchive==true).First();
            TEModelName.Text = DATA.ModelName;
            TEModelYear.Text = DATA.ModelYear;
            if (DATA.ModelArchive==true)
            {
                CheckEArchive.Checked = false;
            }
            else
            {
                CheckEArchive.Checked = true;
            }
            MODELID = DATA.ModelID;

            //MARKA SEÇİMİ
            LUEBlandName.EditValue = BlandTypeList.blandIDWithModelNew;
        }
        int MODELID = -1;
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ModelUpdateWF_Load(object sender, EventArgs e)
        {
            BlandLookUpEditAdd();
            ModelEditProcess();
        }
        Model model;
        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            model = _modelManager.GetById(MODELID);
            model.ModelName = TEModelName.Text;
            model.ModelYear = TEModelYear.Text;
            if (CheckEArchive.Checked)
            {
                model.ModelArchive = false;
            }
            else
            {
                model.ModelArchive = true;
            }
            model.BlandID =(int)LUEBlandName.EditValue;

            if (new ModelCommonValidationControl().ModelValidatorAndMessage(model))
            {
                _modelManager.TUpdate(model);
                XtraMessageBox.Show("MODEL BİLGİLERİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void SBtnModelNameBack_Click(object sender, EventArgs e)
        {
            ModelEditProcess();
        }
    }
}