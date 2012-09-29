using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 按钮类控件
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDispDlg_Click(object sender, EventArgs e)
        {
            TestDialog dlgTest = new TestDialog();
            //显示对话框并获取它的返回结果
            DialogResult dr = dlgTest.ShowDialog(this);
            //在消息框中显示对话结果
            MessageBox.Show("对话框的返回结果为:" + dr);
        }

        //4个单选按钮的CheckedChanged事件的处理方法
        private void ChangeFlatStyle(object sender, EventArgs e)
        {
            FlatStyle fs;

            if (sender == rbFlat)
                fs = FlatStyle.Flat;
            else if (sender == rbPopup)
                fs = FlatStyle.Popup;
            else if (sender == rbSystem)
                fs = FlatStyle.System;
            else
                fs = FlatStyle.Standard;
            //改变所有按钮控件的外观
            btnDispDlg.FlatStyle = fs;
            rbStandard.FlatStyle = fs;
            rbFlat.FlatStyle = fs;
            rbPopup.FlatStyle = fs;
            rbSystem.FlatStyle = fs;
            cbButton.FlatStyle = fs;
            cbTest.FlatStyle = fs;
            cbThreeState.FlatStyle = fs;
        }

        private void rbStandard_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFlatStyle(sender,e);
        }

        private void rbFlat_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFlatStyle(sender, e);
        }

        private void rbPopup_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFlatStyle(sender, e);
        }

        private void rbSystem_CheckedChanged(object sender, EventArgs e)
        {
            ChangeFlatStyle(sender, e);
        }

        //设置复选框的ThreeState属性
        private void cbThreeState_CheckedChanged(object sender, EventArgs e)
        {
            if (cbThreeState.Checked)
                cbTest.ThreeState = true;
            else
                cbTest.ThreeState = false;
        }
        //改变复选框的外观
        private void cbButton_CheckedChanged(object sender, EventArgs e)
        {
            if (cbButton.Checked)
                cbTest.Appearance = Appearance.Button;
            else
                cbTest.Appearance = Appearance.Normal;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
