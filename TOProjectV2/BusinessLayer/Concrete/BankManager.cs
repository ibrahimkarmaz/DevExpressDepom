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
    public class BankManager : IBankService
    {
        IBankDAL _bankDAL;

        public BankManager(IBankDAL bankDAL)
        {
            _bankDAL = bankDAL;
        }

        public List<BankINCountyDistrintAndCompanyDTO> GetAllBank(Expression<Func<BankINCountyDistrintAndCompanyDTO, bool>> filter = null)
        {
            return _bankDAL.GetAllBank(filter);
        }

        public List<Bank> GetAllList()
        {
            return _bankDAL.GetAll();
        }

        public List<Bank> GetAllList(Expression<Func<Bank, bool>> filter = null)
        {
            return _bankDAL.GetAll(filter);
        }

        public Bank GetById(int id)
        {
            return _bankDAL.GetById(id);
        }

        public void TAdd(Bank t)
        {
            _bankDAL.Insert(t);
        }

        public void TRemove(Bank t)
        {
            _bankDAL.Delete(t);
        }

        public void TUpdate(Bank t)
        {
            _bankDAL.Update(t);
        }
    }
}
