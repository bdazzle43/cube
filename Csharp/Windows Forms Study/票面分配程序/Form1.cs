using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 票面分配程序
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int money = int.Parse(txtGZ.Text);
            int m100 = money / 100;
            money -= m100 * 100;
            int m50 = money / 50;
            money -= m50 * 50;
            int m20 = money / 20;
            money -= m20 * 20;
            int m10 = money / 10;
            money -= m10 * 10;
            int m5 = money / 5;
            money -= m5 * 5;

            textBox1.Text = m100.ToString();
            textBox2.Text = m50.ToString();
            textBox3.Text = m20.ToString();
            textBox4.Text = m10.ToString();
            textBox5.Text = m5.ToString();
            textBox6.Text = money.ToString();
        }
    }
}
