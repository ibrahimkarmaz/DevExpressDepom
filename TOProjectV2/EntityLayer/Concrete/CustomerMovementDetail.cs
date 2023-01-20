using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class CustomerMovementDetail
	{
		public int CustomerMovementDetailID { get; set; }
		//ÜRÜN
		//-----
		public int? ProductID { get; set; }
		public Product Product { get; set; }
		//------
		public int? CustomerMovementDetailPiece { get; set; }
		public decimal? CustomerMovementDetailPrice { get; set; }
		public decimal? CustomerMovementDetailTotalPrice { get; set; }
		//MÜŞTERİ HAREKET 
		//------
		public int? CustomerMovementID { get; set; }
		public CustomerMovement CustomerMovement { get; set; }
		//------s
	}
}
