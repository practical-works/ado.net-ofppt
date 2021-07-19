namespace EFM_2017
{
    partial class Question_C3
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
            this.numericUpDown_numConsult = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker_date = new System.Windows.Forms.DateTimePicker();
            this.comboBox_medecin = new System.Windows.Forms.ComboBox();
            this.comboBox_patient = new System.Windows.Forms.ComboBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_suivant = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numConsult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDown_numConsult
            // 
            this.numericUpDown_numConsult.Location = new System.Drawing.Point(152, 33);
            this.numericUpDown_numConsult.Name = "numericUpDown_numConsult";
            this.numericUpDown_numConsult.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_numConsult.TabIndex = 0;
            // 
            // dateTimePicker_date
            // 
            this.dateTimePicker_date.Location = new System.Drawing.Point(152, 65);
            this.dateTimePicker_date.Name = "dateTimePicker_date";
            this.dateTimePicker_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_date.TabIndex = 1;
            // 
            // comboBox_medecin
            // 
            this.comboBox_medecin.FormattingEnabled = true;
            this.comboBox_medecin.Location = new System.Drawing.Point(152, 91);
            this.comboBox_medecin.Name = "comboBox_medecin";
            this.comboBox_medecin.Size = new System.Drawing.Size(121, 21);
            this.comboBox_medecin.TabIndex = 2;
            // 
            // comboBox_patient
            // 
            this.comboBox_patient.FormattingEnabled = true;
            this.comboBox_patient.Location = new System.Drawing.Point(152, 117);
            this.comboBox_patient.Name = "comboBox_patient";
            this.comboBox_patient.Size = new System.Drawing.Size(121, 21);
            this.comboBox_patient.TabIndex = 3;
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(152, 143);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(294, 20);
            this.textBox_desc.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NumConsult :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Médecin :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Patient :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Description :";
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(377, 218);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(148, 47);
            this.button_ajouter.TabIndex = 6;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_suivant
            // 
            this.button_suivant.Location = new System.Drawing.Point(450, 36);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(75, 48);
            this.button_suivant.TabIndex = 7;
            this.button_suivant.Text = "Suivant >";
            this.button_suivant.UseVisualStyleBackColor = true;
            this.button_suivant.Click += new System.EventHandler(this.button_suivant_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 8;
            // 
            // Question_C3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 387);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_suivant);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.comboBox_patient);
            this.Controls.Add(this.comboBox_medecin);
            this.Controls.Add(this.dateTimePicker_date);
            this.Controls.Add(this.numericUpDown_numConsult);
            this.Name = "Question_C3";
            this.Text = "Question_C3";
            this.Load += new System.EventHandler(this.Question_C3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numConsult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDown_numConsult;
        private System.Windows.Forms.DateTimePicker dateTimePicker_date;
        private System.Windows.Forms.ComboBox comboBox_medecin;
        private System.Windows.Forms.ComboBox comboBox_patient;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_suivant;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}