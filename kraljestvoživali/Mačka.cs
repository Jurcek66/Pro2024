using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kraljestvoživali
{
    internal class Mačka : žival, IGovor
    {
        public string Govor()
        {
            return "Mijav";
        }
        public Mačka()
        {
            opis = "Mačka";
            ime = "muri";
        }
        public void izpis()
        {
            Console.WriteLine("Žival: "+opis);
            Console.WriteLine("ime: "+ime);
        }
    }
}
