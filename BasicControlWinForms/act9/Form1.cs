using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("10");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("9");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.Text;
        }


    }
}
