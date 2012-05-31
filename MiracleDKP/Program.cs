using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MiracleDKP
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _news = new MiracleDKP.News();
            Application.Run(_news);
        }

        static MiracleDKP.MainForm _news;
    }
}
