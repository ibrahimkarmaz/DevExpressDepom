using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;
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

namespace PresentationLayer.WinFormList.SectorWF
{
    public partial class SectorUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public SectorUpdateWF()
        {
            InitializeComponent();
        }
        SectorManager _sectorManager = new SectorManager(new EFSectorDAL());
        private void GetByName()
        {
            Sector value = _sectorManager.GetById(SectorWF.SectorIDUpdate);
            TESectorName.Text = value.SectorName;
            if (value.SectorArchive)
            {
                CheckEArchive.Checked = false;
            }
            else
            {
                CheckEArchive.Checked = true;
            }
        }
        private void SectorUpdateWF_Load(object sender, EventArgs e)
        {
            GetByName();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Sector sector;
        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            sector = _sectorManager.GetById(SectorWF.SectorIDUpdate);
            sector.SectorName = TESectorName.Text;
            if (CheckEArchive.Checked)//TEK TRUE İSE VERİTABANINDA FALSE
            {
                sector.SectorArchive = false;
            }
            else
            {
                sector.SectorArchive = true;
            }
            if (new SectorCommonValidationControl().SectorValidatorAndMessage(sector))
            {
                _sectorManager.TUpdate(sector);
                this.Close();
                XtraMessageBox.Show("SEKTÖR BİLGİSİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SBtnSectorNameBack_Click(object sender, EventArgs e)
        {
            GetByName();
        }
    }
}