using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class ProductSelectDTO
    {
        public int? ProductID { get; set; }
        public string ProductName { get; set; }
        public int? ProductPiece { get; set; }
        public decimal? ProductPrice { get; set; }
    }
}
