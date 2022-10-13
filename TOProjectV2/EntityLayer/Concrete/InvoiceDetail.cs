using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class InvoiceDetail
    {
        public int InvoiceProductID { get; set; }
        public string ProductName { get; set; }
        public int ProductPiece { get; set; }
        public decimal ProductPrice { get; set; }
        public decimal ProductAmount { get; set; }
        public decimal InvoiceID { get; set; }
        public bool InvoiceArchive { get; set; }
    }
}
