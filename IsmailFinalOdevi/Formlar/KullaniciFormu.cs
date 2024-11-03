using FinalOdevi.Objeler;
using FinalOdevi.Objeler.Uye;
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
    public partial class KullaniciFormu : Form
    {


        public IzlemeListesiYoneticisi izlemeYoneticisi = new IzlemeListesiYoneticisi();
        public FilmListeleyicisi filmListeleyicisi = new FilmListeleyicisi();
        public DegerlendirmeYoneticisi degerlendirmeYoneticisi = new DegerlendirmeYoneticisi();
        public Giris girisYapanKullanici;
        public KullaniciFormu(Giris girisYapan)
        {
            InitializeComponent();
            girisYapanKullanici = girisYapan;
            kullaniciAdi_textbox.Text = girisYapanKullanici.KullaniciAdi;
            adsoyad_textbox.Text = girisYapanKullanici.AdiSoyadi;
            tc_textbox.Text = girisYapanKullanici.TC;
            sifre_textbox.Text = girisYapanKullanici.Sifre;
            if (girisYapanKullanici.Cinsiyet == "Erkek")
            {
                erkek_radio.Checked = true;
            }
            else
            {
                kadin_radio.Checked = true;
            }
            uyelikUcreti_label.Text = girisYapanKullanici.KullaniciTipi == KullaniciTipi.Standart ? "100" : "200";
            uyelikTipiLabel.Text = girisYapanKullanici.KullaniciTipi == KullaniciTipi.Standart ? "Standart" : "Premium";

        }

        private void KullaniciFormu_Load(object sender, EventArgs e)
        {

            var filmler = filmListeleyicisi.FilmleriGetir();

            var izlemeListesi = izlemeYoneticisi.IzlemeListesiGetir(girisYapanKullanici.TC);

            var sonFilm = filmler.OrderByDescending(x => x.Id).FirstOrDefault();


            notifyIcon1.BalloonTipTitle = "Son filmlerimize gözatın!";
            notifyIcon1.BalloonTipText = sonFilm.Adi + " adlı filmi hemen izleyin!";
            notifyIcon1.Icon = SystemIcons.Warning;
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(2000);


            foreach (var film in izlemeListesi)
            {
                izlemeListesi_datagrid.Rows.Add(film.Id, film.Film.Adi, film.IzlendiMi ? "İzlendi" : "İzlenmedi");

            }


            foreach (var film in filmler)
            {
                filmListesi_datagrid.Rows.Add(film.Id, film.Adi, film.Tur, film.YayinlanmaYili, film.DegerlendirmePuani, film.Yonetmen.AdiSoyadi);
            }

        }

        private void filmListesi_datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void izlemeyeEkle_button_Click(object sender, EventArgs e)
        {

            if (filmListesi_datagrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }

            var a = filmListesi_datagrid.SelectedRows[0];
            if (a == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }


            // dinamik olarak alıyoruz istediğimiz özelliklere erişmek için
            var filmId = a.Cells[0].Value as int?;
            if (filmId == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }

            var ekle = new IzlemeListesi(0, new Film(filmId ?? 0, null, null, null, DateTime.Now, 0, null, 0), new StandartUye(girisYapanKullanici.TC, girisYapanKullanici.AdiSoyadi, null, DateTime.Now, null, null), false);

            izlemeYoneticisi.IzlemeListesineEkle(ekle);

            MessageBox.Show("Başarıyla Eklendi");

            var filmler = filmListeleyicisi.FilmleriGetir();

            var izlemeListesi = izlemeYoneticisi.IzlemeListesiGetir(girisYapanKullanici.TC);


            izlemeListesi_datagrid.Rows.Clear();
            filmListesi_datagrid.Rows.Clear();

            foreach (var film in izlemeListesi)
            {
                izlemeListesi_datagrid.Rows.Add(film.Id, film.Film.Adi, film.IzlendiMi ? "İzlendi" : "İzlenmedi");

            }

            foreach (var film in filmler)
            {
                filmListesi_datagrid.Rows.Add(film.Id, film.Adi, film.Tur, film.YayinlanmaYili, film.DegerlendirmePuani, film.Yonetmen.AdiSoyadi);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnalizFormu yeniForm = new AnalizFormu();
            yeniForm.Show();
        }

        private void detay_button_Click(object sender, EventArgs e)
        {
            if (filmListesi_datagrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }

            var a = filmListesi_datagrid.SelectedRows[0];
            if (a == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }


            // dinamik olarak alıyoruz istediğimiz özelliklere erişmek için
            var filmId = a.Cells[0].Value as int?;
            if (filmId == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }


            var film = filmListeleyicisi.FilmGetir(filmId ?? 0);

            var detayFormu = new FilmDetayFormu(film);
            detayFormu.Show();



        }

        private void izlenmeCikar_button_Click(object sender, EventArgs e)
        {




        }

        private void listedenKaldir_button_Click(object sender, EventArgs e)
        {
            if (izlemeListesi_datagrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }

            var a = izlemeListesi_datagrid.SelectedRows[0];
            if (a == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }


            // dinamik olarak alıyoruz istediğimiz özelliklere erişmek için
            var filmId = a.Cells[0].Value as int?;
            if (filmId == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }


            izlemeYoneticisi.IzlemeListesindenCikar(new IzlemeListesi(filmId ?? 0, null, null, false));

            MessageBox.Show("Başarıyla Kaldırıldı");

            var filmler = filmListeleyicisi.FilmleriGetir();

            var izlemeListesi = izlemeYoneticisi.IzlemeListesiGetir(girisYapanKullanici.TC);


            izlemeListesi_datagrid.Rows.Clear();
            filmListesi_datagrid.Rows.Clear();

            foreach (var film in izlemeListesi)
            {
                izlemeListesi_datagrid.Rows.Add(film.Id, film.Film.Adi, film.IzlendiMi ? "İzlendi" : "İzlenmedi");

            }

            foreach (var film in filmler)
            {
                filmListesi_datagrid.Rows.Add(film.Id, film.Adi, film.Tur, film.YayinlanmaYili, film.DegerlendirmePuani, film.Yonetmen.AdiSoyadi);
            }

        }

        private void izlendiIsaretle_button_Click(object sender, EventArgs e)
        {


            if (izlemeListesi_datagrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }

            var a = izlemeListesi_datagrid.SelectedRows[0];
            if (a == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }


            // dinamik olarak alıyoruz istediğimiz özelliklere erişmek için
            var filmId = a.Cells[0].Value as int?;
            if (filmId == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }


            izlemeYoneticisi.IzlendiOlarakIsaretle(new IzlemeListesi(filmId ?? 0, null, null, false));

            MessageBox.Show("Başarıyla İşaretlendi");

            var filmler = filmListeleyicisi.FilmleriGetir();

            var izlemeListesi = izlemeYoneticisi.IzlemeListesiGetir(girisYapanKullanici.TC);


            izlemeListesi_datagrid.Rows.Clear();
            filmListesi_datagrid.Rows.Clear();

            foreach (var film in izlemeListesi)
            {
                izlemeListesi_datagrid.Rows.Add(film.Id, film.Film.Adi, film.IzlendiMi ? "İzlendi" : "İzlenmedi");

            }

            foreach (var film in filmler)
            {
                filmListesi_datagrid.Rows.Add(film.Id, film.Adi, film.Tur, film.YayinlanmaYili, film.DegerlendirmePuani, film.Yonetmen.AdiSoyadi);
            }


        }

        private void degerlendirmeYap_button_Click(object sender, EventArgs e)
        {

            if (girisYapanKullanici.KullaniciTipi != KullaniciTipi.Premium)
            {
                MessageBox.Show("Sadece premium üyeler değerlendirme yapabilir!");
                return;
            }

            if (filmListesi_datagrid.SelectedRows.Count <= 0)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }

            var a = filmListesi_datagrid.SelectedRows[0];
            if (a == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }


            // dinamik olarak alıyoruz istediğimiz özelliklere erişmek için
            var filmId = a.Cells[0].Value as int?;
            if (filmId == null)
            {
                MessageBox.Show("Lütfen bir film seçiniz!");
                return;
            }

            var film = new Film(filmId ?? 0, null, null, null, DateTime.Now, 0, null, 0);

            var degerlendirmeFormu = new DegerlendirmeYapFormu(girisYapanKullanici, film);
            degerlendirmeFormu.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adSoyad = adsoyad_textbox.Text;
            string kullaniciAdi = kullaniciAdi_textbox.Text;
            string sifre = sifre_textbox.Text;
            bool isErkek = erkek_radio.Checked;
            bool isKadin = kadin_radio.Checked;

            if (string.IsNullOrEmpty(adSoyad) || string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz!");
                return;
            }


            Veritabani.baglanti.Open();

            string query = "UPDATE kullanici SET adi_soyadi = @adSoyad, kullanici_adi = @kullaniciAdi, sifre = @sifre, cinsiyet = @cinsiyet WHERE tc_kimlik_no = @userId";

            using (var command = new NpgsqlCommand(query, Veritabani.baglanti))
            {
                command.Parameters.AddWithValue("adSoyad", adSoyad);
                command.Parameters.AddWithValue("kullaniciAdi", kullaniciAdi);
                command.Parameters.AddWithValue("sifre", sifre);

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


                command.Parameters.AddWithValue("userId", girisYapanKullanici.TC);

                command.ExecuteNonQuery();
            }

            Veritabani.baglanti.Close();
            MessageBox.Show("Başarıyla Güncellendi!");

        }

        private void ara_btn_Click(object sender, EventArgs e)
        {
            string ara = ara_textbox.Text;
            if (String.IsNullOrEmpty(ara))
            {
                MessageBox.Show("Lütfen aranacak bir metin giriniz!");
                return;
            }
            filmListesi_datagrid.Rows.Clear();

            var filmListesi = filmListeleyicisi.FilmAra(ara);

            foreach (var film in filmListesi)
            {
                filmListesi_datagrid.Rows.Add(film.Id, film.Adi, film.Tur, film.YayinlanmaYili, film.DegerlendirmePuani, film.Yonetmen.AdiSoyadi);

            }
        }
    }
}
