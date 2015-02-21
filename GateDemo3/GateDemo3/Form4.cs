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
    public partial class Form4 : Form 
    {
        public static double subtotal = 0; // the total amount of the sum of our items
        public static int index = 0; // counting the amount of the items we want to buy
        public static CheckOut pay = new CheckOut(); // public object to the payment page

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //to drinks
        {
            Form4AA Drinks = new Form4AA();
            Drinks.Show();
        }

        private void button2_Click(object sender, EventArgs e) //to fastfood
        {
            Form4B JunkFood = new Form4B();
            JunkFood.Show();
        }

        private void button3_Click(object sender, EventArgs e) // to main food
        {
            Form4C mainFood = new Form4C();
            mainFood.Show();
        }

        private void button4_Click(object sender, EventArgs e) // to apetisers
        {
            Form4D apetiser = new Form4D();
            apetiser.Show();
        }

        private void button5_Click(object sender, EventArgs e) // to salads
        {
            Form4E salad = new Form4E();
            salad.Show();
        }

        private void button6_Click(object sender, EventArgs e) // to sweets 
        {
            Form4F gateau = new Form4F();
            gateau.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e) // to the payment page
        {
            Form4.pay.Show();
        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e) //to be sure that all the objects will be closed
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               
                    pay.Close();
                   
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) Πατήστε πάνω στα κουμπιά για να μεταβείτε στην προϊοντική κατηγορία της επιθυμίας σας.\n(2) πατήστε στο check out για να πραγματοποιήσετε την παραγγελία σας");
        }
    }
}
