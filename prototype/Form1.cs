using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void userControl31_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;
            userControl11.Show();
            userControl21.Hide();
            userControl31.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Height = button2.Height;
            panel3.Top = button2.Top;
            userControl11.Hide();
            userControl21.Show();
            userControl31.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Height = button3.Height;
            panel3.Top = button3.Top;
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Show();
        }
    }
}
