using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
using System.Linq;
//using System.Text;
using System.Windows.Forms;
//using System.Timers;
//using System.Threading;
//using System.Threading.Tasks;

namespace ang
{
    public partial class Ang : Form
    {
        //declarate location for buttons
        Point b1 = new Point(55,    40);
        Point b2 = new Point(160,   40);
        Point b3 = new Point(55,    80);
        Point b4 = new Point(160,   80);
        Point b5 = new Point(55,    120);
        Point b6 = new Point(160,   120);
        Point b7 = new Point(55,    160);
        Point b8 = new Point(160,   160);
        Point b9 = new Point(55,    200);
        Point b10 = new Point(160,  200);
        Point b11 = new Point(55,   240);
        Point b12 = new Point(160,  240);

        //table for locations button
        Point[] pointTable;

        Dictionary<int, Point> points = new Dictionary<int, Point>();

        Random numberRandom = new Random();
        int number = 1;

        List<int> numbers = new List<int>();

        //write file to table
        string[] stringDictionary;

        //declarate tables for words
        string[] TabPol;
        string[] TabEng;
            
        Diction dict0;
        Diction dict1;
        Diction dict2;
        Diction dict3;

        Diction dict4;
        Diction dict5;

        //declarate varibles for time
        int sekond;
        short miliSekond;

        // firt constructor without parammeters
        public Ang()
        {
            InitializeComponent();
            
            //turn of form edukolandia

            sekond= miliSekond =0;

            //turn on stopWatch
            stopWatch.Start();            

            //read file and save words to table
            try
            {
                //stringDictionary = System.IO.File.ReadAllLines(@"C:\Users\sokald\Documents\Visual Studio 2012\Projects\ang\ang\Dictionary.txt");
                stringDictionary = System.IO.File.ReadAllLines(@"Dictionary.txt");
            }
            catch(Exception e)
            {
                MessageBox.Show("blad odczytu pliku, program zostnaie zamkniety");
                this.Close();
            }

            if (stringDictionary.Count() < 4)
            {
                MessageBox.Show("w pliku znajduje sie zamalo slow, aby mozna bylo rozpoczac gre. Program zostanie zamkniety");
                this.Close();
            }
            else
            { 
                //declarate size tables with words
                TabPol = new string[stringDictionary.Count()];
                TabEng = new string[stringDictionary.Count()];
            }

            //add word to tables
            number = 0;
            foreach(string line in stringDictionary)
            {
                try
                {
                    string[] words = line.Split(',');
                    TabPol[number] = words[0];
                    TabEng[number] = words[1];
                    number++;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Błąd przy tworzeniu slownika, program zostanie zamknięty");
                    this.Close();
                }
            }

            //random numbers for location buttons
            while (numbers.Count < 8)
            {
                number = numberRandom.Next(1, 9);
                if (!(numbers.Contains(number)))
                {
                    numbers.Add(number);
                }
            }

            points.Add(numbers[0], b1);
            points.Add(numbers[1], b2);
            points.Add(numbers[2], b3);
            points.Add(numbers[3], b4);
            points.Add(numbers[4], b5);
            points.Add(numbers[5], b6);
            points.Add(numbers[6], b7);
            points.Add(numbers[7], b8);

            numbers.Clear();

            //random words for buttons
            if (4 <= TabPol.Count())
            { 
                while (numbers.Count < TabPol.Count())
                {
                    number = numberRandom.Next(0, TabPol.Count());
                    if (!(numbers.Contains(number)))
                    {
                        numbers.Add(number);
                    }
                }
            }
            else
            {
                MessageBox.Show("Błąd aplikacji, program zostanie zamknięty");
                this.Close();
            }

            //add words
            dict0 = new Diction(TabPol[numbers[0]], TabEng[numbers[0]]);
            dict1 = new Diction(TabPol[numbers[1]], TabEng[numbers[1]]);
            dict2 = new Diction(TabPol[numbers[2]], TabEng[numbers[2]]);
            dict3 = new Diction(TabPol[numbers[3]], TabEng[numbers[3]]);

            //declarate place for buttons
            button1.Location = new System.Drawing.Point(points[1].X, points[1].Y);
            button2.Location = new System.Drawing.Point(points[2].X, points[2].Y);
            button3.Location = new System.Drawing.Point(points[3].X, points[3].Y);
            button4.Location = new System.Drawing.Point(points[4].X, points[4].Y);
            button5.Location = new System.Drawing.Point(points[5].X, points[5].Y);
            button6.Location = new System.Drawing.Point(points[6].X, points[6].Y);
            button7.Location = new System.Drawing.Point(points[7].X, points[7].Y);
            button8.Location = new System.Drawing.Point(points[8].X, points[8].Y);

            button1.Text = "1";
            button2.Text = "2";
            button3.Text = "3";
            button4.Text = "4";
            button5.Text = "5";
            button6.Text = "6";
            button7.Text = "7";
            button8.Text = "8";

            //button1.Text = null;
            //button2.Text = null;
            //button3.Text = null;
            //button4.Text = null;
            //button5.Text = null;
            //button6.Text = null;
            //button7.Text = null;
            //button8.Text = null;
        } // firt constructor without parammeters

