using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kraljestvoživali
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mačka m = new Mačka();
            m.Oglašanje();
            m.izpis();
            pes p = new pes();
            p.Oglašanje();
            p.izpis();

        }
    }
}
