using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OS_object.Properties;

namespace OS_object
{
    public partial class RR : Form
    {
        public RR()
        {
            InitializeComponent();
        }
       

        int count = 0;
        int q = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (bursttime.Text != "")
            {
                int n = listView1.Items.Count;
                ListViewItem a = new ListViewItem("P" + count++);
                listView1.Items.Add(a);
                a.SubItems.Add(bursttime.Text);
            }
            bursttime.Clear(); 
        }
        public void toarray()
        {
            int[] bt = new int[listView1.Items.Count];
            for (int i = 0; i < bt.Length; i++)
            {
                bt[i] = int.Parse(listView1.Items[i].SubItems[1].Text);
            }

            Raundr raundr = new Raundr();
            // process id's 
          

            // Burst time of all processes 
           

            // Time quantum 
            int quantum = int.Parse( quantom.Text);
           float d= raundr.findavgTime(listView1.Items.Count, bt, quantum);
            averagerr.Text = d + "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            toarray();
        }
    }




}
