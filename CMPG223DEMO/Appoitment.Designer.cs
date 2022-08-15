
namespace CMPG223DEMO
{
    partial class Appoitment
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timee = new System.Windows.Forms.TextBox();
            this.descr = new System.Windows.Forms.TextBox();
            this.dayy = new System.Windows.Forms.TextBox();
            this.emailTocheck = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.PatientF = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.emailView = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(250, 285);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // timee
            // 
            this.timee.Location = new System.Drawing.Point(242, 69);
            this.timee.Name = "timee";
            this.timee.Size = new System.Drawing.Size(197, 26);
            this.timee.TabIndex = 4;
            // 
            // descr
            // 
            this.descr.Location = new System.Drawing.Point(242, 228);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(197, 26);
            this.descr.TabIndex = 5;
            // 
            // dayy
            // 
            this.dayy.Location = new System.Drawing.Point(242, 173);
            this.dayy.Name = "dayy";
            this.dayy.ReadOnly = true;
            this.dayy.Size = new System.Drawing.Size(197, 26);
            this.dayy.TabIndex = 6;
            // 
            // emailTocheck
            // 
            this.emailTocheck.Location = new System.Drawing.Point(242, 120);
            this.emailTocheck.Name = "emailTocheck";
            this.emailTocheck.Size = new System.Drawing.Size(197, 26);
            this.emailTocheck.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Available best time for you";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter your email address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Enter the describtion ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Choose an available Physician";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Available best date for you";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(16, 332);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(423, 48);
            this.insert.TabIndex = 13;
            this.insert.Text = "Submit";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(60, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(264, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Appointment Form";
            // 
            // PatientF
            // 
            this.PatientF.Location = new System.Drawing.Point(21, 399);
            this.PatientF.Name = "PatientF";
            this.PatientF.Size = new System.Drawing.Size(418, 37);
            this.PatientF.TabIndex = 44;
            this.PatientF.Text = "Go to Patient Form";
            this.PatientF.UseVisualStyleBackColor = true;
            this.PatientF.Click += new System.EventHandler(this.PatientF_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 579);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "enter email to view, and delete all datails";
            // 
            // emailView
            // 
            this.emailView.Location = new System.Drawing.Point(299, 573);
            this.emailView.Name = "emailView";
            this.emailView.Size = new System.Drawing.Size(148, 26);
            this.emailView.TabIndex = 42;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(240, 620);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(207, 44);
            this.delete.TabIndex = 41;
            this.delete.Text = "Delete detalis";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 44);
            this.button1.TabIndex = 39;
            this.button1.Text = "View Details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 451);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(431, 116);
            this.dataGridView1.TabIndex = 38;
            // 
            // Appoitment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(454, 676);
            this.Controls.Add(this.PatientF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.emailView);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTocheck);
            this.Controls.Add(this.dayy);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.timee);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Appoitment";
            this.Text = "Appoitment";
            this.Load += new System.EventHandler(this.Appoitment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox timee;
        private System.Windows.Forms.TextBox descr;
        private System.Windows.Forms.TextBox dayy;
        private System.Windows.Forms.TextBox emailTocheck;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button PatientF;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox emailView;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}