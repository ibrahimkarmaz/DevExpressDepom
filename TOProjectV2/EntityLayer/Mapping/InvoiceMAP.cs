using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class InvoiceMAP:EntityTypeConfiguration<Invoice>
    {
        public InvoiceMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Invoices");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.InvoiceID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.InvoiceSeries).HasMaxLength(1);
            this.Property(x => x.InvoiceDesk).HasMaxLength(10);
            this.Property(x => x.InvoiceTaxOffice).HasMaxLength(40);
            this.Property(x => x.InvoiceBuyer).HasMaxLength(40);
            this.Property(x => x.InvoiceSubmitter).HasMaxLength(40);
            this.Property(x => x.InvoiceDeliveryArea).HasMaxLength(40);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.InvoiceSeries).IsRequired();
            this.Property(y => y.InvoiceDesk).IsRequired();
            this.Property(y => y.InvoiceDate).IsRequired();
            this.Property(y => y.InvoiceTime).IsRequired();
            this.Property(y => y.InvoiceTaxOffice).IsRequired();
            this.Property(y => y.InvoiceBuyer).IsRequired();
            this.Property(y => y.InvoiceSubmitter).IsRequired();
            this.Property(y => y.InvoiceDeliveryArea).IsRequired();
            this.Property(y => y.InvoiceArchive).IsRequired();


            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X TABLOSU İÇİNDEKİ GİBİ DEVAM EDER EĞER X TABLOSUNDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.InvoiceID).HasColumnName("InvoiceID");
            this.Property(z => z.InvoiceSeries).HasColumnName("InvoiceSeries");
            this.Property(z => z.InvoiceDesk).HasColumnName("InvoiceDesk");
            this.Property(z => z.InvoiceDate).HasColumnName("InvoiceDate");
            this.Property(z => z.InvoiceTime).HasColumnName("InvoiceTime");
            this.Property(z => z.InvoiceTaxOffice).HasColumnName("InvoiceTaxOffice");
            this.Property(z => z.InvoiceBuyer).HasColumnName("InvoiceBuyer");
            this.Property(z => z.InvoiceSubmitter).HasColumnName("InvoiceSubmitter");
            this.Property(z => z.InvoiceDeliveryArea).HasColumnName("InvoiceDeliveryArea");
            this.Property(z => z.InvoiceArchive).HasColumnName("InvoiceArchive");


            //VERİ TİPLERİ
            this.Property(d => d.InvoiceSeries).HasColumnType("char");
            this.Property(d => d.InvoiceDate).HasColumnType("smalldatetime");
            this.Property(d => d.InvoiceDate).HasColumnType("smalldatetime");

            //VERİ TİPİ ÖZEL 
           // --
        }
    }
}
