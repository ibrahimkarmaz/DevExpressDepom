using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class CompanyMovementDetailDTO
    {
        public int CompanyMovementDetailID { get; set; }
        //ÜRÜN
        //-----
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string BlandName { get; set; }
        public string ModelName { get; set; }
        
        //------
        public int? CompanyMovementDetailPiece { get; set; }
        public decimal? CompanyMovementDetailPrice { get; set; }
        public decimal? CompanyMovementDetailTotalPrice { get; set; }
        //FİRMA HAREKET
        //------
        public int? CompanyMovementID { get; set; }
        //------
    }
}
