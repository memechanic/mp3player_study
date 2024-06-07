using ClassLibrary;
using Logic;
using Interfaces;
using System.Text;

namespace MP3Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SongList mainList = new SongList();
            

            Song song = SongFactory.UploadSong("..\\..\\..\\SONGS\\song.txt", ref mainList);
            Song song2 = SongFactory.UploadSong("..\\..\\..\\SONGS\\song2.txt", ref mainList);
            Song song3 = SongFactory.UploadSong("..\\..\\..\\SONGS\\song3.txt", ref mainList);
            SongPrinter.Print(song);

            Console.WriteLine();

            SongListPrinter.Info(mainList);
            SongListPrinter.Songs(mainList);

            Console.WriteLine();

            PlaylistsGroup playlistsGroup = new PlaylistsGroup();

            Playlist playlist = PlaylistFactory.CreatePlaylist("AC/DC songs", ref playlistsGroup);
            playlist.Add(song);
            playlist.Add(song2);

            PlaylistPrinter.Print(playlist);
            PlaylistPrinter.Songs(playlist);

            Console.WriteLine();

            playlist.Remove(song);

            PlaylistPrinter.Print(playlist);
            PlaylistPrinter.Songs(playlist);

            Console.WriteLine();

            var fileLogger = LoggerFactory.CreateLogger('f');
            fileLogger.Log("Продемонстрировал работу");
        }
    }
}