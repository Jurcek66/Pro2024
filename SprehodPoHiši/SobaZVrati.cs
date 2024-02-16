using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class SobaZVrati : Soba, IZunanjaVrata
    {
        public Lokacija blok;
        string vrata;
        public SobaZVrati(string i, string d, string v) : base(i, d)
        {
            vrata = v;

        }

        public Lokacija lokacijaVrat()
        {
            
            return blok;
        }

        public string OpisVrat()
        {
            return vrata;
        }
    }
}
