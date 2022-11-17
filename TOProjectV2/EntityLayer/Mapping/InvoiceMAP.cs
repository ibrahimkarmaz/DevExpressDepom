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

            this.Property(x => x.InvoiceSeries).HasMaxLength(20);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.InvoiceSeries).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X TABLOSU İÇİNDEKİ GİBİ DEVAM EDER EĞER X TABLOSUNDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.InvoiceID).HasColumnName("InvoiceID");
            this.Property(z => z.InvoiceSeries).HasColumnName("InvoiceSeries");



            //VERİ TİPLERİ
            this.Property(d => d.InvoiceSeries).HasColumnType("char");

            //VERİ TİPİ ÖZEL 
           // --
        }
    }
}
