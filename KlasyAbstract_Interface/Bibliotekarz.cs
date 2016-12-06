using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    class Bibliotekarz : Osoba
    {
        public Bibliotekarz() { }
        public Bibliotekarz(string imie_, string nazwisko_, string dataZatrudnienia_, double wynagrodzenie_):
            base(imie_, nazwisko_)
        {
            dataZatrudnienia = dataZatrudnienia_;
            wynagrodzenie = wynagrodzenie_;
        }


        private string dataZatrudnienia;
        private double wynagrodzenie;


        public void WypiszInfo()
        {
            Console.WriteLine("Bibliotekarz: " + imie + " " + nazwisko);
            Console.WriteLine(dataZatrudnienia);
            Console.WriteLine(wynagrodzenie);
        }
    }
}
