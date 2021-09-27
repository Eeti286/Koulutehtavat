using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaKirjasto
{
    public class Linnut : Elain
    {
        private double siipivali;

        public double Siipivali
        {
            get { return siipivali; }
            set { siipivali = value; }
        }


        public void asetaSiipivali(double aseta_siipienvali)
        {
            siipivali = aseta_siipienvali;
        }

        public void palautaSiipivali()
        {
            Console.WriteLine(siipivali);
        }


    }
}
