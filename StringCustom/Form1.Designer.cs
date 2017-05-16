namespace StringCustom
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.cboxAlpha = new System.Windows.Forms.CheckBox();
            this.cboxNum = new System.Windows.Forms.CheckBox();
            this.cboxMark = new System.Windows.Forms.CheckBox();
            this.cboxChinese = new System.Windows.Forms.CheckBox();
            this.tboxLength = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboxAlpha
            // 
            this.cboxAlpha.AutoSize = true;
            this.cboxAlpha.Location = new System.Drawing.Point(13, 13);
            this.cboxAlpha.Name = "cboxAlpha";
            this.cboxAlpha.Size = new System.Drawing.Size(48, 16);
            this.cboxAlpha.TabIndex = 0;
            this.cboxAlpha.Text = "字母";
            this.cboxAlpha.UseVisualStyleBackColor = true;
            // 
            // cboxNum
            // 
            this.cboxNum.AutoSize = true;
            this.cboxNum.Location = new System.Drawing.Point(13, 45);
            this.cboxNum.Name = "cboxNum";
            this.cboxNum.Size = new System.Drawing.Size(48, 16);
            this.cboxNum.TabIndex = 1;
            this.cboxNum.Text = "数字";
            this.cboxNum.UseVisualStyleBackColor = true;
            // 
            // cboxMark
            // 
            this.cboxMark.AutoSize = true;
            this.cboxMark.Location = new System.Drawing.Point(13, 78);
            this.cboxMark.Name = "cboxMark";
            this.cboxMark.Size = new System.Drawing.Size(48, 16);
            this.cboxMark.TabIndex = 2;
            this.cboxMark.Text = "符号";
            this.cboxMark.UseVisualStyleBackColor = true;
            // 
            // cboxChinese
            // 
            this.cboxChinese.AutoSize = true;
            this.cboxChinese.Location = new System.Drawing.Point(12, 110);
            this.cboxChinese.Name = "cboxChinese";
            this.cboxChinese.Size = new System.Drawing.Size(48, 16);
            this.cboxChinese.TabIndex = 3;
            this.cboxChinese.Text = "中文";
            this.cboxChinese.UseVisualStyleBackColor = true;
            // 
            // tboxLength
            // 
            this.tboxLength.Location = new System.Drawing.Point(148, 8);
            this.tboxLength.Name = "tboxLength";
            this.tboxLength.Size = new System.Drawing.Size(141, 21);
            this.tboxLength.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 36);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 90);
            this.textBox2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "指定长度";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "生成";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 156);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tboxLength);
            this.Controls.Add(this.cboxChinese);
            this.Controls.Add(this.cboxMark);
            this.Controls.Add(this.cboxNum);
            this.Controls.Add(this.cboxAlpha);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cboxAlpha;
        private System.Windows.Forms.CheckBox cboxNum;
        private System.Windows.Forms.CheckBox cboxMark;
        private System.Windows.Forms.CheckBox cboxChinese;
        private System.Windows.Forms.TextBox tboxLength;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

