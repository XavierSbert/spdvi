using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act5
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String val1 = "";
            String val2 = "";
            String val3 = "";
            if (checkBox1.Checked == true)
            {
                val1 = checkBox1.Text + ", ";
            }
            if (checkBox2.Checked == true)
            {
                val2 = checkBox2.Text + ", ";
            }
            if (checkBox1.Checked == true)
            {
                val3 = checkBox3.Text + ", ";
            }

            textBox1.Text = "Los valores elegidos son: " + val1 + val2 + val3;   

        }
    }
}
