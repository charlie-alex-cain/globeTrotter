namespace Globe_Trotter_project
{
    partial class coordsfr
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
            this.long_coordstb = new System.Windows.Forms.TextBox();
            this.lat_coordstb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.locationnametb = new System.Windows.Forms.TextBox();
            this.frequentlocaltickbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.submitbt3 = new System.Windows.Forms.Button();
            this.coordsgb = new System.Windows.Forms.GroupBox();
            this.freqlocalgb = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.freqlocaldd = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startcoordstickbox = new System.Windows.Forms.CheckBox();
            this.backbt2 = new System.Windows.Forms.Button();
            this.coordsgb.SuspendLayout();
            this.freqlocalgb.SuspendLayout();
            this.SuspendLayout();
            // 
            // long_coordstb
            // 
            this.long_coordstb.Location = new System.Drawing.Point(9, 37);
            this.long_coordstb.Name = "long_coordstb";
            this.long_coordstb.Size = new System.Drawing.Size(206, 22);
            this.long_coordstb.TabIndex = 0;
            this.long_coordstb.TextChanged += new System.EventHandler(this.long_coordstb_TextChanged);
            // 
            // lat_coordstb
            // 
            this.lat_coordstb.Location = new System.Drawing.Point(9, 81);
            this.lat_coordstb.Name = "lat_coordstb";
            this.lat_coordstb.Size = new System.Drawing.Size(206, 22);
            this.lat_coordstb.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "longitude coordinates";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "latitude coordinates";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "name of location";
            // 
            // locationnametb
            // 
            this.locationnametb.Location = new System.Drawing.Point(9, 125);
            this.locationnametb.Name = "locationnametb";
            this.locationnametb.Size = new System.Drawing.Size(206, 22);
            this.locationnametb.TabIndex = 5;
            // 
            // frequentlocaltickbox
            // 
            this.frequentlocaltickbox.AutoSize = true;
            this.frequentlocaltickbox.Location = new System.Drawing.Point(0, 41);
            this.frequentlocaltickbox.Name = "frequentlocaltickbox";
            this.frequentlocaltickbox.Size = new System.Drawing.Size(152, 20);
            this.frequentlocaltickbox.TabIndex = 6;
            this.frequentlocaltickbox.Text = "use frequent location";
            this.frequentlocaltickbox.UseVisualStyleBackColor = true;
            this.frequentlocaltickbox.CheckedChanged += new System.EventHandler(this.frequentlocaltickbox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Globe Trotter";
            // 
            // submitbt3
            // 
            this.submitbt3.Location = new System.Drawing.Point(13, 281);
            this.submitbt3.Name = "submitbt3";
            this.submitbt3.Size = new System.Drawing.Size(118, 48);
            this.submitbt3.TabIndex = 8;
            this.submitbt3.Text = "submit";
            this.submitbt3.UseVisualStyleBackColor = true;
            this.submitbt3.Click += new System.EventHandler(this.submitbt3_Click);
            // 
            // coordsgb
            // 
            this.coordsgb.Controls.Add(this.label1);
            this.coordsgb.Controls.Add(this.long_coordstb);
            this.coordsgb.Controls.Add(this.label2);
            this.coordsgb.Controls.Add(this.lat_coordstb);
            this.coordsgb.Controls.Add(this.locationnametb);
            this.coordsgb.Controls.Add(this.label3);
            this.coordsgb.Location = new System.Drawing.Point(37, 103);
            this.coordsgb.Name = "coordsgb";
            this.coordsgb.Size = new System.Drawing.Size(219, 167);
            this.coordsgb.TabIndex = 9;
            this.coordsgb.TabStop = false;
            // 
            // freqlocalgb
            // 
            this.freqlocalgb.Controls.Add(this.label5);
            this.freqlocalgb.Controls.Add(this.freqlocaldd);
            this.freqlocalgb.Location = new System.Drawing.Point(13, 140);
            this.freqlocalgb.Name = "freqlocalgb";
            this.freqlocalgb.Size = new System.Drawing.Size(196, 100);
            this.freqlocalgb.TabIndex = 11;
            this.freqlocalgb.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "frequent location drop-down";
            // 
            // freqlocaldd
            // 
            this.freqlocaldd.FormattingEnabled = true;
            this.freqlocaldd.Location = new System.Drawing.Point(36, 61);
            this.freqlocaldd.Name = "freqlocaldd";
            this.freqlocaldd.Size = new System.Drawing.Size(121, 24);
            this.freqlocaldd.TabIndex = 10;
            this.freqlocaldd.SelectedIndexChanged += new System.EventHandler(this.freqlocaldd_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startcoordstickbox
            // 
            this.startcoordstickbox.AutoSize = true;
            this.startcoordstickbox.Location = new System.Drawing.Point(0, 77);
            this.startcoordstickbox.Name = "startcoordstickbox";
            this.startcoordstickbox.Size = new System.Drawing.Size(268, 20);
            this.startcoordstickbox.TabIndex = 13;
            this.startcoordstickbox.Text = "enter start location or default will be used";
            this.startcoordstickbox.UseVisualStyleBackColor = true;
            // 
            // backbt2
            // 
            this.backbt2.Location = new System.Drawing.Point(151, 281);
            this.backbt2.Name = "backbt2";
            this.backbt2.Size = new System.Drawing.Size(118, 48);
            this.backbt2.TabIndex = 14;
            this.backbt2.Text = "back";
            this.backbt2.UseVisualStyleBackColor = true;
            this.backbt2.Click += new System.EventHandler(this.backbt2_Click);
            // 
            // coordsfr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 341);
            this.Controls.Add(this.backbt2);
            this.Controls.Add(this.startcoordstickbox);
            this.Controls.Add(this.freqlocalgb);
            this.Controls.Add(this.coordsgb);
            this.Controls.Add(this.submitbt3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.frequentlocaltickbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "coordsfr";
            this.Text = "enter coordinates";
            this.Load += new System.EventHandler(this.coordsfr_Load);
            this.coordsgb.ResumeLayout(false);
            this.coordsgb.PerformLayout();
            this.freqlocalgb.ResumeLayout(false);
            this.freqlocalgb.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox long_coordstb;
        private System.Windows.Forms.TextBox lat_coordstb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox locationnametb;
        private System.Windows.Forms.CheckBox frequentlocaltickbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button submitbt3;
        private System.Windows.Forms.GroupBox coordsgb;
        private System.Windows.Forms.ComboBox freqlocaldd;
        private System.Windows.Forms.GroupBox freqlocalgb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.CheckBox startcoordstickbox;
        private System.Windows.Forms.Button backbt2;
    }
}