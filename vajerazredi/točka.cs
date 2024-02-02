using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajerazredi
{
    internal class točka
    {
        private double x;
            private double y;
            private double r;
        private int fi;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public double R { get => r; set => r = value; }

        public void pretvoriVPolarne()
        {
            //x, y poznam... računam r in fi
            r = Math.Sqrt(x * x + y * y);
            fi = (int)(Math.Atan(y / x) * 180 / Math.PI);
        }
        public void PretvotiVkartezične()
        {
            //r in fi poznam, računam x in y
            x = r * Math.Cos(fi * Math.PI / 180);
            y =Math.Round(r * Math.Sin(fi * Math.PI / 180));
         
        }
        public točka(double x1, double y1)
        {
            x = x1;y = y1;
            pretvoriVPolarne();
        }
        public točka(double r1, int fi1)
        {
            r = r1;fi = fi1;
            PretvotiVkartezične();
        }
        public void Izpis()
        {
            Console.WriteLine("kartezične ("+x+", "+y+")");
            Console.WriteLine("polarne (" + r + ", " + fi + "°)");
        }
    }
}
