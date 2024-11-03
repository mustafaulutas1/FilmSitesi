using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler.Uye
{
    public class UyeYoneticisi
    {
        public void UyeEkle(Uye uye, bool premiumMu)
        {

            Veritabani.baglanti.Open();
            try
            {
                string commandText = $"INSERT INTO kullanici values(@tc,@adi_soyadi,@tarih,@cinsiyet,@kullanici_adi,@sifre,@premium_mu)";
                var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
                sqlCmd.Parameters.AddWithValue("tc", uye.TcKimlik);
                sqlCmd.Parameters.AddWithValue("adi_soyadi", uye.AdiSoyadi);
                sqlCmd.Parameters.AddWithValue("tarih", DateTime.Now);
                sqlCmd.Parameters.AddWithValue("cinsiyet", uye.Cinsiyet);
                sqlCmd.Parameters.AddWithValue("kullanici_adi", uye.KullaniciAdi);
                sqlCmd.Parameters.AddWithValue("sifre", uye.Sifre);
                sqlCmd.Parameters.AddWithValue("premium_mu", NpgsqlDbType.Bit, premiumMu);
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
        public Uye? GirisYap(string kullaniciAdi, string sifre)
        {
            string commandText = $"SELECT * FROM kullanici WHERE kullanici_adi = @kullanici_adi && sifre = @sifre";
            var sqlCmd = new NpgsqlCommand(commandText, Veritabani.baglanti);
            sqlCmd.Parameters.AddWithValue("kullanici_adi", kullaniciAdi);
            sqlCmd.Parameters.AddWithValue("sifre", sifre);
            var varmi = sqlCmd.ExecuteScalar;

            Uye uye = null;

            using (var reader = sqlCmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    string tc = "";
                    string adi = "";
                    string kullanici_adi = "";
                    string ksifre = "";
                    string kcinsiyet = "";
                    DateTime tarih = DateTime.Now;
                    bool premiumMu = false;

                    tc = reader["id"].ToString();
                    adi = reader["adi"].ToString();
                    kullaniciAdi = reader["tur"].ToString();
                    ksifre = reader["yonetmen_id"].ToString();
                    kcinsiyet = reader["degerlendirme"].ToString();
                    tarih = DateTime.Parse(reader["yayin_yili"].ToString());
                    premiumMu = bool.Parse(reader["premium_kullanici_mi"].ToString());

                    if (premiumMu)
                    {
                        uye = new PremiumUye(tc, adi, kcinsiyet, tarih, kullaniciAdi, sifre);
                    }
                    else
                    {
                        uye = new StandartUye(tc, adi, kcinsiyet, tarih, kullaniciAdi, sifre);
                    }

                }
            }
            return uye;
        }
    }
}
