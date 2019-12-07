using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OS_object
{
    public partial class process : Form
    {
        public process()
        {
            InitializeComponent();
        }

        private void current_process_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                Process p = Process.GetCurrentProcess();
                dataGridView1.Rows.Add(p.Id, p.ProcessName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            try
            {
                Process[] p = Process.GetProcesses();
                foreach (Process process in p)
                {
                    dataGridView1.Rows.Add(process.Id, process.ProcessName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                Process p = Process.GetProcessById(Convert.ToInt16(textBox1.Text));
                dataGridView1.Rows.Add(p.Id, p.ProcessName);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Process p = Process.GetProcessById(Convert.ToInt16(textBox1.Text));
                p.Kill();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start(textBox1.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
           Process.Start("https://www.google.com/");
        }

        private void button7_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Are you sure you want to Shut dawn your pc", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (res == DialogResult.OK)
            {
                Process.Start("shutdown", "-s -t 00");
            }
          
            
        }
    }
}
