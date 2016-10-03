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
    public partial class FrmBilgi : Form
    {
        Bilgi Info;
        public FrmBilgi(Bilgi info)
        {
            this.Info = info;
            InitializeComponent();
        }

        private void FrmBilgi_Load(object sender, EventArgs e)
        {
            if (Info != null)
            {
                lbltarih.Text = Info.Tarih.Date.ToShortDateString();
                lblsaat.Text = Info.Tarih.ToShortTimeString();
                lblkalite.Text = Info.Kalite;
                lblkare.Text = Info.Kare_Sayisi.ToString();

            }
            else { MessageBox.Show("Lütfen uygun bir dosya seçtiğinizden emin olun..","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error); this.Close(); }
            
            
        }
    }
}
