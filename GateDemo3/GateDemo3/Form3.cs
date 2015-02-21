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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public static Form5 control = new Form5(); // panel
        
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
                
            }
        }

        private void Form3_MouseMove(object sender, MouseEventArgs e)
        {
            //finding the coordinates
           /* label1.Visible = true;
            label2.Visible = true;
            label1.Text = "X: " + e.X.ToString();
            label2.Text = "Y " + e.Y.ToString();*/

            if (((e.Y > 430) && (e.Y < 580)) && ((e.X > 73) && (e.X < 280))) //control panel
            {
                Cursor = Cursors.Hand;
                
            }
            else
                Cursor = Cursors.Arrow;

           
        }

        private void Form3_MouseClick(object sender, MouseEventArgs e)
        {
            if (((e.Y > 430) && (e.Y < 580)) && ((e.X > 73) && (e.X < 280))) //control panel
            {
                try
                {
                    control.Show();
                    this.Hide();
                }
                catch (ObjectDisposedException f)
                {

                }
            }

        }

        private void button1_Click(object sender, EventArgs e) // to interior
        {
            Form1.Inside.Show();
            Form2.index = 0;
            Form2.index2 = 0;
            this.Hide();
        }
        public void backroundselector(bool tv, bool light)
        {
            if (tv == false && light == false)
            {
                BackgroundImage = Image.FromFile(@"interior\interiorblack.jpg");
                button1.Visible = false;
                button2.Visible = false;
            }
            else if (tv == true && light == false)
            {
                BackgroundImage = Image.FromFile(@"interior\interiorblacktv.jpg");
                button1.Visible = false;
                button2.Visible = false;
            }
            else if (tv == false && light == true)
            {
                BackgroundImage = Image.FromFile(@"interior\interior.png");
                button1.Visible = false;
                button2.Visible = false;
            }
            else if(tv == true && light == true)
            {
                BackgroundImage = Image.FromFile(@"interior\interiortv.jpg");
                button1.Visible = false;
                button2.Visible = false;
            }
        }
        //
        //help
        //
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατήστε πάνω στον υπολογιστή για να μεταβείτε στον πάνελ ρυθμίσεων του δωματίου!");
        }
        
       
    }
}
