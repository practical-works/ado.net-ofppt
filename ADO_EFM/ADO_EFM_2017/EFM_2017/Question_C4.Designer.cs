namespace EFM_2017
{
    partial class Question_C4
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
            this.comboBox_patient = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_date = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient :";
            // 
            // comboBox_patient
            // 
            this.comboBox_patient.FormattingEnabled = true;
            this.comboBox_patient.Location = new System.Drawing.Point(121, 50);
            this.comboBox_patient.Name = "comboBox_patient";
            this.comboBox_patient.Size = new System.Drawing.Size(187, 21);
            this.comboBox_patient.TabIndex = 1;
            this.comboBox_patient.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date dernière consultation :";
            // 
            // label_date
            // 
            this.label_date.AutoSize = true;
            this.label_date.Location = new System.Drawing.Point(230, 109);
            this.label_date.Name = "label_date";
            this.label_date.Size = new System.Drawing.Size(79, 13);
            this.label_date.TabIndex = 3;
            this.label_date.Text = "____________";
            // 
            // Question_C4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 190);
            this.Controls.Add(this.label_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_patient);
            this.Controls.Add(this.label1);
            this.Name = "Question_C4";
            this.Text = "Question_C4";
            this.Load += new System.EventHandler(this.Question_C4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_patient;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_date;
    }
}