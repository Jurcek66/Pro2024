using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedovanje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Delavec d = new Delavec();
            d.DelID = "098";
            d.Ime = "Janez Novak";
            d.UrnaPostavka = 8;
            d.ŠtUr = 176;
            d.Izpis();
            Ldelavec a = new Ldelavec();
            a.DelID = "111";
            a.Ime = "Lojze Slak";
            a.LetnaPlača = 12000;
            a.Izpis();
        }
    }
}
