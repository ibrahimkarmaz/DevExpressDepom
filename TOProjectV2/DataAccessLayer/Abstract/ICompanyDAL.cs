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
    public interface ICompanyDAL:IGenericDAL<Company>
    {
        List<CompanyINCountyDistrintAndSectorDTO> CompanyGetList(Expression<Func<CompanyINCountyDistrintAndSectorDTO, bool>> filter = null);
    }
}
