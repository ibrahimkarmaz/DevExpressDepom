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
    public partial class BankExpandWF : DevExpress.XtraEditors.XtraForm
    {
        public BankExpandWF()
        {
            InitializeComponent();
        }
        BankManager _bankManager = new BankManager(new EFBankDAL());
        public static bool Archive;
        private void GetAllBank()
        {
            GControlBank.DataSource = _bankManager.GetAllBank(x=>x.BankArchive== Archive);
        }
        private void BankExpandWF_Load(object sender, EventArgs e)
        {
            GetAllBank();
        }
    }
}