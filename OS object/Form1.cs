﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_object
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            threads form = new threads();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            multithreads m = new multithreads();
            m.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listview l = new listview();
            l.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FCFE o = new FCFE();
            o.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SFJ o = new SFJ();
            o.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            process p = new process();
            p.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            file f = new file();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            test f = new test();
            f.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            priority p = new priority();
            p.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            proritywith_A f = new proritywith_A();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RR rR = new RR();
            rR.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            banker banker = new banker();
            banker.Show();
        }
    }
}
