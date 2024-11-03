using FinalOdevi.Objeler.Uye;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler
{
    public class DegerlendirmeYoneticisi
    {

        public void DegerlendirmeYap(PremiumUye uye, Film film, int puan, string degerlendirme)
        {
            Veritabani.baglanti.Open();
            string insertCommandText = "INSERT INTO public.degerlendirme (film_id, degerlendirme, kullanici_tc, puan) VALUES (@film_id, @degerlendirme, @kullanici_tc, @puan);";
            string updateFilmCommandText = "UPDATE public.film SET degerlendirme_sayisi = degerlendirme_sayisi + 1, puan = (puan * (degerlendirme_sayisi - 1) + @puan) / degerlendirme_sayisi WHERE id = @film_id;";

            var insertCmd = new NpgsqlCommand(insertCommandText, Veritabani.baglanti);
            var updateFilmCmd = new NpgsqlCommand(updateFilmCommandText, Veritabani.baglanti);

            insertCmd.Parameters.AddWithValue("film_id", film.Id);
            insertCmd.Parameters.AddWithValue("degerlendirme", degerlendirme);
            insertCmd.Parameters.AddWithValue("kullanici_tc", uye.TcKimlik);
            insertCmd.Parameters.AddWithValue("puan", puan);

            updateFilmCmd.Parameters.AddWithValue("film_id", film.Id);
            updateFilmCmd.Parameters.AddWithValue("puan", puan);

            insertCmd.ExecuteNonQuery();
            Veritabani.baglanti.Close();

        }

        public List<Degerlendirme> FilminDegerlendirmeleriniGetir(Film film)
        {
            List<Degerlendirme> degerlendirmeler = new List<Degerlendirme>();

            string selectCommandText = "select * from degerlendirme d join kullanici k on d.kullanici_tc = kullanici_tc where d.film_id = @film_id";

            using (var sqlCommand = new NpgsqlCommand(selectCommandText, Veritabani.baglanti))
            {
                sqlCommand.Parameters.AddWithValue("film_id", film.Id);

                Veritabani.baglanti.Open();

                using (var reader = sqlCommand.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Degerlendirme degerlendirme = new Degerlendirme
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("id")),
                            Film = film,
                            Mesaj = reader.GetString(reader.GetOrdinal("degerlendirme")),
                            YapanAdiSoyadi = reader.GetString(reader.GetOrdinal("adi_soyadi")),
                            Puan = reader.GetInt32(reader.GetOrdinal("puan")),

                        };

                        degerlendirmeler.Add(degerlendirme);
                    }
                }
                Veritabani.baglanti.Close();

            }

            return degerlendirmeler;
        }

    }
}
