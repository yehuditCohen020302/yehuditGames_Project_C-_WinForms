using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using yehuditGames.GUI;

namespace yehuditGames
{
    public enum StatusKind { add, delete, update, show };

    static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DAL.Dal.ConnectToDb();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new FrmMain(true));
            Application.Run(new FrmStart());
        }
    }
}
