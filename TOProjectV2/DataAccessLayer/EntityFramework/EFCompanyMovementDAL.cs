using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EFCompanyMovementDAL : GenericRepository<CompanyMovement>, ICompanyMovementDAL
    {
        Context _context = new Context();
        public int RecentlyAddedMovementID()
        {
            return _context.CompanyMovements.OrderByDescending(x => x.CompanyMovementID).FirstOrDefault().CompanyMovementID;
        }
    }
}
