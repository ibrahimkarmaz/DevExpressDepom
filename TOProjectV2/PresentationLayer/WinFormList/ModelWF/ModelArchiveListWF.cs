using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
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

namespace PresentationLayer.WinFormList.ModelWF
{
    public partial class ModelArchiveListWF : DevExpress.XtraEditors.XtraForm
    {
        ModelManager _modelManager = new ModelManager(new EFModelDAL());
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        public ModelArchiveListWF()
        {
            InitializeComponent();
        }
        private void ModelGetAll()
        {
            LabelBland.Text = _blandManager.GetById(BlandTypeList.blandIDWithModelNew).BlandName +" MODEL ARŞİVİ";
            GControlModel.DataSource = _modelManager.GetAllList(x=>x.ModelArchive==false && x.BlandID==BlandTypeList.blandIDWithModelNew);
        }
        private void ModelArchiveListWF_Load(object sender, EventArgs e)
        {
            ModelGetAll();
            GViewModel.OptionsBehavior.Editable = false;
            GViewModel.OptionsBehavior.ReadOnly = true;
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)GViewModel.GetRowCellValue(GViewModel.FocusedRowHandle, GViewModel.Columns[0]);
                if (id > 0)//VERİTABANINDA 0 DEĞERİ OLMAYACAĞI İÇİN BU DEĞER BELİRLENDİ.
                {
                    Model Data = _modelManager.GetById(id);
                    Data.ModelArchive = true;
                    _modelManager.TUpdate(Data);
                    XtraMessageBox.Show("MODEL ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModelGetAll();
                }
                else
                {
                    XtraMessageBox.Show("LÜTFEN MODEL SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN MODEL SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}