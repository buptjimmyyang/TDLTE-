namespace TD_LTE上行干扰分析系统
{
    partial class ProjectDelete
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_projectName = new System.Windows.Forms.ComboBox();
            this.textBox_projectCity = new System.Windows.Forms.TextBox();
            this.textBox_projectDate = new System.Windows.Forms.TextBox();
            this.textBox_projectPerson = new System.Windows.Forms.TextBox();
            this.button_create = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_projectDb = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_projectDb);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox_projectPerson);
            this.groupBox1.Controls.Add(this.textBox_projectDate);
            this.groupBox1.Controls.Add(this.textBox_projectCity);
            this.groupBox1.Controls.Add(this.comboBox_projectName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(34, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 262);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "项目地区";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "创建时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "负责人";
            // 
            // comboBox_projectName
            // 
            this.comboBox_projectName.FormattingEnabled = true;
            this.comboBox_projectName.Location = new System.Drawing.Point(113, 40);
            this.comboBox_projectName.Name = "comboBox_projectName";
            this.comboBox_projectName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_projectName.TabIndex = 4;
            this.comboBox_projectName.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectName_SelectedIndexChanged);
            // 
            // textBox_projectCity
            // 
            this.textBox_projectCity.Location = new System.Drawing.Point(113, 81);
            this.textBox_projectCity.Name = "textBox_projectCity";
            this.textBox_projectCity.ReadOnly = true;
            this.textBox_projectCity.Size = new System.Drawing.Size(121, 21);
            this.textBox_projectCity.TabIndex = 5;
            // 
            // textBox_projectDate
            // 
            this.textBox_projectDate.Location = new System.Drawing.Point(113, 135);
            this.textBox_projectDate.Name = "textBox_projectDate";
            this.textBox_projectDate.ReadOnly = true;
            this.textBox_projectDate.Size = new System.Drawing.Size(121, 21);
            this.textBox_projectDate.TabIndex = 6;
            // 
            // textBox_projectPerson
            // 
            this.textBox_projectPerson.Location = new System.Drawing.Point(113, 220);
            this.textBox_projectPerson.Name = "textBox_projectPerson";
            this.textBox_projectPerson.ReadOnly = true;
            this.textBox_projectPerson.Size = new System.Drawing.Size(121, 21);
            this.textBox_projectPerson.TabIndex = 7;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(147, 301);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 1;
            this.button_create.Text = "删除";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "数据库名称";
            // 
            // textBox_projectDb
            // 
            this.textBox_projectDb.Location = new System.Drawing.Point(113, 175);
            this.textBox_projectDb.Name = "textBox_projectDb";
            this.textBox_projectDb.ReadOnly = true;
            this.textBox_projectDb.Size = new System.Drawing.Size(121, 21);
            this.textBox_projectDb.TabIndex = 9;
            // 
            // ProjectDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 358);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectDelete";
            this.Text = "ProjectDelete";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectDelete_FormClosing);
            this.Load += new System.EventHandler(this.ProjectDelete_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_projectPerson;
        private System.Windows.Forms.TextBox textBox_projectDate;
        private System.Windows.Forms.TextBox textBox_projectCity;
        private System.Windows.Forms.ComboBox comboBox_projectName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_projectDb;
        private System.Windows.Forms.Label label5;
    }
}