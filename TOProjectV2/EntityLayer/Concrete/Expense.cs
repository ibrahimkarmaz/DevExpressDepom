using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Expense
    {
        public int ExpenseID { get; set; }
        public decimal ExpenseElectric { get; set; }
        public decimal ExpenseWater { get; set; }
        public decimal ExpenseNaturalGas { get; set; }
        public decimal ExpenseInternet { get; set; }
        public decimal ExpenseWage { get; set; }
        public decimal ExpenseExtra { get; set; }
        public string ExpenseNote { get; set; }
        public bool ExpenseArchive { get; set; }
    }
}
