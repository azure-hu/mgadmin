namespace MiracleDKP
{
    partial class RaidControl
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
            this.groupLayout1 = new libMiracle.GroupLayout();
            this.SuspendLayout();
            // 
            // groupLayout1
            // 
            this.groupLayout1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupLayout1.Location = new System.Drawing.Point(5, 5);
            this.groupLayout1.Name = "groupLayout1";
            this.groupLayout1.Size = new System.Drawing.Size(625, 360);
            this.groupLayout1.TabIndex = 0;
            // 
            // RaidControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 372);
            this.Controls.Add(this.groupLayout1);
            this.Name = "RaidControl";
            this.Text = "RaidControl";
            this.ResumeLayout(false);

        }

        #endregion

        private libMiracle.GroupLayout groupLayout1;

    }
}