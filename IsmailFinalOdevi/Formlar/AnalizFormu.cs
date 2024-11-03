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
    public partial class AnalizFormu : Form
    {
        public Analiz analiz;
        public AnalizFormu()
        {
            InitializeComponent();
            this.analiz = new Analiz();
        }

        private void AnalizFormu_Load(object sender, EventArgs e)
        {
            enCokDegerlendirilenFilmLabel.Text = analiz.EnCokDegerlendirilenFilm.Adi + " ,Değerlendirme Sayısı " + analiz.EnCokDegerlendirilenFilm.DegerlendirmeSayisi;
            enYuksekPuanliFilmLabel.Text = analiz.EnYuksekPuanliFilm.Adi + " ,Puanı : " + analiz.EnYuksekPuanliFilm.DegerlendirmePuani;

        }
    }
}
