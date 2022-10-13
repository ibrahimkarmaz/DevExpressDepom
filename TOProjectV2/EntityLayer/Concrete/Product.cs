using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }    
        public string ProductBland { get; set; }    
        public string ProductModel { get; set; }    
        public string ProductYear { get; set; }    
        public int ProductPiece { get; set; }    
        public decimal ProductPurchasePrice { get; set; }    
        public decimal ProductSalePrice { get; set; }

        public bool ProductArchive { get; set; }

    }
}
