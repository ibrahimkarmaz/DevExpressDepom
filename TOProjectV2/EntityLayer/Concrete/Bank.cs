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
        public string BankBranch { get; set; }
        public string IBAN { get; set; }
        public string BankAccountName { get; set; }
        public string BankOfficial { get; set; }
        public DateTime BankDate { get; set; }
        public string BankAccountType { get; set; }

        public bool BankArchive { get; set; }

    }
}
