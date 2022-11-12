using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class BankINCountyDistrintAndCompanyDTO
    {
        public int BankID { get; set; }
        public string BankName { get; set; }

        public string CountyName { get; set; }
        public string DistrictName { get; set; }

        public string BankBranch { get; set; }
        public string IBAN { get; set; }
        public string BankAccountNo { get; set; }
        public string BankOfficial { get; set; }
        public string BankPhone { get; set; }
        public DateTime? BankDate { get; set; }
        public string BankAccountType { get; set; }

        public string CompanyName { get; set; }
        public bool BankArchive { get; set; }
    }
}
