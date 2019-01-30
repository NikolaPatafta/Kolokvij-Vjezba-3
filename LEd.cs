using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij_3
{
    class LED : Sastojak
    {
        public LED(string opis)
        {
            this.opis = "Led " + opis;
            volumen = 1;
        }

        public override string Prikazi()
        {
            return opis;
        }
    }
}
