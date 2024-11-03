using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi.Objeler
{
    public class IzlemeListesiYoneticisi
    {

        public void IzlemeListesineEkle(IzlemeListesi izlemeListesi)
        {
            var connection = Veritabani.baglanti;
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = new NpgsqlCommand("INSERT INTO public.izleme_listesi (film_id, uye_id, izlendi_mi) VALUES (@film_id, @uye_id, @izlendi_mi);", connection))
                        {
                            command.Parameters.AddWithValue("film_id", izlemeListesi.Film.Id);
                            command.Parameters.AddWithValue("uye_id", izlemeListesi.uye.TcKimlik);
                            command.Parameters.AddWithValue("izlendi_mi", izlemeListesi.IzlendiMi);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }

                }
                connection.Close();

            }
        }

        public void IzlemeListesindenCikar(IzlemeListesi izlemeListesi)
        {
            var connection = Veritabani.baglanti;
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = new NpgsqlCommand("DELETE FROM public.izleme_listesi WHERE id = @id;", connection))
                        {
                            command.Parameters.AddWithValue("id", izlemeListesi.Id);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            connection.Close();
        }

        public List<IzlemeListesi> IzlemeListesiGetir(string kullaniciTc)
        {
            Veritabani.baglanti.Open();
            var liste = new List<IzlemeListesi>();

            try
            {
                string query = "SELECT il.*, f.adi as filmAdi, u.* FROM izleme_listesi il JOIN film f ON il.film_id = f.id JOIN kullanici u ON il.uye_id = u.tc_kimlik_no WHERE u.tc_kimlik_no = @kullaniciTc";

                using (var command = new NpgsqlCommand(query, Veritabani.baglanti))
                {
                    command.Parameters.AddWithValue("kullaniciTc", kullaniciTc);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Assuming you have a constructor for IzlemeListesi that takes relevant parameters
                            IzlemeListesi izleme = new IzlemeListesi(
                                reader.GetInt32(reader.GetOrdinal("id")),
                                new Film(0, reader.GetString(reader.GetOrdinal("filmadi")), null, null, DateTime.Now, 0, "", 0)
                                ,
                              null,
                                reader.GetBoolean(reader.GetOrdinal("izlendi_mi"))
                            );

                            liste.Add(izleme);
                        }
                    }
                }
                return liste;

            }
            catch (Exception ex)
            {
                return new List<IzlemeListesi>();
            }
            finally
            {
                Veritabani.baglanti.Close();

            }

        }

        public void IzlendiOlarakIsaretle(IzlemeListesi izlemeListesi)
        {
            var connection = Veritabani.baglanti;
            {
                connection.Open();

                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        using (var command = new NpgsqlCommand("UPDATE public.izleme_listesi SET izlendi_mi = true WHERE id = @id;", connection))
                        {
                            command.Parameters.AddWithValue("id", izlemeListesi.Id);

                            command.ExecuteNonQuery();
                        }

                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
            connection.Close();

        }


    }
}
