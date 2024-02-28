using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabela_objektov
{
    internal class Moštvo
    {
        string ime;
        int stZmag;
        int stNeodlocenih;
        int stPorazov;
        int daniGoli;
        int prejetiGoli;
        int stTekem;

        public string Ime { get => ime; set => ime = value; }

        public Moštvo(string i)
        {
            ime = i;
            stZmag = 0;stNeodlocenih = 0;stPorazov = 0;daniGoli = 0;prejetiGoli = 0;stTekem = 0;
        }
        public void VpisRezultata(int d, int p)
        {
            //vpiši rezultat za ekipo, p=prejeti goli, d= dani goli
            daniGoli += d;
            prejetiGoli += p;
            stTekem++;
            if (d > p)
                stZmag++;
            if (p == d)
                stNeodlocenih++;
        }
        //koliko ima ekipa točk
        public int ŠtTočk()
        {
            return stZmag * 3 + stNeodlocenih;
        }
        public int GolRaztlika()
        {
            return daniGoli - prejetiGoli;
        }
        public string Izpis()
        {
            return ime + "\t" + ŠtTočk() + "\t" + GolRaztlika() + "\t" + daniGoli;
        }
        public bool BoljšaEkipa(Moštvo x)
        {
            if (this.ŠtTočk() > x.ŠtTočk())
                return true;
            if (this.ŠtTočk() == x.ŠtTočk() && this.GolRaztlika() > x.GolRaztlika())
                return true;
            if (this.ŠtTočk() == x.ŠtTočk() && this.GolRaztlika() == x.GolRaztlika() && this.daniGoli>x.daniGoli)
                return true;
            return false;


        }
    }
}
