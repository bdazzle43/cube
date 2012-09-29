using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            label3.Text = ("计算结果：\n");
            n3 = n2 + n1;
            label3.Text += ("两个整数的和为：" + n3 + "\n");
            n3 = n1 - n2;
            label3.Text += ("两个整数的差为：" + n3 + "\n");
            n3 = n1 * n2;
            label3.Text += ("两个整数的积为：" + n3 + "\n");
            float n4 = (float)n1 / n2;
            label3.Text += ("两个整数的商为：" + n4 + "\n");



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            label3.Text = "";
        }
    }
}
