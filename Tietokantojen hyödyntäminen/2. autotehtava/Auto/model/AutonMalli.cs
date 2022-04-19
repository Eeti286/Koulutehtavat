using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class AutonMalli
    {
        int Id;
        int merkkiId;
        string malli;

        public int ID { get => Id; set => Id = value; }
        public int MerkkiID { get => merkkiId; set => merkkiId = value; }
        public string Malli { get => malli; set => malli = value; }
    }
}
