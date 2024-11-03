using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalOdevi
{
    public static class Veritabani
    {

        public static NpgsqlConnection baglanti = new NpgsqlConnection("Server=192.168.1.13;Port=5432;Database=film_yonetim_sistemi;User Id = postgres; Password=123456");
    }
}
