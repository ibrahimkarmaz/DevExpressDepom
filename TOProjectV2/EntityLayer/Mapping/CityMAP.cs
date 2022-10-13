using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class CityMAP:EntityTypeConfiguration<City>
    {
        public CityMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Citys");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.CityID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER SAYILARI
            this.Property(x => x.CityName).HasMaxLength(20);


            //BOŞ GEÇİLEMEZ ALANLAR
            //--



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X İÇİNDEKİ GİBİ DEVAM EDER EĞER X YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.CityID).HasColumnName("CityID");
            this.Property(z => z.CityName).HasColumnName("CityName");
            this.Property(z => z.CityPlateNo).HasColumnName("CityPlateNo");
            this.Property(z => z.CityPhoneCode).HasColumnName("CityPhoneCode");
            this.Property(z => z.CityRowNumber).HasColumnName("CityRowNumber");


            //VERİ TİPLERİ
            //--
        }
    }
}
