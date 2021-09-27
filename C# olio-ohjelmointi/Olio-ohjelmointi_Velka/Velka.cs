using System;
using System.Collections.Generic;
using System.Text;

namespace Olio_ohjelmointi_Velka
{
    class Velka
    {
        double saldo;
        double korkokerroin;

        public Velka(double saldo, double korkokerroin)
        {
            this.saldo = saldo;
            this.korkokerroin = korkokerroin;
        }

        public void tulostaSaldo() 
        {
            Console.WriteLine(saldo);
        }

        public void odotaVuosi()
        {
            Console.WriteLine(saldo * korkokerroin);
        }


    }
}
