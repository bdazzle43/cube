using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 进程条控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            progressBar1.Value = 0;
            for (i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                label1.Text = i.ToString() + "/100";
            }
        }
    }
}
