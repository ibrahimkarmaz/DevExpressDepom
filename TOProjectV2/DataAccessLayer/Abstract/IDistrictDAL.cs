using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IDistrictDAL
    {
        List<District> GetDistricts(Expression<Func<District,bool>> filter=null);
    }
}
