namespace newproject
{
    partial class insertteacher
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
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tnum = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tname = new System.Windows.Forms.TextBox();
            this.tid = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(560, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 32);
            this.label3.TabIndex = 63;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(205, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 21);
            this.label8.TabIndex = 62;
            this.label8.Text = "Add New Teacher";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(168, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 61;
            this.label2.Text = "Phone number";
            // 
            // tnum
            // 
            this.tnum.FormattingEnabled = true;
            this.tnum.Location = new System.Drawing.Point(168, 220);
            this.tnum.Name = "tnum";
            this.tnum.Size = new System.Drawing.Size(226, 23);
            this.tnum.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(170, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(168, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 58;
            this.label5.Text = "Teacher  Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(173, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 57;
            this.label4.Text = "Teacher Id";
            // 
            // tname
            // 
            this.tname.Location = new System.Drawing.Point(168, 164);
            this.tname.Name = "tname";
            this.tname.Size = new System.Drawing.Size(224, 23);
            this.tname.TabIndex = 56;
            // 
            // tid
            // 
            this.tid.Location = new System.Drawing.Point(168, 117);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(226, 23);
            this.tid.TabIndex = 55;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SeaGreen;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(291, 285);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(115, 32);
            this.add.TabIndex = 65;
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
            this.clear.Location = new System.Drawing.Point(147, 285);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(107, 32);
            this.clear.TabIndex = 64;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // insertteacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(592, 339);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tname);
            this.Controls.Add(this.tid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "insertteacher";
            this.Text = "insertteacher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tnum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tname;
        private System.Windows.Forms.TextBox tid;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
    }
}