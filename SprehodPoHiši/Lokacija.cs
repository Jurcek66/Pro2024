using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Lokacija
    {
        public string ime;
        public Lokacija[] izhodi;
        public Lokacija(string i)
        {
            ime = i;
            Lokacija l;
            string vrata;
        }
        public string Opis()
        {
            string s = "";
            s += "Trenutno so v " + ime + "\n";
            s += " Od tod lahko greš: \n";
            for(int k=0;k<izhodi.Length;k++)
            {
                s += k + "-" + izhodi[k].ime + "\n";
            }
            return s;
        }
        

    }
}
