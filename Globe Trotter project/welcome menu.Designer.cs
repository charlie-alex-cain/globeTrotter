namespace Globe_Trotter_project
{
    partial class welcomeFr
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
            this.loginbt = new System.Windows.Forms.Button();
            this.changepassbt = new System.Windows.Forms.Button();
            this.exitbt = new System.Windows.Forms.Button();
            this.newemployeebt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginbt
            // 
            this.loginbt.Location = new System.Drawing.Point(272, 101);
            this.loginbt.Name = "loginbt";
            this.loginbt.Size = new System.Drawing.Size(339, 94);
            this.loginbt.TabIndex = 0;
            this.loginbt.Text = "login";
            this.loginbt.UseVisualStyleBackColor = true;
            this.loginbt.Click += new System.EventHandler(this.loginbt_Click);
            // 
            // changepassbt
            // 
            this.changepassbt.Location = new System.Drawing.Point(272, 201);
            this.changepassbt.Name = "changepassbt";
            this.changepassbt.Size = new System.Drawing.Size(339, 95);
            this.changepassbt.TabIndex = 1;
            this.changepassbt.Text = "Change Password";
            this.changepassbt.UseVisualStyleBackColor = true;
            // 
            // exitbt
            // 
            this.exitbt.Location = new System.Drawing.Point(272, 399);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(339, 93);
            this.exitbt.TabIndex = 2;
            this.exitbt.Text = "Exit";
            this.exitbt.UseVisualStyleBackColor = true;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            // 
            // newemployeebt
            // 
            this.newemployeebt.Location = new System.Drawing.Point(272, 302);
            this.newemployeebt.Name = "newemployeebt";
            this.newemployeebt.Size = new System.Drawing.Size(339, 91);
            this.newemployeebt.TabIndex = 3;
            this.newemployeebt.Text = "New Employee";
            this.newemployeebt.UseVisualStyleBackColor = true;
            this.newemployeebt.Click += new System.EventHandler(this.newemployeebt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(479, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Globe Trotter";
            // 
            // welcomeFr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 517);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.newemployeebt);
            this.Controls.Add(this.exitbt);
            this.Controls.Add(this.changepassbt);
            this.Controls.Add(this.loginbt);
            this.Name = "welcomeFr";
            this.Text = "Welcome menu";
            this.Load += new System.EventHandler(this.welcomeFr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbt;
        private System.Windows.Forms.Button changepassbt;
        private System.Windows.Forms.Button exitbt;
        private System.Windows.Forms.Button newemployeebt;
        private System.Windows.Forms.Label label1;
    }
}

