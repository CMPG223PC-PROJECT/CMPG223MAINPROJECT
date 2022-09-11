namespace CMPG223DEMO
{
    partial class ReportForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.medApp = new System.Windows.Forms.RadioButton();
            this.feedbackR = new System.Windows.Forms.RadioButton();
            this.age65M = new System.Windows.Forms.RadioButton();
            this.age55N64 = new System.Windows.Forms.RadioButton();
            this.age0N14 = new System.Windows.Forms.RadioButton();
            this.age15N24 = new System.Windows.Forms.RadioButton();
            this.generateR = new System.Windows.Forms.Button();
            this.exist = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(26, 117);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(936, 445);
            this.dataGridView1.TabIndex = 0;
            // 
            // medApp
            // 
            this.medApp.AutoSize = true;
            this.medApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.medApp.Location = new System.Drawing.Point(26, 587);
            this.medApp.Name = "medApp";
            this.medApp.Size = new System.Drawing.Size(211, 24);
            this.medApp.TabIndex = 1;
            this.medApp.TabStop = true;
            this.medApp.Text = "Report on PatientRecord";
            this.medApp.UseVisualStyleBackColor = true;
            // 
            // feedbackR
            // 
            this.feedbackR.AutoSize = true;
            this.feedbackR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedbackR.Location = new System.Drawing.Point(356, 587);
            this.feedbackR.Name = "feedbackR";
            this.feedbackR.Size = new System.Drawing.Size(181, 24);
            this.feedbackR.TabIndex = 2;
            this.feedbackR.TabStop = true;
            this.feedbackR.Text = "Report for Feedback";
            this.feedbackR.UseVisualStyleBackColor = true;
            // 
            // age65M
            // 
            this.age65M.AutoSize = true;
            this.age65M.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age65M.Location = new System.Drawing.Point(657, 587);
            this.age65M.Name = "age65M";
            this.age65M.Size = new System.Drawing.Size(305, 24);
            this.age65M.TabIndex = 3;
            this.age65M.TabStop = true;
            this.age65M.Text = "Report For Patient aged 65 and above";
            this.age65M.UseVisualStyleBackColor = true;
            // 
            // age55N64
            // 
            this.age55N64.AutoSize = true;
            this.age55N64.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age55N64.Location = new System.Drawing.Point(657, 715);
            this.age55N64.Name = "age55N64";
            this.age55N64.Size = new System.Drawing.Size(250, 24);
            this.age55N64.TabIndex = 4;
            this.age55N64.TabStop = true;
            this.age55N64.Text = "Report For Patient aged 55-64";
            this.age55N64.UseVisualStyleBackColor = true;
            // 
            // age0N14
            // 
            this.age0N14.AutoSize = true;
            this.age0N14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age0N14.Location = new System.Drawing.Point(26, 641);
            this.age0N14.Name = "age0N14";
            this.age0N14.Size = new System.Drawing.Size(241, 24);
            this.age0N14.TabIndex = 5;
            this.age0N14.TabStop = true;
            this.age0N14.Text = "Report For Patient aged 0-14";
            this.age0N14.UseVisualStyleBackColor = true;
            // 
            // age15N24
            // 
            this.age15N24.AutoSize = true;
            this.age15N24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age15N24.Location = new System.Drawing.Point(356, 641);
            this.age15N24.Name = "age15N24";
            this.age15N24.Size = new System.Drawing.Size(257, 24);
            this.age15N24.TabIndex = 6;
            this.age15N24.TabStop = true;
            this.age15N24.Text = "Report for Patients  aged 15-24";
            this.age15N24.UseVisualStyleBackColor = true;
            // 
            // generateR
            // 
            this.generateR.BackColor = System.Drawing.Color.Lime;
            this.generateR.Location = new System.Drawing.Point(83, 689);
            this.generateR.Name = "generateR";
            this.generateR.Size = new System.Drawing.Size(291, 50);
            this.generateR.TabIndex = 7;
            this.generateR.Text = "Generate report";
            this.generateR.UseVisualStyleBackColor = false;
            this.generateR.Click += new System.EventHandler(this.generateR_Click);
            // 
            // exist
            // 
            this.exist.BackColor = System.Drawing.Color.Red;
            this.exist.Location = new System.Drawing.Point(568, 693);
            this.exist.Name = "exist";
            this.exist.Size = new System.Drawing.Size(291, 46);
            this.exist.TabIndex = 8;
            this.exist.Text = "Exit";
            this.exist.UseVisualStyleBackColor = false;
            this.exist.Click += new System.EventHandler(this.exist_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 9;
            this.label1.Tag = "Generate ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(294, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(463, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Project Report Genarating FORM";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 77);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(936, 34);
            this.progressBar1.TabIndex = 27;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(1004, 762);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exist);
            this.Controls.Add(this.generateR);
            this.Controls.Add(this.age15N24);
            this.Controls.Add(this.age0N14);
            this.Controls.Add(this.age55N64);
            this.Controls.Add(this.age65M);
            this.Controls.Add(this.feedbackR);
            this.Controls.Add(this.medApp);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(1030, 822);
            this.MinimumSize = new System.Drawing.Size(1030, 822);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton medApp;
        private System.Windows.Forms.RadioButton feedbackR;
        private System.Windows.Forms.RadioButton age65M;
        private System.Windows.Forms.RadioButton age55N64;
        private System.Windows.Forms.RadioButton age0N14;
        private System.Windows.Forms.RadioButton age15N24;
        private System.Windows.Forms.Button generateR;
        private System.Windows.Forms.Button exist;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}