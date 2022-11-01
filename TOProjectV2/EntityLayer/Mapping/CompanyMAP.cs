using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class CompanyMAP: EntityTypeConfiguration<Company>
    {
        public CompanyMAP()
        {

            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Companies");

            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.CompanyID);

            //BENZERSİZ ALANLAR
            this.HasIndex(x => x.CompanyPhone1).IsUnique();
            this.HasIndex(x => x.CompanyMail).IsUnique();
            this.HasIndex(x => x.CompanyFax).IsUnique();
            this.HasIndex(x => x.CompanyOfficialTC).IsUnique();


            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.CompanyOfficialStatus).HasMaxLength(30);
            this.Property(x => x.CompanyOfficialNameSurName).HasMaxLength(30);
            this.Property(x => x.CompanyPhone1).HasMaxLength(15);
            this.Property(x => x.CompanyPhone2).HasMaxLength(15);
            this.Property(x => x.CompanyPhone3).HasMaxLength(15);
            this.Property(x => x.CompanyMail).HasMaxLength(40);
            this.Property(x => x.CompanyFax).HasMaxLength(15);
            this.Property(x => x.CompanyTaxOffice).HasMaxLength(30);
            this.Property(x => x.CompanyAddress).HasMaxLength(250);
            this.Property(x => x.CompanyOfficialTC).HasMaxLength(11);

            /*this.Property(x => x.CompanyTown).HasMaxLength(13);
            this.Property(x => x.CompanyCounty).HasMaxLength(20);
            this.Property(x => x.CompanySpecialCode1).HasMaxLength(10);
            this.Property(x => x.CompanySpecialCode2).HasMaxLength(10);
            this.Property(x => x.CompanySpecialCode3).HasMaxLength(10);*/

            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.CompanyOfficialNameSurName).IsRequired();
            this.Property(y => y.CompanyPhone1).IsRequired();
            this.Property(y => y.CompanyMail).IsRequired();
            this.Property(y => y.CompanyTaxOffice).IsRequired();
            this.Property(y => y.CompanyAddress).IsRequired();
            this.Property(y => y.CompanyOfficialTC).IsRequired();
            this.Property(y => y.CountyID).IsRequired();
            this.Property(y => y.DistrictID).IsRequired();
            this.Property(y => y.SectorID).IsRequired();

            // this.Property(y => y.CompanyTown).IsRequired();
            // this.Property(y => y.CompanyCounty).IsRequired();


            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI x İÇİNDEKİ GİBİ DEVAM EDER EĞER x YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.CompanyID).HasColumnName("CompanyID");
            this.Property(z => z.CompanyName).HasColumnName("CompanyName");
            this.Property(z => z.CompanyOfficialNameSurName).HasColumnName("CompanyOfficialNameSurName");
            this.Property(z => z.CompanyOfficialStatus).HasColumnName("CompanyOfficialStatus");
            this.Property(z => z.CompanyPhone1).HasColumnName("CompanyPhone1");
            this.Property(z => z.CompanyPhone2).HasColumnName("CompanyPhone2");
            this.Property(z => z.CompanyPhone3).HasColumnName("CompanyPhone3");
            this.Property(z => z.CompanyMail).HasColumnName("CompanyMail");
            this.Property(z => z.CompanyFax).HasColumnName("CompanyFax");
       
            this.Property(z => z.CompanyTaxOffice).HasColumnName("CompanyTaxOffice");
            this.Property(z => z.CompanyAddress).HasColumnName("CompanyAddress");
            this.Property(z => z.CompanyArchive).HasColumnName("CompanyArchive");
            this.Property(z => z.CompanyOfficialTC).HasColumnName("CompanyOfficialTC");
            this.Property(z => z.CountyID).HasColumnName("CountyID");
            this.Property(z => z.DistrictID).HasColumnName("DistrictID");
            this.Property(z => z.SectorID).HasColumnName("SectorID");


            /*this.Property(z => z.CompanyTown).HasColumnName("CompanyTown");
            this.Property(z => z.CompanyCounty).HasColumnName("CompanyCounty");
            this.Property(z => z.CompanySpecialCode1).HasColumnName("CompanySpecialCode1");
            this.Property(z => z.CompanySpecialCode2).HasColumnName("CompanySpecialCode2");
            this.Property(z => z.CompanySpecialCode3).HasColumnName("CompanySpecialCode3");*/



            //VERİ TİPLERİ
            //--
        }
    }
}
