using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij_3
{
    class ZavrsniKoktel
    {
        static List<Sastojak> sastojci = new List<Sastojak>();

        private string naziv;

        public ZavrsniKoktel(string naziv)
        {
            this.naziv = naziv;
        }
        public void Dodaj(Sastojak s)
        {
            sastojci.Add(s);
        }


        public string Posluzi()
        {
            string koktelcic = "Posluzujem koktel " + naziv + "\nSastojci: (" + sastojci.Count() + ")\n";
            double izracun = 0;

            foreach (Sastojak s in sastojci)
            {
                koktelcic += s.Prikazi() + "\n";
                izracun += s.VratiDecilitre();
            }

            return String.Format(koktelcic + "Potrebna casa minimalno dcl: " + izracun);
        }
    }
}

