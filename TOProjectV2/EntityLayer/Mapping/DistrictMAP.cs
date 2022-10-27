using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class DistrictMAP:EntityTypeConfiguration<District>
    {
        public DistrictMAP()
        {
            //TABLO ADI
            this.ToTable("Districts");

            //BİRİNCİ VE YABANCI ANAHTARLAR
            this.HasKey(x => x.DistrictID);


            //BENZERSİZ ALANLAR
            //this.HasIndex(a => a.DistrictName).IsUnique();
            //EN FAZLA KARAKTER
            this.Property(b => b.DistrictName).HasMaxLength(255);

            //BOŞ GEÇİLEMEZ
            this.Property(c => c.DistrictName).IsRequired();

            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI x İÇİNDEKİ GİBİ DEVAM EDER EĞER x YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.
            this.Property(z => z.DistrictID).HasColumnName("DistrictID");
            this.Property(z => z.DistrictName).HasColumnName("DistrictName");
            this.Property(z => z.CountyID).HasColumnName("CountyID");
        }
    }
}
