using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class InvoiceDetailMAP:EntityTypeConfiguration<InvoiceDetail>
    {
        public InvoiceDetailMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("InvoiceDetails");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.InvoiceProductID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.ProductName).HasMaxLength(20);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.ProductName).IsRequired();
            this.Property(y => y.ProductPiece).IsRequired();
            this.Property(y => y.ProductPrice).IsRequired();
            this.Property(y => y.ProductAmount).IsRequired();
            this.Property(y => y.InvoiceArchive).IsRequired();


            //***************
            this.Property(y => y.InvoiceID).IsRequired();//YABANCI ANAHTAR SİLİNEBİLİR.
                                                         //***************


            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X İÇİNDEKİ GİBİ DEVAM EDER EĞER X YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.InvoiceProductID).HasColumnName("InvoiceProductID");
            this.Property(z => z.ProductName).HasColumnName("ProductName");
            this.Property(z => z.ProductPiece).HasColumnName("ProductPiece");
            this.Property(z => z.ProductPrice).HasColumnName("ProductPrice");
            this.Property(z => z.ProductAmount).HasColumnName("ProductAmount");
            this.Property(z => z.InvoiceID).HasColumnName("InvoiceID");
            this.Property(z => z.InvoiceArchive).HasColumnName("InvoiceArchive");


            //VERİ TİPLERİ
            //--

            //VERİ AYARLARI
            // HasPrecision decimal(18,2) columntype kullanmak yerine bu kullanılır.
            this.Property(d => d.ProductPrice).HasPrecision(18, 2);
            this.Property(d => d.ProductAmount).HasPrecision(18, 2);
        }
    }
}
