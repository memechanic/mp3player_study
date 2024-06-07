namespace ClassLibrary
{
    public class PlaylistsGroup
    {
        int _count = 0;
        List<Playlist> _list = new List<Playlist> { };

        public int Count 
        { 
            get { return _count; }
            set { _count = value; }
        }

        public void AddPlaylist(Playlist pl)
        {
            _list.Add(pl);
            _count++;
        }
        public void RemovePlaylist(Playlist pl)
        {
            _list.Remove(pl);
            _count--;
        }

        public List<Playlist> List
        {
            get { return _list; }
        }
    }
}
