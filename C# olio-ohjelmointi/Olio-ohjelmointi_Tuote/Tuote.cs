using System;
using System.Collections.Generic;
using System.Text;

namespace Olio_ohjelmointi_Tuote
{
    class Tuote
    {
        double hinta;
        int lukumaara;
        string nimi;

        public Tuote(double hinta, int lukumaara, string nimi)
        {
            this.hinta = hinta;
            this.lukumaara = lukumaara;
            this.nimi = nimi;
        }

        public void tulostaTuote()
        {
            Console.WriteLine(nimi + ", " + hinta + ", " + lukumaara + "Kpl");
        }
    }
}
