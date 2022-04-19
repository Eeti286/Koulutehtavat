using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Auto
    {
        int Id;
        int Mittarilukema;
        int AutonMerkkiID;
        int AutonMalliID;
        int VaritID;
        int PolttoaineID;
        Decimal Hinta;
        Decimal Moottorin_tilavuus;
        DateTime Rekisteri_paivamaara;

        string AutoMerkki;
        string AutoMalli;
        string Vari;
        string Polttoaine;

        public int Id1 { get => Id; set => Id = value; }
        public int Mittarilukema1 { get => Mittarilukema; set => Mittarilukema = value; }
        public int AutonMerkkiID1 { get => AutonMerkkiID; set => AutonMerkkiID = value; }
        public int AutonMalliID1 { get => AutonMalliID; set => AutonMalliID = value; }
        public int VaritID1 { get => VaritID; set => VaritID = value; }
        public int PolttoaineID1 { get => PolttoaineID; set => PolttoaineID = value; }
        public decimal Hinta1 { get => Hinta; set => Hinta = value; }
        public decimal Moottorin_tilavuus1 { get => Moottorin_tilavuus; set => Moottorin_tilavuus = value; }
        public DateTime Rekisteri_paivamaara1 { get => Rekisteri_paivamaara; set => Rekisteri_paivamaara = value; }
        public string AutoMerkki1 { get => AutoMerkki; set => AutoMerkki = value; }
        public string AutoMalli1 { get => AutoMalli; set => AutoMalli = value; }
        public string Vari1 { get => Vari; set => Vari = value; }
        public string Polttoaine1 { get => Polttoaine; set => Polttoaine = value; }
    }
}
