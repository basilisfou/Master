using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading; 



namespace GateDemo3
{
    public partial class Form2 : Form
    {
        Graphics g;
        Bitmap Image;
        public static int index = 0;
        public static int index2 = 0;
       
        
       
        public static Form3 room = new Form3();
        /**************************************************************Array Paths ****************************************************************/             
        //
        //adding the paths of the Images of the prince
        //
        string[] princeImageArray = {   
                                        @"interior\εσωτερικο καστρου.jpg",
                                        @"interior\prince.jpg",
                                        @"interior\prince2.jpg",
                                        @"interior\prince3.jpg",
                                        @"interior\prince4.jpg",
                                        @"interior\prince5.jpg",
                                        @"interior\prince6.jpg",
                                        @"interior\prince7.jpg",
                                        @"interior\prince8.jpg", 
                                        @"interior\prince7.jpg",
                                        @"interior\prince6.jpg",
                                        @"interior\prince5.jpg",
                                        @"interior\prince4.jpg",
                                        @"interior\prince3.jpg",
                                        @"interior\prince2.jpg",
                                        @"interior\prince.jpg",
                                        @"interior\εσωτερικο καστρου.jpg"
                                    };
        //
       //adding the paths of the cloud 
       //
        string[] princeCloud = {    
                                    @"interior\εσωτερικο καστρου.jpg",
                                    @"interior\prince.jpg",
                                    @"interior\prince2.jpg",
                                    @"interior\prince3.jpg",
                                    @"interior\prince4.jpg",
                                    @"interior\prince5.jpg",
                                    @"interior\prince6.jpg",
                                    @"interior\prince7.jpg",
                                    @"interior\prince8.jpg",
                                    @"interior\a.jpg",
                                    @"interior\b.jpg",
                                    @"interior\c.jpg",
                               };
         string[] princessCloud = {    
                                     @"interior\εσωτερικο καστρου.jpg",
                                        @"interior\princess.jpg",
                                        @"interior\princess2.jpg",
                                        @"interior\princess3.jpg",
                                        @"interior\princess4.jpg",
                                        @"interior\princess5.jpg",
                                        @"interior\princess6.jpg",
                                        @"interior\princess7.jpg",
                                        @"interior\princess8.jpg",
                                        @"interior\princess9.jpg",
                                        @"interior\princess10.jpg",
                                        @"interior\e.jpg",
                                        @"interior\f.jpg",
                                        @"interior\g.jpg"

                               };
         //
        //adding the paths of the Images of the princess
        //
        string[] princessImageArray = { 
                                        @"interior\εσωτερικο καστρου.jpg",
                                        @"interior\princess.jpg",
                                        @"interior\princess2.jpg",
                                        @"interior\princess3.jpg",
                                        @"interior\princess4.jpg",
                                        @"interior\princess5.jpg",
                                        @"interior\princess6.jpg",
                                        @"interior\princess7.jpg",
                                        @"interior\princess8.jpg",
                                        @"interior\princess9.jpg",
                                        @"interior\princess10.jpg",
                                        @"interior\princess9.jpg",
                                        @"interior\princess8.jpg",
                                        @"interior\princess7.jpg",
                                        @"interior\princess6.jpg",
                                        @"interior\princess5.jpg",
                                        @"interior\princess4.jpg",
                                        @"interior\princess3.jpg",
                                        @"interior\princess2.jpg",
                                        @"interior\princess.jpg",
                                        @"interior\εσωτερικο καστρου.jpg"
                                      };

        string[] intdoor = { 
                            @"intdoor1.jpg",
                            @"intdoor2.jpg",
                            @"intdoor3.jpg",
                            @"intdoor4.jpg",
                            @"intdoor5.jpg",
                            @"intdoor6.jpg",
                            @"intdoor7.jpg",
                            @"intdoor8.jpg",
                            @"intdoor9.jpg",
                            @"intdoor10.jpg",
                            @"intdoor11.jpg",
                            @"intdoor12.jpg",
                            @"intdoor13.jpg",
                            @"intdoor14.jpg",
                            @"intdoor15.jpg",
                            @"intdoor16.jpg",
                            @"intdoor17.jpg",
                            @"intdoor18.jpg",
                            @"intdoor19.jpg",
                            @"intdoor20.jpg",
                            @"intdoor21.jpg",
                            @"intdoor22.jpg",
                            @"intdoor23.jpg",
                            @"intdoor24.jpg"
                           };

