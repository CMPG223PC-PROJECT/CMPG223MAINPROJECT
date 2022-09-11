namespace CMPG223DEMO
{
    partial class Medication
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.descr = new System.Windows.Forms.Label();
            this.descrBox = new System.Windows.Forms.RichTextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.brandBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.idToValidate = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Brand*";
            // 
            // descr
            // 
            this.descr.AutoSize = true;
            this.descr.Location = new System.Drawing.Point(12, 127);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(95, 20);
            this.descr.TabIndex = 3;
            this.descr.Text = "Describtion*";
            // 
            // descrBox
            // 
            this.descrBox.Location = new System.Drawing.Point(107, 127);
            this.descrBox.MaxLength = 200;
            this.descrBox.Name = "descrBox";
            this.descrBox.Size = new System.Drawing.Size(198, 96);
            this.descrBox.TabIndex = 4;
            this.descrBox.Text = "";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(107, 48);
            this.nameBox.MaxLength = 80;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(198, 26);
            this.nameBox.TabIndex = 5;
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(107, 87);
            this.brandBox.MaxLength = 80;
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(198, 26);
            this.brandBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(485, 150);
            this.dataGridView1.TabIndex = 7;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(16, 524);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(152, 40);
            this.select.TabIndex = 8;
            this.select.Text = "View ";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(203, 526);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(119, 40);
            this.update.TabIndex = 9;
            this.update.Text = "Update ";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(349, 522);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(152, 44);
            this.delete.TabIndex = 10;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 450);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(341, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter ID for  the delete and update operations*";
            // 
            // idToValidate
            // 
            this.idToValidate.Location = new System.Drawing.Point(16, 492);
            this.idToValidate.Name = "idToValidate";
            this.idToValidate.Size = new System.Drawing.Size(485, 26);
            this.idToValidate.TabIndex = 12;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(364, 437);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(137, 24);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "View all details";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(136, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(265, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Medication  FORM";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(364, 462);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(132, 24);
            this.radioButton2.TabIndex = 27;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "View one field";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(517, 574);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.idToValidate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.update);
            this.Controls.Add(this.select);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.descrBox);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(543, 634);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(543, 634);
            this.Name = "Medication";
            this.Text = "Medication";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label descr;
        private System.Windows.Forms.RichTextBox descrBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idToValidate;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}