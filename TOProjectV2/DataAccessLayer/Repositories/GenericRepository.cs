using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDAL<T> where T : class
    {
        Context _context = new Context();
        DbSet<T> _table;

        public GenericRepository()
        {
            _table = _context.Set<T>();
        }

        public void Delete(T t)
        {
            _table.Remove(t);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _table.ToList();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter = null)
        {
            return _table.Where(filter).ToList();
        }

        public T GetById(int id)
        {
            return _table.Find(id);
        }

        public void Insert(T t)
        {
            _table.Add(t);
            _context.SaveChanges();
        }

        public void Update(T t)
        {
            _context.SaveChanges();
        }
    }
}
