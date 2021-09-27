using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaKirjasto
{
    public class Papukaija : Linnut
    {
        public override string ToString()
        {
            return "papukaija: " + Nimi + " on " + Ika + " vuotias kasvissyöjä, jolla on " + Siipivali + "cm siipivali!";
        }
    }
}
