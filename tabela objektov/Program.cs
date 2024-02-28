using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabela_objektov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Moštvo a = new Moštvo("Slovenija");
            //Moštvo b = new Moštvo("Nemčija  ");
            //a.VpisRezultata(2, 0);
            //b.VpisRezultata(0, 2);
            //Console.WriteLine(a.Izpis());
            //Console.WriteLine(b.Izpis());
            //Console.WriteLine("Je Slovenija boljša od Nemčije? "+a.BoljšaEkipa(b));
            //Console.ReadLine();

            //int numTeams = 10;
            //string[] teams = new string[10] { "Team 1", "Team 2", "Team 3", "Team 4", "Team 5", "Team 6", "Team 7", "Team 8", "Team 9", "Team 10" };

            //Console.WriteLine("Round Robin Schedule:");
            //Console.WriteLine();

            //for (int i = 0; i < numTeams - 1; i++)
            //{
            //    Console.WriteLine("Round " + (i + 1));
            //    Console.WriteLine("------------");

            //    for (int j = 0; j < numTeams / 2; j++)
            //    {
            //        int team1Index = j;
            //        int team2Index = (numTeams - 1 - j + i) % (numTeams - 1);
            //        if (j == 0)
            //        {
            //            Console.WriteLine($"{teams[team1Index]} vs {teams[team2Index]}");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{teams[team2Index]} vs {teams[team1Index]}");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            NogometnaLiga a = new NogometnaLiga();
            a.IzpisTurnirja();
            Console.WriteLine("vpiši rezulata");
            
     

        }
    }
}
