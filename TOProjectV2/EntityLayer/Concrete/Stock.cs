using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Stock
    {
        public int StockID { get; set; }
        public string StockType { get; set; }
        public string StockPiece { get; set; }
        public bool StockArchive { get; set; }
    }
}
