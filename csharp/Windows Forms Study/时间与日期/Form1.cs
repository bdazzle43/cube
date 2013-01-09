using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 时间与日期
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                label1.Text = DateTime.Now.Year + "年" + DateTime.Now.Month + "月" + DateTime.Now.Second + "日";
            if (radioButton2.Checked)
                label1.Text = DateTime.Now.Hour + "时" + DateTime.Now.Minute + "分" + DateTime.Now.Second + "秒";
        }
    }
}
