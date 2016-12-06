using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    class Autor : Osoba
    {
        public Autor() { }
        public Autor(string imie_, string nazwisko_, string narodowosc_) :
            base(imie_, nazwisko_)
        {
            narodowosc = narodowosc_;
        }


        private string narodowosc;
        private List<Ksiazka> książki = new List<Ksiazka>();


        public void WypiszInfo()
        {
            Console.WriteLine("Autor: " + imie + " " + nazwisko + " - " + narodowosc);
        }
    }
}
