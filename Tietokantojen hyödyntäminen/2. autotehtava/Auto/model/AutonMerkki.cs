using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class AutonMerkki
    {
        private string merkki;
        private int iD;

        public string Merkki { get => merkki; set => merkki = value; }
        public int ID { get => iD; set => iD = value; }
    }
}
