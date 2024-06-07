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
    public partial class AddPlaylistForm : Form
    {
        PlaylistsGroup _playlistsGroup;
        ListBox _listBox;
        string _cover;

        public AddPlaylistForm(ref PlaylistsGroup playlistsGroup, ref ListBox listBox)
        {
            InitializeComponent();
            _playlistsGroup = playlistsGroup;
            _listBox = listBox;
            _cover = "";
        }

        private void AddPlaylistForm_Load(object sender, EventArgs e)
        {

        }

        private void addCoverButton_Click(object sender, EventArgs e)
        {
            if (openCoverDialog.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }
            string path = openCoverDialog.FileName;
            _cover = path;
            coverNameLabel.Text = path.Substring(path.LastIndexOf("\\") + 1);
        }

        private void createPlaylistButton_Click(object sender, EventArgs e)
        {
            if (_cover == "")
            {
                MessageBox.Show(
                "Cover requaried",
                "No cover",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Error);
                return;
            }
            else
            {
                string name = nameTextBox.Text;

                if (_cover == "")
                {
                    PlaylistFactory.CreatePlaylist(name, ref _playlistsGroup);
                }
                else
                {
                    PlaylistFactory.CreatePlaylist(name, ref _playlistsGroup, _cover);
                }

                _listBox.Items.Clear();

                foreach (Playlist playlist in _playlistsGroup.List)
                {
                    _listBox.Items.Add(PlaylistPrinter.GetName(playlist));
                }
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
