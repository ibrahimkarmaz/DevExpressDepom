using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.WinFormList.DepartmentWF;
using PresentationLayer.WinFormList.ExpenseWF.ExpenseHeaderWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.ExpenseWF
{
    public partial class ExpenseWF : DevExpress.XtraEditors.XtraForm
    {
        public ExpenseWF()
        {
            InitializeComponent();
        }
        ExpenseHeaderManager _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
        private void accordionControlNewExpenseHeader_Click(object sender, EventArgs e)
        {
            ExpenseHeaderAddWF expenseHeaderAddWF = new ExpenseHeaderAddWF();
            expenseHeaderAddWF.ShowDialog();
            GetAllExpenseHeader();
        }
        private void GetAllExpenseHeader()
        {
            _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
            GControlExpenseHeader.DataSource = _expenseHeaderManager.GetAllList(x => x.ExpenseHeaderArchive == true);
        }
        private void GetAllExpenseHeaderArcihve()
        {
            _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
            GControlArchive.DataSource = _expenseHeaderManager.GetAllList(x => x.ExpenseHeaderArchive == false);
        }
        private void ExpenseWF_Load(object sender, EventArgs e)
        {
            GetAllExpenseHeader();
            GetAllExpenseHeaderArcihve();
        }

        private void GControlCustomer_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlExpenseHeaderUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ExpenseHeaderUpdateWF.ExpenseHeaderID = (int)GViewExpenseHeader.GetRowCellValue(GViewExpenseHeader.FocusedRowHandle, GViewExpenseHeader.Columns[0]);
                ExpenseHeaderUpdateWF expenseHeaderUpdateWF = new ExpenseHeaderUpdateWF();
                expenseHeaderUpdateWF.ShowDialog();
                GetAllExpenseHeader();
            }
            catch (Exception)
            {
                ExpenseHeaderUpdateWF.ExpenseHeaderID = -1;
                XtraMessageBox.Show("LÜTFEN GİDER BAŞLIĞI BİLGİSİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void accordionControlExpenseHeaderList_Click(object sender, EventArgs e)
        {
            GetAllExpenseHeader();
        }
        ExpenseHeader expenseHeader;
        private void accordionControlExpenseHeaderDelete_Click(object sender, EventArgs e)
        {
            try
            {
                expenseHeader = _expenseHeaderManager.GetById((int)GViewExpenseHeader.GetRowCellValue(GViewExpenseHeader.FocusedRowHandle, GViewExpenseHeader.Columns[0]));
                _expenseHeaderManager.TRemove(expenseHeader);
                GetAllExpenseHeader();
                XtraMessageBox.Show("GİDER BAŞLIĞI BİLGİLERİ SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN GİDER BAŞLIĞI BİLGİSİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlExpenseHeaderrArchive_Click(object sender, EventArgs e)
        {
            try
            {
                expenseHeader = _expenseHeaderManager.GetById((int)GViewExpenseHeader.GetRowCellValue(GViewExpenseHeader.FocusedRowHandle, GViewExpenseHeader.Columns[0]));
                expenseHeader.ExpenseHeaderArchive = false;
                _expenseHeaderManager.TUpdate(expenseHeader);
                GetAllExpenseHeader();
                GetAllExpenseHeaderArcihve();
                XtraMessageBox.Show("GİDER BAŞLIĞI BİLGİLERİ ARŞİVLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN GİDER BAŞLIĞI BİLGİSİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                expenseHeader = _expenseHeaderManager.GetById((int)GViewArchive.GetRowCellValue(GViewArchive.FocusedRowHandle, GViewArchive.Columns[0]));
                expenseHeader.ExpenseHeaderArchive = true;
                _expenseHeaderManager.TUpdate(expenseHeader);
                GetAllExpenseHeader();
                GetAllExpenseHeaderArcihve();
                XtraMessageBox.Show("GİDER BAŞLIĞI BİLGİLERİ ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                XtraMessageBox.Show("LÜTFEN GİDER BAŞLIĞI BİLGİSİ SEÇİNİZ...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlExpenseHeaderArchiveList_Click(object sender, EventArgs e)
        {
            GetAllExpenseHeaderArcihve();
        }

        private void xtraTabControl_Click(object sender, EventArgs e)
        {
            if (xtraTabControl.SelectedTabPage==TabPageExpenseHeader)
            {
                accordionControl1.ActiveGroup = accordionControlExpenseHeaderProcess;
            }
            else
            {
                accordionControl1.ActiveGroup = accordionControlArchive;
            }
        }

        private void accordionControlExpenseHeaderProcess_Click(object sender, EventArgs e)
        {
            xtraTabControl.SelectedTabPage = TabPageExpenseHeader;
        }

        private void accordionControlArchive_Click(object sender, EventArgs e)
        {
            xtraTabControl.SelectedTabPage = TabPageExpenseHeaderArchive;
        }
    }
}