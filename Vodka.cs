using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij_3
{
    class Vodka : Sastojak
    {
        public Vodka(double volumen, string opis)
        {
            this.volumen = volumen;
            this.opis = "vodka " + opis;
           
        }

        public override string Prikazi()
        {
            return String.Format("{0}dcl {1}", VratiDecilitre()/*volumen(?)*/, opis);
        }
    }
}
}
