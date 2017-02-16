using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava03
{
    class Program
    {
        static void Main(string[] args)
        {
            // LUODAAN ASUNTOJA JA ASUKKAITA
            Asunto leppa = new Asunto();
            leppa.Asuntonro = 1;
            leppa.Asukkaat = "Timo, Hilda ja Hulda Heppoinen";
            leppa.Vuokra = 3000.0;
            leppa.Kunto = "Todella hyvä";

            Asunto koivu = new Asunto();
            koivu.Asuntonro = 2;
            koivu.Asukkaat = "Hra ja Rva Mallikas";
            koivu.Vuokra = 5000.0;
            koivu.Kunto = "Juuri remontoitu kattohuoneisto";

            //LUODAAN KERROSTALO JOHON LAITETAAN ASUNNOT
            Kerrostalo puut = new Kerrostalo();
            puut.Osoite = "Seppäläntie 13";
            puut.Rakvuosi = "2017";

            // Laitetaan asunnot taloon
            puut.AddAsunto(leppa);
            puut.AddAsunto(koivu);
            // TULOSTETAAN TIEODT!
            puut.PrintCollection();


            //Luodaan uusia asuntoja
            Asunto orvokki = new Asunto();
            orvokki.Asuntonro = 3;
            orvokki.Asukkaat = "Sikke ja Sakke";
            orvokki.Vuokra = 590;
            orvokki.Kunto = "Semmoinen semi hyvä";

            Asunto kakkara = new Asunto();
            kakkara.Asuntonro = 4;
            kakkara.Asukkaat = "Hilleri Hiiri";
            kakkara.Vuokra = 15;
            kakkara.Kunto = "Pikku paska";

            // Luodaan kerrostalo, johon laitetaan asunnot
            Kerrostalo kukat = new Kerrostalo();
            kukat.Osoite = "Niityntie 7";
            kukat.Rakvuosi = "1961";

            kukat.AddAsunto(orvokki);
            kukat.AddAsunto(kakkara);

            kukat.PrintCollection();

        }
    }
}
