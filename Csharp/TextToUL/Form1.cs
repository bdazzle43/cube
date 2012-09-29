using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TextToUL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToUpper();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text.ToLower();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
