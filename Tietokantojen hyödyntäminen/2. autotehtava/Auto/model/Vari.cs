using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autokauppa.model
{
    public class Vari
    {
        int id;
        string vari;

        public int ID { get => id; set => id = value; }
        public string VariNimi { get => vari; set => vari = value; }
    }
}
