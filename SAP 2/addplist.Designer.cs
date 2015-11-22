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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addplist));
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
            this.pictureBox_dragDrop = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dragDrop)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_playlistName
            // 
            this.textBox_playlistName.Location = new System.Drawing.Point(100, 12);
            this.textBox_playlistName.Name = "textBox_playlistName";
            this.textBox_playlistName.Size = new System.Drawing.Size(440, 20);
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
            this.textBox_saveLocation.Size = new System.Drawing.Size(409, 20);
            this.textBox_saveLocation.TabIndex = 3;
            // 
            // button_saveLocationDialog
            // 
            this.button_saveLocationDialog.Location = new System.Drawing.Point(515, 38);
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
            this.listBox.Size = new System.Drawing.Size(440, 199);
            this.listBox.TabIndex = 5;
            this.listBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.listBox.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.listBox.DragLeave += new System.EventHandler(this.listBox_DragLeave);
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
            this.textBox_addSong.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_addSong.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox_addSong.Location = new System.Drawing.Point(100, 64);
            this.textBox_addSong.Name = "textBox_addSong";
            this.textBox_addSong.Size = new System.Drawing.Size(409, 20);
            this.textBox_addSong.TabIndex = 8;
            this.textBox_addSong.Text = "Select a song to add. You can also drag and drop files below.";
            this.textBox_addSong.Click += new System.EventHandler(this.textBox_addSong_Click);
            // 
            // button_addSongDialog
            // 
            this.button_addSongDialog.Location = new System.Drawing.Point(515, 64);
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
            this.button_createPlaylist.Location = new System.Drawing.Point(12, 261);
            this.button_createPlaylist.Name = "button_createPlaylist";
            this.button_createPlaylist.Size = new System.Drawing.Size(75, 41);
            this.button_createPlaylist.TabIndex = 10;
            this.button_createPlaylist.Text = "Create playlist";
            this.button_createPlaylist.UseVisualStyleBackColor = true;
            this.button_createPlaylist.Click += new System.EventHandler(this.button_createPlaylist_Click);
            // 
            // pictureBox_dragDrop
            // 
            this.pictureBox_dragDrop.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBox_dragDrop.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_dragDrop.Image")));
            this.pictureBox_dragDrop.Location = new System.Drawing.Point(261, 137);
            this.pictureBox_dragDrop.Name = "pictureBox_dragDrop";
            this.pictureBox_dragDrop.Size = new System.Drawing.Size(130, 130);
            this.pictureBox_dragDrop.TabIndex = 11;
            this.pictureBox_dragDrop.TabStop = false;
            this.pictureBox_dragDrop.Visible = false;
            // 
            // addplist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 312);
            this.Controls.Add(this.pictureBox_dragDrop);
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
            this.Text = "Create playlist";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_dragDrop)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox_dragDrop;
    }
}