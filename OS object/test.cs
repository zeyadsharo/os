using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace OS_object
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add("dsf", "ergsdfgds");
        }
        bool ff = true;
        void p1()
        {
            while (ff)
            {
                Graphics graphics = progressBar1.CreateGraphics();
                Rectangle r1 = progressBar1.ClientRectangle;
                Rectangle r2 = progressBar1.ClientRectangle;
                Random r = new Random();
                int rr = r.Next(r1.Height);
                r1.Height = rr;
                graphics.FillRectangle(Brushes.Red, r1);
                Thread.Sleep(200);
                graphics.FillRectangle(Brushes.Green, r2);
                Thread.Sleep(200);
                graphics.FillRectangle(Brushes.Yellow, r1);
                Thread.Sleep(200);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = true;
            Thread t = new Thread(new ThreadStart(color));
            t.Start();
        }
        bool f = true;
        public void color()
        {
            while(f)
            {
              label1.ForeColor = Color.Red;
                Thread.Sleep(1000);
                label1.ForeColor = Color.Orange;
                Thread.Sleep(1000);
                label1.ForeColor = Color.PaleGreen;
            }
                     
        }

        private void button3_Click(object sender, EventArgs e)
        {
            f = false;
            Thread thread = new Thread(new ThreadStart(color));
            thread.Abort();
            ff = false;
            Thread th= new Thread(new ThreadStart(p1));
            th.Abort();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(p1));
            thread.Start();
            ff = true;
        }



        public delegate void print(string str);
        void name(string str)
        {
            label2.Text = str;
        }
        void s()
        {
            label2.Invoke(new print(name), new object[] { "Khalaf" });
        }
        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(s));
            thread.Start();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderDlg = new FolderBrowserDialog();
            folderDlg.ShowNewFolderButton = true;
            // Show the FolderBrowserDialog.
            DialogResult result = folderDlg.ShowDialog();

        }
    }
}
