using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Windows.Forms;

namespace FinalOdevi.Objeler
{
    public class Analiz
    {
        public Film EnCokDegerlendirilenFilm { get; set; }
        public Film EnYuksekPuanliFilm { get; set; }

        public Analiz()
        {
            var connection = Veritabani.baglanti;
            {
                connection.Open();

                using (var command1 = new NpgsqlCommand("SELECT f.* FROM public.film f JOIN public.degerlendirme d ON f.id = d.film_id GROUP BY f.id ORDER BY COUNT(d.id) DESC LIMIT 1;", connection))
                {
                    using (var reader = command1.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            int id = 0;
                            string adi = "";
                            string tur = "";
                            int yonetmenId = 0;
                            int degerlendirme = 0;
                            DateTime tarih = DateTime.Now;

                            id = int.Parse(reader["id"].ToString());
                            adi = reader["adi"].ToString();
                            tur = reader["tur"].ToString();
                            yonetmenId = int.Parse(reader["yonetmen_id"].ToString());
                            degerlendirme = int.Parse(reader["degerlendirme"].ToString());
                            tarih = DateTime.Parse(reader["yayin_yili"].ToString());
                            int degSayisi = int.Parse(reader["degerlendirme_sayisi"].ToString());


                            var film = new Film(id, adi, null, new List<Oyuncu>(), tarih, degerlendirme, tur, degSayisi);


                            EnCokDegerlendirilenFilm = film;
                        }
                    }
                }

                using (var command2 = new NpgsqlCommand("SELECT f.* FROM public.film f JOIN public.degerlendirme d ON f.id = d.film_id GROUP BY f.id ORDER BY AVG(d.puan) DESC LIMIT 1;", connection))
                {
                    using (var reader = command2.ExecuteReader())
                    {
                        if (reader.Read())
                        {


                            int id = 0;
                            string adi = "";
                            string tur = "";
                            int yonetmenId = 0;
                            int degerlendirme = 0;
                            DateTime tarih = DateTime.Now;

                            id = int.Parse(reader["id"].ToString());
                            adi = reader["adi"].ToString();
                            tur = reader["tur"].ToString();
                            yonetmenId = int.Parse(reader["yonetmen_id"].ToString());
                            degerlendirme = int.Parse(reader["degerlendirme"].ToString());
                            tarih = DateTime.Parse(reader["yayin_yili"].ToString());
                            int degSayisi = int.Parse(reader["degerlendirme_sayisi"].ToString());


                            var film = new Film(id, adi, null, new List<Oyuncu>(), tarih, degerlendirme, tur, degSayisi);



                            EnYuksekPuanliFilm = film;
                        }
                    }
                }
                connection.Close();
            }
        }
    }

}
