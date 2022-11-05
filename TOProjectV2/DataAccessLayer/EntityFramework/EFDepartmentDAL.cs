using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
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
    public class EFDepartmentDAL : GenericRepository<Department>, IDepartmentDAL
    {
        Context _context = new Context();
        public bool GetByDepartmenName(Expression<Func<Department, bool>> filter = null)
        {
            if (_context.Departments.Where(filter).ToList().Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
