using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Logic
{
    public class SongListPrinter
    {
        public static void Info(SongList sl)
        {
            Console.WriteLine(" Songs count: " + sl.Count);
        }
        public static void Songs(SongList sl)
        {
            Console.WriteLine(" Songs: ");
            foreach (Song s in sl.Songs)
            {
                Console.Write("    ");
                SongPrinter.Print(s);
            }
        }
    }
}
