using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace VideoRecordWin
{
    public partial class FrmPlayer : Form
    {
        public FrmPlayer()
        {
            InitializeComponent();
        }
        Kayit Dosya;
        int son,i=0;
        List<Bitmap> Resimler;
        Bilgi Info;
        private void dosyaAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                groupBox1.Enabled = true;
                FileStream fs = new FileStream(OpenFile.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Dosya = (Kayit)bf.Deserialize(fs);
                Info = Dosya.Info;
                Timer.Interval = Dosya.interval;
                son = Dosya.Kare_Adet();
                trackBar.Maximum = son;
                Resimler = Dosya.Dizi_Dondur();
                Pctresim.Image = Resimler[0];
            }
            else MessageBox.Show("Bir Dosya Seçmediniz....","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void bntplay_Click(object sender, EventArgs e)
        {
            Timer.Start();
            btnplay.Enabled = false;
            btnStop.Enabled = true;
            Pctresim.Select();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btnplay.Enabled = true;
            btnStop.Enabled = false;
            Pctresim.Select();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Pctresim.Image = Resimler[i];
            if (i+1 == son)
            {
                Timer.Stop();
                trackBar.Value = i+1;
                MessageBox.Show("Video Bitti..\nToplam : " + son + " kare Oynatıldı..","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                i = 0;
                btnplay.Enabled = true;
            }
            trackBar.Value = i;
            i++;
                
        }

        private void dosyaHakkndaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBilgi frm = new FrmBilgi(Info);
            frm.ShowDialog();

        }

        private void hakkindaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHakkinda frm = new FrmHakkinda();
            frm.ShowDialog();
        }

        private void trackBar_Scroll(object sender, EventArgs e)
        {
            Timer.Stop();
            i=trackBar.Value;
            Pctresim.Image = Resimler[i];
            
        }

        private void btnh_Click(object sender, EventArgs e)
        {
            if (Timer.Interval>10)
            {
                Timer.Interval -= 10;
                lbldurum.Text = (Convert.ToInt32(lbldurum.Text) +1).ToString();
            }
        }

        private void btny_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(lbldurum.Text) - 1)>=-20)
            {
                Timer.Interval += 10;
                lbldurum.Text = (Convert.ToInt32(lbldurum.Text) - 1).ToString(); 
            }
        }

        private void FrmPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            Pctresim.Select();
            if (e.KeyCode == Keys.Right)
                btnh_Click(null, null);
            else if
                (e.KeyCode == Keys.Left)
                btny_Click(null, null);
            else if (e.KeyCode == Keys.Space)
                Timer.Enabled = Timer.Enabled ? false : true;
        }
    }
}
