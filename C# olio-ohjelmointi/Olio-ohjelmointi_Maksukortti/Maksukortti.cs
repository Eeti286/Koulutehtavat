using System;
using System.Collections.Generic;
using System.Text;

namespace Olio_ohjelmointi_Maksukortti
{
    class Maksukortti
    {
        private double saldo;

        public Maksukortti(int _saldo)
        {
            saldo = _saldo;
        }

        public override string ToString()
        {
            return "kortilla on rahaa " + saldo + " euroa";
        }

        public void syoEdullisesti()
        {

            if (saldo - 2.60 >= 0)
            {
                saldo = saldo - 2.60;
            }
        }
        public void syoMaukkaasti()
        {

            if (saldo - 4.60 >= 0)
            {
                saldo = saldo - 4.60;
            }

        }

        public void lataaRahaa(double _raha)
        {
            if (_raha >= 0)
            {
                saldo = saldo + _raha;
            }        
        }

    }
}
