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
            this.label7 = new System.Windows.Forms.Label();
            this.tbContentType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUserAgent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbRes = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbReferer = new System.Windows.Forms.TextBox();
            this.cbShowResult = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudThreadCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSingleCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupTimeout)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(598, 21);
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
            this.label1.Location = new System.Drawing.Point(48, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Url：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Method：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "TimeOut(s)：";
            // 
            // tbUrl
            // 
            this.tbUrl.Location = new System.Drawing.Point(94, 22);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(494, 21);
            this.tbUrl.TabIndex = 5;
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(94, 132);
            this.rtbData.Name = "rtbData";
            this.rtbData.Size = new System.Drawing.Size(579, 118);
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
            this.cbMethod.Location = new System.Drawing.Point(94, 59);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(168, 20);
            this.cbMethod.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "ThreadCount：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "SingleCount：";
            // 
            // nudThreadCount
            // 
            this.nudThreadCount.Location = new System.Drawing.Point(95, 287);
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
            this.nudSingleCount.Location = new System.Drawing.Point(303, 287);
            this.nudSingleCount.Maximum = new decimal(new int[] {
            100000000,
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
            this.nupTimeout.Location = new System.Drawing.Point(395, 59);
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
            this.nupTimeout.Size = new System.Drawing.Size(89, 21);
            this.nupTimeout.TabIndex = 16;
            this.nupTimeout.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 12);
            this.label7.TabIndex = 17;
            this.label7.Text = "ContentType：";
            // 
            // tbContentType
            // 
            this.tbContentType.Location = new System.Drawing.Point(94, 93);
            this.tbContentType.Name = "tbContentType";
            this.tbContentType.Size = new System.Drawing.Size(249, 21);
            this.tbContentType.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 12);
            this.label8.TabIndex = 19;
            this.label8.Text = "UserAgent：";
            // 
            // tbUserAgent
            // 
            this.tbUserAgent.Location = new System.Drawing.Point(452, 93);
            this.tbUserAgent.Name = "tbUserAgent";
            this.tbUserAgent.Size = new System.Drawing.Size(221, 21);
            this.tbUserAgent.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 327);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "Result：";
            // 
            // rtbRes
            // 
            this.rtbRes.Location = new System.Drawing.Point(94, 327);
            this.rtbRes.Name = "rtbRes";
            this.rtbRes.Size = new System.Drawing.Size(579, 105);
            this.rtbRes.TabIndex = 22;
            this.rtbRes.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 23;
            this.label10.Text = "Referer：";
            // 
            // tbReferer
            // 
            this.tbReferer.Location = new System.Drawing.Point(95, 256);
            this.tbReferer.Name = "tbReferer";
            this.tbReferer.Size = new System.Drawing.Size(578, 21);
            this.tbReferer.TabIndex = 24;
            // 
            // cbShowResult
            // 
            this.cbShowResult.AutoSize = true;
            this.cbShowResult.Location = new System.Drawing.Point(452, 290);
            this.cbShowResult.Name = "cbShowResult";
            this.cbShowResult.Size = new System.Drawing.Size(84, 16);
            this.cbShowResult.TabIndex = 26;
            this.cbShowResult.Text = "ShowResult";
            this.cbShowResult.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 452);
            this.Controls.Add(this.cbShowResult);
            this.Controls.Add(this.tbReferer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.rtbRes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tbUserAgent);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbContentType);
            this.Controls.Add(this.label7);
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
            this.MaximumSize = new System.Drawing.Size(713, 491);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(713, 491);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbContentType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbUserAgent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbRes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbReferer;
        private System.Windows.Forms.CheckBox cbShowResult;
    }
}

