using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class County
    {
        public int CountyID { get; set; }
        public string CountyName { get; set; }

        public ICollection<District> Districts { get; set; }
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Company> Companys { get; set; }

    }
}
