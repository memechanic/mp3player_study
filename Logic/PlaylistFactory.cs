using ClassLibrary;

namespace Logic
{   
    public class PlaylistFactory
    {
        const string DefaultPath = "..\\..\\..\\cover.txt";
        public static Playlist CreatePlaylist(string name, ref PlaylistsGroup plg ,string filePath = DefaultPath)
        {
            string cover = FileManager.UploadFile(filePath);

            Playlist playlist = new Playlist();

            playlist.Name = name;
            playlist.Cover = cover;
            playlist.Id = new Random().Next(int.MaxValue);

            plg.AddPlaylist(playlist);

            return playlist;
        }
    }
}
