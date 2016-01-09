using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidePuzzle
{
    public partial class Puzzle : Form
    {
        //table for points with place for buttons
        Point[] netPoint;

        int i = 0;

        //points with place for buttons
        Point P1;
        Point P2;
        Point P3;
        Point P4;
        Point P5;
        Point P6;
        Point P7;
        Point P8;
        Point P9;
        Point P10;
        Point P11;
        Point P12;
        Point P13;
        Point P14;
        Point P15;
        Point P16;
        Point P17; 
        Point P18; 
        Point P19; 
        Point P20;
        Point P21;
        Point P22;
        Point P23;
        Point P24;
        Point P25;

        //table for buttons
        Button[] buttonTbl;

        //constructor without parameters
        public Puzzle()
        {
            InitializeComponent();

            buttonTbl = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9};

            P1 = new Point(13, 13);
            P2 = new Point(69, 12);
            P3 = new Point(125, 12);
            P4 = new Point(13, 69);
            P5 = new Point(69, 69);
            P6 = new Point(125, 69);
            P7 = new Point(13, 125);
            P8 = new Point(69, 125);
            P9 = new Point(125, 125);
            
            netPoint = new Point[] { P1, P2, P3, P4, P5, P6, P7, P8, P9 };

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = null;
        }

        // global varible for level
        int level;

        //constructor with parameters
        public Puzzle(int lev)
        {
            InitializeComponent();

            //declarate level in global varible
            level = lev;

            //declarate 
            buttonTbl = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };

            if(lev == 1)
            {       
                //declarate place for buttons
                P1 = new Point(13, 13);
                P2 = new Point(69, 12);
                P3 = new Point(125, 12);
                P4 = new Point(13, 69);
                P5 = new Point(69, 69);
                P6 = new Point(125, 69);
                P7 = new Point(13, 125);
                P8 = new Point(69, 125);
                P9 = new Point(125, 125);

                //table for net points
                netPoint = new Point[] { P1, P2, P3, P4, P5, P6, P7, P8, P9 };

                //location buttons in net
                for (i = 0; i < 9; i++ )
                    buttonTbl[i].Location = netPoint[i];

                //make text on buttons
                for (i = 0; i < 9; i++ )
                    buttonTbl[i].Text = (1+i).ToString();

                //set text on the empty button
                button9.Text = null;

                //turn off the empty button
                button9.Enabled = false;

                //turn off other buttons
                for (i = 9; i < 25; i++)
                    buttonTbl[i].Enabled = buttonTbl[i].Visible = false;

                //radnom location for buttons
                for (i = 0; i < 50; i++)
                    drawLocation(9);
            }

            if(lev == 2)
            {
                //declarate place for buttons
                P1 = new Point(13, 13);
                P2 = new Point(69, 12);
                P3 = new Point(125, 12);
                P4 = new Point(181, 12);

                P5 = new Point(13, 69);
                P6 = new Point(69, 69);
                P7 = new Point(125, 69);
                P8 = new Point(181, 69);

                P9 = new Point(13, 125);
                P10 = new Point(69, 125);
                P11 = new Point(125, 125);
                P12 = new Point(181, 125);

                P13 = new Point(13, 181);
                P14 = new Point(69, 181);
                P15 = new Point(125, 181);
                P16 = new Point(181, 181);

                //table for net points
                netPoint = new Point[] { P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16 };

                //location buttons in net
                for (i = 0; i < 16; i++)
                    buttonTbl[i].Location = netPoint[i];

                //make text on buttons
                for (i = 0; i < 16; i++)
                    buttonTbl[i].Text = (1 + i).ToString();

                //set text on the empty button
                button16.Text = null;

                //turn off the empty button
                button16.Enabled = false;

                //turn off other buttons
                for (i = 16; i < 25; i++)
                    buttonTbl[i].Enabled = buttonTbl[i].Visible = false;

                //radnom location for buttons
                for (i = 0; i < 50; i++)
                    drawLocation(16);
            }

            if(lev == 3)
            {
                //declarate place for buttons
                P1 = new Point(13, 13);
                P2 = new Point(69, 12);
                P3 = new Point(125, 12);
                P4 = new Point(181, 12);
                P5 = new Point(237, 12);

                P6 = new Point(13, 69);
                P7 = new Point(69, 69);
                P8 = new Point(125, 69);
                P9 = new Point(181, 69);
                P10 = new Point(237, 69);

                P11 = new Point(13, 125);
                P12 = new Point(69, 125);
                P13 = new Point(125, 125);
                P14 = new Point(181, 125);
                P15 = new Point(237, 125);

                P16 = new Point(13, 181);
                P17 = new Point(69, 181);
                P18 = new Point(125, 181);
                P19 = new Point(181, 181);
                P20 = new Point(237, 181);

                P21 = new Point(13, 237);
                P22 = new Point(69, 237);
                P23 = new Point(125, 237);
                P24 = new Point(181, 237);
                P25 = new Point(237, 237);

                //table for net points
                netPoint = new Point[] { P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20, P21, P22, P23, P24, P25 };

                //location buttons in net
                for (i = 0; i < 25; i++)
                    buttonTbl[i].Location = netPoint[i];

                //make text on buttons
                for (i = 0; i < 25; i++)
                    buttonTbl[i].Text = (1 + i).ToString();

                //set text on the empty button
                button25.Text = null;

                //turn off the empty button
                button25.Enabled = false;

                //radnom location for buttons
                for (i = 0; i < 50; i++)
                    drawLocation(buttonTbl.Length);
            }
        }

        //for random positions
        Random Rand = new Random();

        //varibles for random n
        int firstNumber, secondNumber;
        Button btnForSwap;

        //random location for buttons
        public void drawLocation(int amountButtons)
        {
            //random numbers for swap
            firstNumber = Rand.Next(amountButtons);
            secondNumber = Rand.Next(amountButtons);

            //firstNumber = 23;
            //secondNumber = 24;

            //swap locations buttons
            buttonTbl[firstNumber].Location = netPoint[secondNumber];
            buttonTbl[secondNumber].Location = netPoint[firstNumber];

            //swap buttons
            btnForSwap = buttonTbl[firstNumber];
            buttonTbl[firstNumber] = buttonTbl[secondNumber];
            buttonTbl[secondNumber] = btnForSwap;
        }
        
        //varibles for clicked button
        Button clickedButton;

        //check null and swap buttons
        public void lookNull(Object sender)
        {
            clickedButton = sender as Button;

            if (clickedButton == null)
            {
                MessageBox.Show("Błąd aplikacji");
                this.Close();
            }

            //look turn off button and swap buttons
            switch (level)
            {
                case 1:
                    {
                        //level 1
                        int[] tabExceptions1 = { 2, 5 };
                        int[] tabExceptions2 = { 3, 6 };
                        lookNull3(9, tabExceptions1, tabExceptions2, button9, clickedButton, 3);
                    }
                    break;
                case 2:
                    {
                        //level 2
                        int[] tabExceptions1 = new int[] { 3, 7, 11 };
                        int[] tabExceptions2 = new int[] { 4, 8, 17 };
                        lookNull3(16, tabExceptions1, tabExceptions2, button16, clickedButton, 4);
                    }
                    break;
                case 3:
                    { 
                        //level 3
                        int[] tabExceptions1 = new int[] { 4, 9, 14, 19 };
                        int[] tabExceptions2 = new int[] { 5, 10, 15, 20 };
                        lookNull3(buttonTbl.Length, tabExceptions1, tabExceptions2, button25, clickedButton, 5);
                    }
                    break;
                default:
                    MessageBox.Show("Błąd programu");
                    break;
            }
        }

        public void lookNull3(int amountButtons, int[] exceptions1, int[] exceptions2, Button turnOffBtn, Button clickedButton, int upOrDownBtn)
        {
            //look turn off button
            for (i = 0; i < amountButtons; i++)
            {
                if (buttonTbl[i].Name == clickedButton.Name)
                {
                    //check if turn off button is on the right
                    if (i + 1 < amountButtons)
                    {
                        //condition 
                        bool condition = false;
                        for (int j = 0; j < exceptions1.Length; j++)
                        {
                            if (i == exceptions1[j])
                            {
                                condition = true;
                                break;
                            }
                        }
                            
                        if (buttonTbl[i + 1] == turnOffBtn && condition == false)
                        {
                            swapButtons(clickedButton, i, i + 1, turnOffBtn);
                            break;
                        }    
                    }

                    //check if turn off button is on the left
                    if (i - 1 >= 0)
                    {
                        //condition 
                        bool condition = false;
                        for (int j = 0; j < exceptions1.Length; j++)
                        {
                            if (i == exceptions2[j])
                            {
                                condition = true;
                                break;
                            }
                        }

                        if (buttonTbl[i - 1] == turnOffBtn && condition == false)
                        {
                            swapButtons(clickedButton, i, i - 1, turnOffBtn);
                            break;
                        }                        
                    }

                    //check if turn off button is on the down
                    if (i + upOrDownBtn < amountButtons)
                    {
                        if (buttonTbl[i + upOrDownBtn] == turnOffBtn)
                        {
                            swapButtons(clickedButton, i, i + upOrDownBtn, turnOffBtn);
                            break;
                        }
                    }

                    //check if turn off button is on the up
                    if (i - upOrDownBtn >= 0)
                    {
                        if (buttonTbl[i - upOrDownBtn] == turnOffBtn)
                        {
                            swapButtons(clickedButton, i, i - upOrDownBtn, turnOffBtn);
                            break;
                        }
                    }
                    break;
                }
            }
        }

        //swap buttons
        public void swapButtons(Button clickedButton, int i, int j, Button btnTurnOff)
        {
            try
            {
                buttonTbl[i] = btnTurnOff;
                buttonTbl[j] = clickedButton;

                buttonTbl[i].Location = netPoint[i];
                buttonTbl[j].Location = netPoint[j];
            }
            catch(Exception e)
            {
                MessageBox.Show("Błąd aplikacji");
            }

            //check finished game
            switch(level)
            {
                case 1:
                    //check finished game
                    if (btnTurnOff == buttonTbl[8])
                    {
                        checkFinish();
                    }
                    break;

                case 2:
                    //check finished game
                    if (btnTurnOff == buttonTbl[15])
                    {
                        checkFinish();
                    }
                    break;

                case 3:
                    //check finished game
                    if (btnTurnOff == buttonTbl[24])
                    {
                        checkFinish();
                    }
                    break;
            }
        }

        //check finish game
        public void checkFinish()
        {
            Button[] buttonTbl2 = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };

            bool score = true;

            if (buttonTbl.Length == buttonTbl2.Length)
            {
                for (i = 0; i < buttonTbl.Length; i++)
                {
                    if (buttonTbl[i] != buttonTbl2[i])
                    {
                        score = false;
                        break;
                    }
                }
            }
            else
            {
                score = false;
                MessageBox.Show("Błąd programu, aplikacja zostanie zamknięta");
                this.Close();
            }

            if (score)
            {
                MessageBox.Show("koniec gry");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            lookNull(sender);
        }

        private void button25_Click(object sender, EventArgs e)
        {

        }

        //timer for measure game time
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
