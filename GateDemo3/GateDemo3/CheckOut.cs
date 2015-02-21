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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Αν συνεχίσετε Θα χαθεί η παραγγελία", "Προσοχή!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Form4.index = 0;
                Form4.subtotal = 0;
                label1.Visible = false; textBox1.Visible = false;
                label2.Visible = false; textBox3.Visible = false;
                label3.Visible = false; textBox4.Visible = false;
                label4.Visible = false; textBox5.Visible = false;
                label5.Visible = false; textBox6.Visible = false;
                label6.Visible = false; textBox2.Visible = false;
                label10.Visible = false; textBox7.Visible = false;
                label9.Visible = false; textBox8.Visible = false;
                label7.Visible = false; textBox10.Visible = false;
                label8.Visible = false; textBox9.Visible = false;

                Hide();
                
            }
        }

        public void enableLabels()
        {
            if (Form4.index == 1)
            {
                label1.Visible = true; textBox1.Visible = true;
            }
            else if (Form4.index == 2)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true;
            }
            else if (Form4.index == 3)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true; label3.Visible = true; textBox4.Visible = true;
            }
            else if (Form4.index == 4)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true; label3.Visible = true; textBox4.Visible = true; label4.Visible = true; textBox5.Visible = true;
            }
            else if (Form4.index == 5)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true; label3.Visible = true; textBox4.Visible = true; label4.Visible = true; textBox5.Visible = true; label5.Visible = true; textBox6.Visible = true;
            }
            else if (Form4.index == 6)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true; label3.Visible = true; textBox4.Visible = true; label4.Visible = true; textBox5.Visible = true; label5.Visible = true; textBox6.Visible = true; label6.Visible = true; textBox2.Visible = true;
            }
            else if (Form4.index == 7)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true; label3.Visible = true; textBox4.Visible = true; label4.Visible = true; textBox5.Visible = true; label5.Visible = true; textBox6.Visible = true; label6.Visible = true; textBox2.Visible = true; label10.Visible = true; textBox7.Visible = true;
            }
            else if (Form4.index == 8)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true; label3.Visible = true; textBox4.Visible = true; label4.Visible = true; textBox5.Visible = true; label5.Visible = true; textBox6.Visible = true; label6.Visible = true; textBox2.Visible = true; label10.Visible = true; textBox7.Visible = true; label9.Visible = true; textBox8.Visible = true;
            }
            else if (Form4.index == 9)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true; label3.Visible = true; textBox4.Visible = true; label4.Visible = true; textBox5.Visible = true; label5.Visible = true; textBox6.Visible = true; label6.Visible = true; textBox2.Visible = true; label10.Visible = true; textBox7.Visible = true; label9.Visible = true; textBox8.Visible = true; label8.Visible = true; textBox9.Visible = true;
            }
            else if (Form4.index == 10 || Form4.index == 11)
            {
                label1.Visible = true; textBox1.Visible = true; label2.Visible = true; textBox3.Visible = true; label3.Visible = true; textBox4.Visible = true; label4.Visible = true; textBox5.Visible = true; label5.Visible = true; textBox6.Visible = true; label6.Visible = true; textBox2.Visible = true; label10.Visible = true; textBox7.Visible = true; label9.Visible = true; textBox8.Visible = true; label8.Visible = true; textBox9.Visible = true; label7.Visible = true; textBox10.Visible = true;
            }

            textBox13.Text = Form4.subtotal.ToString() + " $"; //total amount
        }
       
        private void CheckOut_Load(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox11.Text == "VASILEIOS FOUROULIS" && textBox12.Text == "1345678910111314" && textBox14.Text == "132") || (textBox11.Text == "PANAGIOTIS GEORGIOY" && textBox12.Text == "6210887053221313" && textBox14.Text == "831"))
            {
                MessageBox.Show("Συγχαρητήρια αγοράσατε πράγματα αξίας " + textBox13.Text + "\nΚαλή όρεξη!!");
                Form4.index = 0;
                this.Close();
                Form4.subtotal = 0;
            }
            else
                MessageBox.Show("Προσπαθήστε ξανά δεν δώσατε τα σωστά στοιχεία");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) Πληκτρολογίστε το ονομά σας στο πρώτο πλαίσιο κειμένου (\"VASILEIOS FOUROULIS\")\n(2) Πληκτρολογίστε τον αριθμό της κάρτας σας στο δεύτερο text box (\"1345678910111314\")\n(3) πληκτρολογίστε το κωδικό ασφαλείας της κάρτας σας που βρίσκεται στο πίσω μέρος (\"132\")\n(4) Πατήστε αγορά για να πραγματοποιήσετε την παραγγελία\n(5) Άμα πατήσετε στο κουμπί επιστροφη θα χαθεί η παραγγελία");
        }

       
      
    }
}
