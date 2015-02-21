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
    public partial class Form4A : Form
    {
        public Form4A()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) // button return
        {
                Close();
        }

        public void button2_Click(object sender, EventArgs e) // button check out 
        {
            if (Form4.pay == null)
            {
                CheckOut pay = new CheckOut();
            }

            Form4.pay.Show();
            Form4.pay.enableLabels();
            this.Close();
            
        }

        private void Form4A_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(1) Πατήστε πάνω σε κάθε κουμπί για να προσθέσετε στο καλάθι αγορών το επιθυμητό προϊόν\n(2) Πατήστε επάνω στο κουμπί check out για να πραγματοποιήσετε την αγορά\n(3) Προσοχή μπορείτε να αγοράσετε μόνο 10 πράγματα κάθε φορά!");
        }
    }
}
