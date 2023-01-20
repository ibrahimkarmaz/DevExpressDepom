using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
	public class CustomerMovementMAP:EntityTypeConfiguration<CustomerMovement>
	{
		public CustomerMovementMAP()
		{
			//NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

			//TABLO ADI
			this.ToTable("CustomerMovement");


			//BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

			this.HasKey(x => x.CustomerMovementID);

			//BENZERSİZ ALANLAR
			//--



			//EN FAZLA KARAKTER SAYILARI
			this.Property(x => x.CustomerMovemenNote).HasMaxLength(250);



			//BOŞ GEÇİLEMEZ ALANLAR
			this.Property(y => y.CustomerMovementDate).IsRequired();



			//ALAN ADLARI
			//DİKKAT:ALAN ADLARI X İÇİNDEKİ GİBİ DEVAM EDER EĞER X YANLIŞLIKLA ALAN ADI
			//DEĞİŞİRSE BURADA TOPARLARIZ.

			this.Property(z => z.CustomerMovementID).HasColumnName("CustomerMovementID");
			this.Property(z => z.CustomerMovementDate).HasColumnName("CustomerMovementDate");
			this.Property(z => z.CustomerMovemenNote).HasColumnName("CustomerMovemenNote");
			this.Property(z => z.CustomerMovemenArchive).HasColumnName("CustomerMovemenArchive");
			/*this.Property(z => z.CompanyID).HasColumnName("CompanyID");
			this.Property(z => z.EmployeeID).HasColumnName("EmployeeID");*/

			//VERİ TİPLERİ
			//--
		}
	}
}
