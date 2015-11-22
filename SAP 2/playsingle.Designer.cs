namespace SAP_2
{
    partial class playsingle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(playsingle));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_play = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btOpen = new System.Windows.Forms.Button();
            this.button_pause = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label_volume = new System.Windows.Forms.Label();
            this.label_volumeAmount = new System.Windows.Forms.Label();
            this.label_songName = new System.Windows.Forms.Label();
            this.label_songTime = new System.Windows.Forms.Label();
            this.label_upNext = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mediaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playASongToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playMultipleSongsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createANewPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playlistEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewHelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an audio file or a playlist:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button_play
            // 
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.Location = new System.Drawing.Point(13, 74);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(40, 34);
            this.button_play.TabIndex = 2;
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_stop
            // 
            this.button_stop.Image = ((System.Drawing.Image)(resources.GetObject("button_stop.Image")));
            this.button_stop.Location = new System.Drawing.Point(105, 74);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(40, 34);
            this.button_stop.TabIndex = 4;
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btOpen
            // 
            this.btOpen.Location = new System.Drawing.Point(250, 48);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(25, 20);
            this.btOpen.TabIndex = 5;
            this.btOpen.Text = "...";
            this.btOpen.UseVisualStyleBackColor = true;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // button_pause
            // 
            this.button_pause.Image = ((System.Drawing.Image)(resources.GetObject("button_pause.Image")));
            this.button_pause.Location = new System.Drawing.Point(59, 74);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(40, 34);
            this.button_pause.TabIndex = 8;
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(152, 74);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(121, 45);
            this.trackBar1.TabIndex = 11;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label_volume
            // 
            this.label_volume.AutoSize = true;
            this.label_volume.Location = new System.Drawing.Point(162, 95);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(102, 13);
            this.label_volume.TabIndex = 12;
            this.label_volume.Text = "Volume:                   ";
            // 
            // label_volumeAmount
            // 
            this.label_volumeAmount.AutoSize = true;
            this.label_volumeAmount.Location = new System.Drawing.Point(207, 95);
            this.label_volumeAmount.Name = "label_volumeAmount";
            this.label_volumeAmount.Size = new System.Drawing.Size(19, 13);
            this.label_volumeAmount.TabIndex = 13;
            this.label_volumeAmount.Text = "50";
            // 
            // label_songName
            // 
            this.label_songName.AutoSize = true;
            this.label_songName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_songName.Location = new System.Drawing.Point(7, 143);
            this.label_songName.Name = "label_songName";
            this.label_songName.Size = new System.Drawing.Size(62, 17);
            this.label_songName.TabIndex = 14;
            this.label_songName.Text = "Playing: ";
            this.label_songName.Visible = false;
            // 
            // label_songTime
            // 
            this.label_songTime.AutoSize = true;
            this.label_songTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_songTime.Location = new System.Drawing.Point(6, 118);
            this.label_songTime.Name = "label_songTime";
            this.label_songTime.Size = new System.Drawing.Size(55, 22);
            this.label_songTime.TabIndex = 15;
            this.label_songTime.Text = "00:00";
            // 
            // label_upNext
            // 
            this.label_upNext.AutoSize = true;
            this.label_upNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_upNext.Location = new System.Drawing.Point(7, 165);
            this.label_upNext.Name = "label_upNext";
            this.label_upNext.Size = new System.Drawing.Size(64, 17);
            this.label_upNext.TabIndex = 16;
            this.label_upNext.Text = "Up next: ";
            this.label_upNext.Visible = false;
            // 
            // t1
            // 
            this.t1.Interval = 500;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mediaToolStripMenuItem,
            this.playlistToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mediaToolStripMenuItem
            // 
            this.mediaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playASongToolStripMenuItem,
            this.playMultipleSongsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.mediaToolStripMenuItem.Name = "mediaToolStripMenuItem";
            this.mediaToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.mediaToolStripMenuItem.Text = "Media";
            // 
            // playASongToolStripMenuItem
            // 
            this.playASongToolStripMenuItem.Name = "playASongToolStripMenuItem";
            this.playASongToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playASongToolStripMenuItem.Text = "Play a song";
            this.playASongToolStripMenuItem.Click += new System.EventHandler(this.playASongToolStripMenuItem_Click);
            // 
            // playMultipleSongsToolStripMenuItem
            // 
            this.playMultipleSongsToolStripMenuItem.Name = "playMultipleSongsToolStripMenuItem";
            this.playMultipleSongsToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.playMultipleSongsToolStripMenuItem.Text = "Play multiple songs";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // playlistToolStripMenuItem
            // 
            this.playlistToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createANewPlaylistToolStripMenuItem,
            this.openAPlaylistToolStripMenuItem,
            this.playlistEditorToolStripMenuItem});
            this.playlistToolStripMenuItem.Name = "playlistToolStripMenuItem";
            this.playlistToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.playlistToolStripMenuItem.Text = "Playlist";
            // 
            // createANewPlaylistToolStripMenuItem
            // 
            this.createANewPlaylistToolStripMenuItem.Name = "createANewPlaylistToolStripMenuItem";
            this.createANewPlaylistToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.createANewPlaylistToolStripMenuItem.Text = "Create a new playlist";
            this.createANewPlaylistToolStripMenuItem.Click += new System.EventHandler(this.createANewPlaylistToolStripMenuItem_Click);
            // 
            // openAPlaylistToolStripMenuItem
            // 
            this.openAPlaylistToolStripMenuItem.Name = "openAPlaylistToolStripMenuItem";
            this.openAPlaylistToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.openAPlaylistToolStripMenuItem.Text = "Open a playlist";
            this.openAPlaylistToolStripMenuItem.Click += new System.EventHandler(this.openAPlaylistToolStripMenuItem_Click);
            // 
            // playlistEditorToolStripMenuItem
            // 
            this.playlistEditorToolStripMenuItem.Name = "playlistEditorToolStripMenuItem";
            this.playlistEditorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.playlistEditorToolStripMenuItem.Text = "Playlist editor";
            this.playlistEditorToolStripMenuItem.Click += new System.EventHandler(this.playlistEditorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewHelpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // viewHelpToolStripMenuItem
            // 
            this.viewHelpToolStripMenuItem.Name = "viewHelpToolStripMenuItem";
            this.viewHelpToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.viewHelpToolStripMenuItem.Text = "View Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // playsingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 191);
            this.Controls.Add(this.label_upNext);
            this.Controls.Add(this.label_songTime);
            this.Controls.Add(this.label_songName);
            this.Controls.Add(this.label_volumeAmount);
            this.Controls.Add(this.label_volume);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.button_pause);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 229);
            this.MinimumSize = new System.Drawing.Size(300, 229);
            this.Name = "playsingle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "SAP 2";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.Button button_pause;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label_volume;
        private System.Windows.Forms.Label label_volumeAmount;
        private System.Windows.Forms.Label label_songName;
        private System.Windows.Forms.Label label_songTime;
        private System.Windows.Forms.Label label_upNext;
        private System.Windows.Forms.Timer t1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem playlistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createANewPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openAPlaylistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewHelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playASongToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playMultipleSongsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playlistEditorToolStripMenuItem;
    }
}