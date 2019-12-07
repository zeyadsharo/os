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
    public partial class SFJ : Form
    {
        public SFJ()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {           
            if (bursttime.Text != "")
            {
                int n = listView1.Items.Count;
                ListViewItem a = new ListViewItem(process.Text);
                listView1.Items.Add(a);
                a.SubItems.Add(bursttime.Text);
            }
            process.Clear();
            bursttime.Clear();
        
        }

        void additem()
        {
           
            double []X = new double[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                X[i]=double.Parse(listView1.Items[i].SubItems[1].Text);
            }
            Array.Sort(X);

            double[] X1 = new double[listView1.Items.Count];
            X1[0] = 0;
            string str = "0, ";
            for (int i = 1; i <X1.Length; i++)
            {
                X1[i] = X1[i - 1] + X[i-1];
                str += X1[i - 1] + X[i - 1] + ",";
            }
            textBox1.Text = str;

            avrage.Text=X1.Sum()/X1.Length+"";

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sum = sum + double.Parse(listView1.Items[i].SubItems[1].Text);
            }
            double average = sum / listView1.Items.Count;
            avrage.Text = average.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            additem();
        }
    }
}
