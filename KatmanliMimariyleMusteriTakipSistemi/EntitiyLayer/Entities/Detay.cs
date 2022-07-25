using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;//Key için kullanılacaklar
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiyLayer.Entities
{
    /*NOTLAR
     * Burada Birinci Anahtar Kullanımı için [Key] kullandık fakat direk kullanamıyoruz enttitiy Dll indirilmesi gerekiyor.
     */
    public class Detay
    {   [Key]
        public int DetayID { get; set; }
        [StringLength(250)]
        public string Konu { get; set; }
        public bool arsiv { get; set;}

        public int MusteriID { get; set; }//Burada Bu konunun hangi müşteriye ait olduğu belirtiliyor(Karşılama 1)

        public virtual Musteri Musteriler { get; set; }//Musteriler tablosundan ICollection karşılıyoruz ve bağlantı oluşturuyoruz
    }
}
