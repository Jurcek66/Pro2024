﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metode
{
    class Program
    {
        static float stanje = 0;
        static float novoStanje = 0;
        static float popravek = 0;
        static void Main(string[] args)
        {

            string odgovor;
            string seKaksenPosel;

            Console.Write("Želiš opravljati bančne posle?");
            seKaksenPosel = Console.ReadLine();
            seKaksenPosel = seKaksenPosel.ToUpper();

            while (seKaksenPosel == "DA")
            {
                Console.Write("kaj želiš ? 1 = dvig, 2 = polog, 3= stanje");
                odgovor = Console.ReadLine();
                if (odgovor == "")
                {
                    Console.WriteLine("Vnesti moraš izbiro");
                    Environment.Exit(0);
                }
                else
                 if (int.Parse(odgovor) < 1 | int.Parse(odgovor) > 3)
                {
                    Console.WriteLine(odgovor + "- ni veljaven");
                    Environment.Exit(0);
                }
                switch (int.Parse(odgovor))
                {
                    case 1:
                        Dvig();
                       
                        //Console.Write("Koliko boš položil ? ");
                        //popravek = float.Parse(Console.ReadLine());
                        //novoStanje = stanje + popravek;
                        //MessageBox.Show("Staro stanje " + stanje + "\n" +
                        //"Popravek " + popravek + "\n" +
                        //"Novo stanje " + novoStanje,
                        //"VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 2:
                        polog();
                        //Console.Write("Koliko boš dvignil ? ");
                        //popravek = float.Parse(Console.ReadLine());
                        //novoStanje = stanje - popravek;
                        //MessageBox.Show("Staro stanje " + stanje + "\n" +
                        //"Popravek -" + popravek + "\n" +
                        //"Novo stanje " + novoStanje,
                        //"VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    case 3:
                        izpisStanja();
                       // MessageBox.Show("Stanje " + stanje,
                       //"VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                stanje = novoStanje;
                Console.Write("Bi želel še kakšno transakcijo ? ");
                seKaksenPosel = Console.ReadLine();
                seKaksenPosel = seKaksenPosel.ToUpper();
            } // end while
            MessageBox.Show("Hvala, ker ste poslovali z nami ",
              "VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private static void izpisStanja()
        {
            MessageBox.Show("Stanje " + stanje,
           "VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void polog()
        {
            Console.Write("Koliko boš položil ? ");
            popravek = float.Parse(Console.ReadLine());
            novoStanje = stanje + popravek;
            MessageBox.Show("Staro stanje " + stanje + "\n" +
            "Popravek " + popravek + "\n" +
            "Novo stanje " + novoStanje,
            "VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private static void Dvig()
        {
            Console.Write("Koliko boš dvignil ? ");
            popravek = float.Parse(Console.ReadLine());
            novoStanje = stanje - popravek;
            MessageBox.Show("Staro stanje " + stanje + "\n" +
            "Popravek -" + popravek + "\n" +
            "Novo stanje " + novoStanje,
            "VSS banka", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}