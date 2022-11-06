using DevExpress.XtraEditors;
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

        private void accordionControlNewExpenseHeader_Click(object sender, EventArgs e)
        {
            ExpenseHeaderAddWF expenseHeaderAddWF = new ExpenseHeaderAddWF();
            expenseHeaderAddWF.ShowDialog();
        }
    }
}