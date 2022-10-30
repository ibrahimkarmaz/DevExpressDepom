using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class CustomerINCountyAndDistrintDTO
    {
        public int CustomerID { get; set; }
        public string CustomerTC { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurName { get; set; }
        public string CustomerGender { get; set; }//BAY BAYAN YAPILACAK VERİTABANINDA 0-1
        public DateTime? CustomerDateOfBirth { get; set; }
        public string CustomerMobilePhone { get; set; }
        public string CustomerOfficePhone { get; set; }
        public string CustomerMail { get; set; }

        public string CustomerHomeAddress { get; set; }
        public string CustomerTaxNumber { get; set; }

        public string CountyName { get; set; }
        public string DistrictName { get; set; }
        public bool CustomerArchive { get; set; }
    }
}
