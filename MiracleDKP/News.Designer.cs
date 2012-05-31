namespace MiracleDKP
{
    partial class News
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(News));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hírekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.woWIndításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tagfelvételToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dKPLekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this._mainTimer = new System.Windows.Forms.Timer(this.components);
            this.adminGroup = new System.Windows.Forms.GroupBox();
            this.dkpButton = new System.Windows.Forms.Button();
            this.raidButton = new System.Windows.Forms.Button();
            this.membersButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.adminGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(620, 275);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hírek";
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(614, 256);
            this.label2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(502, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "WoW indítása";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this._startWow_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hírekToolStripMenuItem,
            this.woWIndításaToolStripMenuItem,
            this.tagfelvételToolStripMenuItem,
            this.adminPanelToolStripMenuItem,
            this.dKPLekérdezésToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 136);
            // 
            // hírekToolStripMenuItem
            // 
            this.hírekToolStripMenuItem.Name = "hírekToolStripMenuItem";
            this.hírekToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.hírekToolStripMenuItem.Text = "Hírek";
            this.hírekToolStripMenuItem.Click += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // woWIndításaToolStripMenuItem
            // 
            this.woWIndításaToolStripMenuItem.Name = "woWIndításaToolStripMenuItem";
            this.woWIndításaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.woWIndításaToolStripMenuItem.Text = "WoW indítása...";
            this.woWIndításaToolStripMenuItem.Click += new System.EventHandler(this._startWow_Click);
            // 
            // tagfelvételToolStripMenuItem
            // 
            this.tagfelvételToolStripMenuItem.Name = "tagfelvételToolStripMenuItem";
            this.tagfelvételToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tagfelvételToolStripMenuItem.Text = "Tagok / Hírek";
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.adminPanelToolStripMenuItem.Text = "Raid Felület";
            // 
            // dKPLekérdezésToolStripMenuItem
            // 
            this.dKPLekérdezésToolStripMenuItem.Name = "dKPLekérdezésToolStripMenuItem";
            this.dKPLekérdezésToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dKPLekérdezésToolStripMenuItem.Text = "DKP lekérdezés";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Az alkamazás továbbra is fut.";
            this.notifyIcon1.BalloonTipTitle = "MIracLE Guild System";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MIracLE";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // _mainTimer
            // 
            this._mainTimer.Enabled = true;
            this._mainTimer.Interval = 3600000;
            this._mainTimer.Tick += new System.EventHandler(this._mainTimer_Tick);
            // 
            // adminGroup
            // 
            this.adminGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.adminGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.adminGroup.Controls.Add(this.dkpButton);
            this.adminGroup.Controls.Add(this.raidButton);
            this.adminGroup.Controls.Add(this.membersButton);
            this.adminGroup.Controls.Add(this.loginButton);
            this.adminGroup.Location = new System.Drawing.Point(198, 297);
            this.adminGroup.Name = "adminGroup";
            this.adminGroup.Size = new System.Drawing.Size(273, 59);
            this.adminGroup.TabIndex = 6;
            this.adminGroup.TabStop = false;
            this.adminGroup.Text = "Admin Mode";
            // 
            // dkpButton
            // 
            this.dkpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dkpButton.Enabled = false;
            this.dkpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dkpButton.Location = new System.Drawing.Point(206, 16);
            this.dkpButton.Name = "dkpButton";
            this.dkpButton.Size = new System.Drawing.Size(62, 37);
            this.dkpButton.TabIndex = 6;
            this.dkpButton.Text = "DKP Vezérlés";
            this.dkpButton.UseVisualStyleBackColor = false;
            this.dkpButton.Click += new System.EventHandler(this.dkpButton_Click);
            // 
            // raidButton
            // 
            this.raidButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.raidButton.Enabled = false;
            this.raidButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raidButton.Location = new System.Drawing.Point(136, 16);
            this.raidButton.Name = "raidButton";
            this.raidButton.Size = new System.Drawing.Size(64, 37);
            this.raidButton.TabIndex = 5;
            this.raidButton.Text = "Raid Vezérlés";
            this.raidButton.UseVisualStyleBackColor = false;
            this.raidButton.Click += new System.EventHandler(this.raidButton_Click);
            // 
            // membersButton
            // 
            this.membersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.membersButton.Enabled = false;
            this.membersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.membersButton.Location = new System.Drawing.Point(66, 16);
            this.membersButton.Name = "membersButton";
            this.membersButton.Size = new System.Drawing.Size(64, 37);
            this.membersButton.TabIndex = 4;
            this.membersButton.Text = "Hírek és Tagok";
            this.membersButton.UseVisualStyleBackColor = false;
            this.membersButton.Click += new System.EventHandler(this.membersButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(6, 16);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(54, 37);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // News
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 368);
            this.Controls.Add(this.adminGroup);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Name = "News";
            this.Text = "News";
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.adminGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem woWIndításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dKPLekérdezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer _mainTimer;
        private System.Windows.Forms.ToolStripMenuItem hírekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tagfelvételToolStripMenuItem;
        protected System.Windows.Forms.GroupBox adminGroup;
        private System.Windows.Forms.Button dkpButton;
        private System.Windows.Forms.Button raidButton;
        private System.Windows.Forms.Button membersButton;
        private System.Windows.Forms.Button loginButton;
    }
}