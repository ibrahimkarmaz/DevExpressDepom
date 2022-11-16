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
    public class CompanyMovementDetailManager : ICompanyMovementDetailService
    {
        ICompanyMovementDetailDAL _companyMovementDetailDAL;

        public CompanyMovementDetailManager(ICompanyMovementDetailDAL companyMovementDetailDAL)
        {
            _companyMovementDetailDAL = companyMovementDetailDAL;
        }

        public List<CompanyMovementDetailDTO> GetAllCompanyMovementDetail(Expression<Func<CompanyMovementDetailDTO, bool>> filter = null)
        {
            return _companyMovementDetailDAL.GetAllCompanyMovementDetail(filter);
        }

        public List<CompanyMovementDetail> GetAllList()
        {
            return _companyMovementDetailDAL.GetAll();
        }

        public List<CompanyMovementDetail> GetAllList(Expression<Func<CompanyMovementDetail, bool>> filter = null)
        {
            return _companyMovementDetailDAL.GetAll(filter);
        }

        public CompanyMovementDetail GetById(int id)
        {
            return _companyMovementDetailDAL.GetById(id);
        }

        public void TAdd(CompanyMovementDetail t)
        {
            _companyMovementDetailDAL.Insert(t);
        }

        public void TRemove(CompanyMovementDetail t)
        {
            _companyMovementDetailDAL.Delete(t);
        }

        public void TUpdate(CompanyMovementDetail t)
        {
            _companyMovementDetailDAL.Update(t);
        }
    }
}
