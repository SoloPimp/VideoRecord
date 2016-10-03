using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VideoRecordWin
{
    public partial class FrmRecorder : Form
    {
        public FrmRecorder()
        {
            InitializeComponent();
        }
        int kalite = 100;
        Kayit dosya;
        private void FrmRecorder_Load(object sender, EventArgs e)
        {
            dosya = new Kayit();
            cmbkalite.SelectedIndex = 0;
        }
        private void cmbkalite_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch (cmbkalite.SelectedIndex)
            {
                case 0:
                    kalite=100;
                    break;
                case 1:
                    kalite = 400;
                    break;
                case 2:
                    kalite = 600;
                    break;
            }
        }
        Bitmap Ekran_Al()
        {
            Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);

            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(0, 0, 0, 0, new Size(bmp.Size.Width, bmp.Size.Height));
            return bmp;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            btndurdur.Enabled = true;
            btnstop.Enabled = true;
            cmbkalite.Enabled = false;
            btnplay.Enabled = false;
            Timer.Start();
            Timer.Interval = kalite;
        }

        private void btndurdur_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btndurdur.Enabled = false;
            btnplay.Enabled = true;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dosya.Resim_Ekle(Ekran_Al());
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btndurdur.Enabled = false;
            cmbkalite.Enabled = true;
            btnplay.Enabled = true;            
            if (SaveFile.ShowDialog()==DialogResult.OK)
            {
                dosya.interval = Timer.Interval;
                Bilgi info = new Bilgi(DateTime.Now,dosya.Kare_Adet(),cmbkalite.Text);
                dosya.Info = info;
                dosya.Video_Kayit(SaveFile.FileName);
                dosya=new Kayit();
            }
            else dosya = new Kayit();
        }

        
    }
}
