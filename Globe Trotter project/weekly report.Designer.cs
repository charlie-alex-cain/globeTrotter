namespace Globe_Trotter_project
{
    partial class weekreportfr
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
            this.exitbt2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userIDlb = new System.Windows.Forms.Label();
            this.reporttbl = new System.Windows.Forms.DataGridView();
            this.JIDhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Datehd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startlocalhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endlocalhd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distancehd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timehd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.distancelb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timelb = new System.Windows.Forms.Label();
            this.unitstickbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.reporttbl)).BeginInit();
            this.SuspendLayout();
            // 
            // exitbt2
            // 
            this.exitbt2.Location = new System.Drawing.Point(956, 14);
            this.exitbt2.Name = "exitbt2";
            this.exitbt2.Size = new System.Drawing.Size(122, 50);
            this.exitbt2.TabIndex = 0;
            this.exitbt2.Text = "exit";
            this.exitbt2.UseVisualStyleBackColor = true;
            this.exitbt2.Click += new System.EventHandler(this.exitbt2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "weekly report for employee:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "globe trotter";
            // 
            // userIDlb
            // 
            this.userIDlb.AutoSize = true;
            this.userIDlb.Location = new System.Drawing.Point(190, 27);
            this.userIDlb.Name = "userIDlb";
            this.userIDlb.Size = new System.Drawing.Size(46, 16);
            this.userIDlb.TabIndex = 4;
            this.userIDlb.Text = "userID";
            this.userIDlb.Click += new System.EventHandler(this.userIDlb_Click);
            // 
            // reporttbl
            // 
            this.reporttbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reporttbl.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JIDhd,
            this.Datehd,
            this.startlocalhd,
            this.endlocalhd,
            this.distancehd,
            this.timehd});
            this.reporttbl.Location = new System.Drawing.Point(12, 80);
            this.reporttbl.Name = "reporttbl";
            this.reporttbl.RowHeadersWidth = 51;
            this.reporttbl.RowTemplate.Height = 24;
            this.reporttbl.Size = new System.Drawing.Size(1083, 249);
            this.reporttbl.TabIndex = 5;
            // 
            // JIDhd
            // 
            this.JIDhd.HeaderText = "JournryID";
            this.JIDhd.MinimumWidth = 6;
            this.JIDhd.Name = "JIDhd";
            this.JIDhd.Width = 125;
            // 
            // Datehd
            // 
            this.Datehd.HeaderText = "Date";
            this.Datehd.MinimumWidth = 6;
            this.Datehd.Name = "Datehd";
            this.Datehd.Width = 125;
            // 
            // startlocalhd
            // 
            this.startlocalhd.HeaderText = "Start location";
            this.startlocalhd.MinimumWidth = 6;
            this.startlocalhd.Name = "startlocalhd";
            this.startlocalhd.Width = 125;
            // 
            // endlocalhd
            // 
            this.endlocalhd.HeaderText = "End location";
            this.endlocalhd.MinimumWidth = 6;
            this.endlocalhd.Name = "endlocalhd";
            this.endlocalhd.Width = 125;
            // 
            // distancehd
            // 
            this.distancehd.HeaderText = "distance";
            this.distancehd.MinimumWidth = 6;
            this.distancehd.Name = "distancehd";
            this.distancehd.Width = 125;
            // 
            // timehd
            // 
            this.timehd.HeaderText = "Time taken";
            this.timehd.MinimumWidth = 6;
            this.timehd.Name = "timehd";
            this.timehd.Width = 125;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total distance:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // distancelb
            // 
            this.distancelb.AutoSize = true;
            this.distancelb.Location = new System.Drawing.Point(583, 31);
            this.distancelb.Name = "distancelb";
            this.distancelb.Size = new System.Drawing.Size(58, 16);
            this.distancelb.TabIndex = 7;
            this.distancelb.Text = "distance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(713, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total time taken:";
            // 
            // timelb
            // 
            this.timelb.AutoSize = true;
            this.timelb.Location = new System.Drawing.Point(824, 31);
            this.timelb.Name = "timelb";
            this.timelb.Size = new System.Drawing.Size(32, 16);
            this.timelb.TabIndex = 9;
            this.timelb.Text = "time";
            // 
            // unitstickbox
            // 
            this.unitstickbox.AutoSize = true;
            this.unitstickbox.Location = new System.Drawing.Point(15, 54);
            this.unitstickbox.Name = "unitstickbox";
            this.unitstickbox.Size = new System.Drawing.Size(132, 20);
            this.unitstickbox.TabIndex = 10;
            this.unitstickbox.Text = "use imperial units";
            this.unitstickbox.UseVisualStyleBackColor = true;
            // 
            // weekreportfr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 497);
            this.Controls.Add(this.unitstickbox);
            this.Controls.Add(this.timelb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.distancelb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.reporttbl);
            this.Controls.Add(this.userIDlb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitbt2);
            this.Name = "weekreportfr";
            this.Text = "weekly report";
            this.Load += new System.EventHandler(this.weekreportfr_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reporttbl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitbt2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label userIDlb;
        private System.Windows.Forms.DataGridView reporttbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn JIDhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Datehd;
        private System.Windows.Forms.DataGridViewTextBoxColumn startlocalhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn endlocalhd;
        private System.Windows.Forms.DataGridViewTextBoxColumn distancehd;
        private System.Windows.Forms.DataGridViewTextBoxColumn timehd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label distancelb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timelb;
        private System.Windows.Forms.CheckBox unitstickbox;
    }
}