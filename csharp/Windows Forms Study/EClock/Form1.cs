using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EClock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "今天的日期是:" + DateTime.Now.Year.ToString() + "年"
                + DateTime.Now.Month.ToString() + "月"
                + DateTime.Now.Day.ToString() + "日"
                + DateTime.Now.DayOfWeek.ToString();
            label2.Text = DateTime.Now.Hour.ToString() + ":"
                + DateTime.Now.Minute.ToString() + ":"
                + DateTime.Now.Second.ToString();
        }
    }
}
