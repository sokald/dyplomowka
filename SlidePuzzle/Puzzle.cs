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
        //table for buttons
        //Btn[] net;
        int[] positionsButtons;

        Point[] netPoint;

        int i = 0;

        //Btn Btn1;
        //Btn Btn2;
        //Btn Btn3;
        //Btn Btn4;
        //Btn Btn5;
        //Btn Btn6;
        //Btn Btn7;
        //Btn Btn8;
        //Btn Btn9;
        ////Btn BtnTemp;

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

        Button[] buttonTbl;
        //Button tmpButton;

        //constructor without parameters
        public Puzzle()
        {
            InitializeComponent();

            buttonTbl = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9};

            //Btn1 = new Btn(button1, null, 1, 1);
            //Btn2 = new Btn(button2, null, 2, 2);
            //Btn3 = new Btn(button3, null, 3, 3);
            //Btn4 = new Btn(button4, null, 4, 4);
            //Btn5 = new Btn(button5, null, 5, 5);
            //Btn7 = new Btn(button6, null, 6, 6);
            //Btn6 = new Btn(button7, null, 7, 7);
            //Btn8 = new Btn(button8, null, 8, 8);
            //Btn9 = new Btn(button9, null, 9, 0);
            ////BtnTemp = new Btn();

            P1 = new Point(13, 13);
            P2 = new Point(69, 12);
            P3 = new Point(125, 12);
            P4 = new Point(13, 69);
            P5 = new Point(69, 69);
            P6 = new Point(125, 69);
            P7 = new Point(13, 125);
            P8 = new Point(69, 125);
            P9 = new Point(125, 125);

            //table for buttons
            //net = new Btn[]   {Btn1,Btn2,Btn3,Btn4,Btn5,Btn6,Btn7,Btn8,Btn9};
            
            netPoint = new Point[] { P1, P2, P3, P4, P5, P6, P7, P8, P9 };

            positionsButtons = new int[]  {1,2,3,4,5,6,7,8,9};

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";
            button9.Text = "9null";
        }

        int level;
        //constructor with parameters
        public Puzzle(int lev)
        {
            InitializeComponent();

            level = lev;

            buttonTbl = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };

            if(lev == 1)
            {       
                P1 = new Point(13, 13);
                P2 = new Point(69, 12);
                P3 = new Point(125, 12);
                P4 = new Point(13, 69);
                P5 = new Point(69, 69);
                P6 = new Point(125, 69);
                P7 = new Point(13, 125);
                P8 = new Point(69, 125);
                P9 = new Point(125, 125);

                //table for buttons
                //net = new Btn[]   {Btn1,Btn2,Btn3,Btn4,Btn5,Btn6,Btn7,Btn8,Btn9};
                
                //blacboard for net points
                netPoint = new Point[] { P1, P2, P3, P4, P5, P6, P7, P8, P9 };

                //location buttons in net
                for (i = 0; i < 9; i++ )
                    buttonTbl[i].Location = netPoint[i];

                //positionsButtons = new int[]  {1,2,3,4,5,6,7,8,9};

                //make text on buttons
                for (i = 0; i < 9; i++ )
                    buttonTbl[i].Text = i.ToString();

                //button2.Text = "2";
                //button3.Text = "3";
                //button4.Text = "4";
                //button5.Text = "5";
                //button6.Text = "6";
                //button7.Text = "7";
                //button8.Text = "8";
                
                //set text on the empty button
                button9.Text = "9XXX";

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

                netPoint = new Point[] { P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16 };

                //location buttons in net
                for (i = 0; i < 16; i++)
                    buttonTbl[i].Location = netPoint[i];                
                
                for (i = 0; i < 16; i++)
                    buttonTbl[i].Text = i.ToString();

                //set text on the empty button
                button16.Text = "15XXX";

                //turn off the empty button
                button16.Enabled = false;

                //turn off other buttons
                for (i = 16; i < 25; i++)
                    buttonTbl[i].Enabled = buttonTbl[i].Visible = false;

                //radnom location for buttons
                for (i = 0; i < 50; i++)
                    drawLocation(15);
            }

            if(lev == 3)
            {
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

                netPoint = new Point[] { P1, P2, P3, P4, P5, P6, P7, P8, P9, P10, P11, P12, P13, P14, P15, P16, P17, P18, P19, P20, P21, P22, P23, P24, P25 };

                //location buttons in net
                for (i = 0; i < 25; i++)
                    buttonTbl[i].Location = netPoint[i];

                for (i = 0; i < 25; i++)
                    buttonTbl[i].Text = i.ToString();

                //set text on the empty button
                button25.Text = "25XXX";

                //turn off the empty button
                button25.Enabled = false;

                //radnom location for buttons
                //for (i = 0; i < 50; i++ )
                    drawLocation(buttonTbl.Length);
            }
        }

        //for random positions
        Random Rand = new Random();

        int firstNumber, secondNumber;
        Button btnForSwap;
        Button btnForSwap2;

        //random location for buttons
        public void drawLocation(int amountButtons)
        {
            //random numbers for swap
            firstNumber = Rand.Next(amountButtons);
            secondNumber = Rand.Next(amountButtons);

            firstNumber = 7;
            secondNumber = 8;

            //swap locations buttons
            buttonTbl[firstNumber].Location = netPoint[secondNumber];
            buttonTbl[secondNumber].Location = netPoint[firstNumber];

            //swap buttons
            btnForSwap = buttonTbl[firstNumber];
            
            btnForSwap2 = buttonTbl[secondNumber];
            
            buttonTbl[secondNumber] = btnForSwap;
            buttonTbl[firstNumber] = btnForSwap2;
        }
        
        //varibles for clicked button
        Button clickedButton;

        //check null and swap buttons
        public void lookNull(Object sender)
        {
            clickedButton = sender as Button;

            //moze uzyc swich case
            if (clickedButton == null)
            {
                MessageBox.Show("Błąd aplikacji");
                this.Close();
            }

            try
            {
                //check level
                switch(level)
                {       
                    case 1:
                        //cunkcja(ilosc przyciskow, wylaczonyPrzycisk, ostatnie wylaczone z przeskakiwania)
                        //look turn off button
                        for (i = 0; i < 9; i++)
                        {
                            if (buttonTbl[i].Name == clickedButton.Name)
                            {
                                //check if varibles out table
                                if(i+1<9)
                                {
                                    if(i != 2 && i != 5)
                                    {
                                        if (buttonTbl[i + 1] == button9)
                                        {
                                            swapButtons(clickedButton, i, i + 1, button9);
                                            break;
                                        }
                                    }
                                }

                                if (i - 1 >= 0)
                                {
                                    if (i != 3 && i != 6)
                                    {
                                        if (buttonTbl[i - 1].Name == "button9")
                                        {
                                            swapButtons(clickedButton, i, i - 1, button9);
                                            break;
                                        }
                                    }
                                }

                
                                if (i + 3 < 9)
                                {
                                    if (buttonTbl[i + 3].Name == "button9")
                                    {
                                        swapButtons(clickedButton, i, i + 3, button9);
                                        break;
                                    }
                                }

                                if (i - 3 >= 0)
                                {
                                    if (buttonTbl[i - 3].Name == "button9")
                                    {
                                        swapButtons(clickedButton, i, i - 3, button9);
                                        break;
                                    }
                                }
                            }
                        }
                        break;

                    case 2:
                        //chec if varibles out table
                        for (i = 0; i < 15; i++)
                        {
                            if (buttonTbl[i].Name == clickedButton.Name)
                            {
                                if (i + 1 < 16)
                                {
                                    if (i != 3 && i != 7 && i != 11)
                                    {
                                        if (buttonTbl[i + 1] == button16)
                                        {
                                            swapButtons(clickedButton, i, i + 1, button16);
                                            break;
                                        }
                                    }
                                }

                                if (i - 1 >= 0)
                                {
                                    if (i != 4 && i != 8 && i != 12)
                                    {
                                        if (buttonTbl[i - 1].Name == "button16")
                                        {
                                            swapButtons(clickedButton, i, i - 1, button16);
                                            break;
                                        }
                                    }
                                }


                                if (i + 4 < 15)
                                {
                                    if (buttonTbl[i + 4].Name == "button16")
                                    {
                                        swapButtons(clickedButton, i, i + 4, button16);
                                        break;
                                    }
                                }

                                if (i - 4 >= 0)
                                {
                                    if (buttonTbl[i - 4].Name == "button16")
                                    {
                                        swapButtons(clickedButton, i, i - 4, button16);
                                        break;
                                    }
                                }
                            }
                        }
                        break;

                    case 3:
                        //chec if varibles out table
                        for (i = 0; i < 25; i++)
                        {
                            if (buttonTbl[i].Name == clickedButton.Name)
                            {
                                if (i + 1 < 25)
                                {
                                    if (i != 4 && i != 9 && i != 14 && i != 19)
                                    {
                                        if (buttonTbl[i + 1].Name == "button25")
                                        {
                                            swapButtons(clickedButton, i, i + 1, button25);
                                            break;
                                        }
                                    }
                                }

                                if (i - 1 >= 0)
                                {
                                    if (i != 5 && i != 10 && i != 15 && i != 20)
                                    {
                                        if (buttonTbl[i - 1].Name == "button25")
                                        {
                                            swapButtons(clickedButton, i, i - 1, button25);
                                            break;
                                        }
                                    }
                                }


                                if (i + 5 < 25)
                                {
                                    if (buttonTbl[i + 5].Name == "button25")
                                    {
                                        swapButtons(clickedButton, i, i + 5, button25);
                                        break;
                                    }
                                }

                                if (i - 5 >= 0)
                                {
                                    if (buttonTbl[i - 5].Name == "button25")
                                    {
                                        swapButtons(clickedButton, i, i - 5, button25);
                                        break;
                                    }
                                }
                            }
                        }
                        break;

                }
            }
            catch (IndexOutOfRangeException e)
            {
                MessageBox.Show("index poza zakresem tablicy");
            }
            catch (Exception e)
            {
                MessageBox.Show("błąd programu");
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

            switch(level)
            {
                case 1:
                    //check finished game
                    if (btnTurnOff == buttonTbl[8])
                    {
                        Button[] buttonTbl2 = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };

                        if (buttonTbl.Length == buttonTbl2.Length)
                        {
                            bool score = true;
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
                            MessageBox.Show("Błąd programu, aplikacja zostanie zamknięta");
                            this.Close();
                        }    
                    }
                    break;

                case 2:
                    //check finished game
                    if (btnTurnOff == buttonTbl[14])
                    {
                        Button[] buttonTbl2 = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };

                        for (i = 0; i < buttonTbl.Length; i++)
                        {
                            if (buttonTbl[i] != buttonTbl2[i])
                            {
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Brawo! gra zakończona");
                            }
                        }
                    }
                    break;

                case 3:
                    //check finished game
                    if (btnTurnOff == buttonTbl[buttonTbl.Length-1])
                    {
                        Button[] buttonTbl2 = new Button[] { button1, button2, button3, button4, button5, button6, button7, button8, button9, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, button20, button21, button22, button23, button24, button25 };

                        for( i=0; i< buttonTbl.Length; i++)
                        {
                            if (buttonTbl[i] != buttonTbl2[i])
                            {
                                break;
                            }
                            else
                            {
                                MessageBox.Show("Brawo! gra zakończona");
                            }
                        }
                    }
                    break;
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
    }
}
