using System;

namespace Olio_ohjelmointi_musiikkikappale
{
    class Program
    {
        static void Main(string[] args)
        {
            Musiikkikappale garden = new Musiikkikappale("In The Garden", 10910);
            Console.WriteLine("Kappaleen " + garden.PalautaNimi() + " pituus on " + garden.palautaPituus() + " sekuntia.");
        }
    }
}
