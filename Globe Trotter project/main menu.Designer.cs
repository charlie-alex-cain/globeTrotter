namespace Globe_Trotter_project
{
    partial class mainfr
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
            this.coordsbt = new System.Windows.Forms.Button();
            this.reportbt = new System.Windows.Forms.Button();
            this.logoutbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.journeyviewbt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // coordsbt
            // 
            this.coordsbt.Location = new System.Drawing.Point(12, 66);
            this.coordsbt.Name = "coordsbt";
            this.coordsbt.Size = new System.Drawing.Size(272, 84);
            this.coordsbt.TabIndex = 0;
            this.coordsbt.Text = "Enter Coordinates";
            this.coordsbt.UseVisualStyleBackColor = true;
            this.coordsbt.Click += new System.EventHandler(this.coordsbt_Click);
            // 
            // reportbt
            // 
            this.reportbt.Location = new System.Drawing.Point(290, 66);
            this.reportbt.Name = "reportbt";
            this.reportbt.Size = new System.Drawing.Size(272, 84);
            this.reportbt.TabIndex = 1;
            this.reportbt.Text = "Weekly Report";
            this.reportbt.UseVisualStyleBackColor = true;
            this.reportbt.Click += new System.EventHandler(this.reportbt_Click);
            // 
            // logoutbt
            // 
            this.logoutbt.Location = new System.Drawing.Point(290, 156);
            this.logoutbt.Name = "logoutbt";
            this.logoutbt.Size = new System.Drawing.Size(272, 84);
            this.logoutbt.TabIndex = 2;
            this.logoutbt.Text = "Logout";
            this.logoutbt.UseVisualStyleBackColor = true;
            this.logoutbt.Click += new System.EventHandler(this.logoutbt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 42);
            this.label1.TabIndex = 3;
            this.label1.Text = "Main Menu Globe Trotter";
            // 
            // journeyviewbt
            // 
            this.journeyviewbt.Location = new System.Drawing.Point(12, 156);
            this.journeyviewbt.Name = "journeyviewbt";
            this.journeyviewbt.Size = new System.Drawing.Size(272, 84);
            this.journeyviewbt.TabIndex = 4;
            this.journeyviewbt.Text = "view a journey";
            this.journeyviewbt.UseVisualStyleBackColor = true;
            this.journeyviewbt.Click += new System.EventHandler(this.journeyviewbt_Click);
            // 
            // mainfr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 253);
            this.Controls.Add(this.journeyviewbt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logoutbt);
            this.Controls.Add(this.reportbt);
            this.Controls.Add(this.coordsbt);
            this.Name = "mainfr";
            this.Text = "main menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button coordsbt;
        private System.Windows.Forms.Button reportbt;
        private System.Windows.Forms.Button logoutbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button journeyviewbt;
    }
}