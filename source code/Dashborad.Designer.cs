namespace demo
{
    partial class Dashborad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashborad));
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.Label();
            this.a3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(91, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Doctor";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(91, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(278, 47);
            this.button3.TabIndex = 2;
            this.button3.Text = "Prescription";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(144, 392);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(151, 47);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // a1
            // 
            this.a1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a1.BackColor = System.Drawing.Color.Transparent;
            this.a1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.a1.Location = new System.Drawing.Point(14, 53);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(46, 35);
            this.a1.TabIndex = 4;
            this.a1.Text = ">>";
            this.a1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // a2
            // 
            this.a2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a2.BackColor = System.Drawing.Color.Transparent;
            this.a2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.a2.Location = new System.Drawing.Point(14, 172);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(46, 35);
            this.a2.TabIndex = 5;
            this.a2.Text = ">>";
            this.a2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // a3
            // 
            this.a3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.a3.BackColor = System.Drawing.Color.Transparent;
            this.a3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.a3.Location = new System.Drawing.Point(14, 282);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(46, 35);
            this.a3.TabIndex = 6;
            this.a3.Text = ">>";
            this.a3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.DisplayMember = "patient";
            this.comboBox1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Patient\'s new record",
            "Patient\'s old record"});
            this.comboBox1.Location = new System.Drawing.Point(91, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(278, 36);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Tag = "";
            this.comboBox1.Text = "              Patients";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Dashborad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(821, 466);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Dashborad";
            this.Text = "Dashborad";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashborad_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label a1;
        private System.Windows.Forms.Label a2;
        private System.Windows.Forms.Label a3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}