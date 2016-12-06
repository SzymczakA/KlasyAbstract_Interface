using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasyAbstract_Interface
{
    abstract class Pozycja
    {
        public Pozycja() { }
        public Pozycja(string tytul_, int id_, string wydawnictwo_,int rokWydania_)
        {
            Tytul = tytul_;
            Id = id_;
            wydawnictwo = wydawnictwo_;
            rokWydania = rokWydania_;
        }


        protected string tytul;
        protected int id;
        protected string wydawnictwo;
        protected int rokWydania;


        public string Tytul
        {
            get
            {
                return tytul;
            }

            set
            {
                tytul = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }



        public abstract void WypiszInfo();

    }
}
