namespace newproject
{
    partial class Classstatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Classstatus));
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.courselist = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.gridview = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.quizez = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.Yellow;
            this.radioButton1.Location = new System.Drawing.Point(66, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Assignment";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.MouseLeave += new System.EventHandler(this.radioButton1_MouseLeave);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.Blue;
            this.radioButton2.Location = new System.Drawing.Point(177, 98);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(60, 19);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Quizez";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.MouseLeave += new System.EventHandler(this.radioButton2_MouseLeave);
            // 
            // courselist
            // 
            this.courselist.FormattingEnabled = true;
            this.courselist.Items.AddRange(new object[] {
            "All",
            "Below average"});
            this.courselist.Location = new System.Drawing.Point(312, 100);
            this.courselist.Name = "courselist";
            this.courselist.Size = new System.Drawing.Size(322, 23);
            this.courselist.TabIndex = 68;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(640, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 67;
            this.button1.Text = "Refresh List";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(719, 5);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(38, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 69;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // gridview
            // 
            this.gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridview.Location = new System.Drawing.Point(23, 129);
            this.gridview.Name = "gridview";
            this.gridview.RowTemplate.Height = 25;
            this.gridview.Size = new System.Drawing.Size(704, 250);
            this.gridview.TabIndex = 70;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.label8.Font = new System.Drawing.Font("Cambria", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(218, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 32);
            this.label8.TabIndex = 71;
            this.label8.Text = "Students Report";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SeaGreen;
            this.panel2.Controls.Add(this.quizez);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(168, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 73);
            this.panel2.TabIndex = 72;
            // 
            // quizez
            // 
            this.quizez.AutoSize = true;
            this.quizez.Font = new System.Drawing.Font("Nirmala UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.quizez.ForeColor = System.Drawing.Color.Brown;
            this.quizez.Location = new System.Drawing.Point(0, 6);
            this.quizez.Name = "quizez";
            this.quizez.Size = new System.Drawing.Size(92, 72);
            this.quizez.TabIndex = 1;
            this.quizez.Text = "34";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(86, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(249, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student are below average";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(525, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 40);
            this.button2.TabIndex = 73;
            this.button2.Text = "Download the list";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Classstatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(758, 494);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gridview);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.courselist);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Classstatus";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Classstatus";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridview)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox courselist;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.DataGridView gridview;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label quizez;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Button button2;
    }
}