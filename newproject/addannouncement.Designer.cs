namespace newproject
{
    partial class addannouncement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addannouncement));
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msg = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.se = new System.Windows.Forms.RadioButton();
            this.cs = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(497, 3);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(38, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 47;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label8.Location = new System.Drawing.Point(133, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(280, 32);
            this.label8.TabIndex = 54;
            this.label8.Text = "ADD ANNOUNCEMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(156, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "Announcement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(156, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 51;
            this.label1.Text = "Semester";
            // 
            // msg
            // 
            this.msg.Location = new System.Drawing.Point(156, 123);
            this.msg.Multiline = true;
            this.msg.Name = "msg";
            this.msg.Size = new System.Drawing.Size(244, 73);
            this.msg.TabIndex = 49;
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(156, 72);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(94, 23);
            this.ID.TabIndex = 48;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.SeaGreen;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.Location = new System.Drawing.Point(285, 226);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(115, 32);
            this.add.TabIndex = 56;
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
            this.clear.Location = new System.Drawing.Point(156, 226);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(107, 32);
            this.clear.TabIndex = 55;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = false;
            // 
            // se
            // 
            this.se.AutoSize = true;
            this.se.ForeColor = System.Drawing.SystemColors.ControlText;
            this.se.Location = new System.Drawing.Point(467, 167);
            this.se.Name = "se";
            this.se.Size = new System.Drawing.Size(37, 19);
            this.se.TabIndex = 59;
            this.se.TabStop = true;
            this.se.Text = "SE";
            this.se.UseVisualStyleBackColor = true;
            // 
            // cs
            // 
            this.cs.AutoSize = true;
            this.cs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cs.Location = new System.Drawing.Point(410, 167);
            this.cs.Name = "cs";
            this.cs.Size = new System.Drawing.Size(39, 19);
            this.cs.TabIndex = 58;
            this.cs.TabStop = true;
            this.cs.Text = "CS";
            this.cs.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.GhostWhite;
            this.label7.Location = new System.Drawing.Point(410, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Choose Department";
            // 
            // addannouncement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 270);
            this.Controls.Add(this.se);
            this.Controls.Add(this.cs);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msg);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.pictureBox8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addannouncement";
            this.Text = "addannouncement";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox msg;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RadioButton se;
        private System.Windows.Forms.RadioButton cs;
        private System.Windows.Forms.Label label7;
    }
}