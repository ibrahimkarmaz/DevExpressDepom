using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.DTO;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CustomerMovementDetailManager : ICustomerMovementDetailService
	{
		ICustomerMovementDetailDAL _customerMovementDetailDAL;

		public CustomerMovementDetailManager(ICustomerMovementDetailDAL customerMovementDetailDAL)
		{
			_customerMovementDetailDAL = customerMovementDetailDAL;
		}

		public List<CustomerMovementDetailDTO> GetAllCustomerMovementDetail(Expression<Func<CustomerMovementDetailDTO, bool>> filter = null)
		{
			return _customerMovementDetailDAL.GetAllCustomerMovementDetail(filter);
		}

		public List<CustomerMovementDetail> GetAllList()
		{
			return _customerMovementDetailDAL.GetAll();
		}

		public List<CustomerMovementDetail> GetAllList(Expression<Func<CustomerMovementDetail, bool>> filter = null)
		{
			return _customerMovementDetailDAL.GetAll(filter);
		}

		public CustomerMovementDetail GetById(int id)
		{
			return _customerMovementDetailDAL.GetById(id);
		}

		public void TAdd(CustomerMovementDetail t)
		{
			_customerMovementDetailDAL.Insert(t);
		}

		public void TRemove(CustomerMovementDetail t)
		{
			_customerMovementDetailDAL.Delete(t);
		}

		public void TUpdate(CustomerMovementDetail t)
		{
			_customerMovementDetailDAL.Update(t);
		}
	}
}
