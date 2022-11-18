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
    public interface ICompanyMovementDetailService:IGenericService<CompanyMovementDetail>
    {
        List<CompanyMovementDetailDTO> GetAllCompanyMovementDetail(Expression<Func<CompanyMovementDetailDTO, bool>> filter = null);
        List<CompanyMovementDetail> GetByFilter(Expression<Func<CompanyMovementDetail, bool>> filter = null);

    }
}
