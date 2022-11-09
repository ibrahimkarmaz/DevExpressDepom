using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ExpenseContent
    {
        public int ExpenseContentID { get; set; }
        public string ExpenseContentTitle { get; set; }
        public string ExpenseContentType { get; set; }
        public string ExpenseContentPeceiptNumber { get; set; }
        public decimal ExpenseContentPeceiptPrice { get; set; }
        public string ExpenseContentPeceiptImage { get; set; }
        public string ExpenseContentNote { get; set; }
        public bool ExpenseContentArchive { get; set; }

        public int? ExprenseHeaderID { get; set; }
        public ExpenseHeader ExpenseHeader { get; set; }

    }
}
