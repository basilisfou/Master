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
    public partial class Form4B : Form4A
    {
        public Form4B()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form4B_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form4.subtotal = Form4.subtotal + 7.5;
            if (Form4.index < 11)
            {
                DialogResult dialogResult = MessageBox.Show("Προστεθηκε στο λογαριασμό", "Μήνυμα επιβεβαίωσης", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {

                }
                Form4.index++;
            }

            if (Form4.index == 1)
            {
                Form4.pay.label1.Text = label1.Text;
                Form4.pay.textBox1.Text = label6.Text;
            }
            else if (Form4.index == 2)
            {
                Form4.pay.label2.Text = label1.Text;
                Form4.pay.textBox3.Text = label6.Text;
            }
            else if (Form4.index == 3)
            {
                Form4.pay.label3.Text = label1.Text;
                Form4.pay.textBox4.Text = label6.Text;
            }
            else if (Form4.index == 4)
            {
                Form4.pay.label4.Text = label1.Text;
                Form4.pay.textBox5.Text = label6.Text;
            }
            else if (Form4.index == 5)
            {
                Form4.pay.label5.Text = label1.Text;
                Form4.pay.textBox6.Text = label6.Text;
            }
            else if (Form4.index == 6)
            {
                Form4.pay.label6.Text = label1.Text;
                Form4.pay.textBox2.Text = label6.Text;
            }
            else if (Form4.index == 7)
            {
                Form4.pay.label10.Text = label1.Text;
                Form4.pay.textBox7.Text = label6.Text;
            }
            else if (Form4.index == 8)
            {
                Form4.pay.label9.Text = label1.Text;
                Form4.pay.textBox8.Text = label6.Text;
            }
            else if (Form4.index == 9)
            {
                Form4.pay.label8.Text = label1.Text;
                Form4.pay.textBox9.Text = label6.Text;
            }
            else if (Form4.index == 10)
            {
                Form4.pay.label7.Text = label1.Text;
                Form4.pay.textBox10.Text = label6.Text;
            }
            else
                MessageBox.Show("Μπορείς να αγοράσεις μέχρι 10 αντικείμενα");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4.subtotal = Form4.subtotal + 1.8;
            if (Form4.index < 11)
            {
                DialogResult dialogResult = MessageBox.Show("Προστεθηκε στο λογαριασμό", "Μήνυμα επιβεβαίωσης", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {

                }
                Form4.index++;
            }

            if (Form4.index == 1)
            {
                Form4.pay.label1.Text = label2.Text;
                Form4.pay.textBox1.Text = label7.Text;
            }
            else if (Form4.index == 2)
            {
                Form4.pay.label2.Text = label2.Text;
                Form4.pay.textBox3.Text = label7.Text;
            }
            else if (Form4.index == 3)
            {
                Form4.pay.label3.Text = label2.Text;
                Form4.pay.textBox4.Text = label7.Text;
            }
            else if (Form4.index == 4)
            {
                Form4.pay.label4.Text = label2.Text;
                Form4.pay.textBox5.Text = label7.Text;
            }
            else if (Form4.index == 5)
            {
                Form4.pay.label5.Text = label2.Text;
                Form4.pay.textBox6.Text = label7.Text;
            }
            else if (Form4.index == 6)
            {
                Form4.pay.label6.Text = label2.Text;
                Form4.pay.textBox2.Text = label7.Text;
            }
            else if (Form4.index == 7)
            {
                Form4.pay.label10.Text = label2.Text;
                Form4.pay.textBox7.Text = label7.Text;
            }
            else if (Form4.index == 8)
            {
                Form4.pay.label9.Text = label2.Text;
                Form4.pay.textBox8.Text = label7.Text;
            }
            else if (Form4.index == 9)
            {
                Form4.pay.label8.Text = label2.Text;
                Form4.pay.textBox9.Text = label7.Text;
            }
            else if (Form4.index == 10)
            {
                Form4.pay.label7.Text = label2.Text;
                Form4.pay.textBox10.Text = label7.Text;
            }
            else
                MessageBox.Show("Μπορείς να αγοράσεις μέχρι 10 αντικείμενα");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4.subtotal = Form4.subtotal + 8;
            if (Form4.index < 11)
            {
                DialogResult dialogResult = MessageBox.Show("Προστεθηκε στο λογαριασμό", "Μήνυμα επιβεβαίωσης", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {

                }
                Form4.index++;
            }

            if (Form4.index == 1)
            {
                Form4.pay.label1.Text = label3.Text;
                Form4.pay.textBox1.Text = label8.Text;
            }
            else if (Form4.index == 2)
            {
                Form4.pay.label2.Text = label3.Text;
                Form4.pay.textBox3.Text = label8.Text;
            }
            else if (Form4.index == 3)
            {
                Form4.pay.label3.Text = label3.Text;
                Form4.pay.textBox4.Text = label8.Text;
            }
            else if (Form4.index == 4)
            {
                Form4.pay.label4.Text = label3.Text;
                Form4.pay.textBox5.Text = label8.Text;
            }
            else if (Form4.index == 5)
            {
                Form4.pay.label5.Text = label3.Text;
                Form4.pay.textBox6.Text = label8.Text;
            }
            else if (Form4.index == 6)
            {
                Form4.pay.label6.Text = label3.Text;
                Form4.pay.textBox2.Text = label8.Text;
            }
            else if (Form4.index == 7)
            {
                Form4.pay.label10.Text = label3.Text;
                Form4.pay.textBox7.Text = label8.Text;
            }
            else if (Form4.index == 8)
            {
                Form4.pay.label9.Text = label3.Text;
                Form4.pay.textBox8.Text = label8.Text;
            }
            else if (Form4.index == 9)
            {
                Form4.pay.label8.Text = label3.Text;
                Form4.pay.textBox9.Text = label8.Text;
            }
            else if (Form4.index == 10)
            {
                Form4.pay.label7.Text = label3.Text;
                Form4.pay.textBox10.Text = label8.Text;
            }
            else
                MessageBox.Show("Μπορείς να αγοράσεις μέχρι 10 αντικείμενα");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form4.subtotal = Form4.subtotal + 0.9;
            if (Form4.index < 11)
            {
                DialogResult dialogResult = MessageBox.Show("Προστεθηκε στο λογαριασμό", "Μήνυμα επιβεβαίωσης", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {

                }
                Form4.index++;
            }

            if (Form4.index == 1)
            {
                Form4.pay.label1.Text = label4.Text;
                Form4.pay.textBox1.Text = label9.Text;
            }
            else if (Form4.index == 2)
            {
                Form4.pay.label2.Text = label4.Text;
                Form4.pay.textBox3.Text = label9.Text;
            }
            else if (Form4.index == 3)
            {
                Form4.pay.label3.Text = label4.Text;
                Form4.pay.textBox4.Text = label9.Text;
            }
            else if (Form4.index == 4)
            {
                Form4.pay.label4.Text = label4.Text;
                Form4.pay.textBox5.Text = label9.Text;
            }
            else if (Form4.index == 5)
            {
                Form4.pay.label5.Text = label4.Text;
                Form4.pay.textBox6.Text = label9.Text;
            }
            else if (Form4.index == 6)
            {
                Form4.pay.label6.Text = label4.Text;
                Form4.pay.textBox2.Text = label9.Text;
            }
            else if (Form4.index == 7)
            {
                Form4.pay.label10.Text = label4.Text;
                Form4.pay.textBox7.Text = label9.Text;
            }
            else if (Form4.index == 8)
            {
                Form4.pay.label9.Text = label4.Text;
                Form4.pay.textBox8.Text = label9.Text;
            }
            else if (Form4.index == 9)
            {
                Form4.pay.label8.Text = label4.Text;
                Form4.pay.textBox9.Text = label9.Text;
            }
            else if (Form4.index == 10)
            {
                Form4.pay.label7.Text = label4.Text;
                Form4.pay.textBox10.Text = label9.Text;
            }
            else
                MessageBox.Show("Μπορείς να αγοράσεις μέχρι 10 αντικείμενα");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form4.subtotal = Form4.subtotal + 5;
            if (Form4.index < 11)
            {
                DialogResult dialogResult = MessageBox.Show("Προστεθηκε στο λογαριασμό", "Μήνυμα επιβεβαίωσης", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {

                }
                Form4.index++;
            }

            if (Form4.index == 1)
            {
                Form4.pay.label1.Text = label5.Text;
                Form4.pay.textBox1.Text = label10.Text;
            }
            else if (Form4.index == 2)
            {
                Form4.pay.label2.Text = label5.Text;
                Form4.pay.textBox3.Text = label10.Text;
            }
            else if (Form4.index == 3)
            {
                Form4.pay.label3.Text = label5.Text;
                Form4.pay.textBox4.Text = label10.Text;
            }
            else if (Form4.index == 4)
            {
                Form4.pay.label4.Text = label5.Text;
                Form4.pay.textBox5.Text = label10.Text;
            }
            else if (Form4.index == 5)
            {
                Form4.pay.label5.Text = label5.Text;
                Form4.pay.textBox6.Text = label10.Text;
            }
            else if (Form4.index == 6)
            {
                Form4.pay.label6.Text = label5.Text;
                Form4.pay.textBox2.Text = label10.Text;
            }
            else if (Form4.index == 7)
            {
                Form4.pay.label10.Text = label5.Text;
                Form4.pay.textBox7.Text = label10.Text;
            }
            else if (Form4.index == 8)
            {
                Form4.pay.label9.Text = label5.Text;
                Form4.pay.textBox8.Text = label10.Text;
            }
            else if (Form4.index == 9)
            {
                Form4.pay.label8.Text = label5.Text;
                Form4.pay.textBox9.Text = label10.Text;
            }
            else if (Form4.index == 10)
            {
                Form4.pay.label7.Text = label5.Text;
                Form4.pay.textBox10.Text = label10.Text;
            }
            else
                MessageBox.Show("Μπορείς να αγοράσεις μέχρι 10 αντικείμενα");
        }

    }
}
