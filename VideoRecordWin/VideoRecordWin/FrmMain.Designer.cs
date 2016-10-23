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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnplayer
            // 
            this.btnplayer.Location = new System.Drawing.Point(24, 22);
            this.btnplayer.Name = "btnplayer";
            this.btnplayer.Size = new System.Drawing.Size(144, 41);
            this.btnplayer.TabIndex = 0;
            this.btnplayer.Text = "Player";
            this.btnplayer.UseVisualStyleBackColor = true;
            this.btnplayer.Click += new System.EventHandler(this.btnplayer_Click);
            // 
            // btnrecordr
            // 
            this.btnrecordr.Location = new System.Drawing.Point(24, 81);
            this.btnrecordr.Name = "btnrecordr";
            this.btnrecordr.Size = new System.Drawing.Size(144, 41);
            this.btnrecordr.TabIndex = 1;
            this.btnrecordr.Text = "Recorder";
            this.btnrecordr.UseVisualStyleBackColor = true;
            this.btnrecordr.Click += new System.EventHandler(this.btnrecordr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tüm Hakları Saklıdır. VES@2016";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 179);
            this.Controls.Add(this.btnrecordr);
            this.Controls.Add(this.btnplayer);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmain";
            this.Text = "VES VİDEO";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnplayer;
        private System.Windows.Forms.Button btnrecordr;
        private System.Windows.Forms.Label label1;
    }
}

