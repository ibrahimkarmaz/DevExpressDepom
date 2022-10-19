using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Bland
    {
        public int BlandID { get; set; }
        public string BlandName { get; set; }

        public ICollection<Model> Models { get; set; }
    }
}
