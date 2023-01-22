using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class CustomerMovement
	{
		public int CustomerMovementID { get; set; }

		//-----
		
		public int? EmployeeID { get; set; }
		public Employee Employee { get; set; }

		public int? CustomerID { get; set; }
		public Customer Customer { get; set; }
		
		//-----

		public DateTime? CustomerMovementDate { get; set; }
		public string CustomerMovemenNote { get; set; }
		public bool CustomerMovemenArchive { get; set; }


		public ICollection<CustomerMovementDetail> CustomerMovementDetails { get; set; }
		public ICollection<CustomerMovementInvoice> CustomerMovementInvoices { get; set; }
	}
}
