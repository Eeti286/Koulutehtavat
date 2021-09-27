using System;

namespace Olio_ohjelmointi_Velka
{
    class Program
    {
        static void Main(string[] args)
        {
            Velka velka1 = new Velka(100.0, 1.07);

            velka1.tulostaSaldo();
            velka1.odotaVuosi();
        }
    }
}
