using System;
using System.Collections.Generic;
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
            bool _adminMode = false;
            foreach (string _arg in Environment.GetCommandLineArgs())
            {
                switch (_arg)
                {
                    case "--admin": _adminMode = true; break;
                    default:
                        break;
                }
            }
            _db = new DBEngine(MiracleDKP.Properties.Resources.DBConnStr);
            if (_adminMode)
            {
                _news = new MiracleDKP.RNews();
                ((MiracleDKP.RNews)_news).AttachDB(_db);
            }
            else
            {
                _news = new MiracleDKP.News();
                ((MiracleDKP.News)_news).AttachDB(_db);
            }
            
            Application.Run(_news);
        }
        static MiracleDKP.MainForm _news;
        static MiracleDKP.DBEngine _db;
    }
}
