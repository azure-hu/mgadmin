namespace libMiracle
{
    partial class GroupLayout
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainGroupBox = new System.Windows.Forms.GroupBox();
            this.ActionsGroup = new System.Windows.Forms.GroupBox();
            this.raidGroups = new System.Windows.Forms.GroupBox[5];
            this.raidGroups[0] = new System.Windows.Forms.GroupBox();
            this.raidGroups[1] = new System.Windows.Forms.GroupBox();
            this.raidGroups[2] = new System.Windows.Forms.GroupBox();
            this.raidGroups[3] = new System.Windows.Forms.GroupBox();
            this.raidGroups[4] = new System.Windows.Forms.GroupBox();
            this._players = new System.Windows.Forms.TextBox[25];
            this.mainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainGroupBox
            // 
            this.mainGroupBox.Controls.Add(this.raidGroups[4]);
            this.mainGroupBox.Controls.Add(this.raidGroups[3]);
            this.mainGroupBox.Controls.Add(this.raidGroups[2]);
            this.mainGroupBox.Controls.Add(this.raidGroups[1]);
            this.mainGroupBox.Controls.Add(this.raidGroups[0]);
            this.mainGroupBox.Controls.Add(this.ActionsGroup);
            this.mainGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainGroupBox.Location = new System.Drawing.Point(0, 0);
            this.mainGroupBox.Name = "mainGroupBox";
            this.mainGroupBox.Size = new System.Drawing.Size(625, 360);
            this.mainGroupBox.TabIndex = 0;
            this.mainGroupBox.TabStop = false;
            this.mainGroupBox.Text = "Group Layout";
            this.mainGroupBox.Enter += new System.EventHandler(this.mainGroupBox_Enter);
            // 
            // ActionsGroup
            // 
            this.ActionsGroup.Location = new System.Drawing.Point(5, 16);
            this.ActionsGroup.Name = "ActionsGroup";
            this.ActionsGroup.Size = new System.Drawing.Size(200, 160);
            this.ActionsGroup.TabIndex = 0;
            this.ActionsGroup.TabStop = false;
            this.ActionsGroup.Text = "Actions";
            // 
            // raidGroup3
            // 
            this.raidGroups[2].Location = new System.Drawing.Point(5, 187);
            this.raidGroups[2].Name = "raidGroup3";
            this.raidGroups[2].Size = new System.Drawing.Size(200, 160);
            this.raidGroups[2].TabIndex = 1;
            this.raidGroups[2].TabStop = false;
            this.raidGroups[2].Text = "Group 3";
            // 
            // raidGroup1
            // 
            this.raidGroups[0].Location = new System.Drawing.Point(212, 16);
            this.raidGroups[0].Name = "raidGroup1";
            this.raidGroups[0].Size = new System.Drawing.Size(200, 160);
            this.raidGroups[0].TabIndex = 2;
            this.raidGroups[0].TabStop = false;
            this.raidGroups[0].Text = "Group 1";
            // 
            // raidGroup4
            // 
            this.raidGroups[3].Location = new System.Drawing.Point(212, 187);
            this.raidGroups[3].Name = "raidGroup4";
            this.raidGroups[3].Size = new System.Drawing.Size(200, 160);
            this.raidGroups[3].TabIndex = 4;
            this.raidGroups[3].TabStop = false;
            this.raidGroups[3].Text = "Group 4";
            // 
            // raidGroup2
            // 
            this.raidGroups[1].Location = new System.Drawing.Point(420, 16);
            this.raidGroups[1].Name = "raidGroup2";
            this.raidGroups[1].Size = new System.Drawing.Size(200, 160);
            this.raidGroups[1].TabIndex = 5;
            this.raidGroups[1].TabStop = false;
            this.raidGroups[1].Text = "Group 2";
            // 
            // raidGroup5
            // 
            this.raidGroups[4].Location = new System.Drawing.Point(420, 187);
            this.raidGroups[4].Name = "raidGroup5";
            this.raidGroups[4].Size = new System.Drawing.Size(200, 160);
            this.raidGroups[4].TabIndex = 6;
            this.raidGroups[4].TabStop = false;
            this.raidGroups[4].Text = "Group 5";
            // 
            // GroupLayout
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.mainGroupBox);
            this.Name = "GroupLayout";
            this.Size = new System.Drawing.Size(625, 360);
            this.mainGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mainGroupBox;
        private System.Windows.Forms.GroupBox ActionsGroup;
        private System.Windows.Forms.GroupBox[] raidGroups;
        public System.Windows.Forms.TextBox[] _players;

    }
}
