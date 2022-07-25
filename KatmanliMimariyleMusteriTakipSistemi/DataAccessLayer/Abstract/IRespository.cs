using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace DataAccessLayer.Abstract
{
    public interface IRespository<EntityT>
    {
        int Ekle(EntityT Parametre);
        int Guncelle(EntityT Parametre);
        int Sil(EntityT Parametre);

        List<EntityT> Listele();

        EntityT IdGetir(int id);

        EntityT Find(Expression<Func<EntityT, bool>> obj);

        List<EntityT> Arama(Expression<Func<EntityT, bool>> sart);
    }
}
