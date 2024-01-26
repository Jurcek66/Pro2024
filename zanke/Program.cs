using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace zanke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* //dvigale ki se ustavi v vsakem nadstropju
             Console.WriteLine("dvigalo se usstavi ... ");
             int k = 0;           
             for(k=10;k>=0;k--)
             {
                 Console.WriteLine(k+". nadstropju");
             }
             //samo liha nadstropja
             Console.WriteLine("liha");
             for(k=1;k<=10;k=k+2)
             {
                 Console.WriteLine(k + ". nadstropju");
             }*/
            /*for (int k =10;k>=10;k++)
             {
                 Console.WriteLine(k);
             }
            */
            /* Console.WriteLine("vnesi karkoli, K=konec");
             string vnos = Console.ReadLine();
             Random r = new Random();
             do
             {
                 int prvo = r.Next(1, 11);
                 int drugo = r.Next(1, 11);
                 Console.WriteLine(prvo + "x" + drugo + " = ");
                 int rešitev = int.Parse(Console.ReadLine());
                 if (prvo * drugo == rešitev)
                 {
                     Console.WriteLine("Pravilno");
                 }
                 else
                 {
                     Console.WriteLine("Napačno");
                 }
                 Console.WriteLine("Nadaljujem? K=konec");
                 vnos = Console.ReadLine();

             } while (vnos.ToUpper() != "K");*/
            //prva
            /*  int min = int.MaxValue;
              int x;
              for (int k = 1; k <= 10; k++)
              {
                  Console.WriteLine("vpiši število: ");
                  x = int.Parse(Console.ReadLine());
                  if (min > x)
                      min = x;
              }
              Console.WriteLine("najmanjše število je:" + min);*/
            /* //druga
              Random r = new Random();
              //Število = r.Next(100); // v spremenljivki število je naključno število med 0 in 99
              int vsota = 0;

              for(int i=1;i<=100;i++)
              {
                  vsota = vsota + r.Next(100);
                  Console.WriteLine(vsota);
              }
              Console.WriteLine(vsota); */
            //tretja
            /* Random r = new Random();
             int sum = 0;
             int avg;
             for (int i=1;i<=1000;i++)
             {
                 sum = sum + r.Next(1000);
             }
             avg = sum / 1000;
             Console.WriteLine(avg);*/

            //četrta
            /* float sumZneskov = 0;
             float posamezenznesek;
             float posamezneobr = 0;
             float skupneobr = 0;
             Random r = new Random();
             for (int i=1;i<=100000;i++)
             {
                 posamezenznesek = r.Next(1000000);
                 sumZneskov += posamezenznesek;
                 posamezneobr = (float)(posamezneobr + posamezenznesek * 0.023);
             }
             skupneobr = (float)(sumZneskov * 0.023);
             Console.WriteLine("Skupne obresti: "+skupneobr);
             Console.WriteLine("Posamezne obresti: "+posamezneobr);
            */
           /* 
            double r1 = 20;
            double r2 = -13.6667;
            double r3 = 17;
            double r4 = 12.88;
            double r5 = 2222.879;
            Console.WriteLine("{0,20:f2}", r1);
            Console.WriteLine("{0,20:f2}", r2);
            Console.WriteLine("{0,20:f2}", r3);
            Console.WriteLine("{0,20:f2}", r4);
            Console.WriteLine("{0,20:f2}", r5);
            */
            Console.WriteLine((int)'+');




        }
    }
}
