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
        public string InvoiceSeries { get; set; }
        public string InvoiceDesk { get; set; }
        public DateTime InvoiceDate { get; set; }
        public DateTime InvoiceTime { get; set; }
        public string InvoiceTaxOffice { get; set; }
        public string InvoiceBuyer { get; set; }
        public string InvoiceSubmitter { get; set; }
        public string InvoiceDeliveryArea { get; set; }
        public bool InvoiceArchive { get; set; }

    }
}
