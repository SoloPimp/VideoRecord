using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace VideoRecordWin
{
    public partial class FrmRecorder : Form
    {
        int kalite = 100,GoruntuKalite=1;
        Kayit dosya;
        Point ilk, son;
        int i;
        public FrmRecorder( Point ilk, Point son)
        {
            this.ilk = ilk;
            this.son = son;
            InitializeComponent();
        }
        
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
                    kalite = 200;
                    break;
                case 2:
                    kalite = 500;
                    break;
            }
        }
        byte[] Ekran_Al(Point ilk, Point son)
        {
            Bitmap bmp = new Bitmap(son.X - ilk.X, son.Y - ilk.Y);
            Graphics gr = Graphics.FromImage(bmp);
            gr.CopyFromScreen(ilk.X, ilk.Y, 0, 0, bmp.Size);
            byte[] x = Resim_Kalite_Byte(bmp, GoruntuKalite);
            return x;
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            btndurdur.Enabled = true;
            btnstop.Enabled = true;
            cmbkalite.Enabled = false;
            NmrcKalite.Enabled = false;
            btnplay.Enabled = false;
            Timer.Start();
            Timer.Interval = kalite;
            GoruntuKalite =10*(int)NmrcKalite.Value;
            this.Width = 460;
        }

        private void btndurdur_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btndurdur.Enabled = false;
            btnplay.Enabled = true;
            this.Width = 380;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            dosya.Resim_Ekle(Ekran_Al(ilk,son));
            if (i%10==0)
            {
                i = 0;
                pictureBox1.Hide();
            } else pictureBox1.Show();
            i++;
            sure_yaz(dosya.Kare_Adet() * Timer.Interval);
        }

        private void btnstop_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            btndurdur.Enabled = false;
            cmbkalite.Enabled = true;
            NmrcKalite.Enabled = true;
            btnplay.Enabled = true;
            this.Width = 380;
            if (SaveFile.ShowDialog()==DialogResult.OK)
            {
                dosya.interval = Timer.Interval;
                Bilgi info = new Bilgi(DateTime.Now,dosya.Kare_Adet(),cmbkalite.Text);
                info.sure = lblsure.Text;
                dosya.Info = info;
                dosya.Video_Kayit(SaveFile.FileName);
                dosya=new Kayit();
            }
            else dosya = new Kayit();
        }
        void sure_yaz(int sure)
        {
            int saat, dakika, saniye;
            saniye = (sure / 1000) % 60;
            dakika = ((sure / 1000) / 60) % 60;
            saat = ((sure / 1000) / 3600) % 60;
            lblsure.Text = saat.ToString() + ": " + dakika.ToString() + ": " + saniye.ToString();        
        }


        private Byte[] Resim_Kalite_Byte(Image sourceImage, int imageQuality)
        {

            try
            {
                ImageCodecInfo jpegCodec = null;
                EncoderParameter imageQualitysParameter = new EncoderParameter(
                            System.Drawing.Imaging.Encoder.Quality, imageQuality);
                ImageCodecInfo[] alleCodecs = ImageCodecInfo.GetImageEncoders();
                EncoderParameters codecParameter = new EncoderParameters(1);
                codecParameter.Param[0] = imageQualitysParameter;
                for (int i = 0; i < alleCodecs.Length; i++)
                {

                    if (alleCodecs[i].MimeType == "image/jpeg")
                    {

                        jpegCodec = alleCodecs[i];

                        break;

                    }

                }
                MemoryStream gg = new MemoryStream();
                sourceImage.Save(gg, jpegCodec, codecParameter);
                return gg.GetBuffer();
            }

            catch (Exception e)
            {
                throw e;
            }

        }


        
    }
}
