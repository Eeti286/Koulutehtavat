using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Polttoaine
    {
        string polttoaine;
        int id;

        public string PolttoaineNimi { get => polttoaine; set => polttoaine = value; }
        public int ID { get => id; set => id = value; }
    }
}
