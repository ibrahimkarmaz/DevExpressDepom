using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//Key için
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Entities
{ /*NOTLAR
     * Burada Birinci Anahtar Kullanımı için [Key] kullandık fakat direk kullanamıyoruz enttitiy Dll indirilmesi gerekiyor.
     */
    public class Musteri
    {   
        [Key]
        public int ID { get; set; }
        [StringLength(20)]
        public string Ad { get; set; }
        [StringLength(20)]
        public string Soyad { get; set; }
        public bool Cinsiyet { get; set; }
        [StringLength(20)]
        public string Telefon { get; set; }
        [StringLength(60)]
        public string Mail { get; set; }
        public DateTime KayitTarih { get; set; }
        public bool Arsiv { get; set; }

        public ICollection<Detay>  Detaylar { get; set; }
    }
}
