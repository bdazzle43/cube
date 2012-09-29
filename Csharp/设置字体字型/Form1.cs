using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 设置字体字型
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                label1.Font = new Font("黑体", label1.Font.Size, label1.Font.Style);

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                label1.Font = new Font("华文新魏", label1.Font.Size, label1.Font.Style);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
                label1.Font = new Font("楷体_gb2312", label1.Font.Size, label1.Font.Style);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (checkBox2.Checked && checkBox3.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                else if (checkBox2.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic);
                else if (checkBox3.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Underline);
                else
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
            }
            else
            {
                if (checkBox2.Checked && checkBox3.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Italic | FontStyle.Underline);
                else if (checkBox2.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
                else if (checkBox3.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                else
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                if (checkBox1.Checked && checkBox3.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                else if (checkBox1.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic);
                else if (checkBox3.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Italic | FontStyle.Underline);
                else
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
            }
            else
            {
                if (checkBox1.Checked && checkBox3.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Underline);
                else if (checkBox1.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                else if (checkBox3.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
                else
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                if (checkBox1.Checked && checkBox2.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                else if (checkBox1.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Underline);
                else if (checkBox2.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Italic | FontStyle.Underline);
                else
                    label1.Font = new Font(label1.Font, FontStyle.Underline);
            }
            else
            {
                if (checkBox1.Checked && checkBox2.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold | FontStyle.Underline);
                else if (checkBox1.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Bold);
                else if (checkBox2.Checked)
                    label1.Font = new Font(label1.Font, FontStyle.Italic);
                else
                    label1.Font = new Font(label1.Font, FontStyle.Regular);
            }
        }
    }
}
