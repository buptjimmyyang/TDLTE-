namespace TD_LTE上行干扰分析系统
{
    partial class ImportModelSelectForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.AppendModelButton = new System.Windows.Forms.RadioButton();
            this.OverwriteModelButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.AppendModelButton);
            this.panel1.Controls.Add(this.OverwriteModelButton);
            this.panel1.Location = new System.Drawing.Point(51, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 113);
            this.panel1.TabIndex = 3;
            // 
            // AppendModelButton
            // 
            this.AppendModelButton.AutoSize = true;
            this.AppendModelButton.Location = new System.Drawing.Point(56, 69);
            this.AppendModelButton.Name = "AppendModelButton";
            this.AppendModelButton.Size = new System.Drawing.Size(71, 16);
            this.AppendModelButton.TabIndex = 1;
            this.AppendModelButton.TabStop = true;
            this.AppendModelButton.Text = "添加模式";
            this.AppendModelButton.UseVisualStyleBackColor = true;
            // 
            // OverwriteModelButton
            // 
            this.OverwriteModelButton.AutoSize = true;
            this.OverwriteModelButton.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.OverwriteModelButton.Location = new System.Drawing.Point(56, 23);
            this.OverwriteModelButton.Name = "OverwriteModelButton";
            this.OverwriteModelButton.Size = new System.Drawing.Size(71, 16);
            this.OverwriteModelButton.TabIndex = 0;
            this.OverwriteModelButton.TabStop = true;
            this.OverwriteModelButton.Text = "覆盖模式";
            this.OverwriteModelButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(165, 166);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "取消";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(70, 166);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmButton.TabIndex = 4;
            this.ConfirmButton.Text = "确定";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // ImportModelSelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 215);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.ConfirmButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(326, 253);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(326, 253);
            this.Name = "ImportModelSelectForm";
            this.Text = "ImportModelSelectForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton AppendModelButton;
        private System.Windows.Forms.RadioButton OverwriteModelButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;

    }
}