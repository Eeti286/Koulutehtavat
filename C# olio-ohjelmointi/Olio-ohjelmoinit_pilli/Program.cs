using System;

namespace Olio_ohjelmoinit_pilli
{
    class Program
    {
        static void Main(string[] args)
        {
            Pilli sorsapilli = new Pilli("kvaak");
            Pilli kukkopilli = new Pilli("Peef");

            sorsapilli.soi();
            kukkopilli.soi();
            sorsapilli.soi();
        }
    }
}
