using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class CustomerMovementInvoice
	{
		public int CustomerMovementInvoiceID { get; set; }
		//----
		public int? CustomerMovementID { get; set; }
		public CustomerMovement CustomerMovement { get; set; }
		//----
		public string CustomerMovementInvoiceSeries { get; set; }
	}
}
