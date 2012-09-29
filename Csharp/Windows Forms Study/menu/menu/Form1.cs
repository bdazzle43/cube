using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        
        
        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击了New");
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("点击了Open");
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
