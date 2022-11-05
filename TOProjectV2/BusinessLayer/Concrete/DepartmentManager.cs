using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        IDepartmentDAL _departmentDAL;

        public DepartmentManager(IDepartmentDAL departmentDAL)
        {
            _departmentDAL = departmentDAL;
        }

        public List<Department> GetAllList()
        {
            return _departmentDAL.GetAll();
        }

        public List<Department> GetAllList(Expression<Func<Department, bool>> filter = null)
        {
            return _departmentDAL.GetAll(filter);
        }

        public bool GetByDepartmenName(Expression<Func<Department, bool>> filter = null)
        {
            return _departmentDAL.GetByDepartmenName(filter);
        }

        public Department GetById(int id)
        {
            return _departmentDAL.GetById(id);
        }

        public void TAdd(Department t)
        {
            _departmentDAL.Insert(t);
        }

        public void TRemove(Department t)
        {
            _departmentDAL.Delete(t);
        }

        public void TUpdate(Department t)
        {
            _departmentDAL.Update(t);
        }
    }
}
