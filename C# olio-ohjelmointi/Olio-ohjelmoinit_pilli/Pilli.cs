using System;
using System.Collections.Generic;
using System.Text;

namespace Olio_ohjelmoinit_pilli
{
    class Pilli
    {
        private string aani;

        public Pilli(string pillinAani)
        {
            this.aani = pillinAani;
        }

        public void soi()
        {
            Console.WriteLine(aani);
        }

    }
}
