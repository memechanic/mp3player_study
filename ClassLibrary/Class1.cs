namespace ClassLibrary
{
    public class Song
    {
        int _id;
        string _name;
        string _artist;
        int _duration;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Artist
        {
            get { return _artist; }
            set { _artist = value; }
        }
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }


    }
    public class SongList
    {
        int _id;
        int _count;
        private List<Song> _songs;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public void Add(Song s) { _songs.Add(s);  }

        public void Remove(Song s) { _songs.Remove(s); }
    }

    public class Playlist : SongList
    {
        string _name;
        string _cover;
        int _duration;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Cover
        {
            get { return _cover; }
            set { _cover = value; }
        }
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
    }

    public class Player
    {
        bool _playing;
        private Song _currentSong;

        

        public void PlaySong(Song s) { }
        public void PlayPause() { }
        public void Next(Song s) { }
        public void Previous(Song s) { }

    }


    public class 
}