using FinalOdevi.Objeler.Uye;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler
{
    public class Degerlendirme
    {
        public int Id { get; set; }
        public Film Film { get; set; } = null!;
        public string YapanAdiSoyadi { get; set; } = null!;
        public string Mesaj { get; set; } = null!;
        public int Puan { get; set; }
    }
}