        public Form2()
        {
            InitializeComponent();

        }

        /**************************************************************Mouse events ****************************************************************
         *                                                                                                                                         *
         *           Methods : MouseMove : moving the prince and princess , finding the coordinates of the location of some objects                *
         *           Methods : MouseClick : clicking on the prince and princess so that the user can talk with them                                *
         *           Methods : DoubleClick : clicking to times to the prince and princess so that the cloud can close                              *
         *                                                                                                                                         *
         ******************************************************************************************************************************************/

        private void Form2_MouseMove(object sender, MouseEventArgs e)
        {
            //finding the coordinates
            /*      label3.Visible = true;
                    label4.Visible = true;
                    label3.Text = e.X.ToString();
                    label4.Text = e.Y.ToString();   */

            if (((e.Y > 335) && (e.Y < 560)) && ((e.X > 305) && (e.X < 384))) //for the prince
            {
                Cursor = Cursors.Hand;
                timer1.Enabled = true; // prince is moving

            }
            else if (((e.Y > 325) && (e.Y < 541)) && ((e.X > 925) && (e.X < 1006)))     //for the princess
            {
                Cursor = Cursors.Hand;
                timer2.Enabled = true; // princess is moving 
            }
            else if (((e.Y > 75) && (e.Y < 600)) && ((e.X > 1110) && (e.X < 1210))) //changing the cursor over the door of the room
                Cursor = Cursors.Hand;
            else if (((e.Y > 281) && (e.Y < 491)) && ((e.X > 540) && (e.X < 675))) //for the door of the restaurant to open
                Cursor = Cursors.Hand;
            else if(((e.Y > 339) && (e.Y < 475)) && ((e.X > 740) && (e.X < 820))) // for the control panel to show
                Cursor = Cursors.Hand;
            else
                Cursor = Cursors.Arrow;
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {

           Cursor = Cursors.Hand;

           if (((e.Y > 335) && (e.Y < 560)) && ((e.X > 305) && (e.X < 384))) //for the prince
           {
               //stoping other timers
               timer1.Enabled = false;
               timer4.Enabled = false;
               timer3.Enabled = true; //opening cloud   

           }
           else if (((e.Y > 325) && (e.Y < 541)) && ((e.X > 925) && (e.X < 1006))) //for the princess
           {
                    //stoping other timers 
                    timer2.Enabled = false; 
                    timer6.Enabled = false;
                    timer5.Enabled = true; //opening cloud 
           }    
        }

        private void Form2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (((e.Y > 335) && (e.Y < 560)) && ((e.X > 305) && (e.X < 384))) //for the prince , the cloud goes down
            {
                Cursor = Cursors.Hand;
                timer4.Enabled = true;
            }
            else if (((e.Y > 325) && (e.Y < 541)) && ((e.X > 925) && (e.X < 1006)))//for the princess, the cloud goes down
            {
                Cursor = Cursors.Hand;
                timer6.Enabled = true;
            }
            else if (((e.Y > 75) && (e.Y < 600)) && ((e.X > 1110) && (e.X < 1210))) //for the door of the room to open
            {
                Cursor = Cursors.Hand;
                timer2.Enabled = false;
               

                    if (index == 14)
                    {
                        timer6.Enabled = true;
                        index = 0;
                        timer7.Enabled = true;
                        Play();
                       

                    }
                    else if (index == 12)
                    {
                        timer4.Enabled = true;
                        index = 0;
                        timer7.Enabled = true;
                        Play();
                       
                    }
                    else
                    {
                        timer7.Enabled = true;
                        Play();
                     

                    }
            }
            else if (((e.Y > 281) && (e.Y < 491)) && ((e.X > 540) && (e.X < 675))) //for the door of the restaurant to open
            {
                try
                {
                    Form4 restaurant = new Form4();
                    restaurant.Show();
                }

                catch (ObjectDisposedException f)
                {

                }
             }
            else if (((e.Y > 339) && (e.Y < 475)) && ((e.X > 740) && (e.X < 820))) // for the control panel to show
            { 
                Form6 controlPanel = new Form6();
                controlPanel.Show();
            }

        }   

