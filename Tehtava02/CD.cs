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
        /*
        public void AddPerson(Person person)
        {
            persons.Add(person);
        }
        */


        public Biisit HaeBiisi(int index)
        {
            if (index < cd.Count) return cd.ElementAt(index);
            else return null;
        }

        public string Nimi { get; set; }
        public string Hinta { get; set; }



        public void PrintCollection()
        {
            
            foreach (Biisit biisit in cd)
            {
                Console.WriteLine(biisit.ToString());
            }
        }
          /*
        public void PrintCollection()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person.ToString());
            }
        }
        */
    }
}
