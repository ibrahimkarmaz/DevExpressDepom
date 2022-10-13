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
        public int CityID { get; set; }
        public string CountyName { get; set; }
        public string CityName { get; set; }
    }
}
