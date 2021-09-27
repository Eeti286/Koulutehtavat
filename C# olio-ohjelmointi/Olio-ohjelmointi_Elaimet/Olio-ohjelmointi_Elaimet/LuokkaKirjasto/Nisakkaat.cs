using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaKirjasto
{
    public class Nisakkaat : Elain
    {
        private int poikasten_maara;

        public int Poikasten_maara
        {
            get { return poikasten_maara; }
            set { poikasten_maara = value; }
        }

        public void asetaPoikastenMaara(int aseta_poikasten_maara)
        {
            poikasten_maara = aseta_poikasten_maara;
        }

        public void palautaPoikastenMaara()
        {
            Console.WriteLine(poikasten_maara);
        }

    }
}
