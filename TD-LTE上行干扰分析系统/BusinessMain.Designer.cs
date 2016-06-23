namespace TD_LTE上行干扰分析系统
{
    partial class BusinessMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.数据管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.建模样本导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.建模样本删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.识别数据导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.识别数据导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(520, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 数据管理ToolStripMenuItem
            // 
            this.数据管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.建模样本导入ToolStripMenuItem,
            this.建模样本删除ToolStripMenuItem,
            this.识别数据导入ToolStripMenuItem,
            this.识别数据导出ToolStripMenuItem});
            this.数据管理ToolStripMenuItem.Name = "数据管理ToolStripMenuItem";
            this.数据管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.数据管理ToolStripMenuItem.Text = "数据管理";
            // 
            // 建模样本导入ToolStripMenuItem
            // 
            this.建模样本导入ToolStripMenuItem.Name = "建模样本导入ToolStripMenuItem";
            this.建模样本导入ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.建模样本导入ToolStripMenuItem.Text = "建模样本导入";
            this.建模样本导入ToolStripMenuItem.Click += new System.EventHandler(this.建模样本导入ToolStripMenuItem_Click);
            // 
            // 建模样本删除ToolStripMenuItem
            // 
            this.建模样本删除ToolStripMenuItem.Name = "建模样本删除ToolStripMenuItem";
            this.建模样本删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.建模样本删除ToolStripMenuItem.Text = "建模样本删除";
            this.建模样本删除ToolStripMenuItem.Click += new System.EventHandler(this.建模样本删除ToolStripMenuItem_Click);
            // 
            // 识别数据导入ToolStripMenuItem
            // 
            this.识别数据导入ToolStripMenuItem.Name = "识别数据导入ToolStripMenuItem";
            this.识别数据导入ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.识别数据导入ToolStripMenuItem.Text = "识别数据导入";
            this.识别数据导入ToolStripMenuItem.Click += new System.EventHandler(this.识别数据导入ToolStripMenuItem_Click);
            // 
            // 识别数据导出ToolStripMenuItem
            // 
            this.识别数据导出ToolStripMenuItem.Name = "识别数据导出ToolStripMenuItem";
            this.识别数据导出ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.识别数据导出ToolStripMenuItem.Text = "识别数据删除";
            this.识别数据导出ToolStripMenuItem.Click += new System.EventHandler(this.识别数据导出ToolStripMenuItem_Click);
            // 
            // BusinessMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 418);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BusinessMain";
            this.Text = "BusinessMain";
            this.Load += new System.EventHandler(this.BusinessMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 数据管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 建模样本导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 建模样本删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 识别数据导入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 识别数据导出ToolStripMenuItem;
    }
}