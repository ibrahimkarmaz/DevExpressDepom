using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IEmployeeDAL:IGenericDAL<Employee>
    {
        List<EmployeeINCountyDistrintAndDepartmentDTO> GetAllEmployee(Expression<Func<EmployeeINCountyDistrintAndDepartmentDTO, bool>> filter=null);
    }
}
