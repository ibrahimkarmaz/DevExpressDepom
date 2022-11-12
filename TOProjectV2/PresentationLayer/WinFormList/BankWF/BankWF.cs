using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
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
        BankManager _bankManager = new BankManager(new EFBankDAL());
        private void GetAllBank()
        {
            GControlBank.DataSource = _bankManager.GetAllBank(x => x.BankArchive == true);
        }
        private void BankWF_Load(object sender, EventArgs e)
        {
            GetAllBank();
        }
    }
}