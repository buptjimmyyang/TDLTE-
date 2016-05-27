namespace TD_LTE上行干扰分析系统
{
    partial class ProjectInquire
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
            this.comboBox_projectArea = new System.Windows.Forms.ComboBox();
            this.comboBox_projectName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_inquire = new System.Windows.Forms.Button();
            this.dateTimePicker_endTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_startTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_excel = new System.Windows.Forms.Button();
            this.button_txt = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView_result = new System.Windows.Forms.DataGridView();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_projectArea);
            this.groupBox1.Controls.Add(this.comboBox_projectName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 129);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "请输入查询条件";
            // 
            // comboBox_projectArea
            // 
            this.comboBox_projectArea.FormattingEnabled = true;
            this.comboBox_projectArea.Location = new System.Drawing.Point(92, 105);
            this.comboBox_projectArea.Name = "comboBox_projectArea";
            this.comboBox_projectArea.Size = new System.Drawing.Size(137, 20);
            this.comboBox_projectArea.TabIndex = 4;
            // 
            // comboBox_projectName
            // 
            this.comboBox_projectName.FormattingEnabled = true;
            this.comboBox_projectName.Location = new System.Drawing.Point(92, 30);
            this.comboBox_projectName.Name = "comboBox_projectName";
            this.comboBox_projectName.Size = new System.Drawing.Size(182, 20);
            this.comboBox_projectName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "地区名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "或";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "项目名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_inquire);
            this.groupBox2.Controls.Add(this.dateTimePicker_endTime);
            this.groupBox2.Controls.Add(this.dateTimePicker_startTime);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(37, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 176);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "时间范围";
            // 
            // button_inquire
            // 
            this.button_inquire.Location = new System.Drawing.Point(101, 129);
            this.button_inquire.Name = "button_inquire";
            this.button_inquire.Size = new System.Drawing.Size(75, 23);
            this.button_inquire.TabIndex = 5;
            this.button_inquire.Text = "查询";
            this.button_inquire.UseVisualStyleBackColor = true;
            this.button_inquire.Click += new System.EventHandler(this.button_inquire_Click);
            // 
            // dateTimePicker_endTime
            // 
            this.dateTimePicker_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endTime.Location = new System.Drawing.Point(92, 78);
            this.dateTimePicker_endTime.Name = "dateTimePicker_endTime";
            this.dateTimePicker_endTime.Size = new System.Drawing.Size(129, 21);
            this.dateTimePicker_endTime.TabIndex = 4;
            // 
            // dateTimePicker_startTime
            // 
            this.dateTimePicker_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startTime.Location = new System.Drawing.Point(92, 36);
            this.dateTimePicker_startTime.Name = "dateTimePicker_startTime";
            this.dateTimePicker_startTime.Size = new System.Drawing.Size(129, 21);
            this.dateTimePicker_startTime.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "结束时间";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "开始时间";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_excel);
            this.groupBox3.Controls.Add(this.button_txt);
            this.groupBox3.Location = new System.Drawing.Point(37, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 129);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "导出结果";
            // 
            // button_excel
            // 
            this.button_excel.Location = new System.Drawing.Point(92, 88);
            this.button_excel.Name = "button_excel";
            this.button_excel.Size = new System.Drawing.Size(103, 23);
            this.button_excel.TabIndex = 1;
            this.button_excel.Text = "导出到excel";
            this.button_excel.UseVisualStyleBackColor = true;
            this.button_excel.Click += new System.EventHandler(this.button_excel_Click);
            // 
            // button_txt
            // 
            this.button_txt.Location = new System.Drawing.Point(92, 37);
            this.button_txt.Name = "button_txt";
            this.button_txt.Size = new System.Drawing.Size(103, 23);
            this.button_txt.TabIndex = 0;
            this.button_txt.Text = "导出到txt";
            this.button_txt.UseVisualStyleBackColor = true;
            this.button_txt.Click += new System.EventHandler(this.button_txt_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView_result);
            this.groupBox4.Location = new System.Drawing.Point(351, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 452);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "查询结果";
            // 
            // dataGridView_result
            // 
            this.dataGridView_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_result.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_result.Name = "dataGridView_result";
            this.dataGridView_result.RowTemplate.Height = 23;
            this.dataGridView_result.Size = new System.Drawing.Size(480, 426);
            this.dataGridView_result.TabIndex = 0;
            // 
            // ProjectInquire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 514);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProjectInquire";
            this.Text = "ProjectInquire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProjectInquire_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_result)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_projectArea;
        private System.Windows.Forms.ComboBox comboBox_projectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_inquire;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_startTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_excel;
        private System.Windows.Forms.Button button_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView_result;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}