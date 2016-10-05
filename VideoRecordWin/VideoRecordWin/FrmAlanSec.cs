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
        bool b = false;
        Pen kalem = new Pen(Color.Red, 5F);
        private void FrmAlanSec_MouseDown(object sender, MouseEventArgs e)
        {
            ilk = Cursor.Position;
            b = true;
        }

        private void FrmAlanSec_MouseUp(object sender, MouseEventArgs e)
        {
            son = Cursor.Position;
            FrmRecorder frm = new FrmRecorder(ilk, son);
            this.Hide();
            this.Close();
            frm.ShowDialog();
        }

        private void FrmAlanSec_MouseMove(object sender, MouseEventArgs e)
        {
            if (b)
            {
                this.CreateGraphics().Clear(this.BackColor);
                Graphics g = this.CreateGraphics();
                g.DrawRectangle(kalem, ilk.X, ilk.Y, (Cursor.Position.X - ilk.X), (Cursor.Position.Y - ilk.Y));
            }
        }

       
    }
}
