using FinalOdevi.Formlar;
using Npgsql;

namespace FinalOdevi
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {


            ApplicationConfiguration.Initialize();

            Application.Run(new GirisFormu());

            // admin ile değerlendirme yapınca arttırma kaldı

        }
    }
}