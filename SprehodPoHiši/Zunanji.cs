using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Zunanji:Lokacija
    {
        private bool vroče;
        public Zunanji(string i, bool d):base(i)
        {
            vroče = d;
        }
        public new void Opis()
        {
            base.Opis();
            Console.WriteLine("Je vroče? "+vroče);
        }
    }
}
