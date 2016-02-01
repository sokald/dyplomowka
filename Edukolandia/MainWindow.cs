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
    public partial class MainWindow : Form
    {
        //game english
        ang.startWindow startAng;
    
        //Ortografia game    
        Ortografia.OrtGame startOrt;

        //slide puzzle game
        SlidePuzzle.Puzzle startPuzzle;

        Edukolandia.AboutTheAuthor AboutTheAuthorWindow;

        //open main window game
        public MainWindow()
        {
            InitializeComponent();
            poziom1ToolStripMenuItem.Checked = true;

            // set game instruction  
            label1.Text = "Aby zagrać wybierz poziom trudności z \ngórnego menu, a następnie wybierz grę";
            
            //set bacground color
            this.BackColor = Color.FromArgb(174, 215, 211);
        }

        //run english game
        private void angielskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //level 1
            if (poziom1ToolStripMenuItem.Checked)
            {
                startAng = new ang.startWindow(1);
                startAng.Show();
            }

            //level 2
            if (poziom2ToolStripMenuItem.Checked)
            {
                startAng = new ang.startWindow(2);
                startAng.Show();
            }

            //level 3
            if (poziom3ToolStripMenuItem.Checked)
            {
                startAng = new ang.startWindow(3);
                startAng.Show();
            }
        }

        //select level
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

        //open game ortografia
        private void ortografiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //level 1
            if (poziom1ToolStripMenuItem.Checked)
            {
                startOrt = new Ortografia.OrtGame(1);
                startOrt.Show();
            }

            //level 2
            if (poziom2ToolStripMenuItem.Checked)
            {
                startOrt = new Ortografia.OrtGame(2);
                startOrt.Show();
            }

            //level 3
            if (poziom3ToolStripMenuItem.Checked)
            {
                startOrt = new Ortografia.OrtGame(3);
                startOrt.Show();
            }
        }

        //open game slide puzzle
        private void puzzleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (poziom1ToolStripMenuItem.Checked)
            {
                startPuzzle = new SlidePuzzle.Puzzle(1);
                startPuzzle.Size = new Size(210, 250);
                startPuzzle.Show();
            }

            //level 2
            if (poziom2ToolStripMenuItem.Checked)
            {
                startPuzzle = new SlidePuzzle.Puzzle(2);
                startPuzzle.Size = new Size(260, 300);
                startPuzzle.Show();
            }

            //level 3
            if (poziom3ToolStripMenuItem.Checked)
            {
                startPuzzle = new SlidePuzzle.Puzzle(3);
                startPuzzle.Size = new Size(315, 355);
                startPuzzle.Show();
            }
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //open window with information abouth author
            AboutTheAuthorWindow = new Edukolandia.AboutTheAuthor();
            AboutTheAuthorWindow.Show();                   
        }     
    }
}
