using ClassLibrary;

namespace Logic
{
    public class PlaylistPrinter : SongListPrinter
    {
        public static void Info(Playlist pl)
        {
            int minutes = pl.Duration / 60;
            int seconds = pl.Duration % 60;
            string duration = minutes.ToString() + ":" + seconds.ToString();

            Console.WriteLine(" Playlist name: " + pl.Name +
                            "\n Plalist cover: " + pl.Cover + 
                            "\n Plalist songs count: " + pl.Count + 
                            "\n Playlist duration: " + duration);
        }
    }
}
