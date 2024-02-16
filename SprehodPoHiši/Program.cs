using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprehodPoHiši
{
    internal class Program
    {
        static Lokacija trenutnaLokacija;
        static SobaZVrati dnevnaSoba;
        static Soba jedilnica;
        static SobaZVrati kuhinja;
        static ZunanjiZVrati zadnjeDvorišče;
        static ZunanjiZVrati sprednjeDvorišče;
        static Zunanji vrt;
        public static void UstvariHišo()
        {
            dnevnaSoba = new SobaZVrati("Dnevna soba", "starinski tepih",
            "hrastova vrata");
            jedilnica = new Soba("Jedilnica", "kristalni luster");
            kuhinja = new SobaZVrati("Kuhinja", "nerjaveči pripomočki", "vrata");
           
            sprednjeDvorišče = new ZunanjiZVrati("Sprednje dvorišče", false, "vrata");
           
            zadnjeDvorišče = new ZunanjiZVrati("Zadnje dvorišče", true, "vrata");
           
            vrt = new Zunanji("Vrt", false);
            jedilnica.izhodi = new Lokacija[2];
            jedilnica.izhodi[0] = dnevnaSoba;
            jedilnica.izhodi[1] = kuhinja;
            dnevnaSoba.izhodi = new Lokacija[1];
            dnevnaSoba.izhodi[0] = jedilnica;
            kuhinja.izhodi = new Lokacija[1];
            kuhinja.izhodi[0] = jedilnica;
            sprednjeDvorišče.izhodi = new Lokacija[2];
            sprednjeDvorišče.izhodi[0] = zadnjeDvorišče;
            sprednjeDvorišče.izhodi[1] = vrt;
            zadnjeDvorišče.izhodi = new Lokacija[2];
            zadnjeDvorišče.izhodi[0] = sprednjeDvorišče;
            zadnjeDvorišče.izhodi[1] = vrt;
            vrt.izhodi = new Lokacija[2];
            vrt.izhodi[0] = zadnjeDvorišče;
            vrt.izhodi[1] = sprednjeDvorišče;
            dnevnaSoba.blok = sprednjeDvorišče;
            sprednjeDvorišče.blok = dnevnaSoba;
            kuhinja.blok = zadnjeDvorišče;
            zadnjeDvorišče.blok = kuhinja;
        }
        public static void PremakniSe(Lokacija nova)
        {
            trenutnaLokacija = nova;
            string a = trenutnaLokacija.Opis();
            if (trenutnaLokacija is IZunanjaVrata)
                a += " (I) Pojdi skozi vrata .";
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            UstvariHišo();
            PremakniSe(dnevnaSoba);
            trenutnaLokacija = dnevnaSoba;
            string nova = "";
            while (nova != "K")
            {
                Console.WriteLine("Kam naj grem? K=Konec");
                nova = Console.ReadLine();
                Lokacija novaLokacija = null;
                if (nova == "K")
                {
                    Console.WriteLine("Lep sprehod!");
                    break;
                }
                if (nova == "I")
                {
                    //izhod
                    if (trenutnaLokacija is IZunanjaVrata)
                    {
                        novaLokacija =
                       ((IZunanjaVrata)trenutnaLokacija).lokacijaVrat();
                    }
                }
                else
                {
                    int l = int.Parse(nova);
                    novaLokacija = new Lokacija(trenutnaLokacija.izhodi[l].ime);
                }
                switch (novaLokacija.ime)
                {
                    case "Dnevna soba":
                        novaLokacija = dnevnaSoba; break;
                    case "Jedilnica":
                        novaLokacija = jedilnica; break;
                    case "Kuhinja":
                        novaLokacija = kuhinja; break;
                    case "Sprednje dvorišče":
                        novaLokacija = sprednjeDvorišče; break;
                    case "Zadnje dvorišče":
                        novaLokacija = zadnjeDvorišče; break;
                    case "Vrt":
                        novaLokacija = vrt; break;
                }
                PremakniSe(novaLokacija);

            }
        }
        }
}
