using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajerazredi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            točka t1 = new točka(1.0, 1.0);
            t1.Izpis();
            točka t2 = new točka(1.0, 180);
            t2.Izpis();
        }
    }
}
