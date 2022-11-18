using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class CompanyMovementInvoiceDTO
    {//INVOİCE EKLENECEK. DTO'DAN ÖNCE
        public int InvoiceID { get; set; }
        public string InvoiceSeries { get; set; }
        public string CompanyName { get; set; }
        public string EmployeeNameSurName { get; set; }
        public DateTime? CompanyMovementDate { get; set; }
        public string CompanyMovemenNote { get; set; }
        public bool CompanyMovemenArchive { get; set; }
    }
}
