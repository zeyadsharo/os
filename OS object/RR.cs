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
            pri.Clear();
            q = int.Parse(pri.Text);
           
    }  
   }




}
