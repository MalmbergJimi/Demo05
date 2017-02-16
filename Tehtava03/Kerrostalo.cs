using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava03
{
    class Kerrostalo
    {
        private List<Asunto> kerrostalo;

        public Kerrostalo()
        {
            kerrostalo = new List<Asunto>();
        }

        public void AddAsunto(Asunto asunto)
        {
            kerrostalo.Add(asunto);
        }

       
        public string Osoite { get; set; }
        public string Rakvuosi { get; set; }


        public override string ToString()
        {
            return Osoite + " " + Rakvuosi;
        }

        public void PrintCollection()
        {
            Console.WriteLine("Osoite: " + Osoite + ". Rakennusvuosi: " + Rakvuosi);
            Console.WriteLine("Kerrostalon huoneistot: ");

            foreach (Asunto asunto in kerrostalo)
            {
                Console.WriteLine(asunto.ToString());
            }
            Console.WriteLine();
        }

        
    }
}