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
            FrmRecorder frm = new FrmRecorder();
            this.Hide();
            frm.ShowDialog();
            this.Show();
        }
    }
}
