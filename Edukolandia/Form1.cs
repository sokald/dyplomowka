using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edukolandia
{
    public partial class Form1 : Form
    {
        //game english
        ang.Form1 ang;
        ang.startWindow startAng;

        int i = 1;

        public Form1()
        {
            InitializeComponent();
            poziom1ToolStripMenuItem.Checked = true;
        }

        private void angielskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //level 1
            if (poziom1ToolStripMenuItem.Checked)
            {
                startAng = new ang.startWindow(1);
                startAng.Show();
                //ang = new ang.Form1(1);
                //ang.Size = new Size(295, 280);
                //this.Enabled = false;
                //ang.Show();
            }

            //level 2
            if (poziom2ToolStripMenuItem.Checked)
            {
                startAng = new ang.startWindow(2);
                startAng.Show();

                //ang = new ang.Form1(2);
                //ang.Size = new Size(295, 300);
                //this.Enabled = false;
                //ang.Show();
            }

            //level 3
            if (poziom3ToolStripMenuItem.Checked)
            {
                startAng = new ang.startWindow(3);
                startAng.Show();

                //ang = new ang.Form1(3);
                //ang.Size = new Size(295, 350);
                //this.Hide();
                //ang.Show();
                //this.Close();
            }
        }

        private void poziom1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if( ! poziom1ToolStripMenuItem.Checked)
            {
                poziom1ToolStripMenuItem.Checked = true;
                poziom2ToolStripMenuItem.Checked = false;
                poziom3ToolStripMenuItem.Checked = false;
            }
        }

        private void poziom2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( ! poziom2ToolStripMenuItem.Checked)
            {
                poziom1ToolStripMenuItem.Checked = false;
                poziom2ToolStripMenuItem.Checked = true;
                poziom3ToolStripMenuItem.Checked = false;
            }
        }

        private void poziom3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( ! poziom3ToolStripMenuItem.Checked)
            {
                poziom1ToolStripMenuItem.Checked = false;
                poziom2ToolStripMenuItem.Checked = false;
                poziom3ToolStripMenuItem.Checked = true;
            }
        }

        private void plikToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
