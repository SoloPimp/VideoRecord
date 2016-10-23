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
using System.Drawing.Imaging;

namespace VideoRecordWin
{
    public partial class FrmPlayer : Form
    {
        public FrmPlayer()
        {
            InitializeComponent();
        }
        public FrmPlayer(string d)
        {
            InitializeComponent();
            //MessageBox.Show(dosya);
            Dosya_Ac(d);
           
        }
        Kayit Dosya;
        int son,i=0;
        List<byte[]> Resimler;
        Bilgi Info;
        bool tam = true;
        private void dosyaAcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                Dosya_Ac(OpenFile.FileName);                
            }
            else MessageBox.Show("Bir Dosya Seçmediniz....","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        void Dosya_Ac(string y)
        {
            groupBox1.Enabled = true;
            FileStream fs = new FileStream(y, FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            Dosya = (Kayit)bf.Deserialize(fs);
            fs.Close();
            Info = Dosya.Info;
            Timer.Interval = Dosya.interval;
            son = Dosya.Kare_Adet();
            trackBar.Maximum = son;
            Resimler = Dosya.Dizi_Dondur();
            MemoryStream ms = new MemoryStream(Resimler[0]);
            Pctresim.Image = Icon_Ekle(Image.FromStream(ms));
            sure_yaz(Dosya.Kare_Adet() * Dosya.interval);
            ms.Close();
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
            MemoryStream ms = new MemoryStream(Resimler[i]);
            Pctresim.Image = Icon_Ekle(Image.FromStream(ms));           
            ms.Close();
            if (i+1 == son)
            {
                Timer.Stop();
                trackBar.Value = i+1;
                MessageBox.Show("Video Bitti..\nToplam : " + son + " kare Oynatıldı..","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
                i = 0;
                btnplay.Enabled = true;
            }
            sure_yaz(i * Dosya.interval);
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
        {   i = trackBar.Value;
            if (i >= 0 && i < son)
            {
                Timer.Stop();                
                MemoryStream ms = new MemoryStream(Resimler[i]);
                Pctresim.Image = Icon_Ekle(Image.FromStream(ms));
                ms.Close();
                btnplay.Enabled = true;
                sure_yaz(i * Dosya.interval);
            }
            
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
            else if
                (e.KeyCode == Keys.Escape)
                Eski_Ekran();
        }
        void sure_yaz(int sure)
        {
            int saat, dakika, saniye;
            saniye = (sure / 1000) % 60;
            dakika = ((sure / 1000) / 60) % 60;
            saat = ((sure / 1000) / 3600) % 60;
            lblsure.Text = saat.ToString() + ": " + dakika.ToString() + ": " + saniye.ToString();
        }

        private void Pctresim_DoubleClick(object sender, EventArgs e)
        {
            if (tam)
                Tam_Ekran();
            else Eski_Ekran();
        }
        void Tam_Ekran()
        { 
            this.Text = "";
            this.ControlBox = false;
            this.WindowState = FormWindowState.Maximized;
            Menu.Hide();
            Pctresim.Dock = DockStyle.Fill;
            Pctresim.SizeMode = PictureBoxSizeMode.StretchImage;
            tam = false;
        }
        void Eski_Ekran()
        {
            this.WindowState = FormWindowState.Normal;
            Menu.Show();
            Pctresim.Dock = DockStyle.None;
            this.ControlBox = true;
            this.Text = "PLAYER";           
            Pctresim.SizeMode = PictureBoxSizeMode.StretchImage;
            tam = true;
        }

        private void FrmPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Timer.Stop();
        }
        Image Icon_Ekle(Image r)
        {
            Graphics g = Graphics.FromImage(r);
            g.DrawString("VES VIDEO", new Font("Lucida Calligraphy", 15f), Brushes.Red, new Point(0, 0));
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            return r;
        }
    }
}
