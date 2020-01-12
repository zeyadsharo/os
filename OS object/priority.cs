using System;
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
    public partial class priority : Form
    {
        public priority()
        {
            InitializeComponent();
        }
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (bursttime.Text != "")
            {
                int n = listView1.Items.Count;
                ListViewItem a = new ListViewItem("P" + count++);
                listView1.Items.Add(a);
                a.SubItems.Add(bursttime.Text);
                a.SubItems.Add(pri.Text);
            }
            bursttime.Clear();
            pri.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        void result()
        {

            double[] bt = new double[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                bt[i] = double.Parse(listView1.Items[i].SubItems[1].Text);
            }

            double[] p = new double[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                p[i] = double.Parse(listView1.Items[i].SubItems[1].Text);
            }

            
            for (int j = 0; j <= bt.Length - 2; j++)
            {
                for (int i = 0; i <= bt.Length - 2; i++)
                {
                    if (p[i] > p[i + 1])
                    {
                      
                      double  temp = bt[i + 1];
                        bt[i + 1] = bt[i];
                        bt[i] = temp;

                        double temp1 = p[i + 1];
                        p[i + 1] = p[i];
                        p[i] = temp1;
                       
                    }
                   
                }

             }

               

                double[] X1 = new double[listView1.Items.Count];
                X1[0] = 0;
                string str = "0, ";
                for (int i = 1; i < X1.Length; i++)
                {
                    X1[i] = X1[i - 1] + bt[i - 1];
                    str += X1[i - 1] + bt[i - 1] + ",";
                }
                textBox1.Text = str;

                average.Text = X1.Sum() / X1.Length + "";


           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            result();
        }
    }
}
