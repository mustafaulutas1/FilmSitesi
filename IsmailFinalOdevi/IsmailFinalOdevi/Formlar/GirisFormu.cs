using FinalOdevi.Formlar;
using FinalOdevi.Objeler.Uye;
using Npgsql;

namespace FinalOdevi
{
    public partial class GirisFormu : Form
    {
        public GirisFormu()
        {
            InitializeComponent();
        }

        private void button_kayitOl_Click(object sender, EventArgs e)
        {
            var kayitFormu = new KayitOlFormu();
            kayitFormu.Show();
        }

        private void button_girisYap_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciAdiTextBox.Text;
            string sifre = sifreTextBox.Text;

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }

            var connection = Veritabani.baglanti;
            connection.Open();

            string query = "SELECT tc_kimlik_no, adi_soyadi, cinsiyet, kayit_tarihi, premium_kullanici_mi " +
                           "FROM kullanici " +
                           "WHERE kullanici_adi = @kullaniciAdi AND sifre = @sifre";

            using (var command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("sifre", sifre);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string userId = reader.GetString(reader.GetOrdinal("tc_kimlik_no"));
                        string adSoyad = reader.GetString(reader.GetOrdinal("adi_soyadi"));
                        string cinsiyet = reader.GetString(reader.GetOrdinal("cinsiyet"));
                        DateTime kayitTarihi = reader.GetDateTime(reader.GetOrdinal("kayit_tarihi"));
                        bool isPremium = reader.GetBoolean(reader.GetOrdinal("premium_kullanici_mi"));

                        var giris = new Giris()
                        {
                            AdiSoyadi = adSoyad,
                            Sifre = sifreTextBox.Text,
                            KullaniciAdi = kullaniciAdi,
                            Cinsiyet = cinsiyet,
                            KullaniciTipi = isPremium ? KullaniciTipi.Premium : KullaniciTipi.Standart,
                            TC = userId
                        };
                        connection.Close();
                        var kullaniciFormu = new KullaniciFormu(giris);

                        kullaniciFormu.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("Yanlış kullanıcı adı veya şifre girdiniz!");
                    }

                }
                connection.Close();


            }
        }
    }

}
