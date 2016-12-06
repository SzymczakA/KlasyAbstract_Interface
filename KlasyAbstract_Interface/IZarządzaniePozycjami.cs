using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    interface IZarządzaniePozycjami
    {
        Pozycja ZnajdzPozycjePoTytule(string tytul_);
        Pozycja ZnajdzPozycjePoId(int id_);
        void WypiszWszystkiePozycje();
    }
}
