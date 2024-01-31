using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dedovanje
{
    internal class Ldelavec:Delavec
    {
        private double letnaPlača;

        public double LetnaPlača { get => letnaPlača; set => letnaPlača = value; }
        public new double BrutoPlača
        { 
            get
            {
                brutoPlača = letnaPlača / 12;
                return brutoPlača;
            }
        }
        public new void Izpis()
        {
            Console.WriteLine("**********LETNI DELAVEC**********");
            Console.WriteLine("ID           " + delID);
            Console.WriteLine("ime          " + ime);
            Console.WriteLine("Letna plača  " + letnaPlača);
            Console.WriteLine("Bruto plača  " + BrutoPlača);
            Console.WriteLine("***************************");
        }
    }
  
}
