using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDistrictService
    {
        List<District> GetAllList(Expression<Func<District, bool>> filter = null);
    }
}
