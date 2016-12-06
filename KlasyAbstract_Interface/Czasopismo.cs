using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    class Czasopismo : Pozycja
    {
        public Czasopismo() { }
        public Czasopismo(string tytul_, int id_, string wydawictwo_, int rokWydania_, int numer_):
            base(tytul_, id_, wydawictwo_, rokWydania_)
        {
            numer = numer_;
        }


        private int numer;


        public override void WypiszInfo()
        {
            Console.WriteLine();
            Console.WriteLine(Tytul);
            Console.WriteLine(Id);
            Console.WriteLine(wydawnictwo);
            Console.WriteLine(rokWydania);
            Console.WriteLine(numer);
        }
    }
}
