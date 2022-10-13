using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string CustomerTC { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurName { get; set; }
        public string CustomerMobilePhone { get; set; }
        public string CustomerOfficePhone { get; set; }
        public string CustomerMail { get; set; }
        public string CustomerTown { get; set; }
        public string CustomerCounty { get; set; }
        public string CustomerHomeAddress { get; set; }
        public string CustomerTaxNumber { get; set; }

        public bool CustomerArchive { get; set; }
    }
}
