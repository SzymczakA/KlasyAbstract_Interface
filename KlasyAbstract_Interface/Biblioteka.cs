using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    class Biblioteka
    {
        public Biblioteka() { }
        public Biblioteka(string adres_)
        {
            adres = adres_;
        }


        private string adres;
        private List<Katalog> katalogi = new List<Katalog>();
        private List<Bibliotekarz> bibliotekarze = new List<Bibliotekarz>();


        public void DodajBibliotekarza(Bibliotekarz bibliotekarz_)
        {
            bibliotekarze.Add(bibliotekarz_);
        }
        public void WypiszBibliotekarzy()
        {
            foreach (var item in bibliotekarze)
            {
                item.WypiszInfo();
            }
        }
        public void DodajKatalog(Katalog katalog_)
        {
            katalogi.Add(katalog_);
        }
        public void DodajPozycje(Pozycja p,string dzialematyczny_)
        {
            foreach (var item in katalogi)
            {
                if (item.DzialTematyczny == dzialematyczny_) item.DodajPozycje(p);
            }
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul_)
        {
            foreach (var item in katalogi)
            {
                if (item.ZnajdzPozycjePoTytule(tytul_) != null) return item.ZnajdzPozycjePoTytule(tytul_);
            }
            return null;
        }
        public Pozycja ZnajdzPozycjePoId(int id_)
        {
            foreach (var item in katalogi)
            {
                if (item.ZnajdzPozycjePoId(id_) != null) return item.ZnajdzPozycjePoId(id_);
            }
            return null;
        }
        public void WypiszWszystkiePozycje()
        {
            foreach (var item in katalogi)
            {
                item.WypiszWszystkiePozycje();
            }
        }

    }
}
