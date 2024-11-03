using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler.Uye
{
    public class StandartUye : Uye
    {
        public StandartUye(string tcKimlik, string adiSoyadi, string cinsiyet, DateTime tarih, string kullaniciadi, string sifre) : base(tcKimlik, adiSoyadi, cinsiyet, tarih, kullaniciadi, sifre)
        {
        }

        public override decimal UcretHesapla()
        {
            return 100;
        }

        public override void UyelikBilgileriGuncelle()
        {

        }
    }
}
