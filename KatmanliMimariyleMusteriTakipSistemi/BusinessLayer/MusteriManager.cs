using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using EntitiyLayer.Entities;

namespace BusinessLayer
{//CRUD VB İŞLEMLERDEN ÖNCE BİR SORUN OLUŞMAMASI İÇİN YAPILACAK İŞLEMLERİN YAPILDIĞI YERDİR. (BusinessLayer)
    public class MusteriManager
    {
        Repository<Musteri> RepoMusteri = new Repository<Musteri>();
        public List<Musteri> TumunuListele()
        {
            return RepoMusteri.Listele();
        }
        public void MusteriKayit(Musteri Parametre)
        {
            RepoMusteri.Ekle(Parametre);
        }
        public void MusteriGuncelle(Musteri Parametre)
        {
            Musteri Guncelleme = RepoMusteri.Find(x=>x.ID==Parametre.ID);
            Guncelleme.Ad = Parametre.Ad;
            Guncelleme.Soyad = Parametre.Soyad;
            //.....

            RepoMusteri.Guncelle(Guncelleme);
        }
        public int Sil(int p)
        {
            if (p!=0)
            {
                Musteri DegerAl = RepoMusteri.Find(x=>x.ID==p);
                return RepoMusteri.Sil(DegerAl);
            }
            else
            {
                return -1;
            }
        }

        public List<Musteri> AramaYap(string p)
        {
            return RepoMusteri.Arama(x=>x.Ad==p);
        }
    }
}
