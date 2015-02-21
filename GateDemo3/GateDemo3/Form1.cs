using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; // to use Tread.Sleep()

namespace GateDemo3
{
    public partial class Form1 : Form
    {
        Bitmap myPic;
        public static Form2 Inside = new Form2();
        //declaring an Array and initialing it , adding the paths of the Images of the Gate 
        String[] picArray = {  @"GateImages\πυλη1β.jpg",    //0     Places
                               @"GateImages\πυλη2β.jpg",    //1
                               @"GateImages\πυλη3β.jpg",    //2
                               @"GateImages\πυλη4β.jpg",    //3
                               @"GateImages\πυλη5β.jpg",    //4
                               @"GateImages\πυλη6β.jpg",    //5
                               @"GateImages\πυλη7β.jpg",    //6
                               @"GateImages\πυλη8β.jpg",    //7
                               @"GateImages\πυλη9β.jpg",    //8
                               @"GateImages\πυλη10β.jpg",   //9
                               @"GateImages\πυλη11β.jpg",   //10
                               @"GateImages\πυλη12β.jpg",   //11
                               @"GateImages\πυλη13β.jpg",   //12
                               @"GateImages\πυλη14β.jpg",   //13
                               @"GateImages\πυλη15β.jpg",   //14
                               @"GateImages\πυλη16β.jpg",   //15
                               @"GateImages\πυλη17β.jpg",   //16
                               @"GateImages\πυλη18β.jpg",   //17
                               @"GateImages\πυλη19β.jpg",   //18
                               @"GateImages\πυλη20β.jpg",   //19
                               @"GateImages\πυλη21β.jpg",   //20
                               @"GateImages\πυλη22β.jpg",   //21
                               @"GateImages\πυλη23β.jpg",   //22
                               @"GateImages\πυλη24β.jpg"};  //23

        Graphics g;
        int index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // method that drawes the image in the form , takes as an argument the String (path) of the Image
        private void showImage(string strImage)
        {
            myPic = new Bitmap(strImage);
            g = CreateGraphics();
            g.DrawImage(myPic, 0, 0,1159,634); 
        }

        // method that returns the path of the Image 
        public String NextPic()
        {
            String s = null;

            //checks not to overpass the Lenght of the Array
            if (index < picArray.Length)
            {
                s = picArray[index];
                index++;
            }
            else
            {
                //Initializing the variable index so that it is imposimple to return a null String 
                index = 0;
                s = picArray[index++];

                // terminating the Loop
                timer1.Enabled = false;

                // a delay
                Thread.Sleep(1500);

                //Creating a new Form type of Form 2 and hiding the previus one 
                
                Inside.Show();
                this.Hide();

            }
            return s;
        }

        //method that strats the timer when clicking in a spesific area 
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if ( ( (e.X > 422) && (e.X < 621) ) && ( (e.Y > 223) && (e.Y < 526) ) )
            {
                timer1.Enabled = true;
                timer1.Start();
                Play();
            }
        }

        //Looping 
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            showImage(NextPic()); 
        }

        // changing the cursor over the Gate
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (((e.X > 422) && (e.X < 621)) && ((e.Y > 223) && (e.Y < 526)))
            {
                Cursor = Cursors.Hand;
            }
            else
                Cursor = Cursors.Arrow;
        }

        //Sound of gate
       private void Play()
        {
            string soundfile = @"Sounds\gatedemo.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }

       private void button1_Click(object sender, EventArgs e)
       {
           MessageBox.Show("Για να μπείτε στο κάστρο πατήστε πάνω στην κεντρική πύλη");
       }
        //finding the coordinates to open the door
        /*
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
                label1.Visible = True;
                label2.Visible = True;
                
                label1.Text = e.X.ToString();
                label2.Text = e.Y.ToString();
            
        }
        */
    
    }
}

