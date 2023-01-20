using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }    
        //public string ProductYear { get; set; }    //YÜKLEME YAPILDI.
        public int ProductPiece { get; set; }    
        public decimal ProductPurchasePrice { get; set; }    
        public decimal ProductSalePrice { get; set; }
        public string ProductDetails { get; set; }

        public int ModelID { get; set; }
        public Model Model { get; set; }

        public int BlandID { get; set; }
        public Bland Bland { get; set; }
        public bool ProductArchive { get; set; }

        public ICollection<CompanyMovementDetail> CompanyMovementDetails { get; set; }
        public ICollection<CustomerMovementDetail> CustomerMovementDetails { get; set; }

    }
}
