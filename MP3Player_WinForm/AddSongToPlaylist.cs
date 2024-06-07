using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using Logic;

namespace MP3Player_WinForm
{
    public partial class AddSongToPlaylist : Form
    {
        SongList _songList;
        PlaylistsGroup _playlistGroup;
        int _playlistIndex;
        ListBox _listBox;

        public AddSongToPlaylist(ref SongList songList, ref PlaylistsGroup playlistsGroup,
                                     int playlistIndex, ref ListBox listBox)
        {
            InitializeComponent();
            _songList = songList;
            _playlistGroup = playlistsGroup;
            _playlistIndex = playlistIndex;
            _listBox = listBox;
        }

        private void AddSongToPlaylist_Load(object sender, EventArgs e)
        {
            songsListBox.Items.Clear();

            foreach (Song song in _songList.Songs)
            {
                songsListBox.Items.Add(SongPrinter.GetInfo(song));
            }
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            if (songsListBox.SelectedIndex == -1)
            {
                MessageBox.Show(
                "Select a song",
                "No song",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
                return;
            }
            int addSongIndex = songsListBox.SelectedIndex;
            Playlist playlist = _playlistGroup.List[_playlistIndex];

            Song newsong = _songList.Songs[addSongIndex];
            playlist.Add(newsong);

            _listBox.Items.Clear();

            foreach (Song song in playlist.Songs)
            {
                _listBox.Items.Add(SongPrinter.GetInfo(song));
            }
            
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
