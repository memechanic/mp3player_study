using ClassLibrary;
using Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3Player_WinForm
{
    public partial class EditPlaylist : Form
    {
        PlaylistsGroup _playlistsGroup;
        ListBox _listBox;
        string _cover;

        public EditPlaylist(ref PlaylistsGroup playlistsGroup, ref ListBox listBox)
        {
            InitializeComponent();

            _playlistsGroup = playlistsGroup;
            _listBox = listBox;
            _cover = "";
        }

        private void EditPlaylist_Load(object sender, EventArgs e)
        {

        }


        private void editCoverButton_Click(object sender, EventArgs e)
        {
            if (openCoverDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string path = openCoverDialog.FileName;
            _cover = path;
            coverNameLabel.Text = path.Substring(path.LastIndexOf("\\") + 1);
        }


        private void editPlaylistButton_Click(object sender, EventArgs e)
        {
            string newName = newNameTextBox.Text;
            int playlistIndex = _listBox.SelectedIndex;

            Playlist editedPlaylist = _playlistsGroup.List[playlistIndex];
            if(newName != "") { editedPlaylist.Name = newName; }
            if (_cover != "") { editedPlaylist.Cover = _cover; }

            //_playlistsGroup.List[playlistIndex] = playlist;

            _listBox.Items.Clear();

            foreach (Playlist playlist in _playlistsGroup.List)
            {
                _listBox.Items.Add(PlaylistPrinter.GetName(playlist));
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
