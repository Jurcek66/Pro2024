using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Soba:Lokacija
    {
        private string dekoracija;
        public Soba(string i, string d):base(i)
        {
            dekoracija = d;
        }
        public new void Opis()
        {
            base.Opis();
            Console.WriteLine("Vidiš "+dekoracija);
        }
    }
}
