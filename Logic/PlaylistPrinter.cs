using ClassLibrary;

namespace Logic
{
    public class PlaylistPrinter : SongListPrinter
    {
        public static void Print(Playlist pl)
        {
            int minutes = pl.Duration / 60;
            int seconds = pl.Duration % 60;
            string duration = minutes.ToString() + ":" + seconds.ToString();

            Console.WriteLine(" Playlist name: " + pl.Name +
                            "\n Plalist cover: " + pl.Cover + 
                            "\n Plalist songs count: " + pl.Count + 
                            "\n Playlist duration: " + duration);
        }
        public static string GetName(Playlist pl)
        {
            return pl.Name;
        }
        public static string GetDuration(Playlist pl)
        {
            int minutes = pl.Duration / 60;
            int seconds = pl.Duration % 60;
            return minutes.ToString() + ":" + seconds.ToString();
        }
    }
}
