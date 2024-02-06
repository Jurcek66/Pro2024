using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajaABS
{
    internal class DelavecNaUro : DelavecBazni,Ivarnost
    {
        double urnapostavka;
        int štUr;

        public override double BrutoPlača
        {
            get 
            { 
                brutoPlača = urnapostavka * štUr;
                return brutoPlača;
            }
        }

        public double Urnapostavka { get => urnapostavka; set => urnapostavka = value; }
        public int ŠtUr { get => štUr; set => štUr = value; }

        public void BeležiDostop()
        {
            Console.WriteLine("Beležim dostop");
        }

        public void geslo()
        {
            Console.WriteLine("preverjam geslo;");
        }

        public override void Izpis()
        {
            Console.WriteLine("***************DELAVEC***************");
            Console.WriteLine("ID            " + delID);
            Console.WriteLine("Ime           " + ime);
            Console.WriteLine("Urna postavka " + urnapostavka);
            Console.WriteLine("Število ur    " + štUr);
            Console.WriteLine("Bruto plača   " + BrutoPlača);
            Console.WriteLine("*************************************");
        }

        public void UgotoviUporabnika()
        {
            Console.WriteLine("ugotavljam uporabnika");
        }
    }
}
