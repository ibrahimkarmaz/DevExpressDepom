using System;
using System.Collections;
using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeImage { get; set; }
        public string EmployeeTC { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurName { get; set; }
        public bool? EmployeeGender { get; set; }
        public DateTime? EmployeeDateOfBirth { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeMail { get; set; }
        public int? CountyID { get; set; }
        public County County { get; set; }

        public int? DistrictID { get; set; }
        public District District { get; set; }

        public string EmployeeHomeAddress { get; set; }

        public int? DepartmentID { get; set; }
        public Department Department { get; set; }

        public bool EmployeeArchive { get; set; }


        public ICollection<CompanyMovement> CompanyMovements { get; set; }
    }
}
