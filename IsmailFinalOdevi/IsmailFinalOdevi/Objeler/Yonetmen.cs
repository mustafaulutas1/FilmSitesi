using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler
{
    public class Yonetmen
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; } = null!;

        public Yonetmen(int id,string adisoyadi) {
            Id = id;
            AdiSoyadi = adisoyadi;
        }
    }
}
