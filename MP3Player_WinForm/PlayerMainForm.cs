using ClassLibrary;
using Logic;
using Interfaces;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;
using System.Diagnostics;

namespace MP3Player_WinForm
{
    public partial class playerMainForm : Form
    {
        SongList? _songList;
        PlaylistsGroup? _playlistsGroup;

        public playerMainForm()
        {
            InitializeComponent();

        }

        private void playerMainForm_Load(object sender, EventArgs e)
        {
            playlistNameLabel.Text = "";
            playlistDurationLabel.Text = "";
            playlistCountLabel.Text = "";
            playlistCoverLabel.Text = "";


            _songList = new SongList { };
            _playlistsGroup = new PlaylistsGroup { };
        }

        private void addSongButton_Click(Object sender, EventArgs e)
        {
            if (openSongDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string filePath = openSongDialog.FileName;
            SongFactory.UploadSong(filePath, ref _songList);

            songsListBox.Items.Clear();

            foreach (Song song in _songList.Songs)
            {
                songsListBox.Items.Add(SongPrinter.GetInfo(song));
            }

        }

        private void playlistAddButton_Click(object sender, EventArgs e)
        {
            Form form = new AddPlaylistForm(ref _playlistsGroup, ref playlistsListBox);
            form.ShowDialog();
        }

        private void addSongToPlaylistButton_Click(object sender, EventArgs e)
        {

            int index = playlistsListBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show(
                "Select a playlist",
                "No playlist",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
                return;
            }
            Form form = new AddSongToPlaylist(ref _songList, ref _playlistsGroup, index, ref playlistSongsListBox);
            form.ShowDialog();

            Playlist playlist = _playlistsGroup.List[index];

            playlistNameLabel.Text = playlist.Name;
            playlistDurationLabel.Text = PlaylistPrinter.GetDuration(playlist);
            playlistCountLabel.Text = playlist.Count.ToString();
            playlistCoverLabel.Text = playlist.Cover;
        }

        private void plalyistsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int playlistIndex = playlistsListBox.SelectedIndex;
            if (playlistIndex != -1)
            {
                Playlist playlist = _playlistsGroup.List[playlistIndex];

                playlistSongsListBox.Items.Clear();

                foreach (Song song in playlist.Songs)
                {
                    playlistSongsListBox.Items.Add(SongPrinter.GetInfo(song));
                }
                playlistNameLabel.Text = playlist.Name;
                playlistDurationLabel.Text = PlaylistPrinter.GetDuration(playlist);
                playlistCountLabel.Text = playlist.Count.ToString();
                playlistCoverLabel.Text = playlist.Cover;
            }
        }

        private void deleteSongButton_Click(object sender, EventArgs e)
        {
            int songIndex = songsListBox.SelectedIndex;
            if (songIndex != -1)
            {
                songsListBox.Items.RemoveAt(songIndex);
                _songList.Songs.RemoveAt(songIndex);
            }
        }

        private void playlistDeletebutton_Click(object sender, EventArgs e)
        {
            playlistSongsListBox.Items.Clear();
            playlistNameLabel.Text = "";
            playlistDurationLabel.Text = "";
            playlistCountLabel.Text = "";
            playlistCoverLabel.Text = "";

            int playlistIndex = playlistsListBox.SelectedIndex;
            if (playlistIndex != -1)
            {
                playlistsListBox.Items.RemoveAt(playlistIndex);
                _playlistsGroup.List.RemoveAt(playlistIndex);
            }
        }

        private void deleteSongFromPlaylistButton_Click(object sender, EventArgs e)
        {
            int songIndex = playlistSongsListBox.SelectedIndex;
            int playlistIndex = playlistsListBox.SelectedIndex;

            Playlist playlist = _playlistsGroup.List[playlistIndex];

            if (songIndex != -1 && playlistIndex != -1)
            {
                playlistSongsListBox.Items.RemoveAt(songIndex);
                playlist.Remove(_songList.Songs[songIndex]);

                playlistDurationLabel.Text = PlaylistPrinter.GetDuration(playlist);
                playlistCountLabel.Text = playlist.Count.ToString();

            }
        }

        private void playlistEditButton_Click(object sender, EventArgs e)
        {
            int playlistIndex = playlistSongsListBox.SelectedIndex;
            Form form = new EditPlaylist(ref _playlistsGroup, ref playlistsListBox);
            form.ShowDialog();
        }
    }
}
