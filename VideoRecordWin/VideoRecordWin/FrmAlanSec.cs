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
    public partial class FrmAlanSec : Form
    {
        public FrmAlanSec()
        {
            InitializeComponent();
        }
        Point ilk, son;
        private void FrmAlanSec_Load(object sender, EventArgs e)
        {
        }
        private void FrmAlanSec_MouseDown(object sender, MouseEventArgs e)
        {
            ilk = Cursor.Position;
        }

        private void FrmAlanSec_MouseUp(object sender, MouseEventArgs e)
        {
            son = Cursor.Position;
            FrmRecorder frm = new FrmRecorder(ilk, son);
            this.Close();
            frm.ShowDialog();
        }

       
    }
}
