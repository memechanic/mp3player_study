namespace ClassLibrary
{
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

        public void Add(Song s) { _songs.Add(s); }

        public void Remove(Song s) { _songs.Remove(s); }
    }
}
