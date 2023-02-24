namespace newproject
{
    partial class updatecourse
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
            this.chours = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacher = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cname = new System.Windows.Forms.TextBox();
            this.chr = new System.Windows.Forms.NumericUpDown();
            this.cid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chours
            // 
            this.chours.AutoSize = true;
            this.chours.ForeColor = System.Drawing.Color.Gold;
            this.chours.Location = new System.Drawing.Point(44, 227);
            this.chours.Name = "chours";
            this.chours.Size = new System.Drawing.Size(74, 15);
            this.chours.TabIndex = 33;
            this.chours.Text = "Credit Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(44, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Teacher Id";
            // 
            // teacher
            // 
            this.teacher.FormattingEnabled = true;
            this.teacher.Location = new System.Drawing.Point(44, 188);
            this.teacher.Name = "teacher";
            this.teacher.Size = new System.Drawing.Size(226, 23);
            this.teacher.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(46, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(44, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Course Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(49, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Course Id";
            // 
            // cname
            // 
            this.cname.Location = new System.Drawing.Point(44, 132);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(224, 23);
            this.cname.TabIndex = 27;
            // 
            // chr
            // 
            this.chr.Location = new System.Drawing.Point(44, 245);
            this.chr.Name = "chr";
            this.chr.Size = new System.Drawing.Size(226, 23);
            this.chr.TabIndex = 26;
            // 
            // cid
            // 
            this.cid.Location = new System.Drawing.Point(44, 85);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(226, 23);
            this.cid.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(356, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(461, 304);
            this.dataGridView1.TabIndex = 34;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(320, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 21);
            this.label8.TabIndex = 35;
            this.label8.Text = "UPDATE THE COURSES";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(462, 427);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 32);
            this.button2.TabIndex = 45;
            this.button2.Text = "Refresh the list";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(349, 427);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(107, 32);
            this.clear.TabIndex = 44;
            this.clear.Text = "DELETE";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(349, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 15);
            this.label9.TabIndex = 43;
            this.label9.Text = "Delete this Record";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(347, 398);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(167, 23);
            this.delete.TabIndex = 42;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(14, 306);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 32);
            this.button3.TabIndex = 47;
            this.button3.Text = "Clear Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(178, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 32);
            this.button1.TabIndex = 46;
            this.button1.Text = "Update Record";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.label1.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(816, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 32);
            this.label1.TabIndex = 54;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // updatecourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(846, 471);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chours);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacher);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.chr);
            this.Controls.Add(this.cid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "updatecourse";
            this.Text = "updatecourse";
            ((System.ComponentModel.ISupportInitialize)(this.chr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox teacher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cname;
        private System.Windows.Forms.NumericUpDown chr;
        private System.Windows.Forms.TextBox cid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox delete;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}