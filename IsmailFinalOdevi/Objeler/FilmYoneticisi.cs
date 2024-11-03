using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler
{
    public class FilmYoneticisi
    {

        public void FilmEkle(Film film)
        {
            Veritabani.baglanti.Open();
            try
            {
                string commandText = $"INSERT INTO film values(default,@adi,@tur,@yonetmen_id,@degerlendirme,@yayin_yili)";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                sqlCmd.Parameters.AddWithValue("adi", film.Adi);
                sqlCmd.Parameters.AddWithValue("tur", film.Tur);
                sqlCmd.Parameters.AddWithValue("yayin_yili", film.YayinlanmaYili);
                sqlCmd.Parameters.AddWithValue("yonetmen_id", film.Yonetmen.Id);
                sqlCmd.Parameters.AddWithValue("degerlendirme", film.DegerlendirmePuani);
                sqlCmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Veritabani.baglanti.Close();
            }
        }

        public void FilmGuncelle(Film film)
        {
            Veritabani.baglanti.Open();
            try
            {
                string commandText = $"UPDATE film SET adi=@adi,tur=@tur,yayin_yili=@yayin_yili,yonetmen_id=@yonetmen_id,degerlendirme=@degerlendirme";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                sqlCmd.Parameters.AddWithValue("adi", film.Adi);
                sqlCmd.Parameters.AddWithValue("tur", film.Tur);
                sqlCmd.Parameters.AddWithValue("yayin_yili", film.YayinlanmaYili);
                sqlCmd.Parameters.AddWithValue("yonetmen_id", film.Yonetmen.Id);
                sqlCmd.Parameters.AddWithValue("degerlendirme", film.DegerlendirmePuani);
                sqlCmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Veritabani.baglanti.Close();
            }
        }

        public void FilmSil(Film film)
        {
            Veritabani.baglanti.Open();
            try
            {
                string commandText = $"DELETE FROM film WHERE id=@id";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                sqlCmd.Parameters.AddWithValue("id", film.Id);
                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Veritabani.baglanti.Close();
            }
        }

        public void OyuncuEkle(Oyuncu oyuncu)
        {
            Veritabani.baglanti.Open();
            try
            {
                string commandText = $"INSERT INTO oyuncu values(default,@adi)";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                sqlCmd.Parameters.AddWithValue("adi", oyuncu.AdiSoyadi);
            
                sqlCmd.ExecuteNonQuery();


            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Veritabani.baglanti.Close();
            }
        }

      

        public void OyuncuSil(Oyuncu oyuncu)
        {
            Veritabani.baglanti.Open();
            try
            {
                string commandText = $"DELETE FROM oyuncu WHERE id=@id";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                sqlCmd.Parameters.AddWithValue("adi", oyuncu.AdiSoyadi);
                sqlCmd.Parameters.AddWithValue("id", oyuncu.Id);

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Veritabani.baglanti.Close();
            }
        }

        public void YonetmenEkle(Yonetmen yonetmen)
        {
            Veritabani.baglanti.Open();
            try
            {
                string commandText = $"INSERT INTO oyuncu VALUES(default,adi=@adi)";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                sqlCmd.Parameters.AddWithValue("adi", yonetmen.AdiSoyadi);
                sqlCmd.Parameters.AddWithValue("id", yonetmen.Id);

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Veritabani.baglanti.Close();
            }
        }



        public void YonetmenSil(Yonetmen yonetmen)
        {
            Veritabani.baglanti.Open();
            try
            {
                string commandText = $"DELETE FROM yonetmen WHERE id=@id";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                sqlCmd.Parameters.AddWithValue("adi", yonetmen.AdiSoyadi);
                sqlCmd.Parameters.AddWithValue("id", yonetmen.Id);

                sqlCmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                Veritabani.baglanti.Close();
            }
        }
    }

}
