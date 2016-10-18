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
            this.btndurdur = new System.Windows.Forms.Button();
            this.btnplay = new System.Windows.Forms.Button();
            this.btnstop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbkalite = new System.Windows.Forms.ComboBox();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btndurdur
            // 
            this.btndurdur.Enabled = false;
            this.btndurdur.Location = new System.Drawing.Point(88, 12);
            this.btndurdur.Name = "btndurdur";
            this.btndurdur.Size = new System.Drawing.Size(75, 23);
            this.btndurdur.TabIndex = 0;
            this.btndurdur.Text = "Durdur";
            this.btndurdur.UseVisualStyleBackColor = true;
            this.btndurdur.Click += new System.EventHandler(this.btndurdur_Click);
            // 
            // btnplay
            // 
            this.btnplay.Location = new System.Drawing.Point(7, 12);
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
            this.btnstop.Location = new System.Drawing.Point(169, 12);
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
            this.label1.Location = new System.Drawing.Point(254, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kayıt Kalitesi :";
            // 
            // cmbkalite
            // 
            this.cmbkalite.FormattingEnabled = true;
            this.cmbkalite.Items.AddRange(new object[] {
            "Yuksek",
            "Orta",
            "Dusuk"});
            this.cmbkalite.Location = new System.Drawing.Point(332, 14);
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
            // FrmRecorder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 48);
            this.Controls.Add(this.cmbkalite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.btndurdur);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmRecorder";
            this.Text = "RECORDER";
            this.Load += new System.EventHandler(this.FrmRecorder_Load);
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
    }
}