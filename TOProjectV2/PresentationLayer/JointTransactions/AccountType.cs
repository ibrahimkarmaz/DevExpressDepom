using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.JointTransactions
{
    
    public class AccountType
    {
        List<string> AccountTypeList = new List<string>();
        public AccountType()
        {
            AccountTypeList.Add("BİREYSEL");
            AccountTypeList.Add("KURUMSAL");
        }

        public bool TypeControl(string TypeName)
        {
            return AccountTypeList.Contains(TypeName);
        }

        public List<string> GetAllTypeList()
        {
            return AccountTypeList.ToList();
        }
    }
}
