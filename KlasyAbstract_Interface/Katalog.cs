using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    class Katalog : IZarządzaniePozycjami
    {
        public Katalog() { }
        public Katalog(string dzialTematyczny_)
        {
            DzialTematyczny = dzialTematyczny_;
        }


        private string dzialTematyczny;
        private List<Pozycja> pozycje = new List<Pozycja>();

        public string DzialTematyczny
        {
            get
            {
                return dzialTematyczny;
            }

            set
            {
                dzialTematyczny = value;
            }
        }

        public void DodajPozycje(Pozycja pozycja_)
        {
            pozycje.Add(pozycja_);
        }

        public Pozycja ZnajdzPozycjePoTytule(string tytul_)
        {
            foreach (var item in pozycje)
            {
                if (item.Tytul == tytul_) return item;
            }
            return null;
        }
        public Pozycja ZnajdzPozycjePoId(int id_)
        {
            foreach (var item in pozycje)
            {
                if (item.Id == id_) return item;
            }
            return null;
        }
        public void WypiszWszystkiePozycje()
        {
            foreach (var item in pozycje)
            {
                item.WypiszInfo();
            }
        }

    }
}
