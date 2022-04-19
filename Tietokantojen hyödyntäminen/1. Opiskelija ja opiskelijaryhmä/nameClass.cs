using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Opiskelija_ja_opiskelijaryhmä
{
    class nameClass
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ryhma { get; set; }

        public nameClass(string etunimi, string sukunimi, int ryhma)
        {
            Etunimi = etunimi;
            Sukunimi = sukunimi;
            Ryhma = ryhma;
        }
    }
}
