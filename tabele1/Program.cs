using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tabele1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] b = new int[10];
            //int[] b = { 80, 3, 7, 9, 1, 5, 6, 84, 15 };
            //int[] a = new int[50000];
            //Random r = new Random();
            //for (int i = 0; i < a.Length; i++)
            //    a[i] = r.Next(100000);
            ///*
            //  //a[2 * 3 + 5] = 22;
            //  for(int i=0; i<a.Length;i++)
            //      Console.WriteLine(a[i]+"\t");
            //  //izračunaj vsote elementov v tabeli a
            //  Console.WriteLine();
            //  int vsota = 0;
            //  for(int i=0;i<a.Length;i++)
            //  {
            //      vsota += a[i];
            //  }
            //  Console.WriteLine("Vsota je "+vsota);
            //  //izračunaj minimum
            //  int minimum = a[0];
            //  int imin = 0;
            //  for(int i=1;i<a.Length;i++)
            //  {
            //      if (a[i]<minimum)
            //      {
            //          minimum = a[i];
            //          imin = i;
            //      }
            //  }
            //  Console.WriteLine("Najmanjši je "+minimum);
            //  Console.WriteLine("Je na "+imin+". mestu");
            //  //kako naj zamenjam 0-ti element in 5-ti element tabele
            //  for (int i = 0; i < a.Length; i++)
            //  {
            //      Console.WriteLine(a[i] + "\t");
            //  }
            //  int x;
            //  x = a[0];
            //  a[0] = a[5];
            //  a[5] = x;
            //  for(int i=0;i<a.Length;i++)
            //  {
            //      Console.WriteLine(a[i]+"\t");
            //  }
            //  //Console.WriteLine(a[0]+" + " + a[5]);
            //*/

            ////urejanje z izbiranjem


            //// Console.WriteLine("neurejena ");
            ////Izpiši(a);
            //DateTime pred = DateTime.Now;
            //for (int k = 0; k < a.Length-1; k++)
            //{
            //    int min = a[k];
            //    int imin = k;
            //    for (int i = k+1; i < a.Length; i++)
            //    {
            //        if (a[i] < min)
            //        {
            //            min = a[i];
            //            imin = i;
            //        }
            //    }
            //    //zamenjava
            //    int temp = a[k];
            //    a[k] = a[imin];
            //    a[imin] = temp;
            //  //  Console.WriteLine("urejena ");
            //    //Izpiši(a);

            //}
            //DateTime potem = DateTime.Now;
            //double čas = (potem - pred).TotalMilliseconds;
            //Console.WriteLine(čas);
            ////z vstavljanjem

            //for (int i = 0; i < a.Length; i++)
            //    a[i] = r.Next(100000);
            //pred = DateTime.Now;
            //for (int i=0;i<a.Length;i++)
            //{
            //    int j = i;
            //    int temp = a[i];
            //    //pogrezni i-ti element na pravo mesto v tabeli od a[0] do a[k-1]
            //    //element sodi na mesto j
            //    while (j>0 && a[j-1]>temp)
            //    {
            //        a[j] = a[j - 1];
            //        j--;
            //    }
            //    a[j] = temp;
            //    //Izpiši(a);
            //}
            //potem = DateTime.Now;
            //čas = (potem - pred).TotalMilliseconds;
            //Console.WriteLine(čas);
            int[] a = new int[10];
            int[] a = { 80, 3, 7, 9, 1, 5, 6, 84, 15 };
            int x;
            for(int i=0;i<a.Length;i++)
            {
                for(int k=0;k<a.Length-2;k++)
                {
                    if (a[k] < a[k+1])
                    {
                        x = a[k + 1];
                        a[k + 1] = a[k];
                        a[k] = x;
                    }
                }
            }


        }
        static void Izpiši(int[] tab)
        {
            for(int i=0;i<tab.Length;i++)
                Console.Write(tab[i]+"\t");
            Console.WriteLine();
        }
    }
}
