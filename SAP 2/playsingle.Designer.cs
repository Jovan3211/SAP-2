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
            this.label2 = new System.Windows.Forms.Label();
            this.t1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select an audio file:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(10, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(232, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button_play
            // 
            this.button_play.Image = ((System.Drawing.Image)(resources.GetObject("button_play.Image")));
            this.button_play.Location = new System.Drawing.Point(13, 51);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(40, 34);
            this.button_play.TabIndex = 2;
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_stop
            // 
            this.button_stop.Image = ((System.Drawing.Image)(resources.GetObject("button_stop.Image")));
            this.button_stop.Location = new System.Drawing.Point(105, 51);
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
            this.btOpen.Location = new System.Drawing.Point(250, 25);
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
            this.button_pause.Location = new System.Drawing.Point(59, 51);
            this.button_pause.Name = "button_pause";
            this.button_pause.Size = new System.Drawing.Size(40, 34);
            this.button_pause.TabIndex = 8;
            this.button_pause.UseVisualStyleBackColor = true;
            this.button_pause.Click += new System.EventHandler(this.button_pause_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(152, 51);
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
            this.label_volume.Location = new System.Drawing.Point(162, 72);
            this.label_volume.Name = "label_volume";
            this.label_volume.Size = new System.Drawing.Size(102, 13);
            this.label_volume.TabIndex = 12;
            this.label_volume.Text = "Volume:                   ";
            // 
            // label_volumeAmount
            // 
            this.label_volumeAmount.AutoSize = true;
            this.label_volumeAmount.Location = new System.Drawing.Point(207, 72);
            this.label_volumeAmount.Name = "label_volumeAmount";
            this.label_volumeAmount.Size = new System.Drawing.Size(19, 13);
            this.label_volumeAmount.TabIndex = 13;
            this.label_volumeAmount.Text = "50";
            // 
            // label_songName
            // 
            this.label_songName.AutoSize = true;
            this.label_songName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_songName.Location = new System.Drawing.Point(7, 101);
            this.label_songName.Name = "label_songName";
            this.label_songName.Size = new System.Drawing.Size(62, 17);
            this.label_songName.TabIndex = 14;
            this.label_songName.Text = "Playing: ";
            // 
            // label_songTime
            // 
            this.label_songTime.AutoSize = true;
            this.label_songTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_songTime.Location = new System.Drawing.Point(206, 99);
            this.label_songTime.Name = "label_songTime";
            this.label_songTime.Size = new System.Drawing.Size(49, 20);
            this.label_songTime.TabIndex = 15;
            this.label_songTime.Text = "00:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(7, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Up next: ";
            // 
            // t1
            // 
            this.t1.Interval = 500;
            this.t1.Tick += new System.EventHandler(this.t1_Tick);
            // 
            // playsingle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 250);
            this.Controls.Add(this.label2);
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
            this.Name = "playsingle";
            this.Text = "Playing";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer t1;
    }
}