using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class CompanyMovementDetail
    {
        public int CompanyMovementDetailID { get; set; }
        //ÜRÜN
        //-----
        public int? ProductID { get; set; }
        public Product Product { get; set; }
        //------
        public int? CompanyMovementDetailPiece { get; set; }
        public decimal? CompanyMovementDetailPrice { get; set; }
        public decimal? CompanyMovementDetailTotalPrice { get; set; }
        //FİRMA HAREKET
        //------
        public int? CompanyMovementID { get; set; }
        public CompanyMovement CompanyMovement { get; set; }
        //------
    }
}
