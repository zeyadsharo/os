using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_object
{
    public partial class file : Form
    {
        public file()
        {
            InitializeComponent();
        }
        string path = @"D:\OS object\OS object\file\file.txt";
        private void button1_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                
                 StreamReader file = new StreamReader(path); 
                 textBox1.Text=file.ReadToEnd();
                 file.Close();
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
           StreamWriter file = new StreamWriter(path);
            if (!File.Exists(path))
            { 
               file.WriteLineAsync(textBox1.Text);
                MessageBox.Show("the data inserted sccsufully");
                textBox1.Text = "";
            }
            else
            {
                file.WriteLineAsync(textBox1.Text);
                MessageBox.Show("the data inserted sccsufully");
                textBox1.Text = "";
            }
            file.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show(path,"the file is deleted Successfully! in ");
            }
           
        }
    }
}
