using System;

namespace Olio_ohjelmointi_Tuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote hedelma = new Tuote(1.1, 13, "banaani");

            hedelma.tulostaTuote();
        }
    }
}
