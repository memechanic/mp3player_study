using ClassLibrary;

namespace Logic
{
    public class SongFactory
    {
        public static Song UploadSong(string filePath, ref SongList sl)
        {
            string file = FileManager.UploadFile(filePath);

            if (file != "error")
            {
                Song song = new Song();

                string[] info = file.Split( ' ' );
                song.Id = new Random().Next(int.MaxValue);
                song.Name = info[0];
                song.Artist = info[1];
                song.Duration = int.Parse(info[2]);

                sl.Add(song);

                return song;
            }
            else { throw new Exception("Error in uploading"); }
        }
    }
}
