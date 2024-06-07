namespace ClassLibrary
{
    public class Playlist : SongList
    {
        int _id;
        string _name;
        string _cover;
        int _duration = 0;

        public int Id
        {
            set { _id = value; }
            get { return _id; } 
        }

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
            get {
                if (Songs.Count != 0)
                {
                    _duration = 0;
                    foreach (var item in Songs) { _duration += item.Duration; }
                    return _duration;
                }
                else { return _duration; }
            }
            set { _duration = value; }
        }
    }
}
