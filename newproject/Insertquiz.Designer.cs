namespace newproject
{
    partial class Insertquiz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Insertquiz));
            this.quiznum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tid = new System.Windows.Forms.Label();
            this.teacherid = new System.Windows.Forms.TextBox();
            this.sid = new System.Windows.Forms.Label();
            this.studentid = new System.Windows.Forms.TextBox();
            this.cid = new System.Windows.Forms.Label();
            this.courseid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tmarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.omarks = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.guna2DataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // quiznum
            // 
            this.quiznum.Location = new System.Drawing.Point(43, 88);
            this.quiznum.Name = "quiznum";
            this.quiznum.Size = new System.Drawing.Size(78, 23);
            this.quiznum.TabIndex = 0;
            this.quiznum.TextChanged += new System.EventHandler(this.quiznum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(43, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Quiz Number";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tid
            // 
            this.tid.AutoSize = true;
            this.tid.ForeColor = System.Drawing.Color.Gold;
            this.tid.Location = new System.Drawing.Point(127, 70);
            this.tid.Name = "tid";
            this.tid.Size = new System.Drawing.Size(60, 15);
            this.tid.TabIndex = 13;
            this.tid.Text = "Teacher Id";
            this.tid.Click += new System.EventHandler(this.tid_Click);
            // 
            // teacherid
            // 
            this.teacherid.Location = new System.Drawing.Point(127, 88);
            this.teacherid.Name = "teacherid";
            this.teacherid.Size = new System.Drawing.Size(79, 23);
            this.teacherid.TabIndex = 12;
            this.teacherid.TextChanged += new System.EventHandler(this.teacherid_TextChanged);
            // 
            // sid
            // 
            this.sid.AutoSize = true;
            this.sid.ForeColor = System.Drawing.Color.Gold;
            this.sid.Location = new System.Drawing.Point(43, 158);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(61, 15);
            this.sid.TabIndex = 17;
            this.sid.Text = "Student Id";
            this.sid.Click += new System.EventHandler(this.sid_Click);
            // 
            // studentid
            // 
            this.studentid.Location = new System.Drawing.Point(43, 176);
            this.studentid.Name = "studentid";
            this.studentid.Size = new System.Drawing.Size(133, 23);
            this.studentid.TabIndex = 16;
            this.studentid.TextChanged += new System.EventHandler(this.studentid_TextChanged);
            // 
            // cid
            // 
            this.cid.AutoSize = true;
            this.cid.ForeColor = System.Drawing.Color.Gold;
            this.cid.Location = new System.Drawing.Point(43, 114);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(57, 15);
            this.cid.TabIndex = 15;
            this.cid.Text = "Course Id";
            this.cid.Click += new System.EventHandler(this.cid_Click);
            // 
            // courseid
            // 
            this.courseid.Location = new System.Drawing.Point(43, 132);
            this.courseid.Name = "courseid";
            this.courseid.Size = new System.Drawing.Size(133, 23);
            this.courseid.TabIndex = 14;
            this.courseid.TextChanged += new System.EventHandler(this.courseid_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(139, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total Marks";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tmarks
            // 
            this.tmarks.Location = new System.Drawing.Point(139, 220);
            this.tmarks.Name = "tmarks";
            this.tmarks.Size = new System.Drawing.Size(71, 23);
            this.tmarks.TabIndex = 20;
            this.tmarks.TextChanged += new System.EventHandler(this.tmarks_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(43, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 19;
            this.label6.Text = "Obtained Marks";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // omarks
            // 
            this.omarks.Location = new System.Drawing.Point(43, 220);
            this.omarks.Name = "omarks";
            this.omarks.Size = new System.Drawing.Size(90, 23);
            this.omarks.TabIndex = 18;
            this.omarks.TextChanged += new System.EventHandler(this.omarks_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Variable Small Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(252, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(136, 21);
            this.label8.TabIndex = 23;
            this.label8.Text = "ADD QUIZ MARKS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SeaGreen;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(43, 283);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(163, 35);
            this.add.TabIndex = 24;
            this.add.Text = "Insert";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.Location = new System.Drawing.Point(232, 88);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowTemplate.Height = 25;
            this.guna2DataGridView1.Size = new System.Drawing.Size(489, 264);
            this.guna2DataGridView1.TabIndex = 25;
            this.guna2DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.guna2DataGridView1_CellContentClick);
            this.guna2DataGridView1.Click += new System.EventHandler(this.guna2DataGridView1_Click_1);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(760, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(38, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // Insertquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tmarks);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.omarks);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.studentid);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.courseid);
            this.Controls.Add(this.tid);
            this.Controls.Add(this.teacherid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quiznum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Insertquiz";
            this.Text = "Insertquiz";
            this.Load += new System.EventHandler(this.Insertquiz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox quiznum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label tid;
        private System.Windows.Forms.TextBox teacherid;
        private System.Windows.Forms.Label sid;
        private System.Windows.Forms.TextBox studentid;
        private System.Windows.Forms.Label cid;
        private System.Windows.Forms.TextBox courseid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tmarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox omarks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.DataGridView guna2DataGridView1;
        private System.Windows.Forms.PictureBox pictureBox8;
    }
}