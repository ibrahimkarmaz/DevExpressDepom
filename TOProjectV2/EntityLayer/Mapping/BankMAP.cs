using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class BankMAP:EntityTypeConfiguration<Bank>
    {
        public BankMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Banks");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.BankID);

            //BENZERSİZ ALANLAR
            this.HasIndex(x => x.IBAN).IsUnique();
            this.HasIndex(x => x.BankPhone).IsUnique();



            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.BankName).HasMaxLength(30);
            this.Property(x => x.BankAccountNo).HasMaxLength(30);
            this.Property(x => x.BankBranch).HasMaxLength(30);
            this.Property(x => x.IBAN).HasMaxLength(30);
            this.Property(x => x.BankOfficial).HasMaxLength(30);
            this.Property(x => x.BankAccountType).HasMaxLength(20);
            this.Property(x => x.BankPhone).HasMaxLength(15);
            


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.BankName).IsRequired();
            this.Property(y => y.IBAN).IsRequired();
            this.Property(y => y.BankAccountNo).IsRequired();
            this.Property(y => y.BankOfficial).IsRequired();
            this.Property(y => y.BankDate).IsRequired();
            this.Property(y => y.BankAccountType).IsRequired();
            this.Property(y => y.BankArchive).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI CUSTOMER İÇİNDEKİ GİBİ DEVAM EDER EĞER CUSTOMERDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.BankID).HasColumnName("BankID");
            this.Property(z => z.BankName).HasColumnName("BankName");
            this.Property(z => z.CountyID).HasColumnName("CountyID");
            this.Property(z => z.DistrictID).HasColumnName("DistrictID");
            this.Property(z => z.BankBranch).HasColumnName("BankBranch");
            this.Property(z => z.IBAN).HasColumnName("IBAN");
            this.Property(z => z.BankAccountNo).HasColumnName("BankAccountNo");
            this.Property(z => z.BankOfficial).HasColumnName("BankOfficial");
            this.Property(z => z.BankDate).HasColumnName("BankDate");
            this.Property(z => z.BankAccountType).HasColumnName("BankAccountType");
            this.Property(z => z.BankPhone).HasColumnName("BankPhone");
            this.Property(z => z.BankArchive).HasColumnName("BankArchive");
            this.Property(z => z.CompanyID).HasColumnName("CompanyID");


            //VERİ TİPLERİ
            this.Property(d => d.BankDate).HasColumnType("smalldatetime");
        }
    }
}
