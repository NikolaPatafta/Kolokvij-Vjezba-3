using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolokvij_3
{
    {
        class Program
        {
            static void Main(string[] args)
            {
                ZavrsniKoktel BlueLagoon = new  ZavrsniKoktel("Plava Laguna");
                BlueLagoon.Dodaj(new Orange_juice(0.5));
                BlueLagoon.Dodaj(new Vodka(0.4, "Smirnov"));
                BlueLagoon.Dodaj(new Apple_juice(0.4));
                BlueLagoon.Dodaj(new LED("zdrobljeni"));
                Console.WriteLine(BlueLagoon.Posluzi());


            }

        }
    }
