using System;
using System.Collections.Generic;
using System.Text;

namespace LuokkaKirjasto
{
    abstract public class Elain
    {

        private string _nimi = "Sami";
        private int _ika = 0;
        private bool onLihanSyoja;
        private int _id = 0;

        public string Nimi
        {
            get { return _nimi; }
            set { _nimi = value; }
        }

        public virtual int Ika
        {
            get { return _ika; }
            set { _ika = value; }
        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public bool Lihansyoja
        {
            get { return onLihanSyoja; }
            set { onLihanSyoja = value; }
        }


        public Elain()
        {

        }


        public Elain(string nimi, int ika)
        {
            this._nimi = nimi;
            this._ika = ika;
        }

        public void asetaElaimenNimi(string nimi)
        {
            _nimi = nimi;
        }

        public void asetaElaimenIka(int ika)
        {
            _ika = ika;
        }

        public override string ToString()
        {
            return "Eläimen: " + Nimi + " " + Ika;
        }

        public bool asetaOnLihanSyoja(bool Onlihansyoja)
        {
            onLihanSyoja = Onlihansyoja;
            return true;
        }

        public bool palautaOnLihanSyoja()
        {
            if (onLihanSyoja == true)
            {
                Console.WriteLine("lihansyöjä");
                return true;
            }
            else
            {
                Console.WriteLine("ei ole lihansyöjä");
                return false;
            }
        }

        public void palautaElaimenIka()
        {
            Console.WriteLine(Ika);
        }

        public void palautaElaimenNimi()
        {
            Console.WriteLine(Nimi);
        }

        public virtual void ääntele()
        {
            Console.WriteLine("Umph");
        }


    }
}
