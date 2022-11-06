using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class ExpenseHeaderMAP:EntityTypeConfiguration<ExpenseHeader>
    {
        public ExpenseHeaderMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("ExorenseHeaders");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.ExorenseHeaderID);

            //BENZERSİZ ALANLAR
            this.HasIndex(x => x.ExorenseHeaderName).IsUnique();


            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.ExorenseHeaderName).HasMaxLength(30);
            this.Property(x => x.ExorenseHeaderDetail).HasMaxLength(250);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.ExorenseHeaderName).IsRequired();
            this.Property(y => y.ExorenseHeaderStartDate).IsRequired();
            this.Property(y => y.ExorenseHeaderStopDate).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI CUSTOMER İÇİNDEKİ GİBİ DEVAM EDER EĞER CUSTOMERDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.ExorenseHeaderID).HasColumnName("ExorenseHeaderID");
            this.Property(z => z.ExorenseHeaderName).HasColumnName("ExorenseHeaderName");
            this.Property(z => z.ExorenseHeaderStartDate).HasColumnName("ExorenseHeaderStartDate");
            this.Property(z => z.ExorenseHeaderStopDate).HasColumnName("ExorenseHeaderStopDate");
            this.Property(z => z.ExorenseHeaderDetail).HasColumnName("ExorenseHeaderDetail");
            this.Property(z => z.ExpenseHeaderArchive).HasColumnName("ExpenseHeaderArchive");


            //VERİ TİPLERİ
            //--
        }
    }
}
