using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava02
{
    class CD
    {
        private List<Biisit> cd;

        public CD()
        {
            cd = new List<Biisit>();
        }

        public void AddBiisi(Biisit biisit)
        {
            cd.Add(biisit);
        }
        
        public Biisit HaeBiisi(int index)
        {
            if (index < cd.Count) return cd.ElementAt(index);
            else return null;
        }

        public string Artisti { get; set; }
        public string Nimi { get; set; }
        public string Hinta { get; set; }

        public override string ToString()
        {
            return Nimi + " " + Hinta;
        }


        public void PrintCollection()
        {
            Console.WriteLine("CD DATA: ");
            Console.WriteLine( Artisti + ": " + Nimi + ". Hinta: " + Hinta);
            Console.WriteLine("Albumin kappaleet: ");            
            foreach (Biisit biisit in cd)
            {
                Console.WriteLine(biisit.ToString());
            }
            Console.WriteLine();

        }
        
    }
}
