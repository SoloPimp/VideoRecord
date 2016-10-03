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
                btnStop.Enabled = true;
                btnplay.Enabled = true;
                FileStream fs = new FileStream(OpenFile.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                Dosya = (Kayit)bf.Deserialize(fs);
                Info = Dosya.Info;
                Timer.Interval = Dosya.interval;
                son = Dosya.Kare_Adet();
                Resimler = Dosya.Dizi_Dondur();
            }
            else MessageBox.Show("Bir Dosya Seçmediniz....");
        }

        private void bntplay_Click(object sender, EventArgs e)
        {
            Timer.Start();
            btnplay.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btnplay.Enabled = true;
            btnStop.Enabled = false;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            if (i==son)
            {
                Timer.Stop();
                MessageBox.Show("Video Bitti..");
                i = 0;
            }
            Pctresim.Image = Resimler[i];
            i++;
        }

        private void dosyaHakkndaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBilgi frm = new FrmBilgi(Info);
            frm.ShowDialog();

        }
    }
}
