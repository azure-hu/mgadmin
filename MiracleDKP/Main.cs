using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace MiracleDKP
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            BackgroundInit();
            _mainTimer = new Timer();
        }

        private void BackgroundInit()
        {
            if (DateTime.Now.Hour > 5)
            {
                if(DateTime.Now.Hour > 13)
                {
                    if(DateTime.Now.Hour > 16)
                    {
                        if(DateTime.Now.Hour > 20)
                            this.BackgroundImage = MiracleDKP.Properties.Resources.maelstrom;
                        else
                            this.BackgroundImage = MiracleDKP.Properties.Resources.emerald;
                    }
                    else
                        this.BackgroundImage = MiracleDKP.Properties.Resources.skywall;
                }
                else
                    this.BackgroundImage = MiracleDKP.Properties.Resources.nagrand;
            }
            else
                this.BackgroundImage = MiracleDKP.Properties.Resources.maelstrom;
        }

        private void _mainTimer_Tick(object sender, EventArgs e)
        {
            BackgroundInit();
        }

        private void _startWow_Click(object sender, EventArgs e)
        {
            RegistryKey _regkeyOfWoW = Registry.LocalMachine.OpenSubKey(@"Software\Blizzard Entertainment\World of Warcraft");
            string _runWoW = _regkeyOfWoW.GetValue("InstallPath").ToString() + "WoW.exe";
            Process _proc = new Process();
            _proc.StartInfo.FileName = _runWoW;
            _proc.Start();
            if(this.WindowState != FormWindowState.Minimized)
                this.WindowState = FormWindowState.Minimized;

        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == this.WindowState)
            {
                notifyIcon1.ShowBalloonTip(500);
                this.Hide();
            }
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
