namespace 按钮类控件
{
    partial class TestDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnIgnore = new System.Windows.Forms.Button();
            this.BtnRetry = new System.Windows.Forms.Button();
            this.BtnYes = new System.Windows.Forms.Button();
            this.BtnNo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOK
            // 
            this.BtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOK.Location = new System.Drawing.Point(12, 12);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(75, 23);
            this.BtnOK.TabIndex = 0;
            this.BtnOK.Text = "确定(&O)";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(12, 41);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "取消(&C)";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAbort
            // 
            this.btnAbort.DialogResult = System.Windows.Forms.DialogResult.Abort;
            this.btnAbort.Location = new System.Drawing.Point(12, 70);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 23);
            this.btnAbort.TabIndex = 2;
            this.btnAbort.Text = "终止(&A)";
            this.btnAbort.UseVisualStyleBackColor = true;
            // 
            // btnIgnore
            // 
            this.btnIgnore.DialogResult = System.Windows.Forms.DialogResult.Ignore;
            this.btnIgnore.Location = new System.Drawing.Point(12, 99);
            this.btnIgnore.Name = "btnIgnore";
            this.btnIgnore.Size = new System.Drawing.Size(75, 23);
            this.btnIgnore.TabIndex = 3;
            this.btnIgnore.Text = "忽略(&I)";
            this.btnIgnore.UseVisualStyleBackColor = true;
            // 
            // BtnRetry
            // 
            this.BtnRetry.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.BtnRetry.Location = new System.Drawing.Point(93, 12);
            this.BtnRetry.Name = "BtnRetry";
            this.BtnRetry.Size = new System.Drawing.Size(75, 23);
            this.BtnRetry.TabIndex = 6;
            this.BtnRetry.Text = "重试(&R)";
            this.BtnRetry.UseVisualStyleBackColor = true;
            // 
            // BtnYes
            // 
            this.BtnYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.BtnYes.Location = new System.Drawing.Point(93, 41);
            this.BtnYes.Name = "BtnYes";
            this.BtnYes.Size = new System.Drawing.Size(75, 23);
            this.BtnYes.TabIndex = 5;
            this.BtnYes.Text = "是(&Y)";
            this.BtnYes.UseVisualStyleBackColor = true;
            // 
            // BtnNo
            // 
            this.BtnNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.BtnNo.Location = new System.Drawing.Point(93, 70);
            this.BtnNo.Name = "BtnNo";
            this.BtnNo.Size = new System.Drawing.Size(75, 23);
            this.BtnNo.TabIndex = 4;
            this.BtnNo.Text = "否(&N)";
            this.BtnNo.UseVisualStyleBackColor = true;
            // 
            // TestDialog
            // 
            this.AcceptButton = this.BtnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(240, 136);
            this.Controls.Add(this.BtnRetry);
            this.Controls.Add(this.BtnYes);
            this.Controls.Add(this.BtnNo);
            this.Controls.Add(this.btnIgnore);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TestDialog";
            this.Text = "测试按钮的DialogResult";
            this.Load += new System.EventHandler(this.TestDialog_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnIgnore;
        private System.Windows.Forms.Button BtnRetry;
        private System.Windows.Forms.Button BtnYes;
        private System.Windows.Forms.Button BtnNo;
    }
}