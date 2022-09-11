namespace CMPG223DEMO
{
    partial class updatePatientRecord
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idOfPatientRecord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.update = new System.Windows.Forms.Button();
            this.preBox = new System.Windows.Forms.RichTextBox();
            this.diaBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(34, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(416, 32);
            this.label6.TabIndex = 37;
            this.label6.Text = "Patient Record Update FORM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 20);
            this.label5.TabIndex = 48;
            this.label5.Text = "Enter patient_recordID";
            // 
            // idOfPatientRecord
            // 
            this.idOfPatientRecord.Location = new System.Drawing.Point(190, 78);
            this.idOfPatientRecord.Name = "idOfPatientRecord";
            this.idOfPatientRecord.Size = new System.Drawing.Size(195, 26);
            this.idOfPatientRecord.TabIndex = 49;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Start the diagnosis*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Add the prescribtion*";
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(389, 297);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(105, 36);
            this.update.TabIndex = 47;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // preBox
            // 
            this.preBox.Location = new System.Drawing.Point(173, 237);
            this.preBox.MaxLength = 400;
            this.preBox.Name = "preBox";
            this.preBox.Size = new System.Drawing.Size(195, 96);
            this.preBox.TabIndex = 44;
            this.preBox.Text = "";
            // 
            // diaBox
            // 
            this.diaBox.Location = new System.Drawing.Point(173, 129);
            this.diaBox.MaxLength = 400;
            this.diaBox.Name = "diaBox";
            this.diaBox.Size = new System.Drawing.Size(195, 96);
            this.diaBox.TabIndex = 43;
            this.diaBox.Text = "";
            // 
            // updatePatientRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 350);
            this.Controls.Add(this.idOfPatientRecord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.update);
            this.Controls.Add(this.preBox);
            this.Controls.Add(this.diaBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Name = "updatePatientRecord";
            this.Text = "updatePatientRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idOfPatientRecord;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.RichTextBox preBox;
        private System.Windows.Forms.RichTextBox diaBox;
    }
}