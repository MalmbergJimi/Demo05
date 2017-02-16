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
            naitwis.Artisti = "Nightwish";
            naitwis.Nimi = "Endless Forms Most Beautiful";
            naitwis.Hinta = "5.99€";

            // Lisätään biisit CD:lle
            naitwis.AddBiisi(eka);
            naitwis.AddBiisi(toka);
            naitwis.AddBiisi(kolmas);

            //Tulostetaan biisit
            naitwis.PrintCollection();

            

            // Luodaan lisää biisejä jonka jälkeen tehdään uusi albumi
            Biisit yoyo = new Biisit();
            yoyo.Biisi = "Yoyon kostoretko";
            yoyo.Pituus = "1:00";

            Biisit maan = new Biisit();
            maan.Biisi = "Still alive Wigga";
            maan.Pituus = "5:55";

            Biisit wigga = new Biisit();
            wigga.Biisi = "Hustlin hard";
            wigga.Pituus = "7:01";

            // Tehdään CD
            CD yoman = new CD();
            yoman.Artisti = "Young Yolo";
            yoman.Nimi = "Tales of YoYoMan";
            yoman.Hinta = "99,99€";

            //Lisätään biisit CD:lle
            yoman.AddBiisi(yoyo);
            yoman.AddBiisi(maan);
            yoman.AddBiisi(wigga);

            // Tulostetaan biisit
            yoman.PrintCollection();

            
            

        }
    }
}
