using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CompanyMovementManager : ICompanyMovementService
    {
        ICompanyMovementDAL _companyMovementDAL;

        public CompanyMovementManager(ICompanyMovementDAL companyMovementDAL)
        {
            _companyMovementDAL = companyMovementDAL;
        }

        public List<CompanyMovement> GetAllList()
        {
           return _companyMovementDAL.GetAll();
        }

        public List<CompanyMovement> GetAllList(Expression<Func<CompanyMovement, bool>> filter = null)
        {
            return _companyMovementDAL.GetAll(filter);
        }

        public CompanyMovement GetById(int id)
        {
            return _companyMovementDAL.GetById(id);
        }

        public void TAdd(CompanyMovement t)
        {
            _companyMovementDAL.Insert(t);
        }

        public void TRemove(CompanyMovement t)
        {
            _companyMovementDAL.Delete(t);
        }

        public void TUpdate(CompanyMovement t)
        {
            _companyMovementDAL.Update(t);
        }
    }
}
