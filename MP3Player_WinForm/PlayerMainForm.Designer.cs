namespace MP3Player_WinForm
{
    partial class playerMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playerMainForm));
            allSongsLabel = new Label();
            songsListBox = new ListBox();
            playlistsListBox = new ListBox();
            playlistsLabel = new Label();
            playlistSongsListBox = new ListBox();
            playlistLabel = new Label();
            addSongButton = new Button();
            deleteSongButton = new Button();
            playlistEditButton = new Button();
            playlistDeletebutton = new Button();
            playlistAddButton = new Button();
            addSongToPlaylistButton = new Button();
            deleteSongFromPlaylistButton = new Button();
            playlistNameLabel = new Label();
            playlistDurationLabel = new Label();
            playlistCountLabel = new Label();
            openSongDialog = new OpenFileDialog();
            NameLabel = new Label();
            DurationLabel = new Label();
            CountLabel = new Label();
            playlistCoverLabel = new Label();
            CoverLabel = new Label();
            SuspendLayout();
            // 
            // allSongsLabel
            // 
            resources.ApplyResources(allSongsLabel, "allSongsLabel");
            allSongsLabel.Name = "allSongsLabel";
            allSongsLabel.Tag = "";
            // 
            // songsListBox
            // 
            songsListBox.FormattingEnabled = true;
            resources.ApplyResources(songsListBox, "songsListBox");
            songsListBox.Name = "songsListBox";
            // 
            // playlistsListBox
            // 
            playlistsListBox.FormattingEnabled = true;
            resources.ApplyResources(playlistsListBox, "playlistsListBox");
            playlistsListBox.Name = "playlistsListBox";
            playlistsListBox.SelectedIndexChanged += plalyistsListBox_SelectedIndexChanged;
            // 
            // playlistsLabel
            // 
            resources.ApplyResources(playlistsLabel, "playlistsLabel");
            playlistsLabel.Name = "playlistsLabel";
            playlistsLabel.Tag = "";
            // 
            // playlistSongsListBox
            // 
            playlistSongsListBox.FormattingEnabled = true;
            resources.ApplyResources(playlistSongsListBox, "playlistSongsListBox");
            playlistSongsListBox.Name = "playlistSongsListBox";
            // 
            // playlistLabel
            // 
            resources.ApplyResources(playlistLabel, "playlistLabel");
            playlistLabel.Name = "playlistLabel";
            playlistLabel.Tag = "";
            // 
            // addSongButton
            // 
            resources.ApplyResources(addSongButton, "addSongButton");
            addSongButton.Name = "addSongButton";
            addSongButton.UseVisualStyleBackColor = true;
            addSongButton.Click += addSongButton_Click;
            // 
            // deleteSongButton
            // 
            resources.ApplyResources(deleteSongButton, "deleteSongButton");
            deleteSongButton.Name = "deleteSongButton";
            deleteSongButton.UseVisualStyleBackColor = true;
            deleteSongButton.Click += deleteSongButton_Click;
            // 
            // playlistEditButton
            // 
            resources.ApplyResources(playlistEditButton, "playlistEditButton");
            playlistEditButton.Name = "playlistEditButton";
            playlistEditButton.UseVisualStyleBackColor = true;
            playlistEditButton.Click += playlistEditButton_Click;
            // 
            // playlistDeletebutton
            // 
            resources.ApplyResources(playlistDeletebutton, "playlistDeletebutton");
            playlistDeletebutton.Name = "playlistDeletebutton";
            playlistDeletebutton.UseVisualStyleBackColor = true;
            playlistDeletebutton.Click += playlistDeletebutton_Click;
            // 
            // playlistAddButton
            // 
            resources.ApplyResources(playlistAddButton, "playlistAddButton");
            playlistAddButton.Name = "playlistAddButton";
            playlistAddButton.UseVisualStyleBackColor = true;
            playlistAddButton.Click += playlistAddButton_Click;
            // 
            // addSongToPlaylistButton
            // 
            resources.ApplyResources(addSongToPlaylistButton, "addSongToPlaylistButton");
            addSongToPlaylistButton.Name = "addSongToPlaylistButton";
            addSongToPlaylistButton.UseVisualStyleBackColor = true;
            addSongToPlaylistButton.Click += addSongToPlaylistButton_Click;
            // 
            // deleteSongFromPlaylistButton
            // 
            resources.ApplyResources(deleteSongFromPlaylistButton, "deleteSongFromPlaylistButton");
            deleteSongFromPlaylistButton.Name = "deleteSongFromPlaylistButton";
            deleteSongFromPlaylistButton.UseVisualStyleBackColor = true;
            deleteSongFromPlaylistButton.Click += deleteSongFromPlaylistButton_Click;
            // 
            // playlistNameLabel
            // 
            resources.ApplyResources(playlistNameLabel, "playlistNameLabel");
            playlistNameLabel.Name = "playlistNameLabel";
            playlistNameLabel.Tag = "";
            // 
            // playlistDurationLabel
            // 
            resources.ApplyResources(playlistDurationLabel, "playlistDurationLabel");
            playlistDurationLabel.Name = "playlistDurationLabel";
            playlistDurationLabel.Tag = "";
            // 
            // playlistCountLabel
            // 
            resources.ApplyResources(playlistCountLabel, "playlistCountLabel");
            playlistCountLabel.Name = "playlistCountLabel";
            playlistCountLabel.Tag = "";
            // 
            // openSongDialog
            // 
            openSongDialog.FileName = "openFileDialog1";
            // 
            // NameLabel
            // 
            resources.ApplyResources(NameLabel, "NameLabel");
            NameLabel.Name = "NameLabel";
            NameLabel.Tag = "";
            // 
            // DurationLabel
            // 
            resources.ApplyResources(DurationLabel, "DurationLabel");
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Tag = "";
            // 
            // CountLabel
            // 
            resources.ApplyResources(CountLabel, "CountLabel");
            CountLabel.Name = "CountLabel";
            CountLabel.Tag = "";
            // 
            // playlistCoverLabel
            // 
            resources.ApplyResources(playlistCoverLabel, "playlistCoverLabel");
            playlistCoverLabel.Name = "playlistCoverLabel";
            playlistCoverLabel.Tag = "";
            // 
            // CoverLabel
            // 
            resources.ApplyResources(CoverLabel, "CoverLabel");
            CoverLabel.Name = "CoverLabel";
            CoverLabel.Tag = "";
            // 
            // playerMainForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CoverLabel);
            Controls.Add(playlistCoverLabel);
            Controls.Add(CountLabel);
            Controls.Add(playlistCountLabel);
            Controls.Add(DurationLabel);
            Controls.Add(playlistDurationLabel);
            Controls.Add(NameLabel);
            Controls.Add(playlistNameLabel);
            Controls.Add(playlistEditButton);
            Controls.Add(deleteSongFromPlaylistButton);
            Controls.Add(playlistDeletebutton);
            Controls.Add(addSongToPlaylistButton);
            Controls.Add(playlistAddButton);
            Controls.Add(deleteSongButton);
            Controls.Add(addSongButton);
            Controls.Add(playlistSongsListBox);
            Controls.Add(playlistLabel);
            Controls.Add(playlistsListBox);
            Controls.Add(playlistsLabel);
            Controls.Add(songsListBox);
            Controls.Add(allSongsLabel);
            Name = "playerMainForm";
            Load += playerMainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label allSongsLabel;
        private ListBox songsListBox;
        private ListBox playlistsListBox;
        private Label playlistsLabel;
        private ListBox playlistSongsListBox;
        private Label playlistLabel;
        private Button addSongButton;
        private Button deleteSongButton;
        private Button playlistEditButton;
        private Button playlistDeletebutton;
        private Button playlistAddButton;
        private Button addSongToPlaylistButton;
        private Button deleteSongFromPlaylistButton;
        private Label playlistNameLabel;
        private Label playlistDurationLabel;
        private Label playlistCountLabel;
        private OpenFileDialog openSongDialog;
        private Label NameLabel;
        private Label DurationLabel;
        private Label CountLabel;
        private Label playlistCoverLabel;
        private Label CoverLabel;
    }
}
