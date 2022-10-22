using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class ModelMAP:EntityTypeConfiguration<Model>
    {
        public ModelMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Models");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.ModelID);
            this.HasRequired(x => x.Bland).WithMany(x => x.Models).HasForeignKey(x=>x.BlandID);

            //BENZERSİZ ALANLAR
            //--


            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.ModelName).HasMaxLength(20);
            this.Property(x => x.ModelYear).HasMaxLength(4);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.ModelName).IsRequired();
            this.Property(y => y.ModelYear).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI CUSTOMER İÇİNDEKİ GİBİ DEVAM EDER EĞER CUSTOMERDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.ModelID).HasColumnName("ModelID");
            this.Property(z => z.ModelName).HasColumnName("ModelName");
            this.Property(z => z.ModelYear).HasColumnName("ModelYear");
            this.Property(z => z.ModelArchive).HasColumnName("ModelArchive");


            //VERİ TİPLERİ
            //--
        }
    }
}
