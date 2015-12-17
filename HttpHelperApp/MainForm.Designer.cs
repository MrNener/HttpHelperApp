namespace HttpHelperApp
{
    partial class MainForm
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
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudThreadCount = new System.Windows.Forms.NumericUpDown();
            this.nudSingleCount = new System.Windows.Forms.NumericUpDown();
            this.nupTimeout = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSingleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(303, 304);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Method：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "TimeOut(s)：";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(94, 64);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(284, 21);
            this.tbUrl.TabIndex = 5;
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(94, 174);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(284, 118);
            this.rtbData.TabIndex = 8;
            this.rtbData.Text = "";
            // 
            // cbMethod
            // 
            this.cbMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Items.AddRange(new object[] {
            "POST",
            "GET"});
            this.cbMethod.Location = new System.Drawing.Point(94, 101);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(284, 20);
            this.cbMethod.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "ThreadCount：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(207, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "SingleCount：";
            // 
            // nudThreadCount
            // 
            this.nudThreadCount.Location = new System.Drawing.Point(94, 27);
            this.nudThreadCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudThreadCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudThreadCount.Name = "nudThreadCount";
            this.nudThreadCount.Size = new System.Drawing.Size(102, 21);
            this.nudThreadCount.TabIndex = 14;
            this.nudThreadCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudSingleCount
            // 
            this.nudSingleCount.Location = new System.Drawing.Point(292, 27);
            this.nudSingleCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSingleCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSingleCount.Name = "nudSingleCount";
            this.nudSingleCount.Size = new System.Drawing.Size(86, 21);
            this.nudSingleCount.TabIndex = 15;
            this.nudSingleCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nupTimeout
            // 
            this.nupTimeout.Location = new System.Drawing.Point(94, 138);
            this.nupTimeout.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nupTimeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupTimeout.Name = "nupTimeout";
            this.nupTimeout.Size = new System.Drawing.Size(284, 21);
            this.nupTimeout.TabIndex = 16;
            this.nupTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 339);
            this.Controls.Add(this.nupTimeout);
            this.Controls.Add(this.nudSingleCount);
            this.Controls.Add(this.nudThreadCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.rtbData);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(434, 378);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(434, 378);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HttpHelper";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSingleCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudThreadCount;
        private System.Windows.Forms.NumericUpDown nudSingleCount;
        private System.Windows.Forms.NumericUpDown nupTimeout;
    }
}

