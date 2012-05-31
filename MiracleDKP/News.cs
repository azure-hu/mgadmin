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
    public partial class News : MainForm
    {
        public News()
        {
            InitializeComponent();
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
            if (this.WindowState != FormWindowState.Minimized)
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

        private void loginButton_Click(object sender, EventArgs e)
       {
            MiracleDKP.Login _login = new MiracleDKP.Login();
            if (_login.ShowDialog() == DialogResult.OK)
            {
                bool _loginOk = InitAdminLogin(_login.userBox.Text, _login.passBox.Text);
                
                if (_loginOk)
                {
                    membersButton.Enabled = true;
                    raidButton.Enabled = true;
                    dkpButton.Enabled = true;
                    loginButton.Enabled = false;
                }
            }
        }

        private bool InitAdminLogin(string _user, string _pass)
        {
            return true;
        }

        private void membersButton_Click(object sender, EventArgs e)
        {
            MiracleDKP.MainForm _members = new MiracleDKP.Members();
            _members.ShowDialog();
        }

        private void dkpButton_Click(object sender, EventArgs e)
        {
            MiracleDKP.MainForm _dkpView = new MiracleDKP.DKPView();
            _dkpView.ShowDialog();
        }

        private void raidButton_Click(object sender, EventArgs e)
        {
            MiracleDKP.MainForm _raidControl = new MiracleDKP.RaidControl();
            _raidControl.ShowDialog();
        }

    }
}
