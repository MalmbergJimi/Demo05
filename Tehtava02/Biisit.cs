using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava02
{
    class Biisit
    {
        public string Biisi{ get; set; }
        public string Pituus { get; set; }

        public override string ToString()
        {
            return Biisi + " " + Pituus;
        }
    }
}
