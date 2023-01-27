using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICustomerDAL:IGenericDAL<Customer>
    {
        List<CustomerINCountyAndDistrintDTO> CustomerGetList(Expression<Func<CustomerINCountyAndDistrintDTO,bool>> filter=null);
        bool GetByTC(Expression<Func<Customer, bool>> filter = null);

        List<Customer> GetListWhoIsBirthday(Expression<Func<Customer, bool>> filter = null);
	}
}
