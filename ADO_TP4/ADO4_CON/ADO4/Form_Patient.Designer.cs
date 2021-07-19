namespace ADO4
{
    partial class Form_Patient
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
            this.dateTimePicker_dateNaissance = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.button_verifier = new System.Windows.Forms.Button();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_adresse = new System.Windows.Forms.TextBox();
            this.radioButton_male = new System.Windows.Forms.RadioButton();
            this.radioButton_femelle = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // dateTimePicker_dateNaissance
            // 
            this.dateTimePicker_dateNaissance.Location = new System.Drawing.Point(14, 275);
            this.dateTimePicker_dateNaissance.Name = "dateTimePicker_dateNaissance";
            this.dateTimePicker_dateNaissance.Size = new System.Drawing.Size(318, 22);
            this.dateTimePicker_dateNaissance.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(50, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 39);
            this.label6.TabIndex = 21;
            this.label6.Text = "          Patient          ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(257, 371);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 18;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(176, 371);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 17;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Location = new System.Drawing.Point(95, 371);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.button_enregistrer.TabIndex = 20;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(14, 371);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(75, 23);
            this.button_nouveau.TabIndex = 19;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // button_verifier
            // 
            this.button_verifier.Location = new System.Drawing.Point(257, 90);
            this.button_verifier.Name = "button_verifier";
            this.button_verifier.Size = new System.Drawing.Size(75, 23);
            this.button_verifier.TabIndex = 16;
            this.button_verifier.Text = "Vérifier";
            this.button_verifier.UseVisualStyleBackColor = true;
            this.button_verifier.Click += new System.EventHandler(this.button_verifier_Click);
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(14, 146);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(318, 22);
            this.textBox_nom.TabIndex = 14;
            this.textBox_nom.Text = "nouveau_nom";
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(14, 93);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(237, 22);
            this.textBox_code.TabIndex = 15;
            this.textBox_code.Text = "100";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 312);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sexe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date de naissance";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adresse";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Code";
            // 
            // textBox_adresse
            // 
            this.textBox_adresse.Location = new System.Drawing.Point(14, 200);
            this.textBox_adresse.Multiline = true;
            this.textBox_adresse.Name = "textBox_adresse";
            this.textBox_adresse.Size = new System.Drawing.Size(318, 45);
            this.textBox_adresse.TabIndex = 24;
            this.textBox_adresse.Text = "nouvelle_adresse";
            // 
            // radioButton_male
            // 
            this.radioButton_male.AutoSize = true;
            this.radioButton_male.Location = new System.Drawing.Point(14, 329);
            this.radioButton_male.Name = "radioButton_male";
            this.radioButton_male.Size = new System.Drawing.Size(64, 17);
            this.radioButton_male.TabIndex = 25;
            this.radioButton_male.TabStop = true;
            this.radioButton_male.Text = "Homme";
            this.radioButton_male.UseVisualStyleBackColor = true;
            // 
            // radioButton_femelle
            // 
            this.radioButton_femelle.AutoSize = true;
            this.radioButton_femelle.Location = new System.Drawing.Point(105, 329);
            this.radioButton_femelle.Name = "radioButton_femelle";
            this.radioButton_femelle.Size = new System.Drawing.Size(61, 17);
            this.radioButton_femelle.TabIndex = 25;
            this.radioButton_femelle.TabStop = true;
            this.radioButton_femelle.Text = "Femme";
            this.radioButton_femelle.UseVisualStyleBackColor = true;
            // 
            // Form_Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 408);
            this.Controls.Add(this.radioButton_femelle);
            this.Controls.Add(this.radioButton_male);
            this.Controls.Add(this.textBox_adresse);
            this.Controls.Add(this.dateTimePicker_dateNaissance);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.button_nouveau);
            this.Controls.Add(this.button_verifier);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.textBox_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form_Patient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Patient";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker_dateNaissance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.Button button_verifier;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_adresse;
        private System.Windows.Forms.RadioButton radioButton_male;
        private System.Windows.Forms.RadioButton radioButton_femelle;
    }
}