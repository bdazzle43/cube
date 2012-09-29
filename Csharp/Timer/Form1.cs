using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {

        uint remainder;//保存倒计时的剩余总秒数
        uint minute;//保存倒计时的剩余分钟数
        uint second;//保存倒计时的剩余秒数
        string msg;//保存倒计时的总信息

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            txtNumber.Focus();
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                if (txtNumber.Text == "")
                    return;
                remainder = Convert.ToUInt32(txtNumber.Text) * 60;
                timer2.Enabled = false;         //第2个计时器终止工作
                timer1.Enabled = true;          //第1个计时器开始工作
                lblTimeEnd.Visible = true;      //显示控件
                txtTimeEnd.Visible = true;      //显示控件
                lblTimeStart.Text = "开始时间:";   //更换标签标题
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //在txtTimeStart文本框中显示时间
            txtTimeStart.Text = DateTime.Now.Hour.ToString() + ":"
                + DateTime.Now.Minute.ToString() + ":"
                + DateTime.Now.Second.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //在txtTimeEnd文本框中显示时间
            txtTimeEnd.Text = DateTime.Now.Hour.ToString() + ":"
                + DateTime.Now.Minute.ToString() + ":"
                + DateTime.Now.Second.ToString();
            remainder--;                      //总秒数减1
            minute = remainder / 60;          //求出总秒数折合的分钟数
            second = remainder % 60;          //折合成分钟后剩余的秒数
            if (second < 10)
                msg = "剩余时间:" + minute + "分0" + second + "秒";
            else
                msg = "剩余时间:" + minute + "分" + second + "秒";
            lblRemainder.Text = msg;    //将msg信息在标签上显示
            if (remainder == 0)         //如果剩余总数为0
            {
                timer1.Enabled = false;//倒计时时间到,timer1停止工作
                lblRemainder.Text += "--时间到!";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            lblRemainder.Text = "";      //清空lblRemainder标签
            txtNumber.Text = "";         //清空输入文本框
            txtNumber.Focus();           //输入文本框获得焦点
            timer2.Enabled = true;       //计时器2开始工作
            lblTimeEnd.Visible = false;  //隐藏lblTimeEnd标签控件
            txtTimeEnd.Visible = false;  //隐藏txtTimeEnd标签控件
        }
    }
}
