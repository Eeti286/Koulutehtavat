using System;
using LuokkaKirjasto;
using System.Collections.Generic;

namespace Lista_ja_logiikka
{
    class Program
    {
        static void Main(string[] args)
        {

            Kissa emo = new Kissa();

            emo.lisaaPentu(3);






            int Id = 1;
            int kierrosmittari = 0;

            List<string> nimia = new List<string> { "Jaska", "Aalto", "Aaltonen", "Aarnio", "Ahde", "Aho", "Ahopalo", "Ahokas", "Ahokangas", "Ahola", "Ahonen", "Ahti", "Ahtisaari", "Alanen", "Alasalmi", "Alho", "Annala", "Anttila", "Anttonen", "Arajärvi", "Aro", "Aromaa", "Asikainen", "Askola", "Astala", "Asunmaa", "Aura", "Autio", "Auvinen", "Eerikäinen", "Eerola", "Einiö", "Ekola", "Elo", "Elonen", "Elomaa", "Eloranta", "Elsilä", "Ernamo", "Erola", "Eronen", "Eskelinen", "Eskola", "Haanpää", "Haapakoski", "Haapasalo", "Haataja", "Hakala", "Hamilo", "Hannula", "Harju", "Harjula", "Hartikainen", "Hautala", "Heikkilä", "Heikkinen", "Heinonen", "Heiskanen", "Helminen", "Hietanen" };

            Console.WriteLine("Monta elainta haluat luoda?");
            int maara = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();



            List<Elain> elaimet = new List<Elain>
            {

            };


            for (int i = 1; i <= maara; i++)
            {

                int rnd_ika = rnd.Next(1, 13);
                int rnd_siipivali = rnd.Next(10, 300);
                int rnd_poikasten_maara = rnd.Next(1, 6);
                int Random = rnd.Next(nimia.Count);
                string rnd_nimi = nimia[Random];


                if (Id % 4 == 0 && kierrosmittari == 0)
                {
                    Hevonen hevonen = new Hevonen();
                    elaimet.Add(new Hevonen() { Nimi = rnd_nimi, Ika = rnd_ika, Poikasten_maara = rnd_poikasten_maara });
                    Id = Id + 1;
                    kierrosmittari = kierrosmittari + 1;
                }
                else if (kierrosmittari == 0)
                {
                    Kissa kissa = new Kissa();
                    elaimet.Add(new Kissa() { Nimi = rnd_nimi, Ika = rnd_ika, Poikasten_maara = rnd_poikasten_maara });

                    Id = Id + 1;
                    kierrosmittari = kierrosmittari + 1;
                }


                else if (Id % 4 == 0 && kierrosmittari == 1)
                {
                    Hevonen hevonen = new Hevonen();
                    elaimet.Add(new Hevonen() { Nimi = rnd_nimi, Ika = rnd_ika, Poikasten_maara = rnd_poikasten_maara });
                    Id = Id + 1;
                    kierrosmittari = kierrosmittari + 1;
                }
                else if (kierrosmittari == 1)
                {
                    Koira koira = new Koira();
                    elaimet.Add(new Koira() { Nimi = rnd_nimi, Ika = rnd_ika, Poikasten_maara = rnd_poikasten_maara });
                    Id = Id + 1;
                    kierrosmittari = kierrosmittari + 1;
                }


                else if (Id % 4 == 0 && kierrosmittari == 2)
                {
                    Hevonen hevonen = new Hevonen();
                    elaimet.Add(new Hevonen() { Nimi = rnd_nimi, Ika = rnd_ika, Poikasten_maara = rnd_poikasten_maara });
                    kierrosmittari = kierrosmittari + -2;
                }
                else if (kierrosmittari == 2)
                {
                    Papukaija papukaija = new Papukaija();
                    elaimet.Add(new Papukaija() { Nimi = rnd_nimi, Ika = rnd_ika, Siipivali = rnd_siipivali });
                    Id = Id + 1;
                    kierrosmittari = kierrosmittari + -2;
                }
            }


            elaimet.ForEach(Console.WriteLine);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");

            emo.Pennut();

            //foreach (Elain elukka in elaimet)
            //{
            //    Console.WriteLine(elukka.Nimi, elukka.Ika);
            //}



        }      
    }
}
