using ClassLibrary;

namespace Logic
{
    public class SongPrinter
    {
        public static void Print(Song s)
        {
            int minutes = s.Duration / 60;
            int seconds = s.Duration % 60;
            Console.Write(" " + s.Name + " - " + s.Artist + " (" + minutes + ":" + seconds + ")\n");
        }
        public static string GetInfo(Song s)
        {
            int minutes = s.Duration / 60;
            int seconds = s.Duration % 60;
            return " " + s.Name + " - " + s.Artist + " (" + minutes + ":" + seconds + ")";
        }
    }
}
