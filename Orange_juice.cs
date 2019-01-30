using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij_3
{
    class Orange_juice : Sastojak
    {
        public Orange_juice(double kol)
        {
            porcija = 2.5;
            volumen = kol * porcija;
            this.opis = "Orange Juice " + opis;
        }

        public override string Prikazi()
        {
            return String.Format("{0} {1}", volumen / porcija, opis);
        }
    }
}
