namespace TD_LTE上行干扰分析系统
{
    partial class DataDeleteForm
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
            this.dateTimePicker_startTime = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_endTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_delete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_deleteData = new System.Windows.Forms.DataGridView();
            this.button_inquire = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_deleteData)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker_startTime
            // 
            this.dateTimePicker_startTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_startTime.Location = new System.Drawing.Point(96, 32);
            this.dateTimePicker_startTime.Name = "dateTimePicker_startTime";
            this.dateTimePicker_startTime.Size = new System.Drawing.Size(106, 21);
            this.dateTimePicker_startTime.TabIndex = 0;
            // 
            // dateTimePicker_endTime
            // 
            this.dateTimePicker_endTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_endTime.Location = new System.Drawing.Point(96, 159);
            this.dateTimePicker_endTime.Name = "dateTimePicker_endTime";
            this.dateTimePicker_endTime.Size = new System.Drawing.Size(106, 21);
            this.dateTimePicker_endTime.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "开始时间";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "结束时间";
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(155, 324);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 4;
            this.button_delete.Text = "删除";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_inquire);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_delete);
            this.groupBox1.Controls.Add(this.dateTimePicker_startTime);
            this.groupBox1.Controls.Add(this.dateTimePicker_endTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 406);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "删除条件";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_deleteData);
            this.groupBox2.Location = new System.Drawing.Point(376, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(429, 418);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "删除数据";
            // 
            // dataGridView_deleteData
            // 
            this.dataGridView_deleteData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_deleteData.Location = new System.Drawing.Point(6, 20);
            this.dataGridView_deleteData.Name = "dataGridView_deleteData";
            this.dataGridView_deleteData.RowTemplate.Height = 23;
            this.dataGridView_deleteData.Size = new System.Drawing.Size(417, 392);
            this.dataGridView_deleteData.TabIndex = 0;
            // 
            // button_inquire
            // 
            this.button_inquire.Location = new System.Drawing.Point(36, 324);
            this.button_inquire.Name = "button_inquire";
            this.button_inquire.Size = new System.Drawing.Size(75, 23);
            this.button_inquire.TabIndex = 5;
            this.button_inquire.Text = "查看";
            this.button_inquire.UseVisualStyleBackColor = true;
            this.button_inquire.Click += new System.EventHandler(this.button_inquire_Click);
            // 
            // DataDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 451);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "DataDeleteForm";
            this.Text = "DataDeleteForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DataDeleteForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_deleteData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_startTime;
        private System.Windows.Forms.DateTimePicker dateTimePicker_endTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_deleteData;
        private System.Windows.Forms.Button button_inquire;
    }
}