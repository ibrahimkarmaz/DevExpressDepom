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
    public partial class ExpenseHeaderAddWF : DevExpress.XtraEditors.XtraForm
    {
        public ExpenseHeaderAddWF()
        {
            InitializeComponent();
        }
        ExpenseHeaderManager _expenseHeaderManager = new ExpenseHeaderManager(new EFExpenseHeaderDAL());
        private void SBCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        ExpenseHeader expenseHeader;
        private void SBtnSave_Click(object sender, EventArgs e)
        {
            try
            { 
                expenseHeader = new ExpenseHeader();
                expenseHeader.ExprenseHeaderName = TEExpenseHeader.Text;
                if (TEStartDate.Text!="")
                {
                    expenseHeader.ExprenseHeaderStartDate = Convert.ToDateTime(TEStartDate.Text);
                }
                else
                {
                    expenseHeader.ExprenseHeaderStartDate = null;
                }
                if (TEStopDate.Text!="")
                {
                    expenseHeader.ExprenseHeaderStopDate = Convert.ToDateTime(TEStopDate.Text);

                }
                else
                {
                    expenseHeader.ExprenseHeaderStopDate = null;
                }
                expenseHeader.ExprenseHeaderDetail = MMEDetails.Text;
                expenseHeader.ExpenseHeaderArchive = true;

                if (new ExpenseHeaderCommonValidatoionControl().ExpenseHeaderalidatorAndMessage(expenseHeader))
                {
                    _expenseHeaderManager.TAdd(expenseHeader);
                    XtraMessageBox.Show("YENİ GİDER BAŞLIĞI KAYDEDİLDİ.", "BAŞARILI", MessageBoxButtons.OK, MessageBoxIcon.Information);
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