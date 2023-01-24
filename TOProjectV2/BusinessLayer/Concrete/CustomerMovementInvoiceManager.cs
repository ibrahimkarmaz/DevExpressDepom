using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
	public class CustomerMovementInvoiceManager : ICustomerMovementInvoiceService
	{
		ICustomerMovementInvoiceDAL _customerMovementInvoiceDAL;

		public CustomerMovementInvoiceManager(ICustomerMovementInvoiceDAL customerMovementInvoiceDAL)
		{
			_customerMovementInvoiceDAL = customerMovementInvoiceDAL;
		}


		public List<CustomerMovementInvoiceDTO> GetAllCustomerMovementInvoice(Expression<Func<CustomerMovementInvoiceDTO, bool>> filter = null)
		{
			return _customerMovementInvoiceDAL.GetAllCustomerMovementInvoice(filter);
		}

		public List<CustomerMovementInvoice> GetAllList()
		{
			return _customerMovementInvoiceDAL.GetAll();
		}

		public List<CustomerMovementInvoice> GetAllList(Expression<Func<CustomerMovementInvoice, bool>> filter = null)
		{
			return _customerMovementInvoiceDAL.GetAll(filter);
		}

		public CustomerMovementInvoice GetById(int id)
		{
			return _customerMovementInvoiceDAL.GetById(id);
		}

		public void TAdd(CustomerMovementInvoice t)
		{
			_customerMovementInvoiceDAL.Insert(t);
		}

		public void TRemove(CustomerMovementInvoice t)
		{
			_customerMovementInvoiceDAL.Delete(t);
		}

		public void TUpdate(CustomerMovementInvoice t)
		{
			_customerMovementInvoiceDAL.Update(t);
		}
	}
}
