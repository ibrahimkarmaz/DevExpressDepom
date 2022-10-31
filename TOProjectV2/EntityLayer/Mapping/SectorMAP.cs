using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class SectorMAP:EntityTypeConfiguration<Sector>
    {
        public SectorMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Sectors");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.SectorID);

            //BENZERSİZ ALANLAR
            this.HasIndex(x => x.SectorName).IsUnique();



            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.SectorName).HasMaxLength(40);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.SectorName).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI CUSTOMER İÇİNDEKİ GİBİ DEVAM EDER EĞER CUSTOMERDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.SectorID).HasColumnName("SectorID");
            this.Property(z => z.SectorName).HasColumnName("SectorName");
            this.Property(z => z.SectorArchive).HasColumnName("SectorArchive");


            //VERİ TİPLERİ
            //--
        }
    }
}
