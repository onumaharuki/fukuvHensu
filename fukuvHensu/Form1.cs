﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int textBox1_TextChanged =10;

            label2.Left = textBox1_TextChanged;

            int Box2_TextChanged = 10;

            label2.Top = Box2_TextChanged;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Box2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Top = label2.Top - 20;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Top = label2.Top + 20;
        }
    }
}
