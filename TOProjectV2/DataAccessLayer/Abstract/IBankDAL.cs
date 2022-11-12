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
    public interface IBankDAL:IGenericDAL<Bank>
    {
        List<BankINCountyDistrintAndCompanyDTO> GetAllBank(Expression<Func<BankINCountyDistrintAndCompanyDTO, bool>> filter = null);
    }
}
