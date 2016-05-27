namespace TD_LTE上行干扰分析系统
{
    partial class DbLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_passWd = new System.Windows.Forms.TextBox();
            this.textBox_userName = new System.Windows.Forms.TextBox();
            this.comboBox_validate = new System.Windows.Forms.ComboBox();
            this.textBox_serverIp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_passWd);
            this.groupBox1.Controls.Add(this.textBox_userName);
            this.groupBox1.Controls.Add(this.comboBox_validate);
            this.groupBox1.Controls.Add(this.textBox_serverIp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 292);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox_passWd
            // 
            this.textBox_passWd.Location = new System.Drawing.Point(156, 220);
            this.textBox_passWd.Name = "textBox_passWd";
            this.textBox_passWd.Size = new System.Drawing.Size(140, 21);
            this.textBox_passWd.TabIndex = 7;
            // 
            // textBox_userName
            // 
            this.textBox_userName.Location = new System.Drawing.Point(156, 173);
            this.textBox_userName.Name = "textBox_userName";
            this.textBox_userName.Size = new System.Drawing.Size(140, 21);
            this.textBox_userName.TabIndex = 6;
            // 
            // comboBox_validate
            // 
            this.comboBox_validate.FormattingEnabled = true;
            this.comboBox_validate.Items.AddRange(new object[] {
            "Windows 身份验证",
            "SQL Server 身份验证"});
            this.comboBox_validate.Location = new System.Drawing.Point(156, 103);
            this.comboBox_validate.Name = "comboBox_validate";
            this.comboBox_validate.Size = new System.Drawing.Size(140, 20);
            this.comboBox_validate.TabIndex = 5;
            this.comboBox_validate.SelectedIndexChanged += new System.EventHandler(this.comboBox_validate_SelectedIndexChanged);
            // 
            // textBox_serverIp
            // 
            this.textBox_serverIp.Location = new System.Drawing.Point(156, 49);
            this.textBox_serverIp.Name = "textBox_serverIp";
            this.textBox_serverIp.Size = new System.Drawing.Size(140, 21);
            this.textBox_serverIp.TabIndex = 4;
            this.textBox_serverIp.Text = "localhost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "身份验证";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器Ip";
            // 
            // button_login
            // 
            this.button_login.Location = new System.Drawing.Point(168, 340);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(75, 23);
            this.button_login.TabIndex = 1;
            this.button_login.Text = "登陆";
            this.button_login.UseVisualStyleBackColor = true;
            this.button_login.SizeChanged += new System.EventHandler(this.button_login_SizeChanged);
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            // 
            // DbLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 384);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.groupBox1);
            this.Name = "DbLogin";
            this.Text = "设置数据库连接参数";
            this.Load += new System.EventHandler(this.DbLogin_Load);
            this.SizeChanged += new System.EventHandler(this.DbLogin_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_passWd;
        private System.Windows.Forms.TextBox textBox_userName;
        private System.Windows.Forms.ComboBox comboBox_validate;
        private System.Windows.Forms.TextBox textBox_serverIp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_login;
    }
}