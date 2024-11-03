using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler
{
    public class Oyuncu
    {
        public int Id { get; set; }
        public string AdiSoyadi { get; set; } = null!;

        public Oyuncu(int id, string adi)
        {
            Id = id;
            AdiSoyadi = adi;
        }
    }

}
