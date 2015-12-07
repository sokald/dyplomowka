namespace Edukolandia
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.angielskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poziom1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poziom2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poziom3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.levelToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.angielskiToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            this.plikToolStripMenuItem.Click += new System.EventHandler(this.plikToolStripMenuItem_Click);
            // 
            // angielskiToolStripMenuItem
            // 
            this.angielskiToolStripMenuItem.Name = "angielskiToolStripMenuItem";
            this.angielskiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.angielskiToolStripMenuItem.Text = "Angielski";
            this.angielskiToolStripMenuItem.Click += new System.EventHandler(this.angielskiToolStripMenuItem_Click);
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.poziom1ToolStripMenuItem,
            this.poziom2ToolStripMenuItem,
            this.poziom3ToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.levelToolStripMenuItem.Text = "Level";
            // 
            // poziom1ToolStripMenuItem
            // 
            this.poziom1ToolStripMenuItem.Name = "poziom1ToolStripMenuItem";
            this.poziom1ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.poziom1ToolStripMenuItem.Text = "Poziom 1";
            this.poziom1ToolStripMenuItem.Click += new System.EventHandler(this.poziom1ToolStripMenuItem_Click);
            // 
            // poziom2ToolStripMenuItem
            // 
            this.poziom2ToolStripMenuItem.Name = "poziom2ToolStripMenuItem";
            this.poziom2ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.poziom2ToolStripMenuItem.Text = "Poziom 2";
            this.poziom2ToolStripMenuItem.Click += new System.EventHandler(this.poziom2ToolStripMenuItem_Click);
            // 
            // poziom3ToolStripMenuItem
            // 
            this.poziom3ToolStripMenuItem.Name = "poziom3ToolStripMenuItem";
            this.poziom3ToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.poziom3ToolStripMenuItem.Text = "Poziom 3";
            this.poziom3ToolStripMenuItem.Click += new System.EventHandler(this.poziom3ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(124, 17);
            this.toolStripStatusLabel1.Text = "Maciej Brant 2015 v0.1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Edukolandia";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem angielskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripMenuItem poziom1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poziom2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poziom3ToolStripMenuItem;
    }
}

