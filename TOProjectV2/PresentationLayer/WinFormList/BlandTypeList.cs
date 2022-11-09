using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.WinFormList.ModelWF;
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
    public partial class BlandTypeList : DevExpress.XtraEditors.XtraForm
    {
        public BlandTypeList()
        {
            InitializeComponent();
        }
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        ModelManager _modelManager = new ModelManager(new EFModelDAL());
        ModelUpdateWF modelUpdateWF;

        private void BlandAndModelGridControlSettings()
        {
            GViewBland.OptionsBehavior.Editable = false;
            GViewBland.OptionsBehavior.ReadOnly = true;
            GViewModel.OptionsBehavior.Editable = false;
            GViewModel.OptionsBehavior.ReadOnly = true;
        }
        private void BlandGetAllList()
        {
            _blandManager = new BlandManager(new EFBlandDAL());
            GControlBland.DataSource = _blandManager.GetAllList(x=>x.BlandArchive==true);
        }
        private void ModelGetAllListBlandID()
        {
            _modelManager = new ModelManager(new EFModelDAL());
            try
            {
                int BlandID=(int)GViewBland.GetRowCellValue(GViewBland.FocusedRowHandle, GViewBland.Columns[0]);
                GControlModel.DataSource = _modelManager.GetAllList(x => x.BlandID == BlandID && x.ModelArchive == true);
            }
            catch (Exception)
            {
                Console.WriteLine("HATA");
            }
        }
        private void ProductTypeList_Load(object sender, EventArgs e)
        {
            BlandAndModelGridControlSettings();
            BlandGetAllList();
            ModelGetAllListBlandID();
        }
        private void accordionControlBlandNew_Click_1(object sender, EventArgs e)
        {
            NewBlandWF newBlandWF = new NewBlandWF();
            newBlandWF.ShowDialog();
            BlandGetAllList();
        }

        private void accordionControlBlandList_Click(object sender, EventArgs e)
        {
            BlandGetAllList();
        }

        private void accordionControlBlandArchive_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)GViewBland.GetRowCellValue(GViewBland.FocusedRowHandle, GViewBland.Columns[0]);
                if(id > 0)//VERİTABANINDA 0 DEĞERİ OLMAYACAĞI İÇİN BU DEĞER BELİRLENDİ.
                {
                   Bland Data=_blandManager.GetById(id);
                    Data.BlandArchive = false;
                    _blandManager.TUpdate(Data);
                    XtraMessageBox.Show("MARKA ARŞİVLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BlandGetAllList();
                }
                else
                {
                    XtraMessageBox.Show("LÜTFEN MARKA SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN MARKA SEÇİNİZ...","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
        private void accordionControlBlandArchiveList_Click(object sender, EventArgs e)
        {
            BlandArchiveListWF blandArchiveListWF = new BlandArchiveListWF();
            blandArchiveListWF.ShowDialog();
        }

        private void accordionControlBlandDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)GViewBland.GetRowCellValue(GViewBland.FocusedRowHandle, GViewBland.Columns[0]);
                if (id>0)
                {
                    Bland Data = _blandManager.GetById(id);
                    //NOT BURAYA PRODUCT İŞLEMLERİ YAPILDIKTAN SONRA;
                    //KATEGORİ KONTROLU YAPILACAK EĞER TÜR BİR ÜRÜNDE VAR İSE TRUE OLACAK VE SİLİNMESİ ENGELLENECEK.
                    _blandManager.TRemove(Data);
                    XtraMessageBox.Show("MARKA SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN MARKA SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static int blandIDUpdate = -1;
        private void accordionControlBlandUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                blandIDUpdate =(int)GViewBland.GetRowCellValue(GViewBland.FocusedRowHandle, GViewBland.Columns[0]);
                BlandUpdateWF blandUpdateWF = new BlandUpdateWF();
                blandUpdateWF.ShowDialog();
            }
            catch (Exception)
            {
                blandIDUpdate = -1;
                XtraMessageBox.Show("LÜTFEN MARKA SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int blandIDWithModelNew = -1;
        public static int ModelID = -1;
        private void accordionControlModelNew_Click(object sender, EventArgs e)
        {
            try
            {
                blandIDWithModelNew = (int)GViewBland.GetRowCellValue(GViewBland.FocusedRowHandle, GViewBland.Columns[0]);
                ModelNewWF modelNewWF = new ModelNewWF();
                modelNewWF.ShowDialog();
                ModelGetAllListBlandID();
            }
            catch (Exception)
            {
                blandIDWithModelNew = -1;
                XtraMessageBox.Show("LÜTFEN MARKA SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlModelUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ModelID = (int)GViewModel.GetRowCellValue(GViewModel.FocusedRowHandle, GViewModel.Columns[0]);
                blandIDWithModelNew = (int)GViewBland.GetRowCellValue(GViewBland.FocusedRowHandle, GViewBland.Columns[0]);
                modelUpdateWF = new ModelUpdateWF();
                modelUpdateWF.ShowDialog();
                ModelGetAllListBlandID();
            }
            catch (Exception)
            {
                blandIDWithModelNew = -1;
                ModelID = -1;
                XtraMessageBox.Show("LÜTFEN MARKA/MODEL SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlModelList_Click(object sender, EventArgs e)
        {
            ModelGetAllListBlandID();
        }

        private void accordionControlModelArchive_Click(object sender, EventArgs e)
        {

            try
            {
                int id = (int)GViewModel.GetRowCellValue(GViewModel.FocusedRowHandle, GViewModel.Columns[0]);
                if (id > 0)//VERİTABANINDA 0 DEĞERİ OLMAYACAĞI İÇİN BU DEĞER BELİRLENDİ.
                {
                    Model Data = _modelManager.GetById(id);
                    Data.ModelArchive = false;
                    _modelManager.TUpdate(Data);
                    XtraMessageBox.Show("MODEL ARŞİVLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ModelGetAllListBlandID();
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

        private void accordionControlModelDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)GViewModel.GetRowCellValue(GViewModel.FocusedRowHandle, GViewModel.Columns[0]);
                if (id > 0)
                {
                    Model Data = _modelManager.GetById(id);
                    //NOT BURAYA PRODUCT İŞLEMLERİ YAPILDIKTAN SONRA;
                    //KATEGORİ KONTROLU YAPILACAK EĞER TÜR BİR ÜRÜNDE VAR İSE TRUE OLACAK VE SİLİNMESİ ENGELLENECEK.
                    _modelManager.TRemove(Data);
                    XtraMessageBox.Show("MODEL SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN MODEL SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlArchive_Click(object sender, EventArgs e)
        {
            try
            {
                blandIDWithModelNew = (int)GViewBland.GetRowCellValue(GViewBland.FocusedRowHandle, GViewBland.Columns[0]);
                ModelArchiveListWF modelArchiveListWF = new ModelArchiveListWF();
                modelArchiveListWF.ShowDialog();
                ModelGetAllListBlandID();
            }
            catch (Exception)
            {
                blandIDWithModelNew = -1;
                XtraMessageBox.Show("LÜTFEN MODEL SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GViewBland_Click(object sender, EventArgs e)
        {
            ModelGetAllListBlandID();
        }
    }
}