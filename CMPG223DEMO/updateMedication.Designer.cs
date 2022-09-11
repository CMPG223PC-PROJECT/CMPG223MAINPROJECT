namespace CMPG223DEMO
{
    partial class updateMedication
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
            this.brandBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.descrBox = new System.Windows.Forms.RichTextBox();
            this.descr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // brandBox
            // 
            this.brandBox.Location = new System.Drawing.Point(121, 151);
            this.brandBox.MaxLength = 80;
            this.brandBox.Name = "brandBox";
            this.brandBox.Size = new System.Drawing.Size(198, 26);
            this.brandBox.TabIndex = 13;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(121, 112);
            this.nameBox.MaxLength = 80;
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(198, 26);
            this.nameBox.TabIndex = 12;
            // 
            // descrBox
            // 
            this.descrBox.Location = new System.Drawing.Point(121, 191);
            this.descrBox.MaxLength = 200;
            this.descrBox.Name = "descrBox";
            this.descrBox.Size = new System.Drawing.Size(198, 96);
            this.descrBox.TabIndex = 11;
            this.descrBox.Text = "";
            // 
            // descr
            // 
            this.descr.AutoSize = true;
            this.descr.Location = new System.Drawing.Point(18, 191);
            this.descr.Name = "descr";
            this.descr.Size = new System.Drawing.Size(95, 20);
            this.descr.TabIndex = 10;
            this.descr.Text = "Describtion*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Brand*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name*";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 36);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Sienna;
            this.label6.Location = new System.Drawing.Point(75, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 32);
            this.label6.TabIndex = 26;
            this.label6.Text = "Update detsils";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "medicationID";
            // 
            // idBox
            // 
            this.idBox.Location = new System.Drawing.Point(121, 73);
            this.idBox.MaxLength = 1000;
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(198, 26);
            this.idBox.TabIndex = 28;
            // 
            // updateMedication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(340, 366);
            this.Controls.Add(this.idBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brandBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.descrBox);
            this.Controls.Add(this.descr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximumSize = new System.Drawing.Size(366, 426);
            this.Name = "updateMedication";
            this.Text = "updateMedication";
            this.Load += new System.EventHandler(this.updateMedication_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox brandBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.RichTextBox descrBox;
        private System.Windows.Forms.Label descr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idBox;
    }
}