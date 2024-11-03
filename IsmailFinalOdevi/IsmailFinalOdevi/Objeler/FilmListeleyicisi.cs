using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler
{
    public class FilmListeleyicisi
    {

        public List<Film> FilmAra(string aramaMetni)
        {
            Veritabani.baglanti.Open();
            try
            {

                string commandText = "SELECT f.* , y.adi AS yonetmen_adi FROM public.film f JOIN public.yonetmen y ON f.yonetmen_id = y.id WHERE (LOWER(f.adi) IS NULL or LOWER(f.adi) LIKE LOWER('%' || @adi || '%')) OR (f.tur IS NULL OR LOWER(f.tur) LIKE LOWER('%' || @tur || '%')) or (y.adi IS NULL OR LOWER(y.adi) LIKE LOWER('%' || @yadi || '%'));";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);

                sqlCmd.Parameters.AddWithValue("adi", aramaMetni);
                sqlCmd.Parameters.AddWithValue("tur", aramaMetni);
                sqlCmd.Parameters.AddWithValue("yadi", aramaMetni);

                var liste = new List<Film>();
                using (var reader = sqlCmd.ExecuteReader())
                {
                    while (reader.Read())
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

                        string yonetmenAdi = reader["yonetmen_adi"].ToString();



                        var film = new Film(id, adi, new Yonetmen(0, yonetmenAdi), new List<Oyuncu>(), tarih, degerlendirme, tur, degSayisi);
                        liste.Add(film);

                    }
                    return liste;
                }

            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                Veritabani.baglanti.Close();

            }
        }

        public List<Film> FilmleriGetir()
        {
            Veritabani.baglanti.Open();

            try
            {
                string commandText = "SELECT film.*, y.adi AS yonetmen_adi FROM film JOIN yonetmen y ON film.yonetmen_id = y.id ORDER BY film.id DESC";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                var liste = new List<Film>();
                using (var reader = sqlCmd.ExecuteReader())
                {
                    while (reader.Read())
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
                        string yonetmenAdi = reader["yonetmen_adi"].ToString();
                        tarih = DateTime.Parse(reader["yayin_yili"].ToString());
                        int degSayisi = int.Parse(reader["degerlendirme_sayisi"].ToString());

                        var film = new Film(id, adi, new Yonetmen(0, yonetmenAdi), new List<Oyuncu>(), tarih, degerlendirme, tur, degSayisi);
                        liste.Add(film);

                    }
                    return liste;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {
                Veritabani.baglanti.Close();
            }
        }

        public Film FilmGetir(int filmId)
        {
            var connection = Veritabani.baglanti;

            connection.Open();

            string query = "SELECT f.*, y.adi AS yonetmen_adi FROM film f JOIN yonetmen y ON f.yonetmen_id = y.id WHERE f.id = @filmId";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("filmId", filmId);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Assuming you have a constructor for the Film class that takes relevant parameters
                        var film = new Film(reader.GetInt32(reader.GetOrdinal("id")), reader.GetString(reader.GetOrdinal("adi")), new Yonetmen((reader.GetInt32(reader.GetOrdinal("yonetmen_id"))), reader["yonetmen_adi"].ToString()), null, reader.GetDateTime(reader.GetOrdinal("yayin_yili")), reader.GetInt32(reader.GetOrdinal("degerlendirme")), reader.GetString(reader.GetOrdinal("tur")), reader.GetInt32(reader.GetOrdinal("degerlendirme_sayisi")))
                     ;
                        connection.Close();
                        return film;
                    }
                    connection.Close();

                    return null;
                }

            }

        }
    }
}