        //for shot
        Diction shot = new Diction();

        //for checking
        Checker check = new Checker();
        
        //buttons tablie
        Button[] btnTable;


        //shot hit
        private void timer1_Tick(object sender, EventArgs e)
        {
            //System.Threading.Thread.Sleep(1000);
            timer1.Stop();
            //clrear all
            check.Btn1.Text = null;
            check.Btn1 = null;
            check.Btn2.Text = null;
            check.Btn2 = null;
            check.Pol = check.Eng = null;
        }

        //for read and save time in file
        FileStream fileStreamTime;
        StreamWriter streamWriterTime;

        double time = 0;
        //double timeFromFile = 0;
        StreamReader streamReaderTimer;

        //for storage times in memory
        double[] timeList = new double[10];
        int i;
        string line, timeResults;

        //check the end of the game
        private void CheckFinish()
        {
            if (button1.Enabled == false && button2.Enabled == false 
                && button3.Enabled == false && button4.Enabled == false 
                && button5.Enabled == false && button6.Enabled == false 
                && button7.Enabled == false && button8.Enabled == false
                && button9.Enabled == false && button10.Enabled == false
                && button11.Enabled == false && button12.Enabled == false
                )
            {
                stopWatch.Stop();
                toolStripStatusLabel2.Text = sekond + "," + miliSekond.ToString();

                //save file
                fileStreamTime = new FileStream(fileWithTimes, FileMode.Open, FileAccess.Read);

                try
                {
                    streamReaderTimer = new StreamReader(fileStreamTime);

                    i = 0;
                    while ( ( line = streamReaderTimer.ReadLine()) != null && i < 10)
                    {
                        //streamReaderTimer.ReadLine();
                        timeList[i] = Convert.ToDouble(line);
                        i++;
                    }
                    fileStreamTime.Close();                   

                    //current time
                    time = Convert.ToDouble(sekond + "," + miliSekond);

                    //comparing time and search better time
                    for (i = 0; i < timeList.Count(); i++ )
                    {
                        if (time < timeList[i] || timeList[i] == 0)
                        {
                            //trzeba przesynac cala tablice
                            for (int j = 8; j >= i; j-- )
                            {
                                number = j;
                                number++;
                                timeList[number] = timeList[j];
                            }
                            //new time in table
                            timeList[i] = time;
                            
                            //save to file new times
                            fileStreamTime = new FileStream(fileWithTimes, FileMode.Open, FileAccess.Write);
                            streamWriterTime = new StreamWriter(fileStreamTime);
                            //save time in file
                            for (i = 0; i < 10; i++)
                            {
                                streamWriterTime.WriteLine(timeList[i]);
                            }
                            streamWriterTime.Close();
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("blad aplikacji, program zostanie zamkniety");
                }

                //read time
                fileStreamTime = new FileStream(fileWithTimes, FileMode.Open, FileAccess.Read);
                try
                {
                    streamReaderTimer = new StreamReader(fileStreamTime);

                    i = 0;
                    while ((line = streamReaderTimer.ReadLine()) != null && i < 10)
                    {
                        //streamReaderTimer.ReadLine();
                        timeList[i] = Convert.ToDouble(line);

                        timeResults += i+1+".  " + timeList[i] + "\n";
                        i++;
                    }
                    fileStreamTime.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Błąd aplikacji, program zostanie zamkniety");
                }

                DialogResult result;
                //message box
                result = MessageBox.Show("Brawo!! gra zakończona, twój wynik to:  " + sekond + "," + miliSekond.ToString() + "s \nNajlepsze wyniki: \n" + timeResults, "zakończyć?", MessageBoxButtons.RetryCancel);

                if (result == System.Windows.Forms.DialogResult.Retry)
                {
                    //restart game
                    ang.Ang game = new Ang(level);

                    if (level == 1)
                        game.Size = new Size(295, 280);
                    if (level == 2)
                        game.Size = new Size(295, 300);
                    if (level == 3)
                        game.Size = new Size(295, 350);

                    this.Hide();
                    game.Show();
                    this.Close();
                }
                if (result == System.Windows.Forms.DialogResult.Cancel)
                {
                    //close game
                    this.Hide();
                    this.Close();
                }
            }
        }//check the end of the game

        string fileWithTimes;
        int level;
        // second cosntructor
        public Ang(int lev)
        {
            level = lev;
            sekond = miliSekond = 0;

            //declarate place for buttons
            pointTable = new Point[12];

            pointTable[0] = b1;
            pointTable[1] = b2;
            pointTable[2] = b3;
            pointTable[3] = b4;
            pointTable[4] = b5;
            pointTable[5] = b6;
            pointTable[6] = b7;
            pointTable[7] = b8;
            pointTable[8] = b9;
            pointTable[9] = b10;
            pointTable[10] = b11;
            pointTable[11] = b12;
			
            Diction[] tableDiction = new Diction[6];

            tableDiction[0] = dict0 = new Diction();
            tableDiction[1] = dict1 = new Diction();
            tableDiction[2] = dict2 = new Diction();
            tableDiction[3] = dict3 = new Diction();
            tableDiction[4] = dict4 = new Diction();
            tableDiction[5] = dict5 = new Diction();
            
            // level 1
            if(lev == 1)
            {
                InitializeComponent();
                
                //declarate file with times for leve 1
                //fileWithTimes = @"c:\Users\sokald\Documents\Visual Studio 2012\Projects\ang\ang\timesLevel1.txt";
                fileWithTimes = @"timesLevel1.txt";

                //turn on stopWatch
                stopWatch.Start();

                //add word to tables
                makeTables(4);

                //random numbers for location buttons
                Random(8, 0, 8);

                //while (numbers.Count < 8)
                //{
                //    number = numberRandom.Next(1, 9);
                //    if (!(numbers.Contains(number)))
                //    {
                //        numbers.Add(number);
                //    }
                //}				

                for(i=0; i<8;i++)
                {
                    points.Add(numbers[i], pointTable[i]);
                }
                //points.Add(numbers[0], b1);
                //points.Add(numbers[1], b2);
                //points.Add(numbers[2], b3);
                //points.Add(numbers[3], b4);
                //points.Add(numbers[4], b5);
                //points.Add(numbers[5], b6);
                //points.Add(numbers[6], b7);
                //points.Add(numbers[7], b8);
                
                //random words for buttons
                if (4 <= TabPol.Count())
                {
                    Random(TabPol.Count(), 0, TabPol.Count());
                }
                else
                {
                    MessageBox.Show("Błąd aplikacji, program zostanie zamknięty");
                    this.Close();
                }

                //add words
                for (i = 0; i < 4; i++ )
                {
                    tableDiction[i].Pol = TabPol[numbers[i]];
                    tableDiction[i].Eng = TabEng[numbers[i]];
                }
                //dict0 = new Diction(TabPol[numbers[0]], TabEng[numbers[0]]);
                //dict1 = new Diction(TabPol[numbers[1]], TabEng[numbers[1]]);
                //dict2 = new Diction(TabPol[numbers[2]], TabEng[numbers[2]]);
                //dict3 = new Diction(TabPol[numbers[3]], TabEng[numbers[3]]);

                // declararte table for buttons
                btnTable = new Button[12];

                btnTable[0] = button1;
                btnTable[1] = button2;
                btnTable[2] = button3;
                btnTable[3] = button4;
                btnTable[4] = button5;
                btnTable[5] = button6;
                btnTable[6] = button7;
                btnTable[7] = button8;
                btnTable[8] = button9;
                btnTable[9] = button10;
                btnTable[10] = button11;
                btnTable[11] = button12;

                //declarate place for buttons
                for (i = 0; i < 8; i++)
                {
                    btnTable[i].Location = new System.Drawing.Point(points[i].X, points[i].Y);
                    btnTable[i].Text = null;
                }
                //button1.Location = new System.Drawing.Point(points[1].X, points[1].Y);
                //button2.Location = new System.Drawing.Point(points[2].X, points[2].Y);
                //button3.Location = new System.Drawing.Point(points[3].X, points[3].Y);
                //button4.Location = new System.Drawing.Point(points[4].X, points[4].Y);
                //button5.Location = new System.Drawing.Point(points[5].X, points[5].Y);
                //button6.Location = new System.Drawing.Point(points[6].X, points[6].Y);
                //button7.Location = new System.Drawing.Point(points[7].X, points[7].Y);
                //button8.Location = new System.Drawing.Point(points[8].X, points[8].Y);
                
                //turn off other buttons				
				for(i = 8; i<12; i++)
				{
                    btnTable[i].Enabled = false;
                    btnTable[i].Text = null;
                    btnTable[i].Visible = false;
				}				
                //button9.Enabled = button10.Enabled = button11.Enabled = button12.Enabled = false;
                //button9.Text = button10.Text = button11.Text = button12.Text = null;
                //button9.Visible = button10.Visible = button11.Visible = button12.Visible = false;
            }

            // level 2
            if (lev == 2)
            {
                InitializeComponent();

                //turn on stopWatch
                stopWatch.Start();

                ////add word to tables
                //makeTables(5);

                //declarate file with times for leve 2
                //fileWithTimes = @"c:\Users\sokald\Documents\Visual Studio 2012\Projects\ang\ang\timesLevel2.txt";
                fileWithTimes = @"timesLevel2.txt";

                //turn on stopWatch
                stopWatch.Start();

                //add word to tables
                makeTables(5);

                //numbers.Clear();
                //random numbers for location buttons
                Random(10, 0, 10);

                for (i = 0; i < 10;i++ )
                {
                    points.Add(numbers[i], pointTable[i]);
                }

                //random words for buttons
                if (4 <= TabPol.Count())
                {
                    Random(TabPol.Count(), 0, TabPol.Count());
                }
                else
                {
                    MessageBox.Show("Błąd aplikacji, program zostanie zamknięty");
                    this.Close();
                }

                //add words
                for (i = 0; i < 5; i++)
                {
                    tableDiction[i].Pol = TabPol[numbers[i]];
                    tableDiction[i].Eng = TabEng[numbers[i]];
                }

                // declararte table for buttons
                btnTable = new Button[12];

                btnTable[0] = button1;
                btnTable[1] = button2;
                btnTable[2] = button3;
                btnTable[3] = button4;
                btnTable[4] = button5;
                btnTable[5] = button6;
                btnTable[6] = button7;
                btnTable[7] = button8;
                btnTable[8] = button9;
                btnTable[9] = button10;
                btnTable[10] = button11;
                btnTable[11] = button12;

                //declarate place for buttons
                for (i = 0; i < 10; i++)
                {
                    btnTable[i].Location = new System.Drawing.Point(points[i].X, points[i].Y);
                    btnTable[i].Text = null;
                }

                //turn off other buttons
                for (i = 10; i < 12;i++ )
                {
                    btnTable[i].Enabled = false;
                    btnTable[i].Text = null;
                    btnTable[i].Visible = false;
                }
            }

            // level 3
            if (lev == 3)
            {
                InitializeComponent();

                //turn on stopWatch
                stopWatch.Start();

                //add word to tables
                makeTables(6);

                //declarate file with times for leve 3
                //fileWithTimes = @"c:\Users\sokald\Documents\Visual Studio 2012\Projects\ang\ang\timesLevel3.txt";
                fileWithTimes = @"timesLevel3.txt";

                //turn on stopWatch
                stopWatch.Start();

                //add word to tables
                makeTables(6);

                //numbers.Clear();
                //random numbers for location buttons
                Random(12, 0, 12);

                //foreach (Point btn in pointTable)
                for (i = 0; i < 12; i++ )
                {
                    points.Add(numbers[i], pointTable[i]);
                }
       
                //random words for buttons
                if (4 <= TabPol.Count())
                {
                    Random(TabPol.Count(), 0, TabPol.Count());
                }
                else
                {
                    MessageBox.Show("Błąd aplikacji, program zostanie zamknięty");
                    this.Close();
                }

                //add words
                for (i = 0; i < 6; i++)
                {
                    tableDiction[i].Pol = TabPol[numbers[i]];
                    tableDiction[i].Eng = TabEng[numbers[i]];
                }

                // declararte table for buttons
                btnTable = new Button[12];

                btnTable[0] = button1;
                btnTable[1] = button2;
                btnTable[2] = button3;
                btnTable[3] = button4;
                btnTable[4] = button5;
                btnTable[5] = button6;
                btnTable[6] = button7;
                btnTable[7] = button8;
                btnTable[8] = button9;
                btnTable[9] = button10;
                btnTable[10] = button11;
                btnTable[11] = button12;

                //declarate place for buttons
                for (i = 0; i < 12; i++)
                {
                    btnTable[i].Location = new System.Drawing.Point(points[i].X, points[i].Y);
                    btnTable[i].Text = null;
                }
            }
            
            //button1.Text = "1";
            //button2.Text = "2";
            //button3.Text = "3";
            //button4.Text = "4";
            //button5.Text = "5";
            //button6.Text = "6";
            //button7.Text = "7";
            //button8.Text = "8";
            //button9.Text = "9";
            //button10.Text = "10";
            //button11.Text = "11";
            //button12.Text = "12";             
         
            //if is error
            if(lev != 1 && lev !=2 && lev != 3)
            {
                MessageBox.Show("blad wywolania programu");
            }
        } // second cosntructor

        //stopWatch for cout time game
        private void stopWatch_Tick(object sender, EventArgs e)
        {
            if(miliSekond>10)
            {
                sekond++;
                miliSekond=0;
            }
            toolStripStatusLabel2.Text = sekond+","+miliSekond.ToString();
            miliSekond++;
        }

        //make tables with words
        private void makeTables(int countWords)
        {
            //read file and save words to table
            try
            {
                //stringDictionary = System.IO.File.ReadAllLines(@"C:\Users\sokald\Documents\Visual Studio 2012\Projects\ang\ang\Dictionary.txt");
                stringDictionary = System.IO.File.ReadAllLines(@"Dictionary.txt");
            }
            catch (Exception e)
            {
                MessageBox.Show("blad odczytu pliku, program zostnaie zamkniety");
                this.Close();
            }

            if (stringDictionary.Count() < countWords)
            {
                MessageBox.Show("w pliku znajduje sie zamalo slow, aby mozna bylo rozpoczac gre. Program zostanie zamkniety");
                this.Close();
            }
            else
            {
                //declarate size tables with words
                TabPol = new string[stringDictionary.Count()];
                TabEng = new string[stringDictionary.Count()];
            }

            //add word to tables
            number = 0;
            foreach (string line in stringDictionary)
            {
                try
                {
                    string[] words = line.Split(',');
                    TabPol[number] = words[0];
                    TabEng[number] = words[1];
                    number++;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Błąd aplikacji, program zostanie zamknięty");
                    this.Close();
                }
            }
        }

        //function for random
        private void Random( int rangeTo, int randomForm, int randomTo)
        {
            numbers.Clear();
            while (numbers.Count < rangeTo)
            {
                number = numberRandom.Next(randomForm, randomTo);
                if (!(numbers.Contains(number)))
                {
                    numbers.Add(number);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            check.checker1(button1, timer1, dict0);
            CheckFinish();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check.checker2(button2, timer1, dict0);
            CheckFinish();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            check.checker1(button3, timer1, dict1);
            CheckFinish();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            check.checker2(button4, timer1, dict1);
            CheckFinish();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            check.checker1(button5, timer1, dict2);
            CheckFinish();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            check.checker2(button6, timer1, dict2);
            CheckFinish();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            check.checker1(button7, timer1, dict3);                 
            CheckFinish();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            check.checker2(button8, timer1, dict3);
            CheckFinish();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            check.checker1(button9, timer1, dict4);
            CheckFinish();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            check.checker2(button10, timer1, dict4);
            CheckFinish();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            check.checker1(button11, timer1, dict5);
            CheckFinish();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            check.checker2(button12, timer1, dict5);
            CheckFinish();
        }
    }// public partial class Form1 : Form
}
