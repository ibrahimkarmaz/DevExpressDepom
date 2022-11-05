using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DTO
{
    public class EmployeeINCountyDistrintAndDepartmentDTO
    {
        public int EmployeeID { get; set; }
        public string EmployeeImage { get; set; }
        public string EmployeeTC { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurName { get; set; }
        public string EmployeeGender { get; set; }
        public DateTime? EmployeeDateOfBirth { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeeMail { get; set; }
        public string CountyName { get; set; }
        public string DistrictName { get; set; }

        public string EmployeeHomeAddress { get; set; }
        public string DepartmentName { get; set; }
        public bool EmployeeArchive { get; set; }
    }
}
