using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    class Ksiazka : Pozycja
    {
        public Ksiazka() { }
        public Ksiazka(string tytul_, int id_, string wydawictwo_, int rokWydania_, int liczbaStron_)
            :base(tytul_, id_, wydawictwo_, rokWydania_)
        {
            liczbastron = liczbaStron_;
        }


        private int liczbastron;
        private List<Autor> autorzy= new List<Autor>();


        public void DodajAutora(Autor autor_)
        {
            autorzy.Add(autor_);
        }
        public override void WypiszInfo()
        {
            Console.WriteLine();
            Console.WriteLine(Tytul);
            Console.WriteLine(Id);
            Console.WriteLine(wydawnictwo);
            Console.WriteLine(rokWydania);
            Console.WriteLine(liczbastron);
            foreach (var item in autorzy)
            {
                item.WypiszInfo();
            }
        }
    }
}
