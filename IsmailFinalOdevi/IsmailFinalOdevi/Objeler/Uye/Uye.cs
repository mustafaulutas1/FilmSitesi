using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler.Uye
{
    public abstract class Uye
    {
        public string TcKimlik { get; set; }
        public string AdiSoyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Cinsiyet { get; set; }
        public DateTime UyelikTarihi { get; set; }


        abstract public decimal UcretHesapla();

        abstract public void UyelikBilgileriGuncelle();

        public Uye(string tcKimlik, string adiSoyadi, string cinsiyet, DateTime tarih, string kullaniciAdi, string sifre)
        {
            TcKimlik = tcKimlik;

            AdiSoyadi = adiSoyadi;
            Cinsiyet = cinsiyet;
            UyelikTarihi = tarih;
            KullaniciAdi = kullaniciAdi;
            Sifre = sifre;
        }
    }
}
