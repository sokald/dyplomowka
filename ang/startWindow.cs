using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ang
{
    public partial class startWindow : Form
    {
        int level;

        public startWindow()
        {
            InitializeComponent();
            
            //set bacground color
            this.BackColor = Color.FromArgb(174, 215, 211);
        }

        public startWindow(int lev)
        {
            level = lev;
            InitializeComponent();
            timer1.Start();
            i = 9;

            // set label with instruction
            LabeLWithInstruction.Text = "Znajdz wszystkie pary słów, \naby zakończyć grę";

            //set bacground color
            this.BackColor = Color.FromArgb(174, 215, 211);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ang AngGame;
            
            //check level and choose sieze window
            if (level == 1)
            {
                AngGame = new Ang(level);
                AngGame.Size = new Size(295, 280);
                this.Hide();
                AngGame.Show();
                this.Close();
            }
            if (level == 2)
            {
                AngGame = new Ang(level);
                AngGame.Size = new Size(295, 300);
                this.Hide();
                AngGame.Show();
                this.Close();
            }
            if (level == 3)
            {
                AngGame = new Ang(level);
                AngGame.Size = new Size(295, 350);
                this.Hide();
                AngGame.Show();
                this.Close();
            }
        }
        int i = 9;
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "gra rozpocznie się za: " + i.ToString() + "s";
            i--;
            if(i==-1)
            {
                timer1.Stop();
                Ang AngGame;

                //check level and choose sieze window
                if (level == 1)
                {
                    AngGame = new Ang(level);
                    AngGame.Size = new Size(295, 280);
                    this.Hide();
                    AngGame.Show();
                    this.Close();
                }
                if (level == 2)
                {
                    AngGame = new Ang(level);
                    AngGame.Size = new Size(295, 300);
                    this.Hide();
                    AngGame.Show();
                    this.Close();
                }
                if (level == 3)
                {
                    AngGame = new Ang(level);
                    AngGame.Size = new Size(295, 350);
                    this.Hide();
                    AngGame.Show();
                    this.Close();
                }
            }
        }
    }
}
