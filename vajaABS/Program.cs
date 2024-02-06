using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vajaABS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelavecNaUro d1 = new DelavecNaUro();
            d1.DelID = "123";
            d1.Ime = "Lojze Slak";
            d1.ŠtUr = 180;
            d1.Urnapostavka = 9.5;
            d1.Izpis();
            d1.UgotoviUporabnika();
            letniDelavec d2 = new letniDelavec("789", "marko", 12000);
            d2.Izpis();
            DelavecBazni x; 
            x= new DelavecNaUro();
            x = new letniDelavec("789", "marko", 12000);
            Ivarnost y = new DelavecNaUro();
            y.BeležiDostop();


        }
    }
}
