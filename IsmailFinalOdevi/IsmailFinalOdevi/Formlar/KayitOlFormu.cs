using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalOdevi.Formlar
{
    public partial class KayitOlFormu : Form
    {
        public KayitOlFormu()
        {
            InitializeComponent();
            erkekRadio.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string adSoyad = adsoyadTextbox.Text;
            string tc = tcTextbox.Text;
            DateTime dogumTarihi = dogumTarihiTextbox.Value;
            bool isPremium = premiumUyelikRadio.Checked;
            bool isNormal = normalUyelikRadio.Checked;
            bool isErkek = erkekRadio.Checked;
            bool isKadin = kadinRadio.Checked;
            string kullaniciAdi = kullaniciAdi_textbox.Text;
            string sifre = sifreTextbox.Text;

            if (string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(tc) || dogumTarihi == DateTime.MinValue
                || string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }

            var connection = Veritabani.baglanti;
            connection.Open();

            string query = "INSERT INTO kullanici (tc_kimlik_no, adi_soyadi, kayit_tarihi, cinsiyet, kullanici_adi, sifre, premium_kullanici_mi) " +
                           "VALUES (@tc, @adSoyad, @kayitTarihi, @cinsiyet, @kullaniciAdi, @sifre, @premiumKullaniciMi)";

            using (var command = new NpgsqlCommand(query, connection))
            {
                try
                {
                    command.Parameters.AddWithValue("tc", tc);
                    command.Parameters.AddWithValue("adSoyad", adSoyad);
                    command.Parameters.AddWithValue("kayitTarihi", DateTime.Now);

                    if (isErkek)
                    {
                        command.Parameters.AddWithValue("cinsiyet", "Erkek");
                    }
                    else if (isKadin)
                    {
                        command.Parameters.AddWithValue("cinsiyet", "Kadin");
                    }
                    else
                    {
                        command.Parameters.AddWithValue("cinsiyet", "Erkek");
                    }

                    command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                    command.Parameters.AddWithValue("sifre", sifre);

                    command.Parameters.AddWithValue("premiumKullaniciMi", isPremium);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

            }
            connection.Close();
            MessageBox.Show("Başarıyla kayıt olundu! Şimdi lütfen giriş yapınız!");
            this.Close();
        }

    }

}
