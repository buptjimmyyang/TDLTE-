namespace TD_LTE上行干扰分析系统
{
    partial class SelectProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_projectArea = new System.Windows.Forms.ComboBox();
            this.comboBox_projectName = new System.Windows.Forms.ComboBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "地区名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "项目名";
            // 
            // comboBox_projectArea
            // 
            this.comboBox_projectArea.FormattingEnabled = true;
            this.comboBox_projectArea.Location = new System.Drawing.Point(149, 98);
            this.comboBox_projectArea.Name = "comboBox_projectArea";
            this.comboBox_projectArea.Size = new System.Drawing.Size(121, 20);
            this.comboBox_projectArea.TabIndex = 2;
            this.comboBox_projectArea.SelectedIndexChanged += new System.EventHandler(this.comboBox_projectArea_SelectedIndexChanged);
            // 
            // comboBox_projectName
            // 
            this.comboBox_projectName.FormattingEnabled = true;
            this.comboBox_projectName.Location = new System.Drawing.Point(149, 147);
            this.comboBox_projectName.Name = "comboBox_projectName";
            this.comboBox_projectName.Size = new System.Drawing.Size(121, 20);
            this.comboBox_projectName.TabIndex = 3;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(149, 223);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(75, 23);
            this.button_Ok.TabIndex = 4;
            this.button_Ok.Text = "确定";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // SelectProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 348);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.comboBox_projectName);
            this.Controls.Add(this.comboBox_projectArea);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SelectProject";
            this.Text = "SelectProject";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SelectProject_FormClosing);
            this.Load += new System.EventHandler(this.SelectProject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_projectArea;
        private System.Windows.Forms.ComboBox comboBox_projectName;
        private System.Windows.Forms.Button button_Ok;
    }
}