using System;
using System.Collections.Generic;
using System.Text;

namespace Olio_ohjelmointi_Mitta
{
    class Mittari
    {
        private int _mitta = 0;


        public Mittari()
        {

        }
        public void Lisaa()
        {
            _mitta = _mitta + 1;
        }
        public void Vahenna()
        {
            _mitta = _mitta - 1;
        }
        public  int Mitta()
        {
            return _mitta;
        }
        public Boolean Taynna()
        {
            if (_mitta == 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