        /**********************************************************************Timers**************************************************************
         *                                                                                                                                        *
         *      When Timer1 Starts all the other timers must stops except timer3 and timer4                                                       *
         *      When Timer2 Starts all the other timers must stops except timer5 and timer6                                                       *
         *      Timer1 : triggers the prince and starts moving                                                                                    *
         *      Timer2 : triggers the princess and starts moving                                                                                  *
         *      Timer3 : triggers the cloud and the prince starts talking                                                                         *
         *      Timer4 : close the cloud of the prince                                                                                            *
         *      Timer5 : tringgers the cloud and the princess starts talking                                                                      *
         *      Timer6 : close the cloud of the princess                                                                                          *                                                                                          
         *                                                                                                                                        *
         ******************************************************************************************************************************************/

      
        /*String nameTimer //debugging*/
        //
        //timer for the prince , triggers the showImage method
        //
        private void timer1_Tick(object sender, EventArgs e)    
        {
            if (timer3.Enabled == false && timer4.Enabled == false  && timer7.Enabled == false)
                showImage(NextPic(princeImageArray));

            //stopping other timers 
            timer2.Enabled = false;
            timer5.Enabled = false;
            timer6.Enabled = false;

            //nameTimer = "timer1"; //debugging
        }
        //
        //Timer for the princess
        //
        private void timer2_Tick(object sender, EventArgs e)    
        {
            if(timer5.Enabled == false && timer6.Enabled == false && timer7.Enabled == false)
                showImage(NextPic(princessImageArray));

            //stopping other timers 
            timer1.Enabled = false;
            timer3.Enabled = false;
            timer4.Enabled = false;

            //nameTimer = "timer2";// debugging
        }
        //
        //timer for the cloud of the prince , the cloud opens
        //
        private void timer3_Tick(object sender, EventArgs e) 
        {
            showImage(NextPic(princeCloud));

            //stopping other timers 
            timer2.Enabled = false;

            // nameTimer = "timer3"; //debugging

            //showing the speeching dialogs of the prince
            if (index == 12)
            {
                checkBox1.Visible = true;
                checkBox2.Visible = true;
                checkBox3.Visible = true;
                checkBox4.Visible = true;
                textBox3.Visible = true;
                button1.Visible = true;
            } 
            label1.Visible = false;
            
        }
        //
        //timer for the cloud of the prince , the cloud closes
        //
        private void timer4_Tick(object sender, EventArgs e) 
        {

            showImage(NextPic(princeCloud));

            //stopping other timers 
            timer1.Enabled = false;
            timer3.Enabled = false;

            // nameTimer = "timer4";// debugging
            
            //hiding the speech dialog
            if (index < 12)
                label1.Visible = true;
                
            
            textBox3.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            button1.Visible = false;
        }
        //
        //timer for the cloud of the princess , the cloud opens
        //
        private void timer5_Tick(object sender, EventArgs e)
        {
             showImage(NextPic(princessCloud));
             timer1.Enabled = false;
            // nameTimer = "timer5";//debugging

            //showing the speeching dialogs of the prince
             label1.Visible = false;
            if (index == 14)
            {
                textBox4.Visible = true;
                button3.Visible = true;
            }
            label1.Visible = false;
        }
        //
        //timer for the cloud of the princess , the cloud closes
        //
        private void timer6_Tick(object sender, EventArgs e)
        {
            showImage(NextPic(princessCloud));
            timer2.Enabled = false;
            timer5.Enabled = false;
            // nameTimer = "timer6"; //debugging
            if (index < 14)
            {
                label1.Visible = true;
                textBox4.Visible = false;
                button3.Visible = false;
            }
                
            //hiding the speech dialog
            
        }
        //
        // timer of the doorRoom
        //
        private void timer7_Tick(object sender, EventArgs e)  
        {
            
            showImage(NextPic2(intdoor));
           
        }
        //
        // returns the path of the Image 
        //
        public String NextPic(string[] picArray) 
        {
            string s = null;


            if (index < picArray.Length && index >= 0) 
            { 
               /*Debugging
               textBox1.Visible = true;
               textBox1.Text = "Timer : " + nameTimer + " nextPic";*/

               if (timer4.Enabled == true|| timer6.Enabled == true) 
               {
                   s = picArray[index]; // so that the cloud can close 
                   
                    if(index > 0)
                        index--;
                    else if (index == 0)
                    {
                        timer3.Enabled = false;
                        timer4.Enabled = false;
                    
                    
                        timer5.Enabled = false;
                        timer6.Enabled = false;
                    }
               }
               else
                   s = picArray[index++];
                
               //Debugging
               /*textBox2.Visible = true;
               textBox2.Text = "Index : " + index.ToString();*/
            }
            else  
            {
                if (timer3.Enabled == true || timer5.Enabled == true) // so that the cloud remains open
                {
                    index = picArray.Length - 1;
                    s = picArray[index];
                }
                else
                {
                    index = 0;
                    s = picArray[index];
                }

                //stopping timers that have done their job
                    timer1.Enabled = false;
                    timer2.Enabled = false;  
            }
           
            return s;
        }

