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
    public class CompanyManager : ICompanyService
    {
        ICompanyDAL _companyDAL;

        public CompanyManager(ICompanyDAL companyDAL)
        {
            _companyDAL = companyDAL;
        }

        public List<CompanyINCountyDistrintAndSectorDTO> CompanyGetList(Expression<Func<CompanyINCountyDistrintAndSectorDTO, bool>> filter = null)
        {
           return _companyDAL.CompanyGetList(filter);
        }

        public List<Company> GetAllList()
        {
            return _companyDAL.GetAll();
        }

        public List<Company> GetAllList(Expression<Func<Company, bool>> filter = null)
        {
            return _companyDAL.GetAll(filter);
        }

        public Company GetById(int id)
        {
            return _companyDAL.GetById(id);
        }

        public void TAdd(Company t)
        {
            _companyDAL.Insert(t);
        }

        public void TRemove(Company t)
        {
             _companyDAL.Delete(t);
        }

        public void TUpdate(Company t)
        {
            _companyDAL.Update(t); 
        }
    }
}
