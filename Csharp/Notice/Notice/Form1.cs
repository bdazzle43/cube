using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Notice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        public DateTime setTime;//用于记录时间





        /*******退出提示*******/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (timer1.Enabled == true)
            {
                if (MessageBox.Show("当前有提醒任务,确定的要退出吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
        /******菜单功能*******/
        private void 关于定时提醒ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("定时提醒\nBY：Faye","关于");
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setTime = new DateTime(
                DateTime.Today.Year,
                DateTime.Today.Month,
                DateTime.Today.Day,
                (int)numericUpDown1.Value,
                (int)numericUpDown2.Value,
                0,
                0);
            timer1.Enabled = true;
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "在此输入您要提醒的内容...";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            timer1.Enabled = false;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DateTime.Now > setTime)
            {
                timer1.Enabled = false;
                this.Show();
                this.Activate();
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "在此输入您要提醒的内容...";
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            timer1.Enabled = false;
        }


    }

}
