using System;
using LuokkaKirjasto;

namespace Periytyminen
{
    class Program
    {
        static void Main(string[] args)
        {
            Kissa kissa1 = new Kissa();
            Koira koira1 = new Koira();
            Koira koira2 = new Koira();
            Linnut linnut1 = new Linnut();
            Papukaija papukaija1 = new Papukaija();
            

            kissa1.asetaElaimenIka(12);
            kissa1.asetaElaimenNimi("koistinen");
            kissa1.asetaOnLihanSyoja(true);

            kissa1.palautaOnLihanSyoja();
            kissa1.palautaElaimenNimi();
            kissa1.palautaElaimenIka();


            Console.WriteLine("");


            koira1.ääntele();
            kissa1.ääntele();
            linnut1.ääntele();


            Console.WriteLine("");


            koira2.asetaPoikastenMaara(3);
            papukaija1.asetaElaimenIka(4);
            papukaija1.asetaElaimenNimi("Erkki");
            papukaija1.asetaSiipivali(2.4);

            koira2.palautaElaimenIka();
            koira2.palautaElaimenNimi();
            koira2.palautaPoikastenMaara();

            Console.WriteLine("");

            papukaija1.palautaElaimenIka();
            papukaija1.palautaElaimenNimi();
            papukaija1.palautaSiipivali();
           





        }
    }
}
