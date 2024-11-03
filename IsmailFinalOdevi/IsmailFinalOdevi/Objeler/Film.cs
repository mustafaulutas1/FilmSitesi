using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler
{
    public class Film
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public Yonetmen Yonetmen { get; set; } = null!;
        public string Tur { get; set; }
        public List<Oyuncu> Oyuncular { get; set; } = null!;
        public DateTime YayinlanmaYili { get; set; }
        public int DegerlendirmePuani { get; set; }
        public int DegerlendirmeSayisi { get; set; }



        public Film(int id, string adi, Yonetmen yonetmen, List<Oyuncu> oyuncular, DateTime yayinlanmaYili, int degerlendirmePuani, string tur, int degerlendirmeSayisi)
        {
            Id = id;
            Adi = adi;
            Yonetmen = yonetmen;
            Oyuncular = oyuncular;
            YayinlanmaYili = yayinlanmaYili;
            DegerlendirmePuani = degerlendirmePuani;
            Tur = tur;
            DegerlendirmeSayisi = degerlendirmeSayisi;
        }
    }
}
