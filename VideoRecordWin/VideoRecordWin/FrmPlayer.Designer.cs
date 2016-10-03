namespace VideoRecordWin
{
    partial class FrmPlayer
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
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.dosyaAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dosyaHakkındaBilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Pctresim = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctresim)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem,
            this.dosyaHakkındaBilgiToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(801, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            this.dosyaAçToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.dosyaAçToolStripMenuItem.Text = "Dosya Ac";
            this.dosyaAçToolStripMenuItem.Click += new System.EventHandler(this.dosyaAcToolStripMenuItem_Click);
            // 
            // dosyaHakkındaBilgiToolStripMenuItem
            // 
            this.dosyaHakkındaBilgiToolStripMenuItem.Name = "dosyaHakkındaBilgiToolStripMenuItem";
            this.dosyaHakkındaBilgiToolStripMenuItem.Size = new System.Drawing.Size(130, 20);
            this.dosyaHakkındaBilgiToolStripMenuItem.Text = "Dosya Hakkında Bilgi";
            this.dosyaHakkındaBilgiToolStripMenuItem.Click += new System.EventHandler(this.dosyaHakkndaToolStripMenuItem_Click);
            // 
            // Pctresim
            // 
            this.Pctresim.Location = new System.Drawing.Point(12, 27);
            this.Pctresim.Name = "Pctresim";
            this.Pctresim.Size = new System.Drawing.Size(777, 458);
            this.Pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pctresim.TabIndex = 1;
            this.Pctresim.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnplay);
            this.groupBox1.Location = new System.Drawing.Point(12, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 65);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(133, 13);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 42);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "|  |";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnplay
            // 
            this.btnplay.Enabled = false;
            this.btnplay.Location = new System.Drawing.Point(28, 13);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 42);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = ">";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.bntplay_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "Dosya Sec";
            this.OpenFile.Filter = "VideoDosyası|*.ves";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // FrmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 568);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Pctresim);
            this.Controls.Add(this.Menu);
            this.MainMenuStrip = this.Menu;
            this.Name = "FrmPlayer";
            this.Text = "FrmPlayer";
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctresim)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaHakkındaBilgiToolStripMenuItem;
        private System.Windows.Forms.PictureBox Pctresim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Timer Timer;
    }
}