        public String NextPic2(string[] picArray)
        {
            String s = null;

            //checks not to overpass the Lenght of the Array
            if (index2 < picArray.Length)
            {
                s = picArray[index2];
                index2++;
            }
            else
            {
                //Initializing the variable index so that it is imposimple to return a null String 
                index2 = picArray.Length - 1;
                s = picArray[index2];

                // terminating the Loop
                timer7.Enabled = false;

                //Creating a new Form type of Form 2 and hiding the previus one 
                 
                room.Show();
                Thread.Sleep(500);
                this.Hide();
            }
            return s;
        }
        //
        // stop motion
        //
        private void showImage(string strImage)
        {
            Image = new Bitmap(strImage);
            g = CreateGraphics();
            g.DrawImage(Image, 0, 0, 1280, 677);
        }
      
        //
        //when the form is loading 
        //
        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Visible = false; 
            textBox2.Visible = false;
        }
        //
        //closing the application
        //
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
        //
        //playing the sound
        //
        private void Play()
        {
            string soundfile = @"Sounds\indoor.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }
        //
        // questions to the prince 
        //
        private void button1_Click(object sender, EventArgs e) 
        {
            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == false)
                textBox3.Text = "Πατήστε στην αριστερή πόρτα κάτω από την ταμπέλα δωμάτιο, βρίσκεται δεξιά από την όμορφη πριγκίπισσα";
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false && checkBox4.Checked == false)
                textBox3.Text = "Την καφετέρια - εστιατόριο μπορείτε να την βρείτε με πολλούς τρόπους. 1) πατήστε στην πόρτα του εσωτερικού κτυρίου κάτω από την ταμπέλα εστιατόριο - καφετέρια 2)Μπείτε στο δωμάτιο και ύστερα μπείτε στο πάνελ ρυθμίσεων και πατήστε το κουμπί του εστιατορίου για μετάβαση σε αυτό 3) μπορείτε να παραγγίλετε ορισμένα πράγματα από την πριγκίπισσα κάναντος κλικ πάνω της!! ";
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true && checkBox4.Checked == false)
                textBox3.Text = "Την πισίνα μπορείτε να την επισκεφθείτε μπαίνοντας στο δωμάτιο του και βρίσκοντας το control panel , από εκεί μπορείτε να κατεβάσετε την πόρτα - πύλη της τάφρου έτσι ώστε να δημιουργηθεί η ιδιοτική σας πισίνα";
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false && checkBox4.Checked == true)
                textBox3.Text = "Το παράθυρο μπορείτε να το κλείσετε από το κουμπί Χ πάνω αριστερά σε , στην φόρμα που βρίσκεστε, στην φόρμα της πύλης και στο δωμάτιο με το που πατήσετε το Χ η εφαρμογή τερματίζει. Αντίθετα, στο control panels και στο εστιατόριο αν πατήσετε το Χ επιστρέφετε στην προηγούμενη φόρμα που είσασταν. Προσοχή σε ορισμένες φόρμες έχει αφερεθεί το Χ οπότε αναζητήστε το κατάλληλο κουμπί!!";
  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) Πατήστε μονο klik πάνω στον πρίγγιπα για να πάρετε διάφορες πληροφορίες για την πλοήγηση στον χώρο\n(2) Πατήστε επάνω στο control panel για να γεμίσετε/αδειάσετε την τάφρο και να αλλάξετε θερμοκρασία");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 neworder = new Form4();
            neworder.Show();
            
        }

        

       

        

        

        

        
        

    }
}
        
       
        
       

       

        
        
        
        
         
        
    