using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    int _count = (i * 5) + j;
                    _players[_count] = new System.Windows.Forms.TextBox();
                    _players[_count].Width = 180;
                    raidGroups[i].Controls.Add(_players[_count]);
                    _players[_count].Left = 10;
                    _players[_count].Top = 20 + (j * 6) + (j * 20);

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
