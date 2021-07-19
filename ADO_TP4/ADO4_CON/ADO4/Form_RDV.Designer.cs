namespace ADO4
{
    partial class Form_RDV
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
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.button_verifier = new System.Windows.Forms.Button();
            this.textBox_numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker_dateRDV = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBox_heure = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_medecin = new System.Windows.Forms.ComboBox();
            this.comboBox_patient = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 39);
            this.label6.TabIndex = 38;
            this.label6.Text = "          Rendez-vous          ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(254, 306);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 35;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(173, 306);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 34;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Location = new System.Drawing.Point(92, 306);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.button_enregistrer.TabIndex = 37;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(11, 306);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(75, 23);
            this.button_nouveau.TabIndex = 36;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // button_verifier
            // 
            this.button_verifier.Location = new System.Drawing.Point(254, 91);
            this.button_verifier.Name = "button_verifier";
            this.button_verifier.Size = new System.Drawing.Size(75, 23);
            this.button_verifier.TabIndex = 33;
            this.button_verifier.Text = "Vérifier";
            this.button_verifier.UseVisualStyleBackColor = true;
            this.button_verifier.Click += new System.EventHandler(this.button_verifier_Click);
            // 
            // textBox_numero
            // 
            this.textBox_numero.Location = new System.Drawing.Point(11, 94);
            this.textBox_numero.Name = "textBox_numero";
            this.textBox_numero.Size = new System.Drawing.Size(237, 22);
            this.textBox_numero.TabIndex = 32;
            this.textBox_numero.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Patient";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Médecin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Heure";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Numéro";
            // 
            // dateTimePicker_dateRDV
            // 
            this.dateTimePicker_dateRDV.Location = new System.Drawing.Point(11, 138);
            this.dateTimePicker_dateRDV.Name = "dateTimePicker_dateRDV";
            this.dateTimePicker_dateRDV.Size = new System.Drawing.Size(318, 22);
            this.dateTimePicker_dateRDV.TabIndex = 39;
            // 
            // maskedTextBox_heure
            // 
            this.maskedTextBox_heure.Location = new System.Drawing.Point(11, 181);
            this.maskedTextBox_heure.Mask = "00:00";
            this.maskedTextBox_heure.Name = "maskedTextBox_heure";
            this.maskedTextBox_heure.Size = new System.Drawing.Size(313, 22);
            this.maskedTextBox_heure.TabIndex = 40;
            // 
            // comboBox_medecin
            // 
            this.comboBox_medecin.FormattingEnabled = true;
            this.comboBox_medecin.Location = new System.Drawing.Point(11, 224);
            this.comboBox_medecin.Name = "comboBox_medecin";
            this.comboBox_medecin.Size = new System.Drawing.Size(313, 21);
            this.comboBox_medecin.TabIndex = 41;
            // 
            // comboBox_patient
            // 
            this.comboBox_patient.FormattingEnabled = true;
            this.comboBox_patient.Location = new System.Drawing.Point(11, 267);
            this.comboBox_patient.Name = "comboBox_patient";
            this.comboBox_patient.Size = new System.Drawing.Size(313, 21);
            this.comboBox_patient.TabIndex = 42;
            // 
            // Form_RDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 344);
            this.Controls.Add(this.comboBox_patient);
            this.Controls.Add(this.comboBox_medecin);
            this.Controls.Add(this.maskedTextBox_heure);
            this.Controls.Add(this.dateTimePicker_dateRDV);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.button_nouveau);
            this.Controls.Add(this.button_verifier);
            this.Controls.Add(this.textBox_numero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_RDV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_RDV";
            this.Load += new System.EventHandler(this.Form_RDV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.Button button_verifier;
        private System.Windows.Forms.TextBox textBox_numero;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateRDV;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_heure;
        private System.Windows.Forms.ComboBox comboBox_medecin;
        private System.Windows.Forms.ComboBox comboBox_patient;
    }
}