using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T :class, new()
    {
        void TAdd(T t);
        void TUpdate(T t);
        void TRemove(T t);
        T GetById(int id);
        List<T> GetAllList();
        List<T> GetAllList(Expression<Func<T,bool>> filter=null);
        
    }
}
