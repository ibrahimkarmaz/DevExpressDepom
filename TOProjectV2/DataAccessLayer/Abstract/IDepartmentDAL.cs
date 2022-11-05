using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDepartmentDAL:IGenericDAL<Department>
    {
        bool GetByDepartmenName(Expression<Func<Department, bool>> filter = null);
    }
}
