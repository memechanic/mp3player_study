namespace MP3Player_WinForm
{
    partial class AddSongToPlaylist
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            songsListBox = new ListBox();
            addSongButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // songsListBox
            // 
            songsListBox.FormattingEnabled = true;
            songsListBox.ItemHeight = 20;
            songsListBox.Location = new Point(12, 12);
            songsListBox.Name = "songsListBox";
            songsListBox.Size = new Size(240, 264);
            songsListBox.TabIndex = 0;
            // 
            // addSongButton
            // 
            addSongButton.Location = new Point(12, 285);
            addSongButton.Name = "addSongButton";
            addSongButton.Size = new Size(94, 29);
            addSongButton.TabIndex = 1;
            addSongButton.Text = "Add";
            addSongButton.UseVisualStyleBackColor = true;
            addSongButton.Click += addSongButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(158, 285);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(94, 29);
            cancelButton.TabIndex = 1;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddSongToPlaylist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(267, 326);
            Controls.Add(cancelButton);
            Controls.Add(addSongButton);
            Controls.Add(songsListBox);
            Name = "AddSongToPlaylist";
            Text = "Add Song";
            Load += AddSongToPlaylist_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox songsListBox;
        private Button addSongButton;
        private Button cancelButton;
    }
}