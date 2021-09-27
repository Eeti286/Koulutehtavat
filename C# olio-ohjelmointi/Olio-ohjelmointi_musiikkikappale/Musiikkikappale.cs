using System;
using System.Collections.Generic;
using System.Text;

namespace Olio_ohjelmointi_musiikkikappale
{
    class Musiikkikappale
    {
        string nimi;
        int pituus;


        public Musiikkikappale(string kappaleenNimi, int kappaleenPituus)
        {
            pituus = kappaleenPituus;
            nimi = kappaleenNimi;
        }

        public string PalautaNimi()
        {
            return nimi;
        }

        public int palautaPituus()
        {
            return pituus;     
        }

    }
}


