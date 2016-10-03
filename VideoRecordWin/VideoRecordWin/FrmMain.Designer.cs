namespace VideoRecordWin
{
    partial class frmmain
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
            this.btnplayer = new System.Windows.Forms.Button();
            this.btnrecordr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnplayer
            // 
            this.btnplayer.Location = new System.Drawing.Point(24, 30);
            this.btnplayer.Name = "btnplayer";
            this.btnplayer.Size = new System.Drawing.Size(144, 41);
            this.btnplayer.TabIndex = 0;
            this.btnplayer.Text = "Player";
            this.btnplayer.UseVisualStyleBackColor = true;
            this.btnplayer.Click += new System.EventHandler(this.btnplayer_Click);
            // 
            // btnrecordr
            // 
            this.btnrecordr.Location = new System.Drawing.Point(24, 89);
            this.btnrecordr.Name = "btnrecordr";
            this.btnrecordr.Size = new System.Drawing.Size(144, 41);
            this.btnrecordr.TabIndex = 1;
            this.btnrecordr.Text = "Recorder";
            this.btnrecordr.UseVisualStyleBackColor = true;
            this.btnrecordr.Click += new System.EventHandler(this.btnrecordr_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 145);
            this.Controls.Add(this.btnrecordr);
            this.Controls.Add(this.btnplayer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmain";
            this.Text = "MAİN";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnplayer;
        private System.Windows.Forms.Button btnrecordr;
    }
}

