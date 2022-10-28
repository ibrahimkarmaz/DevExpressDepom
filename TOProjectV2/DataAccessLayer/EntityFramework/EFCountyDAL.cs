using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCountyDAL : ICountyDAL
    {
        Context _context = new Context();
        public List<County> CountyGetAll(Expression<Func<County, bool>> filter = null)
        {
            if (filter!=null)
            {
                return _context.Countys.Where(filter).ToList();
            }
            return _context.Countys.ToList();
        }
    }
}
