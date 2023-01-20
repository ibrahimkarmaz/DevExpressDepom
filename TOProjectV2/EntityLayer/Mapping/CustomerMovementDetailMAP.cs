using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
	public class CustomerMovementDetailMAP:EntityTypeConfiguration<CustomerMovementDetail>
	{
		public CustomerMovementDetailMAP()
		{
			
				//NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

				//TABLO ADI
				this.ToTable("CustomerMovementDetails");


				//BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

				this.HasKey(x => x.CustomerMovementDetailID);

				//BENZERSİZ ALANLAR
				//--



				//EN FAZLA KARAKTER SAYILARI
				//-- HasMaxLength


				//BOŞ GEÇİLEMEZ ALANLAR

				this.Property(y => y.CustomerMovementDetailPiece).IsRequired();
				this.Property(y => y.CustomerMovementDetailPrice).IsRequired();
				this.Property(y => y.CustomerMovementDetailTotalPrice).IsRequired();


				//ALAN ADLARI
				//DİKKAT:ALAN ADLARI x İÇİNDEKİ GİBİ DEVAM EDER EĞER x YANLIŞLIKLA ALAN ADI
				//DEĞİŞİRSE BURADA TOPARLARIZ.

				this.Property(z => z.CustomerMovementDetailID).HasColumnName("CustomerMovementDetailID");
				this.Property(z => z.CustomerMovementDetailPiece).HasColumnName("CustomerMovementDetailPiece");
				this.Property(z => z.CustomerMovementDetailPrice).HasColumnName("CustomerMovementDetailPrice");
				this.Property(z => z.CustomerMovementDetailTotalPrice).HasColumnName("CustomerMovementDetailTotalPrice");
				this.Property(z => z.ProductID).HasColumnName("ProductID");
				this.Property(z => z.CustomerMovementID).HasColumnName("CustomerMovementID");


				//VERİ TİPLERİ
				// this.Property(d => d.ProductYear).HasColumnType("char");

				//VERİ AYARLARI
				// HasPrecision decimal(18,2) columntype kullanmak yerine bu kullanılır.
				this.Property(d => d.CustomerMovementDetailPrice).HasPrecision(18, 2);
				this.Property(d => d.CustomerMovementDetailTotalPrice).HasPrecision(18, 2);

				/*DİKKAT: BURADA DECİMALLA İLGİLİ BİR SORUN OLUŞTUR
				 *SORUN 12,45 SAYISINI VERİTABANİNA 1245 OLARAK KAYIT YAPILIYOR.
				 *
				 *
				 *ÇÖZÜLDÜ NEDENİ:
				 *TextEDİT'te . koyuyordu onu yenileyip , yaptık.*/
				 
			
		}
	}
}
