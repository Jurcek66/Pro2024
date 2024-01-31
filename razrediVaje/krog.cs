using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razrediVaje
{
    internal class krog
    {
        private int x;
        private int y;
        private double r;
        private double premer;
        private double ploščina;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public double R { get => r; set => r = value; }
        public double Premer()
        { 
            {
                premer = r * 2;
                return premer;
            }
        }
        public double Ploščina()
        { 
            {
                ploščina = 3.14 * r * r;
                return ploščina;
            }
        }

        public krog(int xK, int yK, double rK)
        {
            x = xK;
            y = yK;
            r = rK;
        }

    }
}
