using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Mapping
{
    public class NoteMAP:EntityTypeConfiguration<Note>
    {
        public NoteMAP()
        {
            //NOT:BURASI CLASSLAR ÜZERİNDE KISITLAMALARI AYARLAR.

            //TABLO ADI
            this.ToTable("Notes");


            //BİRİNCİ ANAHTAR VE YABANCI ANAHTAR KISITLAMALARI

            this.HasKey(x => x.NoteID);

            //BENZERSİZ ALANLAR
            //--

            //EN FAZLA KARAKTER SAYILARI

            this.Property(x => x.NoteTitle).HasMaxLength(50);
            this.Property(x => x.NoteDetail).HasMaxLength(250);
            this.Property(x => x.NoteCreate).HasMaxLength(40);


            //BOŞ GEÇİLEMEZ ALANLAR

            this.Property(y => y.NoteTitle).IsRequired();
            this.Property(y => y.NoteDetail).IsRequired();
            this.Property(y => y.NoteCreate).IsRequired();

            //ALAN ADLARI
            //DİKKAT:ALAN ADLARI X İÇİNDEKİ GİBİ DEVAM EDER EĞER X YANLIŞLIKLA ALAN ADI
            //DEĞİŞİRSE BURADA TOPARLARIZ.

            this.Property(z => z.NoteID).HasColumnName("NoteID");
            this.Property(z => z.NoteDate).HasColumnName("NoteDate");
            this.Property(z => z.NoteHour).HasColumnName("NoteHour");
            this.Property(z => z.NoteTitle).HasColumnName("NoteTitle");
            this.Property(z => z.NoteDetail).HasColumnName("NoteDetail");
            this.Property(z => z.NoteCreate).HasColumnName("NoteCreate");
            this.Property(z => z.NoteArchive).HasColumnName("NoteArchive");


            //VERİ TİPLERİ
            this.Property(d => d.NoteDate).HasColumnType("smalldatetime");
        }
    }
}
