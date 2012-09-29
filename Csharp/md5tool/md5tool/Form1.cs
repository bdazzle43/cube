using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;//用于md5类

namespace md5tool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string showMd5(string str)
        {
            string pwd = "", tmp;
            //实例化一个MD5类
            MD5 md5 = MD5.Create();
            //string转换成byte[]后计算哈希值
            byte[] s = md5.ComputeHash(Encoding.ASCII.GetBytes(str));
            //循环转换成string
            for (int i = 0; i < s.Length; i++)
            {
                //转成小写string
                tmp = s[i].ToString("x");
                //补足高位转换省略的0
                if (tmp.Length == 1)
                    tmp = "0" + tmp;
                pwd += tmp;
            }
            return pwd;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = showMd5(textBox1.Text);
            button2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (object)label3.Text);
            MessageBox.Show("密文已经复制到剪切板内", "提示");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label3.Text = "";
            button2.Visible = false;
        }
    }
}
