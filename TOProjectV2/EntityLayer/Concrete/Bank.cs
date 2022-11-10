using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bank
    {
        public int BankID { get; set; }
        public string BankName { get; set; }

        public int? CountyID { get; set; }
        public County County { get; set; }

        public int? DistrictID { get; set; }
        public District Districts { get; set; }

        public string BankBranch { get; set; }
        public string IBAN { get; set; }
        public string BankAccountNo { get; set; }
        public string BankOfficial { get; set; }
        public string BankPhone { get; set; }
        public DateTime? BankDate { get; set; }
        public string BankAccountType { get; set; }

        public int? CompanyID { get; set; }
        public Company Companys { get; set; }
        public bool BankArchive { get; set; }

    }
}
