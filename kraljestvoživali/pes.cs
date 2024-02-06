using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kraljestvoživali
{
    internal class pes : žival, IGovor
    {
        public string Govor()
        {
            return "hov";
        }
        public pes()
        {
            opis = "Pes";
            ime = "fido";
        }
        public void izpis()
        {
            Console.WriteLine("Žival: " + opis);
            Console.WriteLine("ime: " + ime);
        }
    }
}
