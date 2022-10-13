using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class ExpenseMAP:EntityTypeConfiguration<Expense>
    {
        public ExpenseMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Expenses");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.ExpenseID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.ExpenseNote).HasMaxLength(500);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.ExpenseArchive).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X İÇİNDEKİ GİBİ DEVAM EDER EĞER X YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.ExpenseID).HasColumnName("ExpenseID");
            this.Property(z => z.ExpenseElectric).HasColumnName("ExpenseElectric");
            this.Property(z => z.ExpenseWater).HasColumnName("ExpenseWater");
            this.Property(z => z.ExpenseNaturalGas).HasColumnName("ExpenseNaturalGas");
            this.Property(z => z.ExpenseInternet).HasColumnName("ExpenseInternet");
            this.Property(z => z.ExpenseWage).HasColumnName("ExpenseWage");
            this.Property(z => z.ExpenseExtra).HasColumnName("ExpenseExtra");
            this.Property(z => z.ExpenseNote).HasColumnName("ExpenseNote");
            this.Property(z => z.ExpenseArchive).HasColumnName("ExpenseArchive");


            //VERİ TİPLERİ
            //--

            //VERİ AYARLARI
            // HasPrecision decimal(18,2) columntype kullanmak yerine bu kullanılır.
            this.Property(d => d.ExpenseElectric).HasPrecision(18, 2);
            this.Property(d => d.ExpenseWater).HasPrecision(18, 2);
            this.Property(d => d.ExpenseNaturalGas).HasPrecision(18, 2);
            this.Property(d => d.ExpenseInternet).HasPrecision(18, 2);
            this.Property(d => d.ExpenseWage).HasPrecision(18, 2);
            this.Property(d => d.ExpenseExtra).HasPrecision(18, 2);
        }
    }
}
