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
    public class SectorManager : ISectorService
    {
        ISectorDAL _sectorDAL;

        public SectorManager(ISectorDAL sectorDAL)
        {
            _sectorDAL = sectorDAL;
        }

        public List<Sector> GetAllList()
        {
            return _sectorDAL.GetAll();
        }

        public List<Sector> GetAllList(Expression<Func<Sector, bool>> filter = null)
        {
            return _sectorDAL.GetAll(filter);
        }

        public Sector GetById(int id)
        {
            return _sectorDAL.GetById(id);
        }

        public void TAdd(Sector t)
        {
            _sectorDAL.Insert(t);
        }

        public void TRemove(Sector t)
        {
            _sectorDAL.Delete(t);
        }

        public void TUpdate(Sector t)
        {
            _sectorDAL.Update(t);
        }
    }
}
