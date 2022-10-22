using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
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

namespace PresentationLayer.WinFormList
{
    public partial class BlandArchiveListWF : DevExpress.XtraEditors.XtraForm
    {
        public BlandArchiveListWF()
        {
            InitializeComponent();
        }
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        private void BlandGetAllList()
        {
            GControlBland.DataSource = _blandManager.GetAllList(x=>x.BlandArchive==false);
        }
        private void BlandArchiveListWF_Load(object sender, EventArgs e)
        {
            GViewBland.OptionsBehavior.Editable = false;
            GViewBland.OptionsBehavior.ReadOnly = true;
            BlandGetAllList();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)GViewBland.GetRowCellValue(GViewBland.FocusedRowHandle, GViewBland.Columns[0]);
                if (id > 0)//VERİTABANINDA 0 DEĞERİ OLMAYACAĞI İÇİN BU DEĞER BELİRLENDİ.
                {
                    Bland Data = _blandManager.GetById(id);
                    Data.BlandArchive = true;
                    _blandManager.TUpdate(Data);
                    XtraMessageBox.Show("MARKA ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BlandGetAllList();
                }
                else
                {
                    XtraMessageBox.Show("LÜTFEN MARKA SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN MARKA SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}