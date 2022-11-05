using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDAL _employeeDAL;

        public EmployeeManager(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        public List<EmployeeINCountyDistrintAndDepartmentDTO> GetAllEmployee(Expression<Func<EmployeeINCountyDistrintAndDepartmentDTO, bool>> filter = null)
        {
            return _employeeDAL.GetAllEmployee(filter);
        }

        public List<Employee> GetAllList()
        {
           return _employeeDAL.GetAll();
        }

        public List<Employee> GetAllList(Expression<Func<Employee, bool>> filter = null)
        {
           return _employeeDAL.GetAll(filter);
        }

        public Employee GetById(int id)
        {
            return _employeeDAL.GetById(id);
        }

        public void TAdd(Employee t)
        {
            _employeeDAL.Insert(t);
        }

        public void TRemove(Employee t)
        {
            _employeeDAL.Delete(t);
        }

        public void TUpdate(Employee t)
        {
            _employeeDAL.Update(t);
        }
    }
}
