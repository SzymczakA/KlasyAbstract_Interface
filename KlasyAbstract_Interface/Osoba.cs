using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    class Osoba
    {
        public Osoba() { }
        public Osoba(string imie_, string nazwisko_)
        {
            imie = imie_;
            nazwisko = nazwisko_;
        }

        protected string imie;
        protected string nazwisko;
    }
}
