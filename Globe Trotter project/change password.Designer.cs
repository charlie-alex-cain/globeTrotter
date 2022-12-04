namespace Globe_Trotter_project
{
    partial class changepassfr
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
            this.submitbt4 = new System.Windows.Forms.Button();
            this.backbt3 = new System.Windows.Forms.Button();
            this.rnewpasstb = new System.Windows.Forms.TextBox();
            this.newpasstb = new System.Windows.Forms.TextBox();
            this.useridtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.oldpasstb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // submitbt4
            // 
            this.submitbt4.Location = new System.Drawing.Point(18, 243);
            this.submitbt4.Name = "submitbt4";
            this.submitbt4.Size = new System.Drawing.Size(110, 53);
            this.submitbt4.TabIndex = 0;
            this.submitbt4.Text = "submit";
            this.submitbt4.UseVisualStyleBackColor = true;
            this.submitbt4.Click += new System.EventHandler(this.submitbt4_Click);
            // 
            // backbt3
            // 
            this.backbt3.Location = new System.Drawing.Point(195, 243);
            this.backbt3.Name = "backbt3";
            this.backbt3.Size = new System.Drawing.Size(110, 53);
            this.backbt3.TabIndex = 1;
            this.backbt3.Text = "back";
            this.backbt3.UseVisualStyleBackColor = true;
            this.backbt3.Click += new System.EventHandler(this.backbt3_Click);
            // 
            // rnewpasstb
            // 
            this.rnewpasstb.Location = new System.Drawing.Point(18, 196);
            this.rnewpasstb.Name = "rnewpasstb";
            this.rnewpasstb.Size = new System.Drawing.Size(215, 22);
            this.rnewpasstb.TabIndex = 2;
            // 
            // newpasstb
            // 
            this.newpasstb.Location = new System.Drawing.Point(18, 152);
            this.newpasstb.Name = "newpasstb";
            this.newpasstb.Size = new System.Drawing.Size(215, 22);
            this.newpasstb.TabIndex = 3;
            // 
            // useridtb
            // 
            this.useridtb.Location = new System.Drawing.Point(18, 55);
            this.useridtb.Name = "useridtb";
            this.useridtb.Size = new System.Drawing.Size(90, 22);
            this.useridtb.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "globe trotter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "repeat new password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "new password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "user ID";
            // 
            // oldpasstb
            // 
            this.oldpasstb.Location = new System.Drawing.Point(18, 108);
            this.oldpasstb.Name = "oldpasstb";
            this.oldpasstb.Size = new System.Drawing.Size(215, 22);
            this.oldpasstb.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "old password";
            // 
            // changepassfr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 308);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.oldpasstb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.useridtb);
            this.Controls.Add(this.newpasstb);
            this.Controls.Add(this.rnewpasstb);
            this.Controls.Add(this.backbt3);
            this.Controls.Add(this.submitbt4);
            this.Name = "changepassfr";
            this.Text = "change password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbt4;
        private System.Windows.Forms.Button backbt3;
        private System.Windows.Forms.TextBox rnewpasstb;
        private System.Windows.Forms.TextBox newpasstb;
        private System.Windows.Forms.TextBox useridtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oldpasstb;
        private System.Windows.Forms.Label label5;
    }
}