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
	public class CustomerMovementManager : ICustomerMovementService
	{
		ICustomerMovementDAL _customerMovementDAL;

		public CustomerMovementManager(ICustomerMovementDAL customerMovementDAL)
		{
			_customerMovementDAL = customerMovementDAL;
		}

		public List<CustomerMovement> GetAllList()
		{
			return _customerMovementDAL.GetAll();
		}

		public List<CustomerMovement> GetAllList(Expression<Func<CustomerMovement, bool>> filter = null)
		{
			return _customerMovementDAL.GetAll(filter);
		}

		public CustomerMovement GetById(int id)
		{
			return _customerMovementDAL.GetById(id);
		}

		public int RecentlyAddedMovementCustomerID()
		{
			return _customerMovementDAL.RecentlyAddedMovementCustomerID();
		}

		public void TAdd(CustomerMovement t)
		{
			_customerMovementDAL.Insert(t);
		}

		public void TRemove(CustomerMovement t)
		{
			_customerMovementDAL.Delete(t);
		}

		public void TUpdate(CustomerMovement t)
		{
			_customerMovementDAL.Update(t);
		}
	}
}
