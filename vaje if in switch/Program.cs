using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaje_if_in_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            int a, b, c;
            Console.WriteLine("podaj velikost stranice a: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj velikost stranice b: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("podaj velikost stranice c: ");
            c = int.Parse(Console.ReadLine());

            if(a+b>c)
                if(a+c>b)
                    if(b+c>a)
                        Console.WriteLine("Trikotnik obstaja");
            else
                        Console.WriteLine("trikotnik ne obstaja");
            */
            int stevilo;
            Console.WriteLine("vnesi trimestno število: ");
            stevilo = int.Parse(Console.ReadLine());
            int stototice = stevilo / 100;
            int desetice = (stevilo / 10) / 10;
            int enice = stevilo % 10;

            if(stototice%2==0 && desetice%2==0 &&enice%2==0)
            {
                Console.WriteLine("stevila so soda");
            }
            else if(stototice % 2 == 1 && desetice % 2 == 1 && enice % 2 == 1)
            {
                Console.WriteLine("števila so liha");
            }
            else
            {
                Console.WriteLine("števila so soda in liha");
            }

        }
    }
}
