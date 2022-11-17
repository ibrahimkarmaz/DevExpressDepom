using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CompanyMovement
    {
        public int CompanyMovementID { get; set; }
        
        //-----
        public int? EmployeeID { get; set; }
        public Employee Employee { get; set; }

        public int? CompanyID { get; set; }
        public Company Company { get; set; }
        //-----

        public DateTime? CompanyMovementDate { get; set; }
        public string CompanyMovemenNote { get; set; }
        public bool CompanyMovemenArchive { get; set; }

        public ICollection<CompanyMovementDetail> CompanyMovementDetails { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
    }
}
