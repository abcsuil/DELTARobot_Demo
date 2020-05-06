namespace DELTARobot_Demo.MS
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
            this.connect_btn = new System.Windows.Forms.Button();
            this.stationNum = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.disconnect_btn = new System.Windows.Forms.Button();
            this.PortNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IpAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.batchRead = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.constantRW = new System.Windows.Forms.Button();
            this.stop_ConstantRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // connect_btn
            // 
            this.connect_btn.Location = new System.Drawing.Point(791, 20);
            this.connect_btn.Name = "connect_btn";
            this.connect_btn.Size = new System.Drawing.Size(91, 28);
            this.connect_btn.TabIndex = 16;
            this.connect_btn.Text = "连接";
            this.connect_btn.UseVisualStyleBackColor = true;
            this.connect_btn.Click += new System.EventHandler(this.connect_btn_Click);
            // 
            // stationNum
            // 
            this.stationNum.Location = new System.Drawing.Point(399, 23);
            this.stationNum.Name = "stationNum";
            this.stationNum.Size = new System.Drawing.Size(39, 25);
            this.stationNum.TabIndex = 19;
            this.stationNum.Text = "1";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(345, 26);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(52, 15);
            this.label21.TabIndex = 18;
            this.label21.Text = "站号：";
            // 
            // disconnect_btn
            // 
            this.disconnect_btn.Enabled = false;
            this.disconnect_btn.Location = new System.Drawing.Point(894, 20);
            this.disconnect_btn.Name = "disconnect_btn";
            this.disconnect_btn.Size = new System.Drawing.Size(91, 28);
            this.disconnect_btn.TabIndex = 17;
            this.disconnect_btn.Text = "断开连接";
            this.disconnect_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.disconnect_btn.UseVisualStyleBackColor = true;
            this.disconnect_btn.Click += new System.EventHandler(this.disconnect_btn_Click);
            // 
            // PortNum
            // 
            this.PortNum.Location = new System.Drawing.Point(257, 23);
            this.PortNum.Name = "PortNum";
            this.PortNum.Size = new System.Drawing.Size(76, 25);
            this.PortNum.TabIndex = 15;
            this.PortNum.Text = "502";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "端口号：";
            // 
            // IpAddress
            // 
            this.IpAddress.Location = new System.Drawing.Point(69, 23);
            this.IpAddress.Name = "IpAddress";
            this.IpAddress.Size = new System.Drawing.Size(128, 25);
            this.IpAddress.TabIndex = 13;
            this.IpAddress.Text = "192.168.0.100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ip地址：";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ABCD",
            "BADC",
            "CDAB",
            "DCBA"});
            this.comboBox1.Location = new System.Drawing.Point(555, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(111, 23);
            this.comboBox1.TabIndex = 29;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(444, 26);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(127, 19);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "首地址从0开始";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(672, 26);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(104, 19);
            this.checkBox3.TabIndex = 28;
            this.checkBox3.Text = "字符串颠倒";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(69, 117);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox10.Size = new System.Drawing.Size(445, 78);
            this.textBox10.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 119);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 15);
            this.label13.TabIndex = 35;
            this.label13.Text = "结果：";
            // 
            // batchRead
            // 
            this.batchRead.Location = new System.Drawing.Point(432, 81);
            this.batchRead.Name = "batchRead";
            this.batchRead.Size = new System.Drawing.Size(82, 28);
            this.batchRead.TabIndex = 34;
            this.batchRead.Text = "批量读取";
            this.batchRead.UseVisualStyleBackColor = true;
            this.batchRead.Click += new System.EventHandler(this.batchRead_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(245, 84);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(102, 25);
            this.textBox9.TabIndex = 33;
            this.textBox9.Text = "10";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(191, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 15);
            this.label12.TabIndex = 32;
            this.label12.Text = "长度：";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(69, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(102, 25);
            this.textBox6.TabIndex = 31;
            this.textBox6.Text = "100";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 15);
            this.label11.TabIndex = 30;
            this.label11.Text = "地址：";
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(611, 116);
            this.textBox17.Multiline = true;
            this.textBox17.Name = "textBox17";
            this.textBox17.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox17.Size = new System.Drawing.Size(396, 179);
            this.textBox17.TabIndex = 38;
            // 
            // constantRW
            // 
            this.constantRW.Location = new System.Drawing.Point(611, 301);
            this.constantRW.Name = "constantRW";
            this.constantRW.Size = new System.Drawing.Size(184, 28);
            this.constantRW.TabIndex = 37;
            this.constantRW.Text = "实时读取";
            this.constantRW.UseVisualStyleBackColor = true;
            this.constantRW.Click += new System.EventHandler(this.constantRW_Click);
            // 
            // stop_ConstantRead
            // 
            this.stop_ConstantRead.Location = new System.Drawing.Point(823, 301);
            this.stop_ConstantRead.Name = "stop_ConstantRead";
            this.stop_ConstantRead.Size = new System.Drawing.Size(184, 28);
            this.stop_ConstantRead.TabIndex = 39;
            this.stop_ConstantRead.Text = "停止读取";
            this.stop_ConstantRead.UseVisualStyleBackColor = true;
            this.stop_ConstantRead.Click += new System.EventHandler(this.stop_ConstantRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 632);
            this.Controls.Add(this.stop_ConstantRead);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.constantRW);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.batchRead);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.connect_btn);
            this.Controls.Add(this.stationNum);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.disconnect_btn);
            this.Controls.Add(this.PortNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IpAddress);
            this.Controls.Add(this.label4);
            this.Name = "Form1";
            this.Text = "v";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connect_btn;
        private System.Windows.Forms.TextBox stationNum;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button disconnect_btn;
        private System.Windows.Forms.TextBox PortNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox IpAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button batchRead;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button constantRW;
        private System.Windows.Forms.Button stop_ConstantRead;
    }
}

