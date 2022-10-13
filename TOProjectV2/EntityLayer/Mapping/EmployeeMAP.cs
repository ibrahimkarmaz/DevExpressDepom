using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class EmployeeMAP: EntityTypeConfiguration<Employee>
    {
        public EmployeeMAP()
        {

            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Employees");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.EmployeeID);

            //BENZERSİZ ALANLAR
            this.HasIndex(x => x.EmployeeTC).IsUnique();
            this.HasIndex(x => x.EmployeePhone).IsUnique();
            this.HasIndex(x => x.EmployeeMail).IsUnique();



            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.EmployeeName).HasMaxLength(20);
            this.Property(x => x.EmployeeSurName).HasMaxLength(20);
            this.Property(x => x.EmployeePhone).HasMaxLength(15);
            this.Property(x => x.EmployeeTC).HasMaxLength(11);
            this.Property(x => x.EmployeeMail).HasMaxLength(40);
            this.Property(x => x.EmployeeTown).HasMaxLength(13);
            this.Property(x => x.EmployeeCounty).HasMaxLength(20);
            this.Property(x => x.EmployeeHomeAddress).HasMaxLength(250);
            this.Property(x => x.EmployeeTask).HasMaxLength(20);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.EmployeeName).IsRequired();
            this.Property(y => y.EmployeeSurName).IsRequired();
            this.Property(y => y.EmployeePhone).IsRequired();
            this.Property(y => y.EmployeeTC).IsRequired();
            this.Property(y => y.EmployeeTown).IsRequired();
            this.Property(y => y.EmployeeCounty).IsRequired();
            this.Property(y => y.EmployeeHomeAddress).IsRequired();
            this.Property(y => y.EmployeeTask).IsRequired();
            this.Property(y => y.EmployeeArchive).IsRequired();



            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI CUSTOMER İÇİNDEKİ GİBİ DEVAM EDER EĞER CUSTOMERDA YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.EmployeeID).HasColumnName("EmployeeID");
            this.Property(z => z.EmployeeTC).HasColumnName("EmployeeTC");
            this.Property(z => z.EmployeeName).HasColumnName("EmployeeName");
            this.Property(z => z.EmployeeSurName).HasColumnName("EmployeeSurName");
            this.Property(z => z.EmployeePhone).HasColumnName("EmployeePhone");
            this.Property(z => z.EmployeeMail).HasColumnName("EmployeeMail");
            this.Property(z => z.EmployeeTown).HasColumnName("EmployeeTown");
            this.Property(z => z.EmployeeCounty).HasColumnName("EmployeeCounty");
            this.Property(z => z.EmployeeHomeAddress).HasColumnName("EmployeeHomeAddress");
            this.Property(z => z.EmployeeTask).HasColumnName("EmployeeTask");
            this.Property(z => z.EmployeeArchive).HasColumnName("EmployeeArchive");


            //VERİ TİPLERİ
            this.Property(d => d.EmployeeTC).HasColumnType("char");
        }
    }
}
