using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class StockMAP:EntityTypeConfiguration<Stock>
    {
        public StockMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Stocks");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.StockID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.StockType).HasMaxLength(20);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.StockType).IsRequired();
            this.Property(y => y.StockPiece).IsRequired();
            this.Property(y => y.StockArchive).IsRequired();


            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X TABLOSU İÇİNDEKİ GİBİ DEVAM EDER EĞER X TABLOSUNDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.StockID).HasColumnName("StockID");
            this.Property(z => z.StockType).HasColumnName("StockType");
            this.Property(z => z.StockPiece).HasColumnName("StockPiece");
            this.Property(z => z.StockArchive).HasColumnName("StockArchive");


            //VERİ TİPLERİ
            //--
        }
    }
}
