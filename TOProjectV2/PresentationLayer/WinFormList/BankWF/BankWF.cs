using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using EntityLayer.Concrete;
using PresentationLayer.WinFormList.CompanyWF;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.WinFormList.BankWF
{
    public partial class BankWF : DevExpress.XtraEditors.XtraForm
    {
        public BankWF()
        {
            InitializeComponent();
        }
        BankManager _bankManager = new BankManager(new EFBankDAL());
        private void accordionControlNewBank_Click(object sender, EventArgs e)
        {
            BankAddWF bankAddWF = new BankAddWF();
            bankAddWF.ShowDialog();
        }
       
        private void accordionControlBankFullList_Click(object sender, EventArgs e)
        {
            BankExpandWF.Archive = true;
            BankExpandWF bankExpand = new BankExpandWF();
            bankExpand.ShowDialog();
        }
        private void GetAllBank()
        {
            GControlBank.DataSource = _bankManager.GetAllBank(x => x.BankArchive == true);
        }
        private void GetAllBankArchive()
        {
            GControlBankArchive.DataSource = _bankManager.GetAllBank(x => x.BankArchive == false);
        }
        private void BankWF_Load(object sender, EventArgs e)
        {
            GetAllBank();
            GetAllBankArchive();
        }

        private void accordionControlBankUpdate_Click(object sender, EventArgs e)
        {
           
            try
            {
                BankUpdateWF.BankID = (int)GViewBank.GetRowCellValue(GViewBank.FocusedRowHandle, GViewBank.Columns[0]);
                BankUpdateWF bankUpdateWF = new BankUpdateWF();
                bankUpdateWF.ShowDialog();
                GetAllBank();
                GetAllBankArchive();
            }
            catch (Exception)
            {
                BankUpdateWF.BankID = -1;
                XtraMessageBox.Show("BANKA SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlBankList_Click(object sender, EventArgs e)
        {
            GetAllBank();
        }
        Bank bank;
        private void accordionControlBankArchive_Click(object sender, EventArgs e)
        {
            try
            {
                bank = _bankManager.GetById((int)GViewBank.GetRowCellValue(GViewBank.FocusedRowHandle, GViewBank.Columns[0]));
                bank.BankArchive = false;
                _bankManager.TUpdate(bank);
                GetAllBank();
                GetAllBankArchive();
                XtraMessageBox.Show("BANKA BİLGİLERİ ARŞİVLENDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("BANKA SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void accordionControlBankArchiveList_Click(object sender, EventArgs e)
        {
            GetAllBankArchive();
        }

        private void accordionControlBankArchiveQuit_Click(object sender, EventArgs e)
        {
            try
            {
                bank = _bankManager.GetById((int)GViewBankArchive.GetRowCellValue(GViewBankArchive.FocusedRowHandle, GViewBankArchive.Columns[0]));
                bank.BankArchive = true;
                _bankManager.TUpdate(bank);
                GetAllBank();
                GetAllBankArchive();
                XtraMessageBox.Show("BANKA BİLGİLERİ ARŞİVDEN ÇIKARILDI.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                XtraMessageBox.Show("ARŞİV LİSTESİNDEN BANKA SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void accordionControlBankDelete_Click(object sender, EventArgs e)
        {
            try
            {
                _bankManager.TRemove(_bankManager.GetById((int)(int)GViewBank.GetRowCellValue(GViewBank.FocusedRowHandle, GViewBank.Columns[0])));
                XtraMessageBox.Show("BANKA BİLGİLERİ SİLİNDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GetAllBank();
            }
            catch (Exception)
            {
                XtraMessageBox.Show("BANKA SEÇİNİZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void accordionControlBankGetAllList_Click(object sender, EventArgs e)
        {
            BankExpandWF.Archive = false;
            BankExpandWF bankExpand = new BankExpandWF();
            bankExpand.ShowDialog();
        }

        private void xtraTabCompanyControl_Click(object sender, EventArgs e)
        {
            if (xtraTabBankControl.SelectedTabPage== TabPageBank)
            {
                accordionControl1.ActiveGroup = accordionControlBankProcess;
            }
            else
            {
                accordionControl1.ActiveGroup = accordionControlArchive;
            }
        }

        private void accordionControlBankProcess_Click(object sender, EventArgs e)
        {
            xtraTabBankControl.SelectedTabPage = TabPageBank;
        }

        private void accordionControlArchive_Click(object sender, EventArgs e)
        {
            xtraTabBankControl.SelectedTabPage = TabPageBankArchive;
        }
    }
}