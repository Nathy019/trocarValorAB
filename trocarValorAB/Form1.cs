﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trocarValorAB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtValorA.Text);
            int b = Convert.ToInt32(txtValorB.Text);

            int c = a;
            int d = b;
            lblresultado.Text = c + "\n" + d;
        }
    }
}
