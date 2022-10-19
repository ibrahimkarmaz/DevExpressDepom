using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class BlandMAP:EntityTypeConfiguration<Bland>
    {
        public BlandMAP()
        {
            //TABLO ADI
            this.ToTable("Blands");

            //BİRİNCİ VE YABANCI ANAHTARLAR
            this.HasKey(x=>x.BlandID);


            //BENZERSİZ ALANLAR
            this.HasIndex(a => a.BlandName).IsUnique();
            //EN FAZLA KARAKTER
            this.Property(b => b.BlandName).HasMaxLength(20);

            //BOŞ GEÇİLEMEZ
            this.Property(c => c.BlandName).IsRequired();

            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI x İÇİNDEKİ GİBİ DEVAM EDER EĞER x YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.
            this.Property(z => z.BlandID).HasColumnName("BlandID");
            this.Property(z => z.BlandName).HasColumnName("BlandName");
        }
    }
}
