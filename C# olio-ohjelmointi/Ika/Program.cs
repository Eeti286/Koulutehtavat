using System;
using Olio_ohjelmointi_Elaimet;

namespace Ika
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                Kissa kissa1 = new Kissa();
                Koira koira1 = new Koira();

                int koiranIka = rnd.Next(1, 15);
                int kissanIka = rnd.Next(1, 10);

                koira1.Ika = koiranIka;
                kissa1.Ika = kissanIka;

                Console.WriteLine("Koira on: " + koira1.Ika + " vuotta, Kissa on: " + kissa1.Ika + " vuotta");

                if (koiranIka > kissanIka)
                {
                    Console.WriteLine("koira on vanhempi");
                }
                else
                {
                    Console.WriteLine("Kissa on vanhempi");
                }

            }


        }
    }
}
