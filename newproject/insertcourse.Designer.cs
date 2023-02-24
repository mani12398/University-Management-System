namespace newproject
{
    partial class insertcourse
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.TextBox();
            this.chr = new System.Windows.Forms.NumericUpDown();
            this.cid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sem = new System.Windows.Forms.NumericUpDown();
            this.teacher = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chours = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sem)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(138, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(136, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(141, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "Course Id";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(136, 138);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(224, 23);
            this.cname.TabIndex = 16;
            // 
            // chr
            // 
            this.chr.Location = new System.Drawing.Point(136, 251);
            this.chr.Name = "chr";
            this.chr.Size = new System.Drawing.Size(226, 23);
            this.chr.TabIndex = 15;
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(136, 91);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(226, 23);
            this.cid.TabIndex = 14;
            this.cid.TextChanged += new System.EventHandler(this.phone_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(138, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Semester";
            // 
            // sem
            // 
            this.sem.Location = new System.Drawing.Point(136, 298);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(226, 23);
            this.sem.TabIndex = 20;
            // 
            // teacher
            // 
            this.teacher.FormattingEnabled = true;
            this.teacher.Location = new System.Drawing.Point(136, 194);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(226, 23);
            this.teacher.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(136, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Teacher Id";
            // 
            // chours
            // 
            this.chours.AutoSize = true;
            this.chours.ForeColor = System.Drawing.Color.Gold;
            this.chours.Location = new System.Drawing.Point(136, 233);
            this.chours.Name = "chours";
            this.chours.Size = new System.Drawing.Size(74, 15);
            this.chours.TabIndex = 24;
            this.chours.Text = "Credit Hours";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(190, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 21);
            this.label8.TabIndex = 25;
            this.label8.Text = "Add New Course";
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SeaGreen;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(263, 349);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(115, 32);
            this.add.TabIndex = 27;
            this.add.Text = "Insert";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(119, 349);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(107, 32);
            this.clear.TabIndex = 26;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(506, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 32);
            this.label3.TabIndex = 54;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // insertcourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(535, 402);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.chours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.chr);
            this.Controls.Add(this.cid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertcourse";
            this.Text = "insertcourse";
            ((System.ComponentModel.ISupportInitialize)(this.chr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.NumericUpDown chr;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown sem;
        private System.Windows.Forms.ComboBox teacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label chours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label3;
    }
}