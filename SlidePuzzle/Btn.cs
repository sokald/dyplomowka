using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidePuzzle
{
    class Btn
    {
        //constructor without parameters
        public Btn()
        {
            btn = null;
            pic = null;
            numberButton = 0;
            position = 0;
        }

        //constructor with parameters
        public Btn(Button button, PictureBox picture, int numberButtonn, int locationInNet)
        {
            btn = button;
            pic = picture;
            numberButton = numberButtonn;
            position = locationInNet;
        }

        //varibles
        Button btn;
        PictureBox pic;
        int numberButton;
        int position;

        public PictureBox Pic
        {
            get { return pic; }
            set { pic = value; }
        }

        public Button Btn1
        {
            get { return btn; }
            set { btn = value; }
        }
        
        public int NumberButton
        {
            get { return numberButton; }
            set { numberButton = value; }
        }  
        
        public int Position
        {
            get { return position; }
            set { position = value; }
        }

        //for move button
        public void ChecFreePlace()
        {
            //where am i

        }
    }
}
