namespace 按钮类控件
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDispDlg = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSystem = new System.Windows.Forms.RadioButton();
            this.rbPopup = new System.Windows.Forms.RadioButton();
            this.rbFlat = new System.Windows.Forms.RadioButton();
            this.rbStandard = new System.Windows.Forms.RadioButton();
            this.cbTest = new System.Windows.Forms.CheckBox();
            this.cbThreeState = new System.Windows.Forms.CheckBox();
            this.cbButton = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDispDlg
            // 
            this.btnDispDlg.Location = new System.Drawing.Point(12, 12);
            this.btnDispDlg.Name = "btnDispDlg";
            this.btnDispDlg.Size = new System.Drawing.Size(128, 23);
            this.btnDispDlg.TabIndex = 0;
            this.btnDispDlg.Text = "显示对话框(&D)";
            this.btnDispDlg.UseVisualStyleBackColor = true;
            this.btnDispDlg.Click += new System.EventHandler(this.btnDispDlg_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSystem);
            this.groupBox1.Controls.Add(this.rbPopup);
            this.groupBox1.Controls.Add(this.rbFlat);
            this.groupBox1.Controls.Add(this.rbStandard);
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 168);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "改变按钮的外观";
            // 
            // rbSystem
            // 
            this.rbSystem.AutoSize = true;
            this.rbSystem.Location = new System.Drawing.Point(50, 125);
            this.rbSystem.Name = "rbSystem";
            this.rbSystem.Size = new System.Drawing.Size(119, 16);
            this.rbSystem.TabIndex = 3;
            this.rbSystem.TabStop = true;
            this.rbSystem.Text = "系统按钮(&System)";
            this.rbSystem.UseVisualStyleBackColor = true;
            this.rbSystem.CheckedChanged += new System.EventHandler(this.rbSystem_CheckedChanged);
            // 
            // rbPopup
            // 
            this.rbPopup.AutoSize = true;
            this.rbPopup.Location = new System.Drawing.Point(50, 89);
            this.rbPopup.Name = "rbPopup";
            this.rbPopup.Size = new System.Drawing.Size(113, 16);
            this.rbPopup.TabIndex = 2;
            this.rbPopup.TabStop = true;
            this.rbPopup.Text = "弹出按钮(&Popup)";
            this.rbPopup.UseVisualStyleBackColor = true;
            this.rbPopup.CheckedChanged += new System.EventHandler(this.rbPopup_CheckedChanged);
            // 
            // rbFlat
            // 
            this.rbFlat.AutoSize = true;
            this.rbFlat.Location = new System.Drawing.Point(50, 54);
            this.rbFlat.Name = "rbFlat";
            this.rbFlat.Size = new System.Drawing.Size(107, 16);
            this.rbFlat.TabIndex = 1;
            this.rbFlat.TabStop = true;
            this.rbFlat.Text = "平面按钮(&Flat)";
            this.rbFlat.UseVisualStyleBackColor = true;
            this.rbFlat.CheckedChanged += new System.EventHandler(this.rbFlat_CheckedChanged);
            // 
            // rbStandard
            // 
            this.rbStandard.AutoSize = true;
            this.rbStandard.Location = new System.Drawing.Point(50, 20);
            this.rbStandard.Name = "rbStandard";
            this.rbStandard.Size = new System.Drawing.Size(131, 16);
            this.rbStandard.TabIndex = 0;
            this.rbStandard.TabStop = true;
            this.rbStandard.Text = "标准按钮(&Standard)";
            this.rbStandard.UseVisualStyleBackColor = true;
            this.rbStandard.CheckedChanged += new System.EventHandler(this.rbStandard_CheckedChanged);
            // 
            // cbTest
            // 
            this.cbTest.AutoSize = true;
            this.cbTest.Location = new System.Drawing.Point(282, 41);
            this.cbTest.Name = "cbTest";
            this.cbTest.Size = new System.Drawing.Size(60, 16);
            this.cbTest.TabIndex = 2;
            this.cbTest.Text = "复选框";
            this.cbTest.UseVisualStyleBackColor = true;
            // 
            // cbThreeState
            // 
            this.cbThreeState.AutoSize = true;
            this.cbThreeState.Location = new System.Drawing.Point(282, 80);
            this.cbThreeState.Name = "cbThreeState";
            this.cbThreeState.Size = new System.Drawing.Size(162, 16);
            this.cbThreeState.TabIndex = 3;
            this.cbThreeState.Text = "把复选框设为三种状态(&T)";
            this.cbThreeState.UseVisualStyleBackColor = true;
            this.cbThreeState.CheckedChanged += new System.EventHandler(this.cbThreeState_CheckedChanged);
            // 
            // cbButton
            // 
            this.cbButton.AutoSize = true;
            this.cbButton.Location = new System.Drawing.Point(282, 119);
            this.cbButton.Name = "cbButton";
            this.cbButton.Size = new System.Drawing.Size(174, 16);
            this.cbButton.TabIndex = 4;
            this.cbButton.Text = "把复选框显示为按钮形状(&B)";
            this.cbButton.UseVisualStyleBackColor = true;
            this.cbButton.CheckedChanged += new System.EventHandler(this.cbButton_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 221);
            this.Controls.Add(this.cbButton);
            this.Controls.Add(this.cbThreeState);
            this.Controls.Add(this.cbTest);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDispDlg);
            this.Name = "Form1";
            this.Text = "按钮类控件";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDispDlg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSystem;
        private System.Windows.Forms.RadioButton rbPopup;
        private System.Windows.Forms.RadioButton rbFlat;
        private System.Windows.Forms.RadioButton rbStandard;
        private System.Windows.Forms.CheckBox cbTest;
        private System.Windows.Forms.CheckBox cbThreeState;
        private System.Windows.Forms.CheckBox cbButton;
    }
}

