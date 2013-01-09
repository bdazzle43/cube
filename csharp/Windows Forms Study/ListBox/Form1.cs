using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int k = 1;
            int sum = 0;
            while (k < 100)
            {
                sum = sum + k;
                listBox1.Items.Add("从0+……" + k.ToString() + "=" + sum.ToString());
                k++;
                if (sum > 1000)
                    break;
            }
        }
    }
}
