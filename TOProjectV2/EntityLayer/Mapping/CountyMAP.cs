using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class CountyMAP:EntityTypeConfiguration<County>
    {
        public CountyMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Countys");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.CountyID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER SAYILARI
            this.Property(x => x.CountyName).HasMaxLength(60).IsUnicode();


            //BOŞ GEÇİLEMEZ ALANLAR
            //--



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X İÇİNDEKİ GİBİ DEVAM EDER EĞER X YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.CountyID).HasColumnName("CountyID");
            this.Property(z => z.CountyName).HasColumnName("CountyName");


            //VERİ TİPLERİ
           //--
        }
    }
}
