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
    

    public partial class Form6 : Form
    {
        private bool haberAgua = false;
        private int index = 15; //celcius
        private bool increment = false;
        public Form6()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e) // changing the switcher 
        {
            Form5 seresHumanos = new Form5();

            if (Form5.selector == false) //checing for humans in the polls
            {
                if (haberAgua == false)
                {
                    pictureBox1.Image = Image.FromFile(@"interiorControl\poolOn.jpg");
                    haberAgua = true;
                    MessageBox.Show("Η τάφρος - πισίνα γέμισε ");
                }
                else
                {
                    pictureBox1.Image = Image.FromFile(@"interiorControl\pooloff.jpg");
                    haberAgua = false;
                    MessageBox.Show("Η τάφρος πισίνα άδειασε ");
                }
            }
            else
                MessageBox.Show("WARNING 003 \nΔεν μπορείτε να πειράξετε την τάφρο - πισίνα κάποιος χρήστης την χρησιμοποιεί! \nΠροσπαθήστε αργότερα!!");
        }

        public bool getAgua() //getting the private variable
        {
            return haberAgua;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
             Form5 seresHumanos = new Form5();

             if (Form5.selector == false ) //checing for humans in the polls
             {
                 if (increment == false) //increase or decrease 
                 {
                     if (index == 15)
                     {
                         index = 20;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius2.jpg");
                         label3.Text = "20 celcius";
                     }
                     else if (index == 20)
                     {
                         index = 25;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius3.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index == 25)
                     {
                         index = 30;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius4.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index == 30)
                     {
                         index = 35;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius5.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index == 35)
                     {
                         index = 40;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius6.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index == 40)
                     {
                         index = 45;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius7.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                 }
                 else
                 {
                     if (index == 45)
                     {
                         index = 40;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius6.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index == 40)
                     {
                         index = 35;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius5.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index == 35)
                     {
                         index = 30;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius4.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index == 30)
                     {
                         index = 25;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius3.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index ==25)
                     {
                         index = 20;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius2.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }
                     else if (index == 20)
                     {
                         index = 15;
                         pictureBox2.Image = Image.FromFile(@"interiorControl\celcius1.jpg");
                         label3.Text = index.ToString() + " celcius";
                     }

                 }
             }
             else
                 MessageBox.Show("WARNING 003 \nΔεν μπορείτε να πειράξετε την τάφρο - πισίνα κάποιος χρήστης την χρησιμοποιεί! \nΠροσπαθήστε αργότερα!!");
        }

        private void button1_Click(object sender, EventArgs e) // to increase or decrease the meter
        {
            if (increment == false)
            {
                button1.Text = "decrease";
                increment = true;
            }
            else
            {
                button1.Text = "increase";
                increment = false;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            

            if (Form5.selector == false) //checks if there are humans in the pool and alarms the people
            {
                pictureBox3.Image = Image.FromFile(@"interiorControl\humans2.jpg");
                label4.Text = "Η πισίνα δεν χρησιμοποιείται";
                
            }   
            else
            {
                pictureBox3.Image = Image.FromFile(@"interiorControl\humans.jpg");
                label4.Text = "H πισίνα χρησιμοποιείται";
                Play(); // the sound
            }
        }
        
        private void Play() // sound alarm
        {
            string soundfile = @"Sounds\ALARM.wav";
            var sound = new System.Media.SoundPlayer(soundfile);
            sound.Play();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1)Πατήστε τον μοχλό για να γεμίσετε ή αδειάσετε την πισίνα - τάφρο\n(2) Πατήστε τον ρυθμιστή θερμοκρασίας για να ανέβει η θερμοκρασία της πισίνας , σε κάθε κλικ ανεβαίνει η θερμοκρασία μέχρι ο ρυθμιστής να φτάσει στο τέλος του, πατήστε το κουμπί Decrease κάτω από τον ρυθμιστή για να μειώσεται την θερμοκρασία της πισίνας.\n(3) Άμα βλέπετε το warning 003 ή ακούτε τον συναγερμό τότε υπάρχει άνθρωπος στην πισίνα τάφρο και δεν μπορείτε να εκτελέσετε κάποια λειτουργία από αυτό το πάνελ. ");
        }
    }
}
