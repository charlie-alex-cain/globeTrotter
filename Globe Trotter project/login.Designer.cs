namespace Globe_Trotter_project
{
    partial class loginFr
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
            this.submitbt1 = new System.Windows.Forms.Button();
            this.passwordtb = new System.Windows.Forms.TextBox();
            this.loginIDtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.backbt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitbt1
            // 
            this.submitbt1.Location = new System.Drawing.Point(12, 191);
            this.submitbt1.Name = "submitbt1";
            this.submitbt1.Size = new System.Drawing.Size(86, 45);
            this.submitbt1.TabIndex = 0;
            this.submitbt1.Text = "submit";
            this.submitbt1.UseVisualStyleBackColor = true;
            this.submitbt1.Click += new System.EventHandler(this.submitbt1_Click);
            // 
            // passwordtb
            // 
            this.passwordtb.Location = new System.Drawing.Point(12, 134);
            this.passwordtb.Name = "passwordtb";
            this.passwordtb.Size = new System.Drawing.Size(333, 22);
            this.passwordtb.TabIndex = 1;
            // 
            // loginIDtb
            // 
            this.loginIDtb.Location = new System.Drawing.Point(12, 68);
            this.loginIDtb.Name = "loginIDtb";
            this.loginIDtb.Size = new System.Drawing.Size(333, 22);
            this.loginIDtb.TabIndex = 2;
            this.loginIDtb.TextChanged += new System.EventHandler(this.loginIDtb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter your password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter your employee ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Globe Trotter";
            // 
            // backbt1
            // 
            this.backbt1.Location = new System.Drawing.Point(259, 191);
            this.backbt1.Name = "backbt1";
            this.backbt1.Size = new System.Drawing.Size(86, 45);
            this.backbt1.TabIndex = 6;
            this.backbt1.Text = "back";
            this.backbt1.UseVisualStyleBackColor = true;
            this.backbt1.Click += new System.EventHandler(this.backbt1_Click);
            // 
            // loginFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 254);
            this.Controls.Add(this.backbt1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginIDtb);
            this.Controls.Add(this.passwordtb);
            this.Controls.Add(this.submitbt1);
            this.Name = "loginFr";
            this.Text = "login";
            this.Load += new System.EventHandler(this.loginFr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbt1;
        private System.Windows.Forms.TextBox passwordtb;
        private System.Windows.Forms.TextBox loginIDtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button backbt1;
    }
}