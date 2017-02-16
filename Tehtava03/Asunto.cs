using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava03
{
    class Asunto
    {
        public int Asuntonro { get; set; }
        public string Asukkaat { get; set; }
        public double Vuokra { get; set; }
        public string Kunto { get; set; }


        public override string ToString()
        {
            return " -Asuntonumero: " + Asuntonro + ", asukkaat: " + Asukkaat + ", vuokra: " + Vuokra + ", kunto: " + Kunto;
        }
    }

    
}
