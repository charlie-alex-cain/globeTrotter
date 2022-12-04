namespace Globe_Trotter_project
{
    partial class journeyviewfr
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.backbt6 = new System.Windows.Forms.Button();
            this.journeydetailsgb = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.distancelb = new System.Windows.Forms.Label();
            this.datelb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.location2lb = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.location1lb = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.enteridgb = new System.Windows.Forms.GroupBox();
            this.submitbt5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.journeyfinderwb = new System.Windows.Forms.WebBrowser();
            this.journeyiddd = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.journeydetailsgb.SuspendLayout();
            this.enteridgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.backbt6);
            this.splitContainer1.Panel1.Controls.Add(this.journeydetailsgb);
            this.splitContainer1.Panel1.Controls.Add(this.enteridgb);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.journeyfinderwb);
            this.splitContainer1.Size = new System.Drawing.Size(855, 507);
            this.splitContainer1.SplitterDistance = 217;
            this.splitContainer1.TabIndex = 0;
            // 
            // backbt6
            // 
            this.backbt6.Location = new System.Drawing.Point(3, 295);
            this.backbt6.Name = "backbt6";
            this.backbt6.Size = new System.Drawing.Size(64, 35);
            this.backbt6.TabIndex = 12;
            this.backbt6.Text = "back";
            this.backbt6.UseVisualStyleBackColor = true;
            this.backbt6.Click += new System.EventHandler(this.backbt6_Click);
            // 
            // journeydetailsgb
            // 
            this.journeydetailsgb.Controls.Add(this.button1);
            this.journeydetailsgb.Controls.Add(this.label2);
            this.journeydetailsgb.Controls.Add(this.distancelb);
            this.journeydetailsgb.Controls.Add(this.datelb);
            this.journeydetailsgb.Controls.Add(this.label6);
            this.journeydetailsgb.Controls.Add(this.location2lb);
            this.journeydetailsgb.Controls.Add(this.label8);
            this.journeydetailsgb.Controls.Add(this.location1lb);
            this.journeydetailsgb.Controls.Add(this.label10);
            this.journeydetailsgb.Location = new System.Drawing.Point(15, 124);
            this.journeydetailsgb.Name = "journeydetailsgb";
            this.journeydetailsgb.Size = new System.Drawing.Size(188, 156);
            this.journeydetailsgb.TabIndex = 1;
            this.journeydetailsgb.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "done";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.UseWaitCursor = true;
            this.button1.Click += new System.EventHandler(this.donebt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "distance:";
            // 
            // distancelb
            // 
            this.distancelb.AutoSize = true;
            this.distancelb.Location = new System.Drawing.Point(84, 104);
            this.distancelb.Name = "distancelb";
            this.distancelb.Size = new System.Drawing.Size(78, 16);
            this.distancelb.TabIndex = 13;
            this.distancelb.Text = "globe trotter";
            // 
            // datelb
            // 
            this.datelb.AutoSize = true;
            this.datelb.Location = new System.Drawing.Point(84, 76);
            this.datelb.Name = "datelb";
            this.datelb.Size = new System.Drawing.Size(78, 16);
            this.datelb.TabIndex = 14;
            this.datelb.Text = "globe trotter";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "date:";
            // 
            // location2lb
            // 
            this.location2lb.AutoSize = true;
            this.location2lb.Location = new System.Drawing.Point(90, 43);
            this.location2lb.Name = "location2lb";
            this.location2lb.Size = new System.Drawing.Size(78, 16);
            this.location2lb.TabIndex = 16;
            this.location2lb.Text = "globe trotter";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 16);
            this.label8.TabIndex = 17;
            this.label8.Text = "end location:";
            // 
            // location1lb
            // 
            this.location1lb.AutoSize = true;
            this.location1lb.Location = new System.Drawing.Point(90, 18);
            this.location1lb.Name = "location1lb";
            this.location1lb.Size = new System.Drawing.Size(78, 16);
            this.location1lb.TabIndex = 18;
            this.location1lb.Text = "globe trotter";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 16);
            this.label10.TabIndex = 19;
            this.label10.Text = "start location:";
            // 
            // enteridgb
            // 
            this.enteridgb.Controls.Add(this.journeyiddd);
            this.enteridgb.Controls.Add(this.submitbt5);
            this.enteridgb.Controls.Add(this.label4);
            this.enteridgb.Location = new System.Drawing.Point(6, 50);
            this.enteridgb.Name = "enteridgb";
            this.enteridgb.Size = new System.Drawing.Size(203, 49);
            this.enteridgb.TabIndex = 11;
            this.enteridgb.TabStop = false;
            // 
            // submitbt5
            // 
            this.submitbt5.Location = new System.Drawing.Point(136, 13);
            this.submitbt5.Name = "submitbt5";
            this.submitbt5.Size = new System.Drawing.Size(61, 30);
            this.submitbt5.TabIndex = 11;
            this.submitbt5.Text = "submit";
            this.submitbt5.UseVisualStyleBackColor = true;
            this.submitbt5.UseWaitCursor = true;
            this.submitbt5.Click += new System.EventHandler(this.submitbt5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "enter a journey ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "globe trotter";
            // 
            // journeyfinderwb
            // 
            this.journeyfinderwb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.journeyfinderwb.Location = new System.Drawing.Point(0, 0);
            this.journeyfinderwb.MinimumSize = new System.Drawing.Size(20, 20);
            this.journeyfinderwb.Name = "journeyfinderwb";
            this.journeyfinderwb.Size = new System.Drawing.Size(634, 507);
            this.journeyfinderwb.TabIndex = 0;
            // 
            // journeyiddd
            // 
            this.journeyiddd.FormattingEnabled = true;
            this.journeyiddd.Location = new System.Drawing.Point(6, 25);
            this.journeyiddd.Name = "journeyiddd";
            this.journeyiddd.Size = new System.Drawing.Size(108, 24);
            this.journeyiddd.TabIndex = 1;
            // 
            // journeyviewfr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 507);
            this.Controls.Add(this.splitContainer1);
            this.Name = "journeyviewfr";
            this.Text = "Journey viewer";
            this.Load += new System.EventHandler(this.journeyviewfr_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.journeydetailsgb.ResumeLayout(false);
            this.journeydetailsgb.PerformLayout();
            this.enteridgb.ResumeLayout(false);
            this.enteridgb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox journeydetailsgb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label distancelb;
        private System.Windows.Forms.Label datelb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label location2lb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label location1lb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox enteridgb;
        private System.Windows.Forms.Button submitbt5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.WebBrowser journeyfinderwb;
        private System.Windows.Forms.Button backbt6;
        private System.Windows.Forms.ComboBox journeyiddd;
    }
}