using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiyLayer.Entities;

namespace DataAccessLayer
{
    public class Context:DbContext
    {
        public DbSet<Musteri> musteriler { get; set; }
        public DbSet<Detay> detayler { get; set; }
    }
}
