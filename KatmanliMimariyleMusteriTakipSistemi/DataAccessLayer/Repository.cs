using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstract;

namespace DataAccessLayer
{//Generic Repository Pattern
    public class Repository<T> : IRespository<T> where T : class
    {
        Context database = new Context();
        DbSet<T> VerilerTablo;
        //ctor Sınıfa bağlı metod.
        public Repository()
        {//Atama işlemleri
            VerilerTablo = database.Set<T>();
        }

        public List<T> Arama(Expression<Func<T, bool>> sart)
        {
            return VerilerTablo.Where(sart).ToList();
        }

        public int Ekle(T Parametre)
        {
            VerilerTablo.Add(Parametre);
            return database.SaveChanges();
        }

        public T Find(Expression<Func<T, bool>> obj)
        {
            return VerilerTablo.FirstOrDefault(obj);
        }

        public int Guncelle(T Parametre)
        {
            return database.SaveChanges();
        }

        public T IdGetir(int id)
        {
            return VerilerTablo.Find(id);
        }

        public List<T> Listele()
        {
            return VerilerTablo.ToList();
        }

        public int Sil(T Parametre)
        {
            VerilerTablo.Remove(Parametre);
            return database.SaveChanges();
        }
    }
}
