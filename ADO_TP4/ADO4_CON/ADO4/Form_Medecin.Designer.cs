namespace ADO4
{
    partial class Form_Medecin
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_code = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_specialite = new System.Windows.Forms.TextBox();
            this.button_verifier = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox_telephone = new System.Windows.Forms.MaskedTextBox();
            this.dateTimePicker_dateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Téléphone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Date d\'embauche";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Spécialité";
            // 
            // textBox_code
            // 
            this.textBox_code.Location = new System.Drawing.Point(19, 96);
            this.textBox_code.Name = "textBox_code";
            this.textBox_code.Size = new System.Drawing.Size(237, 22);
            this.textBox_code.TabIndex = 1;
            this.textBox_code.Text = "100";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(19, 149);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(318, 22);
            this.textBox_nom.TabIndex = 1;
            this.textBox_nom.Text = "nouveau_nom";
            // 
            // textBox_specialite
            // 
            this.textBox_specialite.Location = new System.Drawing.Point(19, 308);
            this.textBox_specialite.Name = "textBox_specialite";
            this.textBox_specialite.Size = new System.Drawing.Size(318, 22);
            this.textBox_specialite.TabIndex = 1;
            this.textBox_specialite.Text = "nouvelle_specialite";
            // 
            // button_verifier
            // 
            this.button_verifier.Location = new System.Drawing.Point(262, 93);
            this.button_verifier.Name = "button_verifier";
            this.button_verifier.Size = new System.Drawing.Size(75, 23);
            this.button_verifier.TabIndex = 2;
            this.button_verifier.Text = "Vérifier";
            this.button_verifier.UseVisualStyleBackColor = true;
            this.button_verifier.Click += new System.EventHandler(this.button_verifier_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(19, 351);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(75, 23);
            this.button_nouveau.TabIndex = 3;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Location = new System.Drawing.Point(100, 351);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(75, 23);
            this.button_enregistrer.TabIndex = 3;
            this.button_enregistrer.Text = "Enregistrer";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(181, 351);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 3;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(262, 351);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 3;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LightGray;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(46, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(261, 39);
            this.label6.TabIndex = 4;
            this.label6.Text = "          Médecin          ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox_telephone
            // 
            this.maskedTextBox_telephone.Location = new System.Drawing.Point(19, 203);
            this.maskedTextBox_telephone.Mask = "\\0600000000";
            this.maskedTextBox_telephone.Name = "maskedTextBox_telephone";
            this.maskedTextBox_telephone.Size = new System.Drawing.Size(318, 22);
            this.maskedTextBox_telephone.TabIndex = 6;
            this.maskedTextBox_telephone.Text = "00000000";
            // 
            // dateTimePicker_dateEmbauche
            // 
            this.dateTimePicker_dateEmbauche.Location = new System.Drawing.Point(19, 255);
            this.dateTimePicker_dateEmbauche.Name = "dateTimePicker_dateEmbauche";
            this.dateTimePicker_dateEmbauche.Size = new System.Drawing.Size(318, 22);
            this.dateTimePicker_dateEmbauche.TabIndex = 7;
            // 
            // Form_Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 391);
            this.Controls.Add(this.dateTimePicker_dateEmbauche);
            this.Controls.Add(this.maskedTextBox_telephone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_enregistrer);
            this.Controls.Add(this.button_nouveau);
            this.Controls.Add(this.button_verifier);
            this.Controls.Add(this.textBox_specialite);
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
            this.Name = "Form_Medecin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Formulaire Médecin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_code;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.TextBox textBox_specialite;
        private System.Windows.Forms.Button button_verifier;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telephone;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateEmbauche;
    }
}