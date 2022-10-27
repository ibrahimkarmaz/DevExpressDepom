using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class ProductMAP:EntityTypeConfiguration<Product>
    {
        public ProductMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Products");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.ProductID);

            //BENZERSİZ ALANLAR
            //--



            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.ProductName).HasMaxLength(20);
            this.Property(x => x.ProductDetails).HasMaxLength(200);
            //this.Property(x => x.ProductBland).HasMaxLength(20);
           // this.Property(x => x.ProductModel).HasMaxLength(20);
           // this.Property(x => x.ProductYear).HasMaxLength(4);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.ProductName).IsRequired();
            //this.Property(y => y.ProductBland).IsRequired();
          //  this.Property(y => y.ProductModel).IsRequired();
           // this.Property(y => y.ProductYear).IsRequired();
            this.Property(y => y.ProductPiece).IsRequired();
            this.Property(y => y.ProductPurchasePrice).IsRequired();
            this.Property(y => y.ProductSalePrice).IsRequired();
            this.Property(y => y.ProductArchive).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI x İÇİNDEKİ GİBİ DEVAM EDER EĞER x YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.ProductID).HasColumnName("ProductID");
            this.Property(z => z.ProductName).HasColumnName("ProductName");
            //this.Property(z => z.ProductBland).HasColumnName("ProductBland");
           // this.Property(z => z.ProductModel).HasColumnName("ProductModel");
           // this.Property(z => z.ProductYear).HasColumnName("ProductYear");
            this.Property(z => z.ProductPiece).HasColumnName("ProductPiece");
            this.Property(z => z.ProductPurchasePrice).HasColumnName("ProductPurchasePrice");
            this.Property(z => z.ProductSalePrice).HasColumnName("ProductSalePrice");
            this.Property(z => z.ProductArchive).HasColumnName("ProductArchive");


            //VERİ TİPLERİ
           // this.Property(d => d.ProductYear).HasColumnType("char");

            //VERİ AYARLARI
            // HasPrecision decimal(18,2) columntype kullanmak yerine bu kullanılır.
            this.Property(d => d.ProductPurchasePrice).HasPrecision(18, 2);
            this.Property(d => d.ProductSalePrice).HasPrecision(18, 2);

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
