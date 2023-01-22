using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
	public class CustomerMovementDetailDTO
	{
		public int CustomerMovementDetailID { get; set; }
		//ÜRÜN
		//-----
		public int ProductID { get; set; }
		public string ProductName { get; set; }
		public string BlandName { get; set; }
		public string ModelName { get; set; }

		//------
		public int? CustomerMovementDetailPiece { get; set; }
		public decimal? CustomerMovementDetailPrice { get; set; }
		public decimal? CustomerMovementDetailTotalPrice { get; set; }
		//MÜŞTERİ HAREKET
		//------
		public int? CustomerMovementID { get; set; }
		//------
	}
}
