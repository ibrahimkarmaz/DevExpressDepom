using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Model
    {
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public bool ModelArchive { get; set; }

        public int BlandID { get; set; }
        public Bland Bland { get; set; }
    }
}
