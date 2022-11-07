using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class ExpenseContentMAP:EntityTypeConfiguration<ExpenseContent>
    {
        public ExpenseContentMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("ExpenseContents");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.ExpenseContentID);

            //BENZERSİZ ALANLAR
            //--



            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.ExpenseContentTitle).HasMaxLength(30);
            this.Property(x => x.ExpenseContentType).HasMaxLength(25);
            this.Property(x => x.ExpenseContentPeceiptNumber).HasMaxLength(20);
            this.Property(x => x.ExpenseContentPeceiptImage).HasMaxLength(250);
            this.Property(x => x.ExpenseContentNote).HasMaxLength(250);



            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.ExpenseContentTitle).IsRequired();
            this.Property(y => y.ExpenseContentType).IsRequired();
            this.Property(y => y.ExpenseContentPeceiptNumber).IsRequired();
            this.Property(y => y.ExpenseContentPeceiptPrice).IsRequired();
            this.Property(y => y.ExpenseContentArchive).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI x İÇİNDEKİ GİBİ DEVAM EDER EĞER x YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.ExpenseContentID).HasColumnName("ExpenseContentID");
            this.Property(z => z.ExpenseContentTitle).HasColumnName("ExpenseContentTitle");
            this.Property(z => z.ExpenseContentType).HasColumnName("ExpenseContentType");
            this.Property(z => z.ExpenseContentPeceiptNumber).HasColumnName("ExpenseContentPeceiptNumber");
            this.Property(z => z.ExpenseContentPeceiptPrice).HasColumnName("ExpenseContentPeceiptPrice");
            this.Property(z => z.ExpenseContentPeceiptImage).HasColumnName("ExpenseContentPeceiptImage");
            this.Property(z => z.ExpenseContentNote).HasColumnName("ExpenseContentNote");
            this.Property(z => z.ExpenseContentArchive).HasColumnName("ExpenseContentArchive");


            //VERİ TİPLERİ
            // this.Property(d => d.ProductYear).HasColumnType("char");

            //VERİ AYARLARI
            // HasPrecision decimal(18,2) columntype kullanmak yerine bu kullanılır.
            this.Property(d => d.ExpenseContentPeceiptPrice).HasPrecision(18, 2);

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
