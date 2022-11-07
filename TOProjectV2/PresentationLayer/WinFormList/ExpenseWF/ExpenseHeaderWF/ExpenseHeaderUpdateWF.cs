using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using DevExpress.XtraEditors;
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

namespace PresentationLayer.WinFormList.ExpenseWF.ExpenseHeaderWF
{
    public partial class ExpenseHeaderUpdateWF : DevExpress.XtraEditors.XtraForm
    {
        public ExpenseHeaderUpdateWF()
        {
            InitializeComponent();
        }
        ExpenseHeaderManager _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
        public static int ExpenseHeaderID;
        ExpenseHeader expenseHeader;
        private void GetExpenseHeaderID()
        {
            expenseHeader = _expenseHeaderManager.GetById(ExpenseHeaderID);
        }
        private void GetAllExpenseHeaderWithID()
        {
            GetExpenseHeaderID();
            TEExpenseHeader.Text = expenseHeader.ExprenseHeaderName;
            TEStartDate.Text = expenseHeader.ExprenseHeaderStartDate.ToString();
            TEStopDate.Text=expenseHeader.ExprenseHeaderStopDate.ToString();
            MMEDetails.Text = expenseHeader.ExprenseHeaderDetail;
            if (expenseHeader.ExpenseHeaderArchive)
            {
                CheckEArchive.Checked = false;
            }
            else
            {
                CheckEArchive.Checked = true;
            }

        }
        private void ExpenseHeaderUpdateWF_Load(object sender, EventArgs e)
        {
            GetAllExpenseHeaderWithID();
        }

        private void SBtnBack_Click(object sender, EventArgs e)
        {
            GetAllExpenseHeaderWithID();
        }

        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SBtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                GetExpenseHeaderID();
                expenseHeader.ExprenseHeaderName = TEExpenseHeader.Text;
                if (TEStartDate.Text != "")
                {
                    expenseHeader.ExprenseHeaderStartDate = Convert.ToDateTime(TEStartDate.Text);
                }
                else
                {
                    expenseHeader.ExprenseHeaderStartDate = null;
                }

                if (TEStopDate.Text != "")
                {
                    expenseHeader.ExprenseHeaderStopDate = Convert.ToDateTime(TEStopDate.Text);

                }
                else
                {
                    expenseHeader.ExprenseHeaderStopDate = null;
                }
                expenseHeader.ExprenseHeaderDetail = MMEDetails.Text;
                expenseHeader.ExpenseHeaderArchive = CheckEArchive.Checked ? false:true;

                if (new ExpenseHeaderCommonValidatoionControl().ExpenseHeaderalidatorAndMessage(expenseHeader))
                {
                    _expenseHeaderManager.TUpdate(expenseHeader);
                    XtraMessageBox.Show("GİDER BAŞLIĞI BİLGİLERİ DÜZENLENDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                XtraMessageBox.Show("GİDER BAŞLIĞI BİLGİLERİNİ DOLDURUNUZ.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}