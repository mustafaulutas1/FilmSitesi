using FinalOdevi.Objeler;
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
    public partial class FilmDetayFormu : Form
    {
        Film film;
        public FilmDetayFormu(Film film)
        {
            this.film = film;
            InitializeComponent();


        }

        private void FilmDetayFormu_Load(object sender, EventArgs e)
        {
            filmAdi_label.Text = film.Adi;
            filmTuru_label.Text = film.Tur;
            degerlendirmePuani_label.Text = film.DegerlendirmePuani.ToString();
            degerlendirmeSayisi_label.Text = film.DegerlendirmeSayisi.ToString();
            yayinYili_label.Text = film.YayinlanmaYili.Year.ToString();
            yonetmen_label.Text = film.Yonetmen.AdiSoyadi.ToString();

            var degerlendirmeYoneticisi = new DegerlendirmeYoneticisi();


            var degerlendirmeler = degerlendirmeYoneticisi.FilminDegerlendirmeleriniGetir(film);

            foreach (var item in degerlendirmeler)
            {

                dataGridView1.Rows.Add(item.YapanAdiSoyadi, item.Puan, item.Mesaj);
            }


            //var oyuncularStr = "";

            //foreach (var oyuncu in film.Oyuncular)
            //{
            //    oyuncularStr += oyuncu.AdiSoyadi + " , ";

            //}

            //oyuncular_label.Text = oyuncularStr;

        }
    }
}
