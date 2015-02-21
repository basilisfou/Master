using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GateDemo3
{
    public partial class GatePool : Form
    {
        public GatePool()
        {
            InitializeComponent();
        }
        int index;
        Graphics g;
        String[] picArray = {  @"ppb\1.jpg",   //0     Places
                               @"ppb\2.jpg",   //1
                               @"ppb\3.jpg",   //2
                               @"ppb\4.jpg",   //3
                               @"ppb\5.jpg",   //4
                               @"ppb\6.jpg",   //5
                               @"ppb\7.jpg",   //6
                               @"ppb\8.jpg",   //7
                               @"ppb\9.jpg",   //8
                               @"ppb\10.jpg",  //9
                               @"ppb\11.jpg", //10
                               @"ppb\12.jpg", //11
                               @"ppb\13.jpg", //12
                               @"ppb\14.jpg", //13
                               @"ppb\15.jpg", //14
                               @"ppb\16.jpg", //15
                               @"ppb\17.jpg", //16
                               @"ppb\18.jpg", //17
                               @"ppb\19.jpg", //18
                               @"ppb\20.jpg", //19
                               @"ppb\21.jpg", //20
                               @"ppb\22.jpg", //21
                               @"ppb\23.jpg", //22
                               @"ppb\24.jpg", //23
                               @"ppb\25.jpg", //24
                               @"ppb\26.jpg", //25
                               @"ppb\27.jpg", //26
                               @"ppb\28.jpg", //27
                               @"ppb\29.jpg", //28
                               @"ppb\30.jpg", //29
                               @"ppb\31.jpg", //30
                               @"ppb\32.jpg", //31
                               @"ppb\33.jpg", //32
                               @"ppb\34.jpg", //33
                               @"ppb\35.jpg", //34
                               @"ppb\36.jpg", //35
                               @"ppb\37.jpg", //36
                               @"ppb\38.jpg", //37
                               @"ppb\39.jpg", //38
                            };

        private void showImage(string strImage)
        {
            try
            {
                Bitmap myPic = new Bitmap(strImage);
                g = CreateGraphics();
                g.DrawImage(myPic, 0, 0, 1280, 654);
            }
            catch (ObjectDisposedException e)
            {
                
            }
            
        }
        public String NextPic()
        {
            String s = null;

            //checks not to overpass the Lenght of the Array
            if (index < picArray.Length )
            {
                s = picArray[index];
                index++;
            }
            else
            {
                //Initializing the variable index so that it is imposimple to return a null String 
                index = 38;
                s = picArray[38];

                // terminating the Loop
                timer1.Enabled = false;

                // a delay
                System.Threading.Thread.Sleep(1500);

                //Creating a new Form type of Form 2 and hiding the previous one 
                Form3.control.Show();
                Form5.selector = true;
                Close();
              
            }
            return s;

        }
        private void Play()
        {
            string soundfile = @"Sounds\smallgate.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            showImage(NextPic());
        }
        private void GatePool_Load(object sender, EventArgs e)
        {
            Play();
            timer1.Enabled = true;
            timer1.Start();
        }

      
    }
}
