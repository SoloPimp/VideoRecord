using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace VideoRecordWin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (args.Length>0&&args[0]=="RECORDER")
            {
               FrmAlanSec frm= new FrmAlanSec();
               frm.ShowDialog();
            }
            else if (args.Length > 0 && args[0] == "PLAYER")
            {
                Application.Run(new FrmPlayer());

            }
            else if (args.Length>0)
            {
                string yol="";
                for (int i = 0; i < args.Length; i++)
                {
                    yol = yol +" "+ args[i];
                }
                Application.Run(new FrmPlayer(yol));

            }
            else Application.Run(new frmmain());
        }
    }
}
