using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.Utils.DPI;
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
    public partial class ModelNewWF : DevExpress.XtraEditors.XtraForm
    {
        public ModelNewWF()
        {
            InitializeComponent();
        }
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        ModelManager _modelManager = new ModelManager(new EFModelDAL());
        Model model;
        private void BlandComboboxAdd()
        {
            _blandManager = new BlandManager(new EFBlandDAL());
            LUEBlandName.Properties.DataSource = _blandManager.GetAllList(x=>x.BlandArchive==true);
            LUEBlandName.EditValue = BlandTypeList.blandIDWithModelNew;
            LUEBlandName.Properties.ReadOnly = true;
        }
        private void ModelNewWF_Load(object sender, EventArgs e)
        {
            BlandComboboxAdd();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnSave_Click(object sender, EventArgs e)
        {
            model = new Model();
            model.ModelName = TEModelName.Text;
            model.ModelYear = TEModelYear.Text;
            model.ModelArchive = true;
            model.BlandID = (int)LUEBlandName.EditValue;
            if (new ModelCommonValidationControl().ModelValidatorAndMessage(model))
            {
                _modelManager.TAdd(model);
                XtraMessageBox.Show("YENİ MODEL KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }//ELSE KISMI YAZILMA ModelCommonValidationControl İÇİNDE ELSE KISMI YANI HATA UYARI KISMI HALLEDİLDİ.
        }

        private void SBtnListAdd_Click(object sender, EventArgs e)
        {
            model = new Model();
            model.ModelName = TEModelName.Text;
            model.ModelYear = TEModelYear.Text;
            if (new ModelCommonValidationControl().ModelValidatorAndMessage(model))
            {
                if (listBoxModel.Items.IndexOf(model.ModelName+"/"+model.ModelYear) == -1)
                {
                    listBoxModel.Items.Add(model.ModelName + "/" + model.ModelYear);
                    TEModelName.Text =TEModelYear.Text= "";
                }
                else
                {
                    XtraMessageBox.Show("MODEL VE YIL LİSTEDE MEVCUTTUR.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SBtnBlandRemove_Click(object sender, EventArgs e)
        {
            if (listBoxModel.SelectedIndex != -1)
            {
                listBoxModel.Items.RemoveAt(listBoxModel.SelectedIndex);
            }
        }

        private void SBtnBlandListClear_Click(object sender, EventArgs e)
        {
            listBoxModel.Items.Clear();
        }

        private void SBtnBlandlListSave_Click(object sender, EventArgs e)
        {
            foreach (var modelAndYear in listBoxModel.Items)
            {
                model = new Model();
                model.ModelName = modelAndYear.ToString().Split('/')[0].ToString();
                model.ModelYear =modelAndYear.ToString().Split('/')[1].ToString();
                model.ModelArchive = true;
                model.BlandID =(int)LUEBlandName.EditValue;
                _modelManager.TAdd(model);
                this.Close();
            }
            XtraMessageBox.Show("YENİ MODEL LİSTESİ KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}