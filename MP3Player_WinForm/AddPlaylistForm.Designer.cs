namespace MP3Player_WinForm
{
    partial class AddPlaylistForm
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
            nameTextBox = new TextBox();
            nameLabel = new Label();
            coverLabel = new Label();
            createPlaylistLabel = new Label();
            addCoverButton = new Button();
            coverNameLabel = new Label();
            createPlaylistButton = new Button();
            openCoverDialog = new OpenFileDialog();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(67, 42);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(168, 28);
            nameTextBox.TabIndex = 0;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(12, 45);
            nameLabel.Margin = new Padding(3);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(48, 20);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Name";
            // 
            // coverLabel
            // 
            coverLabel.AutoSize = true;
            coverLabel.Location = new Point(12, 73);
            coverLabel.Margin = new Padding(3);
            coverLabel.Name = "coverLabel";
            coverLabel.Size = new Size(56, 20);
            coverLabel.TabIndex = 2;
            coverLabel.Text = "Cover: ";
            // 
            // createPlaylistLabel
            // 
            createPlaylistLabel.AutoSize = true;
            createPlaylistLabel.Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point);
            createPlaylistLabel.Location = new Point(12, 9);
            createPlaylistLabel.Name = "createPlaylistLabel";
            createPlaylistLabel.Size = new Size(147, 21);
            createPlaylistLabel.TabIndex = 3;
            createPlaylistLabel.Text = "Create new Playlist";
            // 
            // addCoverButton
            // 
            addCoverButton.Location = new Point(12, 99);
            addCoverButton.Name = "addCoverButton";
            addCoverButton.Size = new Size(223, 29);
            addCoverButton.TabIndex = 4;
            addCoverButton.Text = "Add Cover";
            addCoverButton.UseVisualStyleBackColor = true;
            addCoverButton.Click += addCoverButton_Click;
            // 
            // coverNameLabel
            // 
            coverNameLabel.AutoSize = true;
            coverNameLabel.Location = new Point(74, 73);
            coverNameLabel.Name = "coverNameLabel";
            coverNameLabel.Size = new Size(0, 20);
            coverNameLabel.TabIndex = 5;
            // 
            // createPlaylistButton
            // 
            createPlaylistButton.Location = new Point(12, 134);
            createPlaylistButton.Name = "createPlaylistButton";
            createPlaylistButton.Size = new Size(223, 29);
            createPlaylistButton.TabIndex = 4;
            createPlaylistButton.Text = "Create playlist";
            createPlaylistButton.UseVisualStyleBackColor = true;
            createPlaylistButton.Click += createPlaylistButton_Click;
            // 
            // openCoverDialog
            // 
            openCoverDialog.FileName = "openFileDialog1";
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(12, 169);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(223, 29);
            cancelButton.TabIndex = 4;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += button1_Click;
            // 
            // AddPlaylistForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(247, 203);
            Controls.Add(coverNameLabel);
            Controls.Add(cancelButton);
            Controls.Add(createPlaylistButton);
            Controls.Add(addCoverButton);
            Controls.Add(createPlaylistLabel);
            Controls.Add(coverLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameTextBox);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "AddPlaylistForm";
            Text = "Add Playlist";
            Load += AddPlaylistForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private Label nameLabel;
        private Label coverLabel;
        private Label createPlaylistLabel;
        private Button addCoverButton;
        private Label coverNameLabel;
        private Button createPlaylistButton;
        private OpenFileDialog openCoverDialog;
        private Button cancelButton;
    }
}