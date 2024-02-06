using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajaABS
{
    internal abstract class DelavecBazni
    {
        protected string delID;
        protected string ime;
        protected double brutoPlača;
        public DelavecBazni(string d, string i)
        {
            delID = d;
            ime = i;

        }
        public DelavecBazni()
        {

        }

        public string DelID { get => delID; set => delID = value; }
        public string Ime { get => ime; set => ime = value; }
        public abstract double BrutoPlača { get; }
        public abstract void Izpis();
    }
}
