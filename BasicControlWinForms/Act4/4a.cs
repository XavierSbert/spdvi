using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Act4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /* valor 1*/
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            /* valor 2*/
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            /*resultado*/
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            /* simbolo */


        }

        private void button3_Click(object sender, EventArgs e)
        {
            String simb = "+";
            textBox4.Text = simb;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(textBox1.Text);
            int n2 = int.Parse(textBox2.Text);
            String simb = textBox4.Text;

            if (simb == "+")
            {
                int suma = n1 + n2;
                textBox3.Text = suma.ToString();
            }
            else
            {
                String sresta = "-";
                int resta = n1 - n2;
                textBox3.Text = resta.ToString();
                textBox4.Text = sresta;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* reset */
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String simb = "-";
            textBox4.Text = simb;
        }
    }
}
