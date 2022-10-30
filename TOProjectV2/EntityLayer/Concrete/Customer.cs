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
        public bool? CustomerGender { get; set; }
        public DateTime? CustomerDateOfBirth { get; set; }
        public string CustomerMobilePhone { get; set; }
        public string CustomerOfficePhone { get; set; }
        public string CustomerMail { get; set; }
      
        public string CustomerHomeAddress { get; set; }
        public string CustomerTaxNumber { get; set; }

        public bool CustomerArchive { get; set; }

        public int? CountyID { get; set; }
        public County County { get; set; }

        public int? DistrictID { get; set; }
        public District District { get; set; }
    }
}
