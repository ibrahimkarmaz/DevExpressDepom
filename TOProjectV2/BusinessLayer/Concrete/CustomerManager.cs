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
    public class CustomerManager : ICustomerService
    {
        ICustomerDAL _customerDAL;

        public CustomerManager(ICustomerDAL customerDAL)
        {
            _customerDAL = customerDAL;
        }

        public List<CustomerINCountyAndDistrintDTO> CustomerGetList(Expression<Func<CustomerINCountyAndDistrintDTO, bool>> filter = null)
        {
            return _customerDAL.CustomerGetList(filter);
        }

        public List<Customer> GetAllList()
        {
            return _customerDAL.GetAll();
        }

        public List<Customer> GetAllList(Expression<Func<Customer, bool>> filter = null)
        {
                return _customerDAL.GetAll(filter);
        }

        public Customer GetById(int id)
        {
            return _customerDAL.GetById(id);
        }

        public bool GetByTC(Expression<Func<Customer, bool>> filter = null)
        {
          return  _customerDAL.GetByTC(filter);
        }

		public List<Customer> GetListWhoIsBirthday(Expression<Func<Customer, bool>> filter = null)
		{
            return _customerDAL.GetListWhoIsBirthday(filter);
		}

		public void TAdd(Customer t)
        {
            _customerDAL.Insert(t);
        }

        public void TRemove(Customer t)
        {
            _customerDAL.Delete(t);
        }

        public void TUpdate(Customer t)
        {
           _customerDAL.Update(t);
        }
    }
}
