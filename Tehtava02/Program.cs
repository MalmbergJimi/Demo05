using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Luodaan muutama Biisi
            Biisit eka = new Biisit();
            eka.Biisi = "Shudder Before the Beautiful";
            eka.Pituus = "6:29";

            Biisit toka = new Biisit();
            toka.Biisi = "Weak Fantasy";
            toka.Pituus = "5:23";

            Biisit kolmas = new Biisit();
            kolmas.Biisi = "Elan";
            kolmas.Pituus = "4:45";

            CD naitwis = new CD();
            naitwis.Nimi = "Endless Forms Most Beautiful";
            naitwis.Hinta = "5.99€";

            // Lisätään biisit CD:lle
            naitwis.AddBiisi(eka);
            naitwis.AddBiisi(toka);
            naitwis.AddBiisi(kolmas);

            //Tulostetaan biisit
            naitwis.PrintCollection();
            // Print whole collection
           // henkilot.PrintCollection();





        }
    }
}
