using DataAccessLayer.DTO;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IEmployeeService:IGenericService<Employee>
    {
        List<EmployeeINCountyDistrintAndDepartmentDTO> GetAllEmployee(Expression<Func<EmployeeINCountyDistrintAndDepartmentDTO, bool>> filter = null );
    }
}
