using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class ProductINBlandAndModelDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; } 
        public int ProductPiece { get; set; }
        public decimal ProductPurchasePrice { get; set; }
        public decimal ProductSalePrice { get; set; }
        public string ProductDetails { get; set; }
        public int BlandID { get; set; }
        public string BlandName { get; set; }
        public int ModelID { get; set; }
        public string ModelName { get; set; }
        public string ModelYear { get; set; }
        public bool ProductArchive { get; set; }

    }
}
