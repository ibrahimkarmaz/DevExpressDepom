using System.Collections.Generic;

namespace EntityLayer.Concrete
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public bool DepartmentArchive { get; set; }


        public ICollection<Employee> Employees { get; set; }
    }
}
