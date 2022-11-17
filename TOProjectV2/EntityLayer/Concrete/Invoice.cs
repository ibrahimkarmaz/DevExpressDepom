using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int? CompanyMovementID { get; set; }
        public CompanyMovement CompanyMovement { get; set; }
        public string InvoiceSeries { get; set; }
    }
}
