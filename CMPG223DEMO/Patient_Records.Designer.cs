namespace CMPG223DEMO
{
    partial class Patient_Records
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.diaBox = new System.Windows.Forms.RichTextBox();
            this.preBox = new System.Windows.Forms.RichTextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.medIDBox = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.idToValidate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.insert = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter patient\'s email*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Medication ID*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start the diagnosis*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Add the prescribtion*";
            // 
            // diaBox
            // 
            this.diaBox.Location = new System.Drawing.Point(171, 160);
            this.diaBox.MaxLength = 400;
            this.diaBox.Name = "diaBox";
            this.diaBox.Size = new System.Drawing.Size(195, 96);
            this.diaBox.TabIndex = 4;
            this.diaBox.Text = "";
            // 
            // preBox
            // 
            this.preBox.Location = new System.Drawing.Point(171, 268);
            this.preBox.MaxLength = 400;
            this.preBox.Name = "preBox";
            this.preBox.Size = new System.Drawing.Size(195, 96);
            this.preBox.TabIndex = 5;
            this.preBox.Text = "";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(171, 86);
            this.emailBox.MaxLength = 100;
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(195, 26);
            this.emailBox.TabIndex = 6;
            this.emailBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // medIDBox
            // 
            this.medIDBox.Location = new System.Drawing.Point(171, 121);
            this.medIDBox.Name = "medIDBox";
            this.medIDBox.Size = new System.Drawing.Size(195, 26);
            this.medIDBox.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(364, 526);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 24);
            this.radioButton1.TabIndex = 20;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "View all details";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // idToValidate
            // 
            this.idToValidate.Location = new System.Drawing.Point(8, 587);
            this.idToValidate.Name = "idToValidate";
            this.idToValidate.Size = new System.Drawing.Size(485, 26);
            this.idToValidate.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 541);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(341, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Enter ID for  the delete and update operations*";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(340, 619);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(152, 44);
            this.delete.TabIndex = 17;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(193, 623);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 40);
            this.update.TabIndex = 16;
            this.update.Text = "Update ";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(8, 623);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(152, 40);
            this.select.TabIndex = 15;
            this.select.Text = "View ";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 370);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(485, 150);
            this.dataGridView1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(122, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(318, 32);
            this.label6.TabIndex = 27;
            this.label6.Text = "Patient Record  FORM";
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(387, 328);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(105, 36);
            this.insert.TabIndex = 28;
            this.insert.Text = "Submit";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(364, 556);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(135, 24);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "View one data";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightGreen;
            this.button2.Location = new System.Drawing.Point(16, 48);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 35);
            this.button2.TabIndex = 31;
            this.button2.Text = "Go to Patient form";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Patient_Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(546, 675);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.idToValidate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.select);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.medIDBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.preBox);
            this.Controls.Add(this.diaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimumSize = new System.Drawing.Size(572, 708);
            this.Name = "Patient_Records";
            this.Text = "Patient_Records";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox diaBox;
        private System.Windows.Forms.RichTextBox preBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox medIDBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox idToValidate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}