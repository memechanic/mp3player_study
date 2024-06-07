namespace ClassLibrary
{
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
}
