using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class DNeighborhoodMAP:EntityTypeConfiguration<DNeighborhood>
    {
        public DNeighborhoodMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("DNeighborhoods");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.DNeighborhoodID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER SAYILARI
            this.Property(x => x.DNeighborhoodName1).HasMaxLength(60).IsUnicode();
            this.Property(x => x.DNeighborhoodName2).HasMaxLength(55).IsUnicode();


            //BOŞ GEÇİLEMEZ ALANLAR
            //--



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X İÇİNDEKİ GİBİ DEVAM EDER EĞER X YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.DNeighborhoodID).HasColumnName("DNeighborhoodID");
            this.Property(z => z.DNeighborhoodName1).HasColumnName("DNeighborhoodName1");
            this.Property(z => z.DNeighborhoodName2).HasColumnName("DNeighborhoodName2");
            this.Property(z => z.DNeighborhoodPostCode).HasColumnName("DNeighborhoodPostCode");
            this.Property(z => z.CountyID).HasColumnName("CountyID");


            //VERİ TİPLERİ
            //--
        }
    }
}
