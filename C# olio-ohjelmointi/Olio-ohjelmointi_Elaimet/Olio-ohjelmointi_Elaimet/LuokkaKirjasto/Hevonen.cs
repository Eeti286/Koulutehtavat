using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaKirjasto
{
    public class Hevonen : Nisakkaat
    {
        private string nimi;
        private int paino;
        //Alla konstruktori jossa ei ola parametreja, joten kaikki luokasta 
        //synnytetyt oliot ovat samanlaisia. Konstruktorin tunnistaa siitä
        // ettei siinä ole palautustyyppiä ja metodin nimi on sama kuin luokannimi
        public Hevonen()
        {
            //Konstruktorissa voi olla oletusarvoja
            //Luokan sisällä voidaan käyttää privaatti kenttiä
            nimi = "";
            paino = 0;
        }
        //getterillä ja setterillä annetaan luokan ulkopuolisille sovelluksille mahdollisuus 
        //asettaa tai hakea kenttiä
        public string Nimi
        {
            get
            {
                return nimi;
            }

            set
            {
                nimi = value;
            }
        }

        public int Paino
        {
            get
            {
                return paino;
            }

            set
            {
                paino = value;
            }
        }

        public override string ToString()
        {
            return "Hevonen: " + Nimi + " on " + Ika + " vuotias kasvisyöjä, jolla on " + Poikasten_maara + " poikasta.";
        }

    }
}

