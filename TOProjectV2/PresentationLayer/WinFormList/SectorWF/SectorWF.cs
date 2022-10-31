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

namespace PresentationLayer.WinFormList.SectorWF
{
    public partial class SectorWF : DevExpress.XtraEditors.XtraForm
    {
        public SectorWF()
        {
            InitializeComponent();
        }
        SectorManager _sectorManager = new SectorManager(new EFSectorDAL());
         private void SectorGetAllList()
        {
            _sectorManager = new SectorManager(new EFSectorDAL());//LİSTEYİ YENİLEMİYORDU.
            GControlSector1.DataSource = _sectorManager.GetAllList(x=>x.SectorArchive==true);
        }
        private void SectorGetAllListArchive()
        {
            _sectorManager = new SectorManager(new EFSectorDAL());//LİSTEYİ YENİLEMİYORDU.
            GControlSectorArchive.DataSource = _sectorManager.GetAllList(x => x.SectorArchive == false);
        }
        private void SectorWF_Load(object sender, EventArgs e)
        {
            SectorGetAllList();
            SectorGetAllListArchive();
        }

        private void xtraTabCustomerControl_Click(object sender, EventArgs e)
        {
            if (xtraTabCustomerControl.SelectedTabPage == TabPageSectorArchive)
            {
                accordionControl1.ActiveGroup = accordionControlArchive;

            }
            else
            {
                accordionControl1.ActiveGroup = accordionControlSectorProcess;
            }
        }

        private void accordionControlSectorProcess_Click(object sender, EventArgs e)
        {
            xtraTabCustomerControl.SelectedTabPage = TabPageSector;
        }

        private void accordionControlArchive_Click(object sender, EventArgs e)
        {
            xtraTabCustomerControl.SelectedTabPage = TabPageSectorArchive;
        }
        SectorAddWF sectorAddWF = new SectorAddWF();
        private void accordionControlNewSector_Click(object sender, EventArgs e)
        {
            sectorAddWF = new SectorAddWF();
            sectorAddWF.ShowDialog();
            SectorGetAllList();
        }
        public static int SectorIDUpdate = -1;
        private void accordionControlSectorUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SectorIDUpdate = (int)GViewSector.GetRowCellValue(GViewSector.FocusedRowHandle, GViewSector.Columns[0]);
                SectorUpdateWF sectorUpdateWF = new SectorUpdateWF();
                sectorUpdateWF.ShowDialog();
                SectorGetAllList();
            }
            catch (Exception)
            {
                SectorIDUpdate = -1;
                XtraMessageBox.Show("LÜTFEN SEKTÖR SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        Sector sector;
        private void accordionControlSectorDelete_Click(object sender, EventArgs e)
        {//BURASI DÜZENLENECEK ÜRÜN, MÜŞTERİ VE FİRMA DURUMLARINA BAĞLIDIR.(TAHMİNİ.)
            try
            {
                sector = _sectorManager.GetById((int)GViewSector.GetRowCellValue(GViewSector.FocusedRowHandle, GViewSector.Columns[0]));
                _sectorManager.TRemove(sector);
                SectorGetAllList();
                XtraMessageBox.Show("SEKTÖR BİLGİSİ SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN SEKTÖR SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlSectorArchive_Click(object sender, EventArgs e)
        {
            try
            {
                sector = _sectorManager.GetById((int)GViewSector.GetRowCellValue(GViewSector.FocusedRowHandle, GViewSector.Columns[0]));
                sector.SectorArchive = false;
                _sectorManager.TUpdate(sector);
                SectorGetAllList();
                XtraMessageBox.Show("SEKTÖR BİLGİSİ ARŞİVLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN SEKTÖR SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlSectorList_Click(object sender, EventArgs e)
        {
            SectorGetAllList();
        }

        private void accordionControlSectorArchiveList_Click(object sender, EventArgs e)
        {
            SectorGetAllListArchive();
        }

        private void accordionControlSectorArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                sector = _sectorManager.GetById((int)GViewSectorArchive.GetRowCellValue(GViewSectorArchive.FocusedRowHandle, GViewSectorArchive.Columns[0]));
                sector.SectorArchive = true;
                _sectorManager.TUpdate(sector);
                SectorGetAllListArchive();
                XtraMessageBox.Show("SEKTÖR BİLGİSİ ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN ARŞİV LİSTESİNDEN SEKTÖR SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}