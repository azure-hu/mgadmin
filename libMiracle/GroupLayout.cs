using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace libMiracle
{
    public partial class GroupLayout : UserControl
    {
        public GroupLayout()
        {
            InitializeComponent();
            //
            // Player's TextBox
            //
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int _count = (i * 5) + j;
                    _players[_count] = new System.Windows.Forms.TextBox();
                    raidGroups[i].Controls.Add(_players[_count]);
                }

            }
        }

        private void mainGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
