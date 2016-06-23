namespace TD_LTE上行干扰分析系统
{
    partial class ProjectCreate
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
            this.button_create = new System.Windows.Forms.Button();
            this.textBox_person = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_projectArea = new System.Windows.Forms.ComboBox();
            this.comboBox_projectName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_projectName);
            this.groupBox1.Controls.Add(this.comboBox_projectArea);
            this.groupBox1.Controls.Add(this.button_create);
            this.groupBox1.Controls.Add(this.textBox_person);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 366);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(170, 326);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(75, 23);
            this.button_create.TabIndex = 6;
            this.button_create.Text = "创建";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.SizeChanged += new System.EventHandler(this.button_create_SizeChanged);
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // textBox_person
            // 
            this.textBox_person.Location = new System.Drawing.Point(170, 226);
            this.textBox_person.Name = "textBox_person";
            this.textBox_person.Size = new System.Drawing.Size(121, 21);
            this.textBox_person.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "项目创建人";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "地区名称";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名称";
            // 
            // comboBox_projectArea
            // 
            this.comboBox_projectArea.FormattingEnabled = true;
            this.comboBox_projectArea.Location = new System.Drawing.Point(170, 68);
            this.comboBox_projectArea.Name = "comboBox_projectArea";
            this.comboBox_projectArea.Size = new System.Drawing.Size(121, 20);
            this.comboBox_projectArea.TabIndex = 7;
            this.comboBox_projectArea.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectArea_SelectedIndexChanged);
            // 
            // comboBox_projectName
            // 
            this.comboBox_projectName.FormattingEnabled = true;
            this.comboBox_projectName.Location = new System.Drawing.Point(170, 143);
            this.comboBox_projectName.Name = "comboBox_projectName";
            this.comboBox_projectName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_projectName.TabIndex = 8;
            // 
            // ProjectCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 417);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectCreate";
            this.Text = "ProjectCreate";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectCreate_FormClosing);
            this.Load += new System.EventHandler(this.ProjectCreate_Load);
            this.LocationChanged += new System.EventHandler(this.ProjectCreate_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.ProjectCreate_SizeChanged);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.TextBox textBox_person;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_projectName;
        private System.Windows.Forms.ComboBox comboBox_projectArea;
    }
}