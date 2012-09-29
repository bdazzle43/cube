using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //如果任一组合框没有选定年份，则不执行任何操作
            //SelectedIndex   -1:未选 0:第一项
            if (cboStart.SelectedIndex == -1 || cboEnd.SelectedIndex == -1)
            {
                return;
            }
            //将获取的两个组合框中的被选定内容转换为int类型,进行赋值
            int yearStart = int.Parse(cboStart.SelectedItem.ToString());
            int yearEnd = int.Parse(cboEnd.SelectedItem.ToString());
            if (yearStart > yearEnd)      //如果起始大于截止这部执行任何操作
                return;
            lstOut.Items.Clear();         //清除上次内容
            for (int i = yearStart; i <= yearEnd; i++)
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                    lstOut.Items.Add(i);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstOut.Items.Clear();
        }
    }
}
