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
    public class DistrictManager : IDistrictService
    {
        IDistrictDAL _districtDAL;

        public DistrictManager(IDistrictDAL districtDAL)
        {
            _districtDAL = districtDAL;
        }

        public List<District> GetAllList(Expression<Func<District, bool>> filter = null)
        {
            return _districtDAL.GetDistricts(filter);
        }
    }
}
