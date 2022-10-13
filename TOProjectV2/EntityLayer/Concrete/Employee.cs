using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeTC { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurName { get; set; }
        public string EmployeePhone { get; set; }

        public string EmployeeMail { get; set; }
        public string EmployeeTown { get; set; }
        public string EmployeeCounty { get; set; }
        public string EmployeeHomeAddress { get; set; }
        public string EmployeeTask { get; set; }

        public bool EmployeeArchive { get; set; }
    }
}
