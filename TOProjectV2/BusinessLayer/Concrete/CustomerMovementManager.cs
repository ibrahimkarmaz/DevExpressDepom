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
	public class CustomerMovementManager : ICustomerMovementDAL
	{
		ICustomerMovementDAL _customerMovementDAL;
		public void Delete(CustomerMovement t)
		{
			_customerMovementDAL.Delete(t);
		}

		public List<CustomerMovement> GetAll()
		{
			return _customerMovementDAL.GetAll();
		}

		public List<CustomerMovement> GetAll(Expression<Func<CustomerMovement, bool>> filter = null)
		{
			return _customerMovementDAL.GetAll(filter);
		}

		public CustomerMovement GetById(int id)
		{
			return _customerMovementDAL.GetById(id);
		}

		public void Insert(CustomerMovement t)
		{
			_customerMovementDAL.Insert(t);
		}

		public void Update(CustomerMovement t)
		{
			_customerMovementDAL.Update(t);
		}
	}
}
