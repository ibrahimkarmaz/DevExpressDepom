using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ExpenseHeader
    {
        public int ExorenseHeaderID { get; set; }
        public string ExorenseHeaderName { get; set; }
        public DateTime? ExorenseHeaderStartDate { get; set; }
        public DateTime? ExorenseHeaderStopDate { get; set; }
        public string ExorenseHeaderDetail { get; set; }
        public bool ExpenseHeaderArchive { get; set; }
    }
}
