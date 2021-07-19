namespace ADO4
{
    partial class Form_Consultation
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
            this.dataGridView_main = new System.Windows.Forms.DataGridView();
            this.radioButton_medecins = new System.Windows.Forms.RadioButton();
            this.radioButton_rdvs = new System.Windows.Forms.RadioButton();
            this.radioButton_patients = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(136, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(296, 39);
            this.label6.TabIndex = 39;
            this.label6.Text = "         Consultation         ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView_main
            // 
            this.dataGridView_main.AllowUserToAddRows = false;
            this.dataGridView_main.AllowUserToDeleteRows = false;
            this.dataGridView_main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_main.Location = new System.Drawing.Point(13, 112);
            this.dataGridView_main.Name = "dataGridView_main";
            this.dataGridView_main.ReadOnly = true;
            this.dataGridView_main.Size = new System.Drawing.Size(543, 275);
            this.dataGridView_main.TabIndex = 40;
            // 
            // radioButton_medecins
            // 
            this.radioButton_medecins.AutoSize = true;
            this.radioButton_medecins.Location = new System.Drawing.Point(60, 75);
            this.radioButton_medecins.Name = "radioButton_medecins";
            this.radioButton_medecins.Size = new System.Drawing.Size(117, 17);
            this.radioButton_medecins.TabIndex = 41;
            this.radioButton_medecins.TabStop = true;
            this.radioButton_medecins.Text = "Tous les médecins";
            this.radioButton_medecins.UseVisualStyleBackColor = true;
            this.radioButton_medecins.CheckedChanged += new System.EventHandler(this.radioButton_medecins_CheckedChanged);
            // 
            // radioButton_rdvs
            // 
            this.radioButton_rdvs.AutoSize = true;
            this.radioButton_rdvs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_rdvs.Location = new System.Drawing.Point(221, 75);
            this.radioButton_rdvs.Name = "radioButton_rdvs";
            this.radioButton_rdvs.Size = new System.Drawing.Size(134, 17);
            this.radioButton_rdvs.TabIndex = 41;
            this.radioButton_rdvs.TabStop = true;
            this.radioButton_rdvs.Text = "Tous les rendez-vous";
            this.radioButton_rdvs.UseVisualStyleBackColor = true;
            this.radioButton_rdvs.CheckedChanged += new System.EventHandler(this.radioButton_rdvs_CheckedChanged);
            // 
            // radioButton_patients
            // 
            this.radioButton_patients.AutoSize = true;
            this.radioButton_patients.Location = new System.Drawing.Point(397, 75);
            this.radioButton_patients.Name = "radioButton_patients";
            this.radioButton_patients.Size = new System.Drawing.Size(111, 17);
            this.radioButton_patients.TabIndex = 41;
            this.radioButton_patients.TabStop = true;
            this.radioButton_patients.Text = "Tous les patients";
            this.radioButton_patients.UseVisualStyleBackColor = true;
            this.radioButton_patients.CheckedChanged += new System.EventHandler(this.radioButton_patients_CheckedChanged);
            // 
            // Form_Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 399);
            this.Controls.Add(this.radioButton_patients);
            this.Controls.Add(this.radioButton_rdvs);
            this.Controls.Add(this.radioButton_medecins);
            this.Controls.Add(this.dataGridView_main);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Consultation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Consultation";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_main;
        private System.Windows.Forms.RadioButton radioButton_medecins;
        private System.Windows.Forms.RadioButton radioButton_rdvs;
        private System.Windows.Forms.RadioButton radioButton_patients;
    }
}