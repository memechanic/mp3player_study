namespace MP3Player_WinForm
{
    partial class EditPlaylist
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
            coverNameLabel = new Label();
            editPlaylistButton = new Button();
            newCoverButton = new Button();
            editPlaylistLabel = new Label();
            coverLabel = new Label();
            newNameLabel = new Label();
            newNameTextBox = new TextBox();
            openCoverDialog = new OpenFileDialog();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // coverNameLabel
            // 
            coverNameLabel.AutoSize = true;
            coverNameLabel.Location = new Point(104, 73);
            coverNameLabel.Name = "coverNameLabel";
            coverNameLabel.Size = new Size(0, 20);
            coverNameLabel.TabIndex = 12;
            // 
            // editPlaylistButton
            // 
            editPlaylistButton.Location = new Point(12, 135);
            editPlaylistButton.Name = "editPlaylistButton";
            editPlaylistButton.Size = new Size(223, 29);
            editPlaylistButton.TabIndex = 10;
            editPlaylistButton.Text = "Edit playlist";
            editPlaylistButton.UseVisualStyleBackColor = true;
            editPlaylistButton.Click += editPlaylistButton_Click;
            // 
            // newCoverButton
            // 
            newCoverButton.Location = new Point(12, 100);
            newCoverButton.Name = "newCoverButton";
            newCoverButton.Size = new Size(223, 29);
            newCoverButton.TabIndex = 11;
            newCoverButton.Text = "New Cover";
            newCoverButton.UseVisualStyleBackColor = true;
            newCoverButton.Click += editCoverButton_Click;
            // 
            // editPlaylistLabel
            // 
            editPlaylistLabel.AutoSize = true;
            editPlaylistLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            editPlaylistLabel.Location = new Point(12, 10);
            editPlaylistLabel.Name = "editPlaylistLabel";
            editPlaylistLabel.Size = new Size(96, 21);
            editPlaylistLabel.TabIndex = 9;
            editPlaylistLabel.Text = "Edit playlist";
            // 
            // coverLabel
            // 
            coverLabel.AutoSize = true;
            coverLabel.Location = new Point(12, 72);
            coverLabel.Margin = new Padding(3);
            coverLabel.Name = "coverLabel";
            coverLabel.Size = new Size(86, 20);
            coverLabel.TabIndex = 8;
            coverLabel.Text = "New cover: ";
            // 
            // newNameLabel
            // 
            newNameLabel.AutoSize = true;
            newNameLabel.Location = new Point(12, 46);
            newNameLabel.Margin = new Padding(3);
            newNameLabel.Name = "newNameLabel";
            newNameLabel.Size = new Size(80, 20);
            newNameLabel.TabIndex = 7;
            newNameLabel.Text = "New name";
            // 
            // newNameTextBox
            // 
            newNameTextBox.Location = new Point(105, 43);
            newNameTextBox.Name = "newNameTextBox";
            newNameTextBox.Size = new Size(130, 27);
            newNameTextBox.TabIndex = 6;
            // 
            // openCoverDialog
            // 
            openCoverDialog.FileName = "openFileDialog1";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 170);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(223, 29);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // EditPlaylist
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 213);
            Controls.Add(coverNameLabel);
            Controls.Add(cancelButton);
            Controls.Add(editPlaylistButton);
            Controls.Add(newCoverButton);
            Controls.Add(editPlaylistLabel);
            Controls.Add(coverLabel);
            Controls.Add(newNameLabel);
            Controls.Add(newNameTextBox);
            Name = "EditPlaylist";
            Text = "EditPlaylist";
            Load += EditPlaylist_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label coverNameLabel;
        private Button editPlaylistButton;
        private Button newCoverButton;
        private Label editPlaylistLabel;
        private Label coverLabel;
        private Label newNameLabel;
        private TextBox newNameTextBox;
        private OpenFileDialog openCoverDialog;
        private Button cancelButton;
    }
}