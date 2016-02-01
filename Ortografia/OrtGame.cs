using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ortografia
{
    public partial class OrtGame : Form
    {
        //string for file with words
        string[] fileWithWords;

        int i = 0, j = 0;

        //for ranodm number
        Random numberRandom = new Random();

        string[] tableWithCharacters;
        char[] charWord;

        //string for word
        string word;

        //varible for level
        int lev = 1;

        //constructor without parameters
        public OrtGame()
        {
            lev = 1;

            InitializeComponent();

            //set bacground color
            this.BackColor = Color.FromArgb(174, 215, 211);

            //turn off left and right button
            btnLeft.Visible = btnRight.Visible = false;

            //declarate file with words
            try
            {
                fileWithWords = System.IO.File.ReadAllLines(@"words.txt");
            }
            catch
            {
                MessageBox.Show("Błąd odczytu pliku, program zostanie zamknięty");
                this.Close();
            }

            //run game
            //Game();
        }

        public OrtGame(int level)
        {
            lev = level;
    
            InitializeComponent();

            //turn off left and right button
            btnLeft.Visible = btnRight.Visible = false;

            //declarate file with words
            try
            {
                fileWithWords = System.IO.File.ReadAllLines(@"words.txt");
            }
            catch
            {
                MessageBox.Show("Błąd odczytu pliku, program zostanie zamknięty");
                this.Close();
            }
            
            //set bacground color
            this.BackColor = Color.FromArgb(174, 215, 211);
            
            //run game
            //Game();
        }
    
        //varibles with good and bad ansewer
        int goodAnswer = 0;
        int badAnsewer = 0;

        public void Game()
        {
            if (j < 10)
            {
                //continue game
                j++;
                toolStripStatusLabel2.Text = j + "/10";
                //level1 0-76
                //level2 77-128
                //level3 130-200

                if(lev == 1)
                    i = numberRandom.Next(0, 76);

                if(lev == 2)
                    i = numberRandom.Next(77, 128);

                if(lev == 3)
                    i = numberRandom.Next(130, 200);

                //random word
                //i = numberRandom.Next(0, fileWithWords.Count());

                //set word in string
                word = fileWithWords[i];

                //declarate table with charaters
                charWord = new char[fileWithWords[i].Length];
                charWord = fileWithWords[i].ToCharArray();
                //tableCharacters = C-onvert.ToChar(fileWithWords[i]);

                //declarate table with characters
                tableWithCharacters = new string[] { "rz", "ż", "ó", "u", "ch", "h" };

                for (i = 0; i < tableWithCharacters.Length; i++)
                {
                    if (word.Contains(tableWithCharacters[i]))
                    {
                        word = word.Replace(tableWithCharacters[i], "_");

                        //random button with good answer
                        if (numberRandom.Next(2) == 0)
                        {
                            //left button with good answer
                            if (i % 2 == 0)
                            {
                                btnLeft.Text = tableWithCharacters[i];
                                btnRight.Text = tableWithCharacters[1 + i];
                                goodAnswer++;
                                break;
                            }
                            else
                            {
                                btnLeft.Text = tableWithCharacters[i];
                                btnRight.Text = tableWithCharacters[i - 1];
                                badAnsewer++;
                                break;
                            }
                        }
                        else
                        {
                            //right button with good answer
                            if (i % 2 == 0)
                            {
                                btnRight.Text = tableWithCharacters[i];
                                btnLeft.Text = tableWithCharacters[1 + i];
                                goodAnswer++;
                                break;
                            }
                            else
                            {
                                btnRight.Text = tableWithCharacters[i];
                                btnLeft.Text = tableWithCharacters[i - 1];
                                badAnsewer++;
                                break;
                            }
                        }
                    }
                }
                //set word
                lWord.Text = word;
            }
            else
            {
                DialogResult result;
                //message box
                result = MessageBox.Show("Brawo!! gra zakończona \n\nstatystyki: \n\nilość dobrych odpowiedz: " + goodAnswer + "\nilość nie prawidłowych odpowiedzi:"+badAnsewer+"\n\nChcesz zagrać ponownie?", "koniec?", MessageBoxButtons.RetryCancel);

                //return game
                if (result == System.Windows.Forms.DialogResult.Retry)
                {
                    Ortografia.OrtGame ortGame = new Ortografia.OrtGame(lev);
                    this.Hide();
                    ortGame.Show();
                    this.Close();
                }

                //finish game
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    this.Hide();
                    this.Close();
                }
                //stop game
                lWord.Text = "Koniec gry";
                btnLeft.Visible = false;
                btnRight.Visible = false;
            }
        }
       

        //start button
        private void button1_Click(object sender, EventArgs e)
        {
            btnStart.Visible = false;
            btnRight.Visible = btnLeft.Visible = true;
            Game();
        }

        //left button
        private void button2_Click(object sender, EventArgs e)
        {
            if (btnLeft.Text == tableWithCharacters[i])
            {
                MessageBox.Show("prawidłowa odpowiedź");
                Game();
            }
            else
            {
                MessageBox.Show("zła odpowiedź");
            }
        }

        //right button
        private void button3_Click(object sender, EventArgs e)
        {
            if (btnRight.Text == tableWithCharacters[i])
            {
                MessageBox.Show("prawidłowa odpowiedź");
                Game();
            }
            else
            {
                MessageBox.Show("zła odpowiedź");
            }
        }
    }
}
