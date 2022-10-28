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
    public class EFDistrictDAL : IDistrictDAL
    {
        Context _context = new Context();
        public List<District> GetDistricts(Expression<Func<District, bool>> filter = null)
        {
            if (filter!=null)
            {
                return _context.Districts.Where(filter).ToList();
            }
            return _context.Districts.ToList();
        }
    }
}
