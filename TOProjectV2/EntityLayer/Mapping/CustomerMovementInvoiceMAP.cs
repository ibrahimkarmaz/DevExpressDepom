using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
	public class CustomerMovementInvoiceMAP:EntityTypeConfiguration<CustomerMovementInvoice>
	{
		public CustomerMovementInvoiceMAP()
		{
			//NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

			//TABLO ADI
			this.ToTable("CustomerMovementInvoices");


			//BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

			this.HasKey(x => x.CustomerMovementInvoiceID);

			//BENZERSİZ ALANLAR
			//--

			//EN FAZLA KARAKTER SAYILARI

			this.Property(x => x.CustomerMovementInvoiceSeries).HasMaxLength(20);


			//BOŞ GEÇİLEMEZ ALANLAR

			this.Property(y => y.CustomerMovementInvoiceSeries).IsRequired();



			//ALAN ADLARI
			//DİKKAT:ALAN ADLARI X TABLOSU İÇİNDEKİ GİBİ DEVAM EDER EĞER X TABLOSUNDA YANLIŞLIKLA ALAN ADI
			//DEĞİŞİRSE BURADA TOPARLARIZ.

			this.Property(z => z.CustomerMovementInvoiceID).HasColumnName("CustomerMovementInvoiceID");
			this.Property(z => z.CustomerMovementInvoiceSeries).HasColumnName("CustomerMovementInvoiceSeries");



			//VERİ TİPLERİ
			this.Property(d => d.CustomerMovementInvoiceSeries).HasColumnType("char");

			//VERİ TİPİ ÖZEL 
			// --
		}
	}
}
