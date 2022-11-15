using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class CompanyMovementDetailMAP:EntityTypeConfiguration<CompanyMovementDetail>
    {
        public CompanyMovementDetailMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("CompanyMovementDetails");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.CompanyMovementDetailID);

            //BENZERSİZ ALANLAR
           //--



            //EN FAZLA KARAKTER SAYILARI
            //-- HasMaxLength


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.CompanyMovementDetailPiece).IsRequired();
            this.Property(y => y.CompanyMovementDetailPrice).IsRequired();
            this.Property(y => y.CompanyMovementDetailTotalPrice).IsRequired();


            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI x İÇİNDEKİ GİBİ DEVAM EDER EĞER x YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.CompanyMovementDetailID).HasColumnName("CompanyMovementDetailID");
            this.Property(z => z.CompanyMovementDetailPiece).HasColumnName("CompanyMovementDetailPiece");
            this.Property(z => z.CompanyMovementDetailPrice).HasColumnName("CompanyMovementDetailPrice");
            this.Property(z => z.CompanyMovementDetailTotalPrice).HasColumnName("CompanyMovementDetailTotalPrice");
            this.Property(z => z.ProductID).HasColumnName("ProductID");
            this.Property(z => z.CompanyMovementID).HasColumnName("CompanyMovementID");


            //VERİ TİPLERİ
            // this.Property(d => d.ProductYear).HasColumnType("char");

            //VERİ AYARLARI
            // HasPrecision decimal(18,2) columntype kullanmak yerine bu kullanılır.
            this.Property(d => d.CompanyMovementDetailPrice).HasPrecision(18, 2);
            this.Property(d => d.CompanyMovementDetailTotalPrice).HasPrecision(18, 2);

            /*DİKKAT: BURADA DECİMALLA İLGİLİ BİR SORUN OLUŞTUR
             *SORUN 12,45 SAYISINI VERİTABANİNA 1245 OLARAK KAYIT YAPILIYOR.
             *
             *
             *ÇÖZÜLDÜ NEDENİ:
             *TextEDİT'te . koyuyordu onu yenileyip , yaptık.
             */
        }
    }
}
