using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij_3
{
    class Apple_juice : Sastojak
    {
        {
        public Apple_juice(double kol)
        {
            porcija = 0.4;
            opis = "Apple Juice ";
            volumen = porcija * kol;
        }

        public override string Prikazi()
        {
            return String.Format("{0} {1}", volumen / porcija, opis);
        }
    }
}
