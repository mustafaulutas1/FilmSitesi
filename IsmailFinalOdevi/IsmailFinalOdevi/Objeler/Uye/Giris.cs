using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler.Uye
{
    public class Giris
    {
        public string TC { get; set; }
        public string AdiSoyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Cinsiyet { get; set; }
        public KullaniciTipi KullaniciTipi { get; set; }
    }

    public enum KullaniciTipi
    {
        Standart = 1,
        Premium = 2
    }
}
