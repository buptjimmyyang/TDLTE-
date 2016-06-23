namespace TD_LTE上行干扰分析系统
{
    partial class ImportMainForm
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
            this.importButton = new System.Windows.Forms.Button();
            this.excelFieldList = new System.Windows.Forms.ListBox();
            this.obtainFieldButton = new System.Windows.Forms.Button();
            this.browserButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFile = new System.Windows.Forms.TextBox();
            this.downButton = new System.Windows.Forms.Button();
            this.upButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.databaseFieldList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(344, 443);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(75, 23);
            this.importButton.TabIndex = 18;
            this.importButton.Text = "import";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // excelFieldList
            // 
            this.excelFieldList.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.excelFieldList.FormattingEnabled = true;
            this.excelFieldList.ItemHeight = 16;
            this.excelFieldList.Location = new System.Drawing.Point(454, 110);
            this.excelFieldList.Name = "excelFieldList";
            this.excelFieldList.Size = new System.Drawing.Size(311, 356);
            this.excelFieldList.TabIndex = 17;
            this.excelFieldList.SelectedIndexChanged += new System.EventHandler(this.excelFieldList_SelectedIndexChanged);
            // 
            // obtainFieldButton
            // 
            this.obtainFieldButton.Location = new System.Drawing.Point(425, 36);
            this.obtainFieldButton.Name = "obtainFieldButton";
            this.obtainFieldButton.Size = new System.Drawing.Size(128, 24);
            this.obtainFieldButton.TabIndex = 15;
            this.obtainFieldButton.Text = "获取excel表格字段";
            this.obtainFieldButton.UseVisualStyleBackColor = true;
            this.obtainFieldButton.Click += new System.EventHandler(this.obtainFieldButton_Click);
            // 
            // browserButton
            // 
            this.browserButton.Location = new System.Drawing.Point(344, 37);
            this.browserButton.Name = "browserButton";
            this.browserButton.Size = new System.Drawing.Size(75, 23);
            this.browserButton.TabIndex = 14;
            this.browserButton.Text = "浏览...";
            this.browserButton.UseVisualStyleBackColor = true;
            this.browserButton.Click += new System.EventHandler(this.browserButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(136, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "文件路径：";
            // 
            // txtFile
            // 
            this.txtFile.Location = new System.Drawing.Point(215, 39);
            this.txtFile.Name = "txtFile";
            this.txtFile.Size = new System.Drawing.Size(123, 21);
            this.txtFile.TabIndex = 12;
            // 
            // downButton
            // 
            this.downButton.Location = new System.Drawing.Point(344, 231);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(75, 23);
            this.downButton.TabIndex = 11;
            this.downButton.Text = "down";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // upButton
            // 
            this.upButton.Location = new System.Drawing.Point(344, 166);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 10;
            this.upButton.Text = "up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(344, 300);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 19;
            this.removeButton.Text = "remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // databaseFieldList
            // 
            this.databaseFieldList.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.databaseFieldList.FormattingEnabled = true;
            this.databaseFieldList.ItemHeight = 16;
            this.databaseFieldList.Location = new System.Drawing.Point(77, 110);
            this.databaseFieldList.Name = "databaseFieldList";
            this.databaseFieldList.Size = new System.Drawing.Size(238, 356);
            this.databaseFieldList.TabIndex = 16;
            this.databaseFieldList.SelectedIndexChanged += new System.EventHandler(this.databaseFieldList_SelectedIndexChanged);
            // 
            // ImportMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 504);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.excelFieldList);
            this.Controls.Add(this.obtainFieldButton);
            this.Controls.Add(this.browserButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFile);
            this.Controls.Add(this.downButton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.databaseFieldList);
            this.Name = "ImportMainForm";
            this.Text = "数据导入";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.ListBox excelFieldList;
        private System.Windows.Forms.Button obtainFieldButton;
        private System.Windows.Forms.Button browserButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFile;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.ListBox databaseFieldList;
    }
}

