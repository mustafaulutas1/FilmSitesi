using FinalOdevi.Objeler;
using FinalOdevi.Objeler.Uye;
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
    public partial class DegerlendirmeYapFormu : Form
    {
        Giris girisYapan;
        Film film;
        public DegerlendirmeYapFormu(Giris girisYapan, Film film)
        {
            InitializeComponent();
            if (girisYapan.KullaniciTipi != KullaniciTipi.Premium)
            {
                MessageBox.Show("Sadece premium üyeler değerlendirme yapabilir");
                this.Close();
            }
            this.girisYapan = girisYapan;
            this.film = film;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void degerlendirmeYapButton_Click(object sender, EventArgs e)
        {
            int puan = 0;
            if (String.IsNullOrEmpty(degerlendirme_textbox.Text) || String.IsNullOrEmpty(puan_textbox.Text))

            {
                MessageBox.Show("Lütfen değerlendirme ve puanı doğru şekilde giriniz!");
                return;
            }

            if (!int.TryParse(puan_textbox.Text, out puan))
            {
                MessageBox.Show("Lütfen sadece sayısal değerler giriniz!");
                return;
            }
            if (puan < 0 || puan > 5)
            {
                MessageBox.Show("Lütfen 0 ile 5 arasında bir puan giriniz!");
                return;
            }

            var degerlendirmeYoneticisi = new DegerlendirmeYoneticisi();
            degerlendirmeYoneticisi.DegerlendirmeYap(new PremiumUye(girisYapan.TC, girisYapan.AdiSoyadi, null, DateTime.Now, null, null), film, puan, degerlendirme_textbox.Text);
            MessageBox.Show("Başarıyla değerlendirme yapıldı!");
            this.Close();
            return;

        }
    }
}
