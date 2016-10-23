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
            this.dosyaAçToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldurum = new System.Windows.Forms.Label();
            this.btny = new System.Windows.Forms.Button();
            this.btnh = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.lblsure = new System.Windows.Forms.Label();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Pctresim = new System.Windows.Forms.PictureBox();
            this.Menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctresim)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Menu.Size = new System.Drawing.Size(802, 24);
            this.Menu.TabIndex = 0;
            this.Menu.Text = "Menu";
            // 
            // dosyaAçToolStripMenuItem
            // 
            this.dosyaAçToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaAçToolStripMenuItem1,
            this.bilgiToolStripMenuItem});
            this.dosyaAçToolStripMenuItem.Name = "dosyaAçToolStripMenuItem";
            this.dosyaAçToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaAçToolStripMenuItem.Text = "Dosya";
            // 
            // dosyaAçToolStripMenuItem1
            // 
            this.dosyaAçToolStripMenuItem1.Name = "dosyaAçToolStripMenuItem1";
            this.dosyaAçToolStripMenuItem1.Size = new System.Drawing.Size(97, 22);
            this.dosyaAçToolStripMenuItem1.Text = "Aç";
            this.dosyaAçToolStripMenuItem1.Click += new System.EventHandler(this.dosyaAcToolStripMenuItem_Click);
            // 
            // bilgiToolStripMenuItem
            // 
            this.bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            this.bilgiToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.bilgiToolStripMenuItem.Text = "Bilgi";
            this.bilgiToolStripMenuItem.Click += new System.EventHandler(this.dosyaHakkndaToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.hakkındaToolStripMenuItem.Text = "Hakkımızda";
            this.hakkındaToolStripMenuItem.Click += new System.EventHandler(this.hakkindaToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbldurum);
            this.groupBox1.Controls.Add(this.btny);
            this.groupBox1.Controls.Add(this.btnh);
            this.groupBox1.Controls.Add(this.btnStop);
            this.groupBox1.Controls.Add(this.btnplay);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(12, 536);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(777, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(624, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // lbldurum
            // 
            this.lbldurum.AutoSize = true;
            this.lbldurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldurum.Location = new System.Drawing.Point(603, 28);
            this.lbldurum.Name = "lbldurum";
            this.lbldurum.Size = new System.Drawing.Size(14, 13);
            this.lbldurum.TabIndex = 4;
            this.lbldurum.Text = "0";
            // 
            // btny
            // 
            this.btny.Location = new System.Drawing.Point(675, 13);
            this.btny.Name = "btny";
            this.btny.Size = new System.Drawing.Size(75, 42);
            this.btny.TabIndex = 3;
            this.btny.Text = "<<";
            this.btny.UseVisualStyleBackColor = true;
            this.btny.Click += new System.EventHandler(this.btny_Click);
            // 
            // btnh
            // 
            this.btnh.Location = new System.Drawing.Point(493, 13);
            this.btnh.Name = "btnh";
            this.btnh.Size = new System.Drawing.Size(75, 42);
            this.btnh.TabIndex = 2;
            this.btnh.Text = ">>";
            this.btnh.UseVisualStyleBackColor = true;
            this.btnh.Click += new System.EventHandler(this.btnh_Click);
            // 
            // btnStop
            // 
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
            this.btnplay.Location = new System.Drawing.Point(28, 13);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 42);
            this.btnplay.TabIndex = 0;
            this.btnplay.Text = ">";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.bntplay_Click);
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.Location = new System.Drawing.Point(710, 10);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(57, 13);
            this.lblsure.TabIndex = 6;
            this.lblsure.Text = "00:00:00";
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
            // trackBar
            // 
            this.trackBar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar.Location = new System.Drawing.Point(6, 7);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(708, 45);
            this.trackBar.TabIndex = 3;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblsure);
            this.groupBox2.Controls.Add(this.trackBar);
            this.groupBox2.Location = new System.Drawing.Point(12, 508);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(777, 29);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // Pctresim
            // 
            this.Pctresim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pctresim.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Pctresim.Location = new System.Drawing.Point(16, 27);
            this.Pctresim.Name = "Pctresim";
            this.Pctresim.Size = new System.Drawing.Size(771, 475);
            this.Pctresim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pctresim.TabIndex = 5;
            this.Pctresim.TabStop = false;
            this.Pctresim.DoubleClick += new System.EventHandler(this.Pctresim_DoubleClick);
            // 
            // FrmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 606);
            this.Controls.Add(this.Pctresim);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MainMenuStrip = this.Menu;
            this.MaximizeBox = false;
            this.Name = "FrmPlayer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PLAYER";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPlayer_FormClosing);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmPlayer_KeyDown);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pctresim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripMenuItem bilgiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dosyaAçToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldurum;
        private System.Windows.Forms.Button btny;
        private System.Windows.Forms.Button btnh;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.PictureBox Pctresim;
    }
}