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
            this.ToTable("ExprenseHeaders");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.ExprenseHeaderID);

            //BENZERSİZ ALANLAR
            this.HasIndex(x => x.ExprenseHeaderName).IsUnique();


            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.ExprenseHeaderName).HasMaxLength(30);
            this.Property(x => x.ExprenseHeaderDetail).HasMaxLength(250);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.ExprenseHeaderName).IsRequired();
            this.Property(y => y.ExprenseHeaderStartDate).IsRequired();
            this.Property(y => y.ExprenseHeaderStopDate).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI CUSTOMER İÇİNDEKİ GİBİ DEVAM EDER EĞER CUSTOMERDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.ExprenseHeaderID).HasColumnName("ExprenseHeaderID");
            this.Property(z => z.ExprenseHeaderName).HasColumnName("ExprenseHeaderName");
            this.Property(z => z.ExprenseHeaderStartDate).HasColumnName("ExprenseHeaderStartDate");
            this.Property(z => z.ExprenseHeaderStopDate).HasColumnName("ExprenseHeaderStopDate");
            this.Property(z => z.ExprenseHeaderDetail).HasColumnName("ExprenseHeaderDetail");
            this.Property(z => z.ExpenseHeaderArchive).HasColumnName("ExpenseHeaderArchive");


            //VERİ TİPLERİ
            //--
        }
    }
}
