using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
	public class CustomerMovementInvoiceDTO
	{
		public int InvoiceID { get; set; }
		public string InvoiceSeries { get; set; }
		public string CustomerName { get; set; }
		public string EmployeeNameSurName { get; set; }
		public DateTime? CustomerMovementDate { get; set; }
		public string CustomerMovemenNote { get; set; }
		public bool CustomerMovemenArchive { get; set; }
	}
}
