using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Customization;
using DevExpress.XtraEditors.DXErrorProvider;
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
    public partial class NewBlandWF : DevExpress.XtraEditors.XtraForm
    {
        public NewBlandWF()
        {
            InitializeComponent();
        }
        BlandManager _blandManager = new BlandManager(new EFBlandDAL());
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Bland bland;
        private void SBtnSave_Click(object sender, EventArgs e)
        {
            bland = new Bland();
            bland.BlandName = TEBlandName.Text;
            bland.BlandArchive = true;//ARŞİV OLAYI
            if (blandCommonValidationControl.BlandValidatorAndMessage(bland,TEBlandName.Text))
            {
                _blandManager.TAdd(bland);
                XtraMessageBox.Show("YENİ MARKA KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }

        }

        BlandCommonValidationControl blandCommonValidationControl = new BlandCommonValidationControl();
        private void SBtnListAdd_Click(object sender, EventArgs e)
        {
            bland = new Bland();
            bland.BlandName = TEBlandName.Text;
            bland.BlandArchive = true;//ARŞİV OLAYI
            if (blandCommonValidationControl.BlandValidatorAndMessage(bland, TEBlandName.Text))
            {
                if (listBoxBland.Items.IndexOf(TEBlandName.Text)==-1)
                {
                    listBoxBland.Items.Add(TEBlandName.Text);
                    TEBlandName.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("MARKA LİSTEDE MEVCUTTUR.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SBtnBlandRemove_Click(object sender, EventArgs e)
        {
            if (listBoxBland.SelectedIndex!=-1)
            {
                listBoxBland.Items.RemoveAt(listBoxBland.SelectedIndex);
            }
        }

        private void SBtnBlandListClear_Click(object sender, EventArgs e)
        {
            listBoxBland.Items.Clear();
        }

        private void SBtnBlandlListSave_Click(object sender, EventArgs e)
        {
            foreach (var BlandNameAndOth in listBoxBland.Items)
            {
                bland = new Bland();
                bland.BlandName = BlandNameAndOth.ToString();
                bland.BlandArchive = true;//ARŞİV OLAYI
                _blandManager.TAdd(bland);
                this.Close();
            }
            XtraMessageBox.Show("YENİ MARKA LİSTESİ KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}