namespace ClassLibrary
{
    public class SongList
    {
        int _count = 0;
        List<Song> _songs = new List<Song> { };

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }
        
        public void Add(Song s) { 
            _songs.Add(s);
            _count++;
        }

        public void Remove(Song s) { 
            _songs.Remove(s);
            _count--;
        }
        public List<Song> Songs
        {
            get { return _songs; }
        }
    }
}
