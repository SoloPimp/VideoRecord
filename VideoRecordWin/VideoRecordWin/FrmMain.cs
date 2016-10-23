using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;

namespace VideoRecordWin
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void btnplayer_Click(object sender, EventArgs e)
        {
            FrmPlayer frm = new FrmPlayer();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void btnrecordr_Click(object sender, EventArgs e)
        {
            FrmAlanSec frm = new FrmAlanSec();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            FrmHakkinda frm = new FrmHakkinda();
            frm.ShowDialog();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {
            try
            {
                Registry.ClassesRoot.CreateSubKey(".ves").SetValue("VES", "VES_Dosyasi.ves");
                RegistryKey rk = Registry.ClassesRoot.CreateSubKey("VES_Dosyasi.ves");
                rk.CreateSubKey("DefaultIcon").SetValue("VES", Application.StartupPath + "\\icon.png");
                rk.CreateSubKey(@"shell\open\command").SetValue("VES", "\"" + Application.ExecutablePath + "\"%1");

            }
            catch (Exception ex)
            {
                
                
            }
        }
    }
}
