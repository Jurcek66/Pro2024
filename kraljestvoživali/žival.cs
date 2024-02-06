using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kraljestvoživali
{
    internal class žival
    {
        protected string opis;//mačka, pes, konj ...
        protected string ime;
        public void Oglašanje()
        {
            string glas = ((IGovor)this).Govor();
            Console.WriteLine(glas);
        }
    }
}
