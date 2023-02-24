namespace newproject
{
    partial class insertstudent
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
            this.ID = new System.Windows.Forms.TextBox();
            this.fname = new System.Windows.Forms.TextBox();
            this.lname = new System.Windows.Forms.TextBox();
            this.phone = new System.Windows.Forms.TextBox();
            this.semester = new System.Windows.Forms.NumericUpDown();
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cs = new System.Windows.Forms.RadioButton();
            this.se = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.semester)).BeginInit();
            this.SuspendLayout();
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(151, 99);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(94, 23);
            this.ID.TabIndex = 0;
            // 
            // fname
            // 
            this.fname.Location = new System.Drawing.Point(21, 152);
            this.fname.Name = "fname";
            this.fname.Size = new System.Drawing.Size(156, 23);
            this.fname.TabIndex = 1;
            // 
            // lname
            // 
            this.lname.Location = new System.Drawing.Point(228, 152);
            this.lname.Name = "lname";
            this.lname.Size = new System.Drawing.Size(165, 23);
            this.lname.TabIndex = 2;
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(21, 217);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(156, 23);
            this.phone.TabIndex = 3;
            // 
            // semester
            // 
            this.semester.Location = new System.Drawing.Point(82, 271);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(271, 23);
            this.semester.TabIndex = 5;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(226, 217);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(167, 23);
            this.email.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(167, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(21, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(228, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(21, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(228, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(183, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gold;
            this.label7.Location = new System.Drawing.Point(151, 315);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Choose Department";
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Red;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Location = new System.Drawing.Point(82, 381);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(107, 32);
            this.clear.TabIndex = 15;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SeaGreen;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(226, 381);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(115, 32);
            this.add.TabIndex = 16;
            this.add.Text = "Insert";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(109, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Add New Student Record";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Coral;
            this.label9.Location = new System.Drawing.Point(378, -4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 37);
            this.label9.TabIndex = 18;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.ForeColor = System.Drawing.Color.Coral;
            this.cs.Location = new System.Drawing.Point(140, 343);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(39, 19);
            this.cs.TabIndex = 19;
            this.cs.TabStop = true;
            this.cs.Text = "CS";
            this.cs.UseVisualStyleBackColor = true;
            // 
            // se
            // 
            this.se.AutoSize = true;
            this.se.ForeColor = System.Drawing.Color.Coral;
            this.se.Location = new System.Drawing.Point(228, 343);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(37, 19);
            this.se.TabIndex = 20;
            this.se.TabStop = true;
            this.se.Text = "SE";
            this.se.UseVisualStyleBackColor = true;
            // 
            // insertstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(410, 436);
            this.Controls.Add(this.se);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.lname);
            this.Controls.Add(this.fname);
            this.Controls.Add(this.ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertstudent";
            this.Text = "insertstudent";
            ((System.ComponentModel.ISupportInitialize)(this.semester)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox fname;
        private System.Windows.Forms.TextBox lname;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.NumericUpDown semester;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton cs;
        private System.Windows.Forms.RadioButton se;
    }
}