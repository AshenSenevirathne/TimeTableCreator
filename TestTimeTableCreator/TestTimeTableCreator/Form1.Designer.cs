namespace TestTimeTableCreator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stu = new System.Windows.Forms.Button();
            this.lec = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lct1 = new TestTimeTableCreator.Lct();
            this.std1 = new TestTimeTableCreator.Std();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.stu);
            this.panel1.Controls.Add(this.lec);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(182, 681);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Location = new System.Drawing.Point(0, 34);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 40);
            this.panel4.TabIndex = 5;
            // 
            // stu
            // 
            this.stu.FlatAppearance.BorderSize = 0;
            this.stu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stu.ForeColor = System.Drawing.Color.White;
            this.stu.Image = ((System.Drawing.Image)(resources.GetObject("stu.Image")));
            this.stu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stu.Location = new System.Drawing.Point(0, 75);
            this.stu.Name = "stu";
            this.stu.Size = new System.Drawing.Size(182, 40);
            this.stu.TabIndex = 0;
            this.stu.Text = "Student";
            this.stu.UseVisualStyleBackColor = true;
            this.stu.Click += new System.EventHandler(this.stu_Click);
            // 
            // lec
            // 
            this.lec.FlatAppearance.BorderSize = 0;
            this.lec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lec.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lec.ForeColor = System.Drawing.Color.White;
            this.lec.Image = ((System.Drawing.Image)(resources.GetObject("lec.Image")));
            this.lec.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lec.Location = new System.Drawing.Point(0, 34);
            this.lec.Name = "lec";
            this.lec.Size = new System.Drawing.Size(182, 40);
            this.lec.TabIndex = 0;
            this.lec.Text = "Lecturer";
            this.lec.UseVisualStyleBackColor = true;
            this.lec.Click += new System.EventHandler(this.lec_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(182, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(882, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(207, -8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(96, 99);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Forte", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "TTC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(24, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lct1
            // 
            this.lct1.Location = new System.Drawing.Point(188, 98);
            this.lct1.Name = "lct1";
            this.lct1.Size = new System.Drawing.Size(600, 340);
            this.lct1.TabIndex = 3;
            // 
            // std1
            // 
            this.std1.Location = new System.Drawing.Point(188, 97);
            this.std1.Name = "std1";
            this.std1.Size = new System.Drawing.Size(600, 340);
            this.std1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.std1);
            this.Controls.Add(this.lct1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Time Table Creator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lec;
        private System.Windows.Forms.Button stu;
        private System.Windows.Forms.Panel panel4;
        private Lct lct1;
        private Std std1;
    }
}

