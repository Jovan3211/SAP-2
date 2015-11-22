namespace SAP_2
{
    partial class addplist
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
            this.textBox_playlistName = new System.Windows.Forms.TextBox();
            this.label_playListName = new System.Windows.Forms.Label();
            this.label_saveLocation = new System.Windows.Forms.Label();
            this.textBox_saveLocation = new System.Windows.Forms.TextBox();
            this.button_saveLocationDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.listBox = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_remove = new System.Windows.Forms.Button();
            this.textBox_addSong = new System.Windows.Forms.TextBox();
            this.button_addSongDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_createPlaylist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_playlistName
            // 
            this.textBox_playlistName.Location = new System.Drawing.Point(100, 12);
            this.textBox_playlistName.Name = "textBox_playlistName";
            this.textBox_playlistName.Size = new System.Drawing.Size(301, 20);
            this.textBox_playlistName.TabIndex = 0;
            // 
            // label_playListName
            // 
            this.label_playListName.AutoSize = true;
            this.label_playListName.Location = new System.Drawing.Point(12, 15);
            this.label_playListName.Name = "label_playListName";
            this.label_playListName.Size = new System.Drawing.Size(71, 13);
            this.label_playListName.TabIndex = 1;
            this.label_playListName.Text = "Playlist name:";
            // 
            // label_saveLocation
            // 
            this.label_saveLocation.AutoSize = true;
            this.label_saveLocation.Location = new System.Drawing.Point(12, 41);
            this.label_saveLocation.Name = "label_saveLocation";
            this.label_saveLocation.Size = new System.Drawing.Size(75, 13);
            this.label_saveLocation.TabIndex = 2;
            this.label_saveLocation.Text = "Save location:";
            // 
            // textBox_saveLocation
            // 
            this.textBox_saveLocation.Location = new System.Drawing.Point(100, 38);
            this.textBox_saveLocation.Name = "textBox_saveLocation";
            this.textBox_saveLocation.Size = new System.Drawing.Size(270, 20);
            this.textBox_saveLocation.TabIndex = 3;
            // 
            // button_saveLocationDialog
            // 
            this.button_saveLocationDialog.Location = new System.Drawing.Point(376, 37);
            this.button_saveLocationDialog.Name = "button_saveLocationDialog";
            this.button_saveLocationDialog.Size = new System.Drawing.Size(25, 20);
            this.button_saveLocationDialog.TabIndex = 4;
            this.button_saveLocationDialog.Text = "...";
            this.button_saveLocationDialog.UseVisualStyleBackColor = true;
            this.button_saveLocationDialog.Click += new System.EventHandler(this.button_saveLocationDialog_Click);
            // 
            // listBox
            // 
            this.listBox.AllowDrop = true;
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(100, 103);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(301, 147);
            this.listBox.TabIndex = 5;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(12, 64);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 6;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_remove
            // 
            this.button_remove.Location = new System.Drawing.Point(12, 103);
            this.button_remove.Name = "button_remove";
            this.button_remove.Size = new System.Drawing.Size(75, 23);
            this.button_remove.TabIndex = 7;
            this.button_remove.Text = "Remove";
            this.button_remove.UseVisualStyleBackColor = true;
            this.button_remove.Click += new System.EventHandler(this.button_remove_Click);
            // 
            // textBox_addSong
            // 
            this.textBox_addSong.Location = new System.Drawing.Point(100, 64);
            this.textBox_addSong.Name = "textBox_addSong";
            this.textBox_addSong.Size = new System.Drawing.Size(270, 20);
            this.textBox_addSong.TabIndex = 8;
            this.textBox_addSong.Text = "Select a song to add.";
            // 
            // button_addSongDialog
            // 
            this.button_addSongDialog.Location = new System.Drawing.Point(376, 63);
            this.button_addSongDialog.Name = "button_addSongDialog";
            this.button_addSongDialog.Size = new System.Drawing.Size(25, 20);
            this.button_addSongDialog.TabIndex = 9;
            this.button_addSongDialog.Text = "...";
            this.button_addSongDialog.UseVisualStyleBackColor = true;
            this.button_addSongDialog.Click += new System.EventHandler(this.button_addSongDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_createPlaylist
            // 
            this.button_createPlaylist.Location = new System.Drawing.Point(12, 209);
            this.button_createPlaylist.Name = "button_createPlaylist";
            this.button_createPlaylist.Size = new System.Drawing.Size(75, 41);
            this.button_createPlaylist.TabIndex = 10;
            this.button_createPlaylist.Text = "Create playlist";
            this.button_createPlaylist.UseVisualStyleBackColor = true;
            // 
            // addplist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 262);
            this.Controls.Add(this.button_createPlaylist);
            this.Controls.Add(this.button_addSongDialog);
            this.Controls.Add(this.textBox_addSong);
            this.Controls.Add(this.button_remove);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button_saveLocationDialog);
            this.Controls.Add(this.textBox_saveLocation);
            this.Controls.Add(this.label_saveLocation);
            this.Controls.Add(this.label_playListName);
            this.Controls.Add(this.textBox_playlistName);
            this.Name = "addplist";
            this.Text = "Add playlist";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_playlistName;
        private System.Windows.Forms.Label label_playListName;
        private System.Windows.Forms.Label label_saveLocation;
        private System.Windows.Forms.TextBox textBox_saveLocation;
        private System.Windows.Forms.Button button_saveLocationDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_remove;
        private System.Windows.Forms.TextBox textBox_addSong;
        private System.Windows.Forms.Button button_addSongDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_createPlaylist;
    }
}