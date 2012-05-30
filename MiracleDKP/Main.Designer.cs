namespace MiracleDKP
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._mainTimer = new System.Windows.Forms.Timer(this.components);
            this._startWow = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.woWIndításaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dKPLekérdezésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hírek";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(614, 256);
            this.label1.TabIndex = 0;
            // 
            // _mainTimer
            // 
            this._mainTimer.Enabled = true;
            this._mainTimer.Interval = 3600000;
            this._mainTimer.Tick += new System.EventHandler(this._mainTimer_Tick);
            // 
            // _startWow
            // 
            this._startWow.BackColor = System.Drawing.Color.Black;
            this._startWow.ForeColor = System.Drawing.Color.White;
            this._startWow.Location = new System.Drawing.Point(503, 297);
            this._startWow.Name = "_startWow";
            this._startWow.Size = new System.Drawing.Size(120, 65);
            this._startWow.TabIndex = 1;
            this._startWow.Text = "WoW indítása";
            this._startWow.UseVisualStyleBackColor = false;
            this._startWow.Click += new System.EventHandler(this._startWow_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Az alkamazás továbbra is fut.";
            this.notifyIcon1.BalloonTipTitle = "MIracLE Guild System";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "MIracLE";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.woWIndításaToolStripMenuItem,
            this.dKPLekérdezésToolStripMenuItem,
            this.adminPanelToolStripMenuItem,
            this.kilépésToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 114);
            // 
            // woWIndításaToolStripMenuItem
            // 
            this.woWIndításaToolStripMenuItem.Name = "woWIndításaToolStripMenuItem";
            this.woWIndításaToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.woWIndításaToolStripMenuItem.Text = "WoW indítása...";
            this.woWIndításaToolStripMenuItem.Click += new System.EventHandler(this._startWow_Click);
            // 
            // dKPLekérdezésToolStripMenuItem
            // 
            this.dKPLekérdezésToolStripMenuItem.Name = "dKPLekérdezésToolStripMenuItem";
            this.dKPLekérdezésToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.dKPLekérdezésToolStripMenuItem.Text = "DKP lekérdezés";
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.adminPanelToolStripMenuItem.Text = "Admin felület";
            // 
            // kilépésToolStripMenuItem
            // 
            this.kilépésToolStripMenuItem.Name = "kilépésToolStripMenuItem";
            this.kilépésToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.kilépésToolStripMenuItem.Text = "Kilépés";
            this.kilépésToolStripMenuItem.Click += new System.EventHandler(this.kilépésToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(630, 368);
            this.Controls.Add(this._startWow);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "MIracLE Guild System";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer _mainTimer;
        private System.Windows.Forms.Button _startWow;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem woWIndításaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dKPLekérdezésToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésToolStripMenuItem;

    }
}

