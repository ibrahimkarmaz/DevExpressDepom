using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class DepartmentMAP:EntityTypeConfiguration<Department>
    {
        public DepartmentMAP()
        {
            //TABLO ADI
            this.ToTable("Departments");

            //BİRİNCİ VE YABANCI ANAHTARLAR
            this.HasKey(x => x.DepartmentID);


            //BENZERSİZ ALANLAR
            this.HasIndex(a => a.DepartmentName).IsUnique();
            //EN FAZLA KARAKTER
            this.Property(b => b.DepartmentName).HasMaxLength(20);

            //BOŞ GEÇİLEMEZ
            this.Property(c => c.DepartmentName).IsRequired();
            this.Property(c => c.DepartmentArchive).IsRequired();

            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI x İÇİNDEKİ GİBİ DEVAM EDER EĞER x YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.
            this.Property(z => z.DepartmentID).HasColumnName("DepartmentID");
            this.Property(z => z.DepartmentName).HasColumnName("DepartmentName");
            this.Property(z => z.DepartmentArchive).HasColumnName("DepartmentArchive");
        }
    }
}
