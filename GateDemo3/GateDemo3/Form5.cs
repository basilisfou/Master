using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//control FORM
namespace GateDemo3
{
    public partial class Form5: Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       
        public static bool selector = false;
        public bool tv = false;
        public bool light = true;
        public bool Backtoroom = false;
        private void MakeLabelVisible()
        {
            /* If the panel contains label1, bring it 
            * to the front to make sure it is visible. */
            if (Form3.control.Contains(textBox1))
            {
                textBox1.BringToFront();
            }
        }   
        private void ParentControl_Load(object sender, EventArgs e)
        {
            MakeLabelVisible();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selector == false)
            {
                GatePool obj = new GatePool();
                obj.Show();
                string image1="red.jpg";
                this.button1.BackgroundImage = Image.FromFile(image1);
            }
            else
            {
                GatePool2 obj2 = new GatePool2();
                obj2.Show();
                string image1 = "black.jpg";
                this.button1.BackgroundImage = Image.FromFile(image1);
            }
    
       }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //switch on/off light
        {
            if(tv == false && light == true)
            {
                string image1 = "black.jpg";
                this.button2.BackgroundImage = Image.FromFile(image1);
                light = false;
                Form2.room.backroundselector(tv, light);
                Form2.room.Show();
               // MessageBox.Show("tv: " + tv + " light: " + light);
                System.Threading.Thread.Sleep(2500);
                Form2.room.Hide();
            }
            else if (tv == true && light == false)
            {
                light = true;
                string image1 = "red.jpg";
                this.button2.BackgroundImage = Image.FromFile(image1);
                Form2.room.backroundselector(tv, light);
                Form2.room.Show();
                //MessageBox.Show("tv: " + tv + " light: " + light);
                System.Threading.Thread.Sleep(2500);
                Form2.room.Hide();
            }
            else if(tv == true && light == true)
            {
              
                string image1 = "black.jpg";
                this.button2.BackgroundImage = Image.FromFile(image1);
                light = false;
                Form2.room.backroundselector(tv, light);
                Form2.room.Show();
               // MessageBox.Show("tv: " + tv + " light: " + light);
                System.Threading.Thread.Sleep(2500);
                Form2.room.Hide();
            }
            else if (tv == false && light == false)
            {
                light = true;
                string image1 = "red.jpg";
                this.button2.BackgroundImage = Image.FromFile(image1);
                Form2.room.backroundselector(tv, light);
                Form2.room.Show();
               // MessageBox.Show("tv: " + tv + " light: " + light);
                System.Threading.Thread.Sleep(2500);
                Form2.room.Hide();
            }
        }

        private void button3_Click(object sender, EventArgs e)//switch on/off tv
        {
            if (tv == true && light == false )
            {
                string image1 = "black.jpg";
                this.button3.BackgroundImage = Image.FromFile(image1);
                tv = false;
                Form2.room.backroundselector(tv, light);
                Form2.room.Show();
                //MessageBox.Show("tv: " + tv + " light: " + light);
                System.Threading.Thread.Sleep(2500);
                Form2.room.Hide();
            }
            else if (tv == false && light == false)
            {
                string image1 = "red.jpg";
                this.button3.BackgroundImage = Image.FromFile(image1);
                tv = true;
                Form2.room.backroundselector(tv, light);
                Form2.room.Show();
              //  MessageBox.Show("tv: " + tv + " light: " + light);
                System.Threading.Thread.Sleep(2500);
                Form2.room.Hide();
            }
            else if (tv == true && light == true)
            {
                string image1 = "black.jpg";
                this.button3.BackgroundImage = Image.FromFile(image1);
                tv = false;
                Form2.room.backroundselector(tv, light);
                Form2.room.Show();
               // MessageBox.Show("tv: " + tv + " light: " + light);
                System.Threading.Thread.Sleep(2500);
                Form2.room.Hide();
            }
            else if (tv == false && light == true)
            {
                string image1 = "red.jpg";
                this.button3.BackgroundImage = Image.FromFile(image1);
                tv = true;
                Form2.room.backroundselector(tv, light);
                Form2.room.Show();
               // MessageBox.Show("tv: " + tv + " light: " + light);
                System.Threading.Thread.Sleep(2500);
                Form2.room.Hide();
            }

        }
       
        private void button4_Click(object sender, EventArgs e)
        {
           
            
                Form4 restaurant2 = new Form4();
                restaurant2.Show();
          
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox1.Text + "C";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2.room.Show();
            Form2.room.button1.Visible = true;
            Form2.room.button2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) Πατήστε στο κουμπί (Πόρτας πισίνας για να ανοίξει ή να κλείσει η πόρτα)\n(2) Πατήστε επάνω στο κουμπί φωτισμός για να κλείσουν τα φώτα του δωματίου\n(3) Πατήστε πάνω στο κουμπί Τηλεόραση για να ανοίξετε ή κλείσετε την tv του δωματίου\n(4) Πληκτρολογίστε την επιθυμητή θερμοκρασία του δωματίου μέσα στο κόκκινο πλαίσιο\n (5) Πατώντας πάνω στο κουμπί του εστιατορίου μεταφέρεστε στο εστιατόριο - καφετέρια.");
        }
    }

}
