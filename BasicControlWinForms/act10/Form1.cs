﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace act10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
/*            hScrollBar1.Maximum = 80;
            hScrollBar1.Minimum = 0;*/
            textBox1.Text = hScrollBar1.Value.ToString();
        }
    }
}
