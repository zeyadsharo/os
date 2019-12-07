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
    public partial class threads : Form
    {
        public threads()
        {
            InitializeComponent();
        }
        
        public delegate void print(string str);
        void changname(string X)
        {
            label1.Text = X;
        }
        public void abc()
        {
            label1.Invoke(new print(changname), new object[] { "student" });
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(abc));
            t.Start();
        }
        bool f=false;
        private void button1_Click(object sender, EventArgs e)
        {
            f = true;
            Thread th = new Thread(new ThreadStart(color));
            th.Start();
        }
        void color()
        {
            while (f==true)
            {
            label1.ForeColor = Color.Red;
            Thread.Sleep(500); //for the time sleep deily time
            label1.ForeColor = Color.Green;
            Thread.Sleep(400);
            label1.ForeColor = Color.Pink;
            Thread.Sleep(600);
            }
          
           // Thread.Sleep(3000);
            //label1.BackColor = Color.Yellow;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f = false;
            Thread th = new Thread(new ThreadStart(color));
            th.Abort();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Thread aa = new Thread(new ThreadStart(color2));
            aa.Start();
            f2 = true;
        }
        bool f2;
       public void color2()
        {
            while(f2==true)
            {
                button6.BackColor = Color.Red;
                Thread.Sleep(1000);
                button6.BackColor = Color.Orange;
                Thread.Sleep(1000);
                button6.BackColor = Color.Green;
                Thread.Sleep(1000);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Thread N = new Thread(new ThreadStart(color2));
            N.Abort();
            f2 = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
