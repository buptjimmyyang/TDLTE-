namespace TD_LTE上行干扰分析系统
{
    partial class main
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
            this.项目管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.数据库连接ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目创建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.业务管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.项目管理ToolStripMenuItem,
            this.业务管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 项目管理ToolStripMenuItem
            // 
            this.项目管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.数据库连接ToolStripMenuItem,
            this.项目创建ToolStripMenuItem,
            this.项目查询ToolStripMenuItem,
            this.项目删除ToolStripMenuItem});
            this.项目管理ToolStripMenuItem.Name = "项目管理ToolStripMenuItem";
            this.项目管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.项目管理ToolStripMenuItem.Text = "项目管理";
            // 
            // 数据库连接ToolStripMenuItem
            // 
            this.数据库连接ToolStripMenuItem.Name = "数据库连接ToolStripMenuItem";
            this.数据库连接ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.数据库连接ToolStripMenuItem.Text = "数据库连接";
            this.数据库连接ToolStripMenuItem.Click += new System.EventHandler(this.数据库连接ToolStripMenuItem_Click);
            // 
            // 项目创建ToolStripMenuItem
            // 
            this.项目创建ToolStripMenuItem.Name = "项目创建ToolStripMenuItem";
            this.项目创建ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.项目创建ToolStripMenuItem.Text = "项目创建";
            this.项目创建ToolStripMenuItem.Click += new System.EventHandler(this.项目创建ToolStripMenuItem_Click);
            // 
            // 项目查询ToolStripMenuItem
            // 
            this.项目查询ToolStripMenuItem.Name = "项目查询ToolStripMenuItem";
            this.项目查询ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.项目查询ToolStripMenuItem.Text = "项目查询";
            this.项目查询ToolStripMenuItem.Click += new System.EventHandler(this.项目查询ToolStripMenuItem_Click);
            // 
            // 项目删除ToolStripMenuItem
            // 
            this.项目删除ToolStripMenuItem.Name = "项目删除ToolStripMenuItem";
            this.项目删除ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.项目删除ToolStripMenuItem.Text = "项目删除";
            this.项目删除ToolStripMenuItem.Click += new System.EventHandler(this.项目删除ToolStripMenuItem_Click);
            // 
            // 业务管理ToolStripMenuItem
            // 
            this.业务管理ToolStripMenuItem.Name = "业务管理ToolStripMenuItem";
            this.业务管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.业务管理ToolStripMenuItem.Text = "业务管理";
            this.业务管理ToolStripMenuItem.Click += new System.EventHandler(this.业务管理ToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 303);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "main";
            this.Text = "main";
            this.Load += new System.EventHandler(this.main_Load);
            this.SizeChanged += new System.EventHandler(this.main_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 项目管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 数据库连接ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目创建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 业务管理ToolStripMenuItem;
    }
}

