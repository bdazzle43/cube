using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SimpleClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Student s1 = new Student();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtName.Text == "" || txtSex.Text == "")
            {
                lblShow.Text = "不能为空值！";
                return;
            }

            //为对象字段赋值
            s1.ID = txtID.Text;
            s1.Name = txtName.Text;
            s1.Sex = txtSex.Text;
            lblShow.Text = "设置成功！";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //显示对象字段的值
            lblShow.Text = "学号:" + s1.ID + "姓名:" + s1.Name + "性别:" + s1.Sex;
        }

    }

    class Student
    {
        public string ID, Name, Sex;
    }

}
