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
    public partial class FCFE : Form
    {
        public FCFE()
        {
            InitializeComponent();
        }

        private void averagetime_TextChanged(object sender, EventArgs e)
        {

        }
        int count = 1;
        private void button1_Click(object sender, EventArgs e)
        {
            if (bursttime.Text != "")
            {
                int n = listView1.Items.Count;
                ListViewItem a = new ListViewItem("P"+count++);
                listView1.Items.Add(a);
                a.SubItems.Add(bursttime.Text);
            }
            bursttime.Clear();
        }


        void averagetime()
        {
           
            MessageBox.Show("sdfdsfds");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double [] bt = new double[listView1.Items.Count];
            double[] wt = new double[listView1.Items.Count];
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                bt[i]= double.Parse(listView1.Items[i].SubItems[1].Text);
            }
            wt = findWaitingTime(bt);
            avrage.Text = wt.Sum() / listView1.Items.Count + "";

        }

        private void listfcfe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void avrage_TextChanged(object sender, EventArgs e)
        {

        }

        double[] findWaitingTime(double[] bt)
        {
            // waiting time for first process is 0  
            double[] wt = new double[listView1.Items.Count];
            double[] tat = new double[listView1.Items.Count];
            wt[0] = 0;
          
            // calculating waiting time  
            for (int i = 1; i < listView1.Items.Count; i++)
            {
                wt[i] = bt[i - 1] + wt[i - 1];
                tat[i-1] = bt[i-1] + wt[i-1];
            }
           
             MessageBox.Show("[{0}]", string.Join(", ", tat));
            return wt;
           
        }


      




























    }
}
