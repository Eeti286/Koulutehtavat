using System;

namespace Olio_ohjelmointi_Maksukortti
{
    class Program
    {
        static void Main(string[] args)
        {
            Maksukortti pekanKortti = new Maksukortti(20);
            Maksukortti matinKortti = new Maksukortti(30);

            pekanKortti.syoMaukkaasti();
            matinKortti.syoEdullisesti();

            Console.WriteLine("Pekan " + pekanKortti);
            Console.WriteLine("Matin " + matinKortti);

            pekanKortti.lataaRahaa(20);

            matinKortti.syoMaukkaasti();

            Console.WriteLine("Pekan " + pekanKortti);
            Console.WriteLine("Matin " + matinKortti);

            pekanKortti.syoEdullisesti();
            pekanKortti.syoEdullisesti();

            matinKortti.lataaRahaa(50);

            Console.WriteLine("Pekan " + pekanKortti);
            Console.WriteLine("Matin " + matinKortti);

        }
    }
}
