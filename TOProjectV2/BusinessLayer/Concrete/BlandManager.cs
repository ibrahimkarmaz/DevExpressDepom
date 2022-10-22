using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BlandManager : IBlandService
    {
        IBlandDAL _blandDAL;

        public BlandManager(IBlandDAL blandDAL)
        {
            _blandDAL = blandDAL;
        }

        public List<Bland> GetAllList()
        {
            return _blandDAL.GetAll();
        }

        public List<Bland> GetAllList(Expression<Func<Bland, bool>> filter = null)
        {
            return _blandDAL.GetAll(filter);
        }

        public bool GetByBlandName(Expression<Func<Bland, bool>> filter = null)
        {
            return _blandDAL.GetByBlandName(filter);
        }

        public Bland GetById(int id)
        {
            return _blandDAL.GetById(id);
        }

        public void TAdd(Bland t)
        {
            _blandDAL.Insert(t);
        }

        public void TRemove(Bland t)
        {
            _blandDAL.Delete(t);
        }

        public void TUpdate(Bland t)
        {
            _blandDAL.Update(t);
        }
    }
}
