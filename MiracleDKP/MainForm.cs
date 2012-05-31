using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Diagnostics;

namespace MiracleDKP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            BackgroundInit();
            
        }

        protected void BackgroundInit()
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
    }
}
