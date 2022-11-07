using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ExpenseHeader
    {
        public int ExprenseHeaderID { get; set; }
        public string ExprenseHeaderName { get; set; }
        public DateTime? ExprenseHeaderStartDate { get; set; }
        public DateTime? ExprenseHeaderStopDate { get; set; }
        public string ExprenseHeaderDetail { get; set; }
        public bool ExpenseHeaderArchive { get; set; }

        public ICollection<ExpenseContent> ExpenseContents { get; set; }
    }
}