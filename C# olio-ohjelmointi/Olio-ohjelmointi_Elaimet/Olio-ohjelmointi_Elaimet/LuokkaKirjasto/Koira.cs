using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaKirjasto
{
    public class Koira : Nisakkaat
    {
        public override void ääntele()
        {
            Console.WriteLine("vuh");
        }
        public override string ToString()
        {
            return "koira: " + Nimi + " on " + Ika + " vuotias lihansyöjä, jolla on " + Poikasten_maara + " poikasta.";
        }
    }
}
