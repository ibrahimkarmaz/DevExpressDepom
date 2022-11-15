using EntityLayer.Concrete;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class CompanyMovementMAP:EntityTypeConfiguration<CompanyMovement>
    {
        public CompanyMovementMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("CompanyMovements");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.CompanyMovementID);

            //BENZERSİZ ALANLAR
            //--



            //EN FAZLA KARAKTER SAYILARI
            this.Property(x => x.CompanyMovemenNote).HasMaxLength(250);



            //BOŞ GEÇİLEMEZ ALANLAR
            this.Property(y => y.CompanyMovementDate).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X İÇİNDEKİ GİBİ DEVAM EDER EĞER X YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.CompanyMovementID).HasColumnName("CompanyMovementID");
            this.Property(z => z.CompanyMovementDate).HasColumnName("CompanyMovementDate");
            this.Property(z => z.CompanyMovemenNote).HasColumnName("CompanyMovemenNote");
            this.Property(z => z.CompanyMovemenArchive).HasColumnName("CompanyMovemenArchive");
            this.Property(z => z.CompanyID).HasColumnName("CompanyID");
            this.Property(z => z.EmployeeID).HasColumnName("EmployeeID");

            //VERİ TİPLERİ
            //--
        }
    }
}
