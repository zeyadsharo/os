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


        void averagetime()
        {
           
            MessageBox.Show("sdfdsfds");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            double sum = 0;

            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sum=sum+ double.Parse(listView1.Items[i].SubItems[1].Text);
            }
            double average = sum / listView1.Items.Count;
            avrage.Text = average.ToString();
        }

        private void listfcfe_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void avrage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
