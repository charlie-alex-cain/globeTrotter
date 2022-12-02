namespace Globe_Trotter_project
{
    partial class newEmployeeFr
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
            this.submitbt2 = new System.Windows.Forms.Button();
            this.newRpasstb = new System.Windows.Forms.TextBox();
            this.newpasstb = new System.Windows.Forms.TextBox();
            this.emailtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.surnametb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.backbt4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // submitbt2
            // 
            this.submitbt2.Location = new System.Drawing.Point(38, 300);
            this.submitbt2.Name = "submitbt2";
            this.submitbt2.Size = new System.Drawing.Size(110, 47);
            this.submitbt2.TabIndex = 0;
            this.submitbt2.Text = "submit";
            this.submitbt2.UseVisualStyleBackColor = true;
            this.submitbt2.Click += new System.EventHandler(this.submitbt2_Click);
            // 
            // newRpasstb
            // 
            this.newRpasstb.Location = new System.Drawing.Point(38, 253);
            this.newRpasstb.Name = "newRpasstb";
            this.newRpasstb.Size = new System.Drawing.Size(232, 22);
            this.newRpasstb.TabIndex = 2;
            // 
            // newpasstb
            // 
            this.newpasstb.Location = new System.Drawing.Point(38, 198);
            this.newpasstb.Name = "newpasstb";
            this.newpasstb.Size = new System.Drawing.Size(232, 22);
            this.newpasstb.TabIndex = 3;
            // 
            // emailtb
            // 
            this.emailtb.Location = new System.Drawing.Point(38, 130);
            this.emailtb.Name = "emailtb";
            this.emailtb.Size = new System.Drawing.Size(315, 22);
            this.emailtb.TabIndex = 4;
            this.emailtb.TextChanged += new System.EventHandler(this.emailtb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(146, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Globe Trotter";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Please enter the following details to create your account";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Reapeat password";
            // 
            // surnametb
            // 
            this.surnametb.Location = new System.Drawing.Point(38, 75);
            this.surnametb.Name = "surnametb";
            this.surnametb.Size = new System.Drawing.Size(145, 22);
            this.surnametb.TabIndex = 11;
            this.surnametb.TextChanged += new System.EventHandler(this.surnametb_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Surname";
            // 
            // backbt4
            // 
            this.backbt4.Location = new System.Drawing.Point(282, 300);
            this.backbt4.Name = "backbt4";
            this.backbt4.Size = new System.Drawing.Size(110, 47);
            this.backbt4.TabIndex = 13;
            this.backbt4.Text = "back";
            this.backbt4.UseVisualStyleBackColor = true;
            this.backbt4.Click += new System.EventHandler(this.backbt4_Click);
            // 
            // newEmployeeFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 365);
            this.Controls.Add(this.backbt4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.surnametb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailtb);
            this.Controls.Add(this.newpasstb);
            this.Controls.Add(this.newRpasstb);
            this.Controls.Add(this.submitbt2);
            this.Name = "newEmployeeFr";
            this.Text = "newEmployee";
            this.Load += new System.EventHandler(this.newEmployeeFr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitbt2;
        private System.Windows.Forms.TextBox newRpasstb;
        private System.Windows.Forms.TextBox newpasstb;
        private System.Windows.Forms.TextBox emailtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox surnametb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button backbt4;
    }
}