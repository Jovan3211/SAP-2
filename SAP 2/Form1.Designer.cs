namespace SAP_2
{
    partial class Form1
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
            this.playSingle = new System.Windows.Forms.Button();
            this.createplist = new System.Windows.Forms.Button();
            this.selectplist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // playSingle
            // 
            this.playSingle.Location = new System.Drawing.Point(28, 17);
            this.playSingle.Name = "playSingle";
            this.playSingle.Size = new System.Drawing.Size(104, 27);
            this.playSingle.TabIndex = 0;
            this.playSingle.Text = "Play single";
            this.playSingle.UseVisualStyleBackColor = true;
            this.playSingle.Click += new System.EventHandler(this.playSingle_Click);
            // 
            // createplist
            // 
            this.createplist.Location = new System.Drawing.Point(28, 50);
            this.createplist.Name = "createplist";
            this.createplist.Size = new System.Drawing.Size(104, 27);
            this.createplist.TabIndex = 1;
            this.createplist.Text = "Create playlist";
            this.createplist.UseVisualStyleBackColor = true;
            this.createplist.Click += new System.EventHandler(this.createplist_Click);
            // 
            // selectplist
            // 
            this.selectplist.Location = new System.Drawing.Point(28, 83);
            this.selectplist.Name = "selectplist";
            this.selectplist.Size = new System.Drawing.Size(104, 27);
            this.selectplist.TabIndex = 2;
            this.selectplist.Text = "Select playlist";
            this.selectplist.UseVisualStyleBackColor = true;
            this.selectplist.Click += new System.EventHandler(this.selectplist_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(162, 131);
            this.Controls.Add(this.selectplist);
            this.Controls.Add(this.createplist);
            this.Controls.Add(this.playSingle);
            this.Name = "Form1";
            this.Text = "SAP 2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playSingle;
        private System.Windows.Forms.Button createplist;
        private System.Windows.Forms.Button selectplist;
    }
}

