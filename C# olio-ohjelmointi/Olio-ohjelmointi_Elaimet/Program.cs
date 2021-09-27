using System;

/**
  
   Muista kommentoida toiminnalliset funktiot!
   https://msdn.microsoft.com/en-us/library/5ast78ax.aspx
    1. Luokassa Hevonen ei ole kuin yhden tyyppinen konstruktori,  parametriton konstruktori. Tutki luokkaa.
    2. Luo Hevonen -luokasta olio Main -metodissa
	3. Lisää rivi missä Tulostat olion nimi ja paino näytölle.
	4. Lisää koodiin rivit missä annetaan luodulle oliolle nimi ja paino.
    5. Tulosta olion tiedot nyt näytölle.
  
   
**/

namespace Olio_ohjelmointi_Elaimet
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEHTÄVÄ1 HEVOSET

            //Tässä luot luokasta olion
            Hevonen Hevonen1 = new Hevonen();

            //Tulosta olion nimi ja paino
            Console.WriteLine("Nimi: " + Hevonen1.Nimi + " Paino: " + Hevonen1.Paino);

            //Muuta olion nimeä ja painoa
            Hevonen1.Nimi = "Histamiini";
            Hevonen1.Paino = 89;

            //Tulosta nyt olion nimi ja paino, jotta varmistat että muutos tapahtui
            Console.WriteLine("Nimi: " + Hevonen1.Nimi + " Paino: " + Hevonen1.Paino);







            //TEHTÄVÄ2 KISSA
            Console.WriteLine("");

            Kissa Kissa1 = new Kissa();

            Console.WriteLine("Nimi: " + Kissa1.Nimi);

            Kissa1.asetaKissanNimi("Katri");

            Console.WriteLine("Nimi: " + Kissa1.Nimi + " Ika: " + Kissa1.Ika);

            Kissa Kissa2 = new Kissa("esa", 8);
            Console.WriteLine("Nimi: " + Kissa2.Nimi + " Ika: " + Kissa2.Ika);




            //  TEHTÄVÄ3 ARVON PALAUTTAMINEN
            Console.WriteLine("");

            Kissa2.asetaKissanIka(18);
            Console.WriteLine("Ika: " + Kissa2.Ika);

            Console.WriteLine("");

            Kissa2.asetaKissanNimi("Hilda");
            Console.WriteLine("Nimi: " + Kissa2.Nimi);


            Kissa katti = new Kissa();

            katti.asetaKissanNimi("anneli");
            Console.WriteLine("Nimi: " + katti.Nimi);

            katti.asetaKissanNimi("hilda");
            Console.WriteLine("Nimi: " + katti.Nimi);




            //TEHTÄVÄ4 OVERRIDE STRING
            Console.WriteLine("");

            Console.WriteLine(katti);





            //TEHTÄVÄ5 KOIRA
            Console.WriteLine("");

            Koira Koira1 = new Koira();
            Koira1.asetaKoiranNimi("Max");


        }
    }
}
