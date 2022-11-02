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
    public interface ICompanyService:IGenericService<Company>
    {
        List<CompanyINCountyDistrintAndSectorDTO> CompanyGetList(Expression<Func<CompanyINCountyDistrintAndSectorDTO, bool>> filter = null);
    }
}
