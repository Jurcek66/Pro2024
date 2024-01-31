using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razrediVaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            krog k = new krog(37, 45, 2.5f);
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.R);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploščina());
            k.X = 2;
            k.Y = 2;
            k.R = 4.25f;
            Console.WriteLine("Nova pozicija :");
            Console.WriteLine("X koordinata = " + k.X +
            "\nY koordinata = " + k.Y +
            "\nRadij =" + k.R);
            Console.WriteLine("Premer = " + k.Premer());
            Console.WriteLine("Plošcina =" + k.Ploščina());
            Console.ReadLine();

        }
    }
}
