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
    public partial class listview : Form
    {
        public listview()
        {
            InitializeComponent();
           
        }

        private void listview_Load(object sender, EventArgs e)
        {

        }

        void add()
        {
            //list view is important item in windows form 
            //is contins the the column and row 
            int n=listView1.Items.Count;
            ListViewItem a = new ListViewItem("P"+(n+1));// the value p1 go the first column 
            listView1.Items.Add(a); //to get the values from a and entered to listview in GUI  
                                    //items is row and subitems is column 

            //دي جاوا كولوما قيماتي وات ثابت كن 
          // اب ريكا ارايي
            //int[] x = new int[listView1.Items.Count];
           
            //for (int i = 0; i < listView1.Items.Count; i++)
            //{

            //}
            a.SubItems.Add(textBox1.Text);//to enter column 2
            a.SubItems.Add(textBox2.Text);//to enter column 3


        }

        private void button1_Click(object sender, EventArgs e)
        {
            add();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="")
            {
                int x = int.Parse(textBox3.Text);
                listView1.Items[x].Remove(); //to remove spisfic row 
            }
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
