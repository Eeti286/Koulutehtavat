using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaKirjasto
{
    public class Kissa : Nisakkaat
    {

        List<Kissa> pennut = new List<Kissa>
        {
            
        };

        public void kehrää()
        {
            Console.WriteLine("hrrr");
        }

        public override void ääntele()
        {
            Console.WriteLine("mrrr");
        }
        public override string ToString()
        {
            return "kissa: " + Nimi + " on " + Ika + " vuotias lihansyöjä, jolla on " + Poikasten_maara + " poikasta.";
        }

        public void lisaaPentu(int maara)
        {
            for (int i = 1; i <= maara; i++)
            {
                Kissa kissa = new Kissa();
                pennut.Add(new Kissa() {Ika = 0});

                //Console.WriteLine(_ika + " " + pennut.Count);
            }
        }

        public void Pennut()
        {
            pennut.ForEach(Console.WriteLine);
        }


    }
}
