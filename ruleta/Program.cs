using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ruleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stanje;
            int stava;
            int začStanje;
            int začStava;
            int štm;
            Console.WriteLine("vnesi začetni vložek.");
            začStanje = int.Parse(Console.ReadLine());
            Console.WriteLine("vnesi začetno stavo.");
            začStava = int.Parse(Console.ReadLine());
            Console.WriteLine("vnesi število metov.");
            štm = int.Parse(Console.ReadLine());
            stanje = začStanje;
            stava = začStava;
            int min=stanje;
            int max=stanje;
            string barva;
            
            Random r = new Random();
            for(int i=1;i<=štm;i++)
            {
                int kroglica = r.Next(37);
                if(kroglica%2==0)
                {
                    stanje = stanje + stava;
                    stava = začStava;
                    barva = "Rdeča";
                   if(stanje<0)
                        Console.WriteLine("MET: "+i+ " Barva: "+barva+ " Stanje "+ stanje);
                    if (stanje > max)
                        max = stanje;
                    
                }
                else
                {
                    stanje = stanje - stava;
                    stava = stava * 2;
                    barva = "Črna";
                    if(stanje<0)
                        Console.WriteLine("MET: " + i + " Barva: " + barva + " Stanje "+ stanje);
                    if (min > stanje)
                        min = stanje;
                }
            }
            Console.WriteLine("št metov: "+štm);
            Console.WriteLine("začetno stanje: " + začStanje);
            Console.WriteLine("Končno stanje: " + stanje);
            Console.WriteLine("Max stanje: "+max);
            Console.WriteLine("Min stanje: "+min);
            if((stanje-začStanje)>=0)
            {
                Console.WriteLine("dobiček:" + (stanje - začStanje));
            }
            else
            {
                Console.WriteLine("izguba:" + (stanje - začStanje));
            }


            

        }
    }
}
