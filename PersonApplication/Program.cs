using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a few Person objects

            Person masa = new Person { Firstname = "Getto", Lastname = "Masa", Henkilotunnus = "123421-123A" };
            Person hilla = new Person { Firstname = "Lakka", Lastname = "Hilla", Henkilotunnus = "332211-321B" };
            Person kake = new Person { Firstname = "Kake", Lastname = "Mara", Henkilotunnus = "112244-456C" };

            // Create a Persons object

            Persons henkilot = new Persons();

            // Add person objects to persons collection
            henkilot.AddPerson(masa);
            henkilot.AddPerson(hilla);
            henkilot.AddPerson(kake);

            // Get one person from Persons collection
            Person person4 = henkilot.GetPerson(1);
            if (person4 != null)
            {
                Console.WriteLine(person4.ToString());
            }
            else
            {
                Console.WriteLine("Person not found in dat index!");
            }

            // Print whole collection
            henkilot.PrintCollection();

            // Find person based on Hetu
            string sotu = "112244-456C";
            Console.WriteLine("Find Hetu : " + sotu);
            Person person5 = henkilot.FindPerson(sotu);
            if (person5 != null)
            {
                Console.WriteLine(person5.ToString());
            }
            else
            {
                Console.WriteLine("Cant find person wiht dat Hetu");
            }
        }
    }
}
