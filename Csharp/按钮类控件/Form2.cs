using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace 按钮类控件
{
    public partial class TestDialog : Form
    {
        public TestDialog()
        {
            InitializeComponent();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //this.DialogResult = DialogResult.None;//阻止关闭窗口
        }

        private void TestDialog_Load(object sender, EventArgs e)
        {

        }
    }
}
