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
	public class EFCustomerMovementDAL : GenericRepository<CustomerMovement>, ICustomerMovementDAL
	{
		Context _context = new Context();

		public int RecentlyAddedMovementCustomerID()
		{
			return _context.CustomerMovements.OrderByDescending(x => x.CustomerMovementID).FirstOrDefault().CustomerMovementID;
		}
	}
}
