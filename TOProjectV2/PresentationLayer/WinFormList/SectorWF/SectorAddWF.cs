using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.Utils.Extensions;
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
    public partial class SectorAddWF : DevExpress.XtraEditors.XtraForm
    {
        public SectorAddWF()
        {
            InitializeComponent();
        }
        SectorManager _sectorManager = new SectorManager(new EFSectorDAL());
        private void SectorAddWF_Load(object sender, EventArgs e)
        {

        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Sector sector;
        private void SBtnSave_Click(object sender, EventArgs e)
        {
            sector = new Sector();
            sector.SectorName = TESectorName.Text;
            sector.SectorArchive = true;
            if (new SectorCommonValidationControl().SectorValidatorAndMessage(sector))
            {
                _sectorManager.TAdd(sector);
                XtraMessageBox.Show("YENİ SEKTÖR KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void SBtnListAdd_Click(object sender, EventArgs e)
        {

            sector = new Sector();
            sector.SectorName = TESectorName.Text;
            sector.SectorArchive = true;
            if (new SectorCommonValidationControl().SectorValidatorAndMessage(sector))
            {
                if (listBoxSector.Items.IndexOf(TESectorName.Text) == -1)
                {
                    listBoxSector.Items.Add(TESectorName.Text);
                    TESectorName.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("SECTÖR LİSTEDE MEVCUTTUR.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


           
        }

        private void SBtnSectorListClear_Click(object sender, EventArgs e)
        {
            listBoxSector.Items.Clear();
        }

        private void SBtnSectorListSave_Click(object sender, EventArgs e)
        {
            foreach (var SectorNameAndArchive in listBoxSector.Items)
            {
                sector = new Sector();
                sector.SectorName = SectorNameAndArchive.ToString();
                sector.SectorArchive = true;
                _sectorManager.TAdd(sector);
                this.Close();
            }
            XtraMessageBox.Show("YENİ SEKTÖR LİSTESİ KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SBtnSectorRemove_Click(object sender, EventArgs e)
        {
            if (listBoxSector.SelectedIndex != -1)
            {
                listBoxSector.Items.RemoveAt(listBoxSector.SelectedIndex);
            }
        }
    }
}