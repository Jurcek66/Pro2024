using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naštevni_tipi_naloga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int tip;
            int minute;
            double znesek;
            Console.WriteLine("povejte tip klica (mobilno omrežje je 1, stacionarno omrežje 2)");
            tip = int.Parse(Console.ReadLine());
            Console.WriteLine("povejte število minut: ");
            minute = int.Parse(Console.ReadLine());
            if((TipKlica)tip==TipKlica.KlicVMobilno)
            {
                znesek = minute * 0.03;
                Console.WriteLine(znesek+"€");
            }
            else
            {
                znesek = minute * 0.2;
                Console.WriteLine(znesek+"€");
            }
            */

            Random r = new Random();
            int barva=r.Next(3);
            int vrednost=r.Next(12);
            Console.WriteLine((karte)vrednost+" "+(barva)barva);




        }
    }
}
