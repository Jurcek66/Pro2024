using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabela_objektov
{
    internal class NogometnaLiga
    {
        //izdelaj turnir
        Moštvo[] liga = new Moštvo[10];
        int x = 0;int y = 1;
        int[] gor = { 2, 3, 4, 5 };
        int[] dol = { 9, 8, 7, 6 };
        int[,] pari = new int[10, 10];
        public void NapolniPare(int kolo)
        {
            pari[x, y] = kolo;
            for(int k=0;k<4;k++)
            {
                pari[gor[k], dol[k]] = kolo;
            }
            //zavrti za naslednje kolo
            int temp = y;//začasno shrani y
            y = dol[0];
            dol[0] = dol[1];
            dol[1] = dol[2];
            dol[2] = dol[3];
            dol[3] = gor[3];
            gor[3] = gor[2];
            gor[2] = gor[1];
            gor[1] = gor[0];
            gor[0] = temp;
        }
        public void IzdelajTurnir()
        {
            for (int kolo = 1; kolo <= 9; kolo++)
                NapolniPare(kolo);
        }

        public NogometnaLiga()
        {
            liga[0] = new Moštvo("Slovenija");
            liga[1] = new Moštvo("Nemčija  ");
            liga[2] = new Moštvo("Francija ");
            liga[3] = new Moštvo("Italija  ");
            liga[4] = new Moštvo("Španija  ");
            liga[5] = new Moštvo("Anglija  ");
            liga[6] = new Moštvo("Irska    ");
            liga[7] = new Moštvo("Albanija ");
            liga[8] = new Moštvo("Belgija  ");
            liga[9] = new Moštvo("Vatikan  ");
            IzdelajTurnir();
        }
        //testna metoda da vidimo cel turnir
        public void IzpisTurnirja()
        {
            for(int kolo=1;kolo<=9;kolo++)
            {
                Console.WriteLine(kolo+". kolo");
                for(int k=0;k<10;k++)
                {
                    for(int j=0;j<10;j++)
                    {
                        if (pari[k, j] ==kolo)
                        {
                            Console.WriteLine(liga[k].Ime+" : " + liga[j].Ime);
                        }
                    }
                }
            }
        }

        public void VnesiKolo(int kolo)
        {
            //ponovi za vse pare tega kola
            //rač izpiše prvi par kola Slovenija:Italija
            //uporabnik vnese rezulatat v obliki 2:3
            //izpiši vse ekipe
            
        }
    }
}
