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
    public class EFBlandDAL : GenericRepository<Bland>, IBlandDAL
    {
        Context _context = new Context();

        public bool GetByBlandName(Expression<Func<Bland, bool>> filter = null)
        {
            if(_context.Blands.Where(filter).ToList().Count()>0)
            {
                foreach (var item in _context.Blands.Where(filter).ToList())
                {
                    Console.WriteLine(item.BlandName);
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
