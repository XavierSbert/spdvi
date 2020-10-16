using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String val1 = "";
            String val2 = "";
            String val3 = "";
            if (radioButton1.Checked == true)
            {
                val1 = radioButton1.Text;
            }
            if (radioButton2.Checked == true)
            {
                val2 = radioButton2.Text;
            }
            if (radioButton3.Checked == true)
            {
                val3 = radioButton3.Text;
            }

            textBox1.Text = "El valor elegido es: " + val1 + val2 + val3;

        }
    }
}
