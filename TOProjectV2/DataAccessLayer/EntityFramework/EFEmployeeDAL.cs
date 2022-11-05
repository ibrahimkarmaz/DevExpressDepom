using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.DTO;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFEmployeeDAL : GenericRepository<Employee>, IEmployeeDAL
    {
        Context _context = new Context();
        public List<EmployeeINCountyDistrintAndDepartmentDTO> GetAllEmployee(Expression<Func<EmployeeINCountyDistrintAndDepartmentDTO, bool>> filter = null)
        {
            return (from employee in _context.Employees
                    join county in _context.Countys
                    on employee.CountyID equals county.CountyID
                    join district in _context.Districts
                    on employee.DistrictID equals district.DistrictID
                    join department in _context.Departments
                    on employee.DepartmentID equals department.DepartmentID
                    select new EmployeeINCountyDistrintAndDepartmentDTO
                    {
                        EmployeeID=employee.EmployeeID,
                        EmployeeImage=employee.EmployeeImage,
                        EmployeeTC=employee.EmployeeTC,
                        EmployeeName=employee.EmployeeName,
                        EmployeeSurName=employee.EmployeeSurName,
                        EmployeeGender=employee.EmployeeGender==true ? "BAY":"BAYAN",
                        EmployeeDateOfBirth=employee.EmployeeDateOfBirth,
                        EmployeePhone=employee.EmployeePhone,
                        EmployeeMail=employee.EmployeeMail,
                        CountyName=county.CountyName,
                        DistrictName=district.DistrictName,
                        DepartmentName=department.DepartmentName,
                        EmployeeHomeAddress=employee.EmployeeHomeAddress,
                        EmployeeArchive=employee.EmployeeArchive
                    }
                    ).Where(filter).ToList();
        }
    }
}
