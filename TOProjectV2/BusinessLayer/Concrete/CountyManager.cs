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
    public class CountyManager : ICountyService
    {
        ICountyDAL _countyDAL;

        public CountyManager(ICountyDAL countyDAL)
        {
            this._countyDAL = countyDAL;
        }
        public List<County> GetAllList(Expression<Func<County, bool>> filter = null)
        {
            return _countyDAL.CountyGetAll(filter);
        }
    }
}
