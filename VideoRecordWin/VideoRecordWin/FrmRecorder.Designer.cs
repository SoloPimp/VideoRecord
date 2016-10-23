namespace VideoRecordWin
{
    partial class FrmRecorder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecorder));
            this.btndurdur = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbkalite = new System.Windows.Forms.ComboBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblsure = new System.Windows.Forms.Label();
            this.NmrcKalite = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcKalite)).BeginInit();
            this.SuspendLayout();
            // 
            // btndurdur
            // 
            this.btndurdur.Enabled = false;
            this.btndurdur.Location = new System.Drawing.Point(185, 35);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(75, 23);
            this.btndurdur.TabIndex = 0;
            this.btndurdur.Text = "Durdur";
            this.btndurdur.UseVisualStyleBackColor = true;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(185, 9);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(75, 23);
            this.btnplay.TabIndex = 1;
            this.btnplay.Text = "Başla";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.btnplay_Click);
            // 
            // btnstop
            // 
            this.btnstop.Enabled = false;
            this.btnstop.Location = new System.Drawing.Point(279, 9);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(75, 23);
            this.btnstop.TabIndex = 2;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sn Kare Kalitesi :";
            // 
            // cmbkalite
            // 
            this.cmbkalite.FormattingEnabled = true;
            this.cmbkalite.Items.AddRange(new object[] {
            "Yuksek",
            "Orta",
            "Dusuk"});
            this.cmbkalite.Location = new System.Drawing.Point(103, 9);
            this.cmbkalite.Name = "cmbkalite";
            this.cmbkalite.Size = new System.Drawing.Size(73, 21);
            this.cmbkalite.TabIndex = 4;
            this.cmbkalite.SelectionChangeCommitted += new System.EventHandler(this.cmbkalite_SelectionChangeCommitted);
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // SaveFile
            // 
            this.SaveFile.Filter = "VideoDosyası|*.ves";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(370, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.Location = new System.Drawing.Point(286, 42);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(57, 13);
            this.lblsure.TabIndex = 6;
            this.lblsure.Text = "00:00:00";
            // 
            // NmrcKalite
            // 
            this.NmrcKalite.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.NmrcKalite.Location = new System.Drawing.Point(103, 39);
            this.NmrcKalite.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.NmrcKalite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmrcKalite.Name = "NmrcKalite";
            this.NmrcKalite.Size = new System.Drawing.Size(73, 20);
            this.NmrcKalite.TabIndex = 7;
            this.NmrcKalite.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Görüntü Kalitesi :";
            // 
            // FrmRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 68);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NmrcKalite);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbkalite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btndurdur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecorder";
            this.Text = "RECORDER";
            this.Load += new System.EventHandler(this.FrmRecorder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NmrcKalite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btndurdur;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.Button btnstop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbkalite;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.NumericUpDown NmrcKalite;
        private System.Windows.Forms.Label label2;
    }
}