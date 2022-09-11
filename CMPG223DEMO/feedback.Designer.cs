namespace CMPG223DEMO
{
    partial class feedback
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
            this.email = new System.Windows.Forms.Label();
            this.ratings = new System.Windows.Forms.Label();
            this.comments = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.ratingsBox = new System.Windows.Forms.TextBox();
            this.commentsBox = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(0, 75);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(109, 20);
            this.email.TabIndex = 0;
            this.email.Text = "Current email*";
            // 
            // ratings
            // 
            this.ratings.AutoSize = true;
            this.ratings.Location = new System.Drawing.Point(0, 116);
            this.ratings.Name = "ratings";
            this.ratings.Size = new System.Drawing.Size(70, 20);
            this.ratings.TabIndex = 1;
            this.ratings.Text = "Ratings*";
            // 
            // comments
            // 
            this.comments.AutoSize = true;
            this.comments.Location = new System.Drawing.Point(0, 159);
            this.comments.Name = "comments";
            this.comments.Size = new System.Drawing.Size(86, 20);
            this.comments.TabIndex = 2;
            this.comments.Text = "Comments";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(111, 72);
            this.emailBox.MaxLength = 100;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(293, 26);
            this.emailBox.TabIndex = 3;
            // 
            // ratingsBox
            // 
            this.ratingsBox.Location = new System.Drawing.Point(111, 113);
            this.ratingsBox.Name = "ratingsBox";
            this.ratingsBox.Size = new System.Drawing.Size(293, 26);
            this.ratingsBox.TabIndex = 4;
            // 
            // commentsBox
            // 
            this.commentsBox.Location = new System.Drawing.Point(111, 156);
            this.commentsBox.MaxLength = 500;
            this.commentsBox.Name = "commentsBox";
            this.commentsBox.Size = new System.Drawing.Size(293, 96);
            this.commentsBox.TabIndex = 6;
            this.commentsBox.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = " PATIENT Feed Back FORM";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(392, 44);
            this.button1.TabIndex = 27;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(412, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.commentsBox);
            this.Controls.Add(this.ratingsBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.comments);
            this.Controls.Add(this.ratings);
            this.Controls.Add(this.email);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(438, 389);
            this.Name = "feedback";
            this.Text = "feedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label ratings;
        private System.Windows.Forms.Label comments;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox ratingsBox;
        private System.Windows.Forms.RichTextBox commentsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}