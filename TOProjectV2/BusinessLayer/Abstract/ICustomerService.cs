using DataAccessLayer.DTO;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICustomerService:IGenericService<Customer>
    {
        bool GetByTC(Expression<Func<Customer, bool>> filter = null);
        List<CustomerINCountyAndDistrintDTO> CustomerGetList(Expression<Func<CustomerINCountyAndDistrintDTO, bool>> filter = null);
    }
}
