using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace OS_object
{
    public partial class multithreads : Form
    {
        public multithreads()
        {
            InitializeComponent();
        }
        bool f1, f2, f3;
       
      
        private void button1_Click(object sender, EventArgs e)
        {
            Thread aa = new Thread(new ThreadStart(p1));
            aa.Start();
            f1 = true;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f1 = false;
            Thread th = new Thread(new ThreadStart(p1));
            th.Abort();
        }

        public void p1()
        {
            while (f1==true)
            {
                Graphics gh = progressBar1.CreateGraphics();
                Rectangle r1 = progressBar1.ClientRectangle;
                Rectangle r2 = progressBar1.ClientRectangle;
                Random rand = new Random();
                int h = rand.Next(r1.Height);
                r1.Height = h;
                gh.FillRectangle(Brushes.Green, r2);
                gh.FillRectangle(Brushes.Brown, r1);
                Thread.Sleep(100);
                gh.FillRectangle(Brushes.Yellow, r1);
                Thread.Sleep(250);
            }
        }
       
        private void button3_Click(object sender, EventArgs e)
        {
            Thread aa = new Thread(new ThreadStart(p2));
            aa.Start();
            f2 = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            f2= false;
            Thread th = new Thread(new ThreadStart(p2));
            th.Abort();
        }

        public void p2()
        {
            while (f2 == true)
            {
                Graphics gh = progressBar2.CreateGraphics();
                Rectangle r1 = progressBar2.ClientRectangle;
                Rectangle r2 = progressBar2.ClientRectangle;
                Random rand = new Random();
                int h = rand.Next(r1.Height);
                r1.Height = h;
                gh.FillRectangle(Brushes.Red, r2);
                gh.FillRectangle(Brushes.Green, r1);
                Thread.Sleep(100);
                gh.FillRectangle(Brushes.Pink, r1);
                Thread.Sleep(250);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread aa = new Thread(new ThreadStart(p3));
            aa.Start();
            f3 = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f3 = false;
            Thread th = new Thread(new ThreadStart(p3));
            th.Abort();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Thread aa = new Thread(new ThreadStart(p3));
            aa.Start();
            f3 = true;
            f2 = true;
            f1 = true;
            Thread a2 = new Thread(new ThreadStart(p2));
            a2.Start();
            Thread a3 = new Thread(new ThreadStart(p1));
            a3.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            f3 = false;
            f2 = false;
            f1 = false;
            Thread th = new Thread(new ThreadStart(p3));
            th.Abort();
            Thread th1 = new Thread(new ThreadStart(p2));
            th1.Abort();
            Thread th2 = new Thread(new ThreadStart(p1));
            th2.Abort();
        }

        public void p3()
        {
            while (f3 == true)
            {
                Graphics gh = progressBar3.CreateGraphics();
                Rectangle r1 = progressBar3.ClientRectangle;
                Rectangle r2 = progressBar3.ClientRectangle;
                Random rand = new Random();
                int h = rand.Next(r1.Height);
                r1.Height = h;
                gh.FillRectangle(Brushes.Purple, r2);
                gh.FillRectangle(Brushes.PowderBlue, r1);
                Thread.Sleep(100);
                gh.FillRectangle(Brushes.DarkGray, r1);
                Thread.Sleep(250);
            }
        }





        private void multithreads_Load(object sender, EventArgs e)
        {

        }
    }
}
