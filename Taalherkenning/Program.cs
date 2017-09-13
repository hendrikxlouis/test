using System;
using System.Windows.Forms;

namespace Taalherkenning
{
    static class Program
    {
        static void Main(string[] args)
        {
            string[] defaultwaarden =
            { "Nederlands", "http://nl.wikipedia.org"
            , "Engels",     "http://en.wikipedia.org"
            , "Duits",      "http://de.wikipedia.org"
            , "Frans",      "http://fr.wikipedia.org"
            , "Spaans",     "http://es.wikipedia.org"
            , "Italiaans",  "http://it.wikipedia.org"
            };

            if (args.Length == 0)
                args = defaultwaarden;

            Application.Run(new Taal(args));
        }
    }
}
