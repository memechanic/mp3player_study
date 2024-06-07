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
}
