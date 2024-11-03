using FinalOdevi.Objeler.Uye;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FinalOdevi.Objeler
{
    public class IzlemeListesi
    {
        public int Id { get; set; }
        public Film Film { get; set; }
        public Uye.Uye uye { get; set; }
        public bool IzlendiMi { get; set; }

        public IzlemeListesi(int id, Film film, Uye.Uye uyes,bool izlendiMi)
        {
            Id = id;
            Film = film;
            this.uye = uyes;
            this.IzlendiMi = izlendiMi;
        }
    }
}
