namespace ADO5
{
    partial class Form_Stagiaires
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.maskedTextBox_date_sta = new System.Windows.Forms.MaskedTextBox();
            this.textBox_pre_sta = new System.Windows.Forms.TextBox();
            this.textBox_nom_sta = new System.Windows.Forms.TextBox();
            this.textBox_num_sta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_moyenne = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_enregistrer = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_dernier = new System.Windows.Forms.Button();
            this.button_suivant = new System.Windows.Forms.Button();
            this.button_precedent = new System.Windows.Forms.Button();
            this.button_premier = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_rechercher_nom = new System.Windows.Forms.Button();
            this.button_rechercher_num = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Consolas", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "GESTION DES STAGIAIRES";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.maskedTextBox_date_sta);
            this.panel1.Controls.Add(this.textBox_pre_sta);
            this.panel1.Controls.Add(this.textBox_nom_sta);
            this.panel1.Controls.Add(this.textBox_num_sta);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 151);
            this.panel1.TabIndex = 1;
            // 
            // maskedTextBox_date_sta
            // 
            this.maskedTextBox_date_sta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox_date_sta.Location = new System.Drawing.Point(144, 106);
            this.maskedTextBox_date_sta.Mask = "00/00/0000";
            this.maskedTextBox_date_sta.Name = "maskedTextBox_date_sta";
            this.maskedTextBox_date_sta.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_date_sta.TabIndex = 4;
            this.maskedTextBox_date_sta.Text = "01011991";
            this.maskedTextBox_date_sta.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_date_sta.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBox_date_sta_Validating);
            // 
            // textBox_pre_sta
            // 
            this.textBox_pre_sta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_pre_sta.Location = new System.Drawing.Point(144, 78);
            this.textBox_pre_sta.Name = "textBox_pre_sta";
            this.textBox_pre_sta.Size = new System.Drawing.Size(100, 20);
            this.textBox_pre_sta.TabIndex = 3;
            // 
            // textBox_nom_sta
            // 
            this.textBox_nom_sta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nom_sta.Location = new System.Drawing.Point(144, 50);
            this.textBox_nom_sta.Name = "textBox_nom_sta";
            this.textBox_nom_sta.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom_sta.TabIndex = 2;
            // 
            // textBox_num_sta
            // 
            this.textBox_num_sta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_num_sta.Location = new System.Drawing.Point(144, 22);
            this.textBox_num_sta.Name = "textBox_num_sta";
            this.textBox_num_sta.Size = new System.Drawing.Size(100, 20);
            this.textBox_num_sta.TabIndex = 1;
            this.textBox_num_sta.Text = "1000";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Date de naissance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Numéro d\'inscription";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button_moyenne);
            this.panel2.Controls.Add(this.button_supprimer);
            this.panel2.Controls.Add(this.button_modifier);
            this.panel2.Controls.Add(this.button_enregistrer);
            this.panel2.Controls.Add(this.button_nouveau);
            this.panel2.Location = new System.Drawing.Point(291, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(223, 312);
            this.panel2.TabIndex = 1;
            // 
            // button_moyenne
            // 
            this.button_moyenne.Image = global::ADO5.Properties.Resources.function;
            this.button_moyenne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_moyenne.Location = new System.Drawing.Point(17, 248);
            this.button_moyenne.Name = "button_moyenne";
            this.button_moyenne.Size = new System.Drawing.Size(186, 43);
            this.button_moyenne.TabIndex = 9;
            this.button_moyenne.Text = "Moyenne";
            this.button_moyenne.UseVisualStyleBackColor = true;
            this.button_moyenne.Click += new System.EventHandler(this.button_moyenne_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Image = global::ADO5.Properties.Resources.delete;
            this.button_supprimer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_supprimer.Location = new System.Drawing.Point(17, 191);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(186, 43);
            this.button_supprimer.TabIndex = 8;
            this.button_supprimer.Text = "Supprimer Stagiaire";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Image = global::ADO5.Properties.Resources.save_as;
            this.button_modifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_modifier.Location = new System.Drawing.Point(17, 134);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(186, 43);
            this.button_modifier.TabIndex = 7;
            this.button_modifier.Text = "Modifier Stagiaire";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_enregistrer
            // 
            this.button_enregistrer.Image = global::ADO5.Properties.Resources.diskette;
            this.button_enregistrer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_enregistrer.Location = new System.Drawing.Point(17, 77);
            this.button_enregistrer.Name = "button_enregistrer";
            this.button_enregistrer.Size = new System.Drawing.Size(186, 43);
            this.button_enregistrer.TabIndex = 6;
            this.button_enregistrer.Text = "Enregistrer Stagiaire";
            this.button_enregistrer.UseVisualStyleBackColor = true;
            this.button_enregistrer.Click += new System.EventHandler(this.button_enregistrer_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Image = global::ADO5.Properties.Resources.page_white1;
            this.button_nouveau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_nouveau.Location = new System.Drawing.Point(17, 20);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(186, 43);
            this.button_nouveau.TabIndex = 5;
            this.button_nouveau.Text = "Nouveau Stagiaire";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button_dernier);
            this.panel3.Controls.Add(this.button_suivant);
            this.panel3.Controls.Add(this.button_precedent);
            this.panel3.Controls.Add(this.button_premier);
            this.panel3.Location = new System.Drawing.Point(12, 226);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(273, 61);
            this.panel3.TabIndex = 1;
            // 
            // button_dernier
            // 
            this.button_dernier.Image = global::ADO5.Properties.Resources.resultset_last;
            this.button_dernier.Location = new System.Drawing.Point(212, 11);
            this.button_dernier.Name = "button_dernier";
            this.button_dernier.Size = new System.Drawing.Size(41, 37);
            this.button_dernier.TabIndex = 15;
            this.button_dernier.UseVisualStyleBackColor = true;
            this.button_dernier.Click += new System.EventHandler(this.button_dernier_Click);
            // 
            // button_suivant
            // 
            this.button_suivant.Image = global::ADO5.Properties.Resources.resultset_next;
            this.button_suivant.Location = new System.Drawing.Point(147, 11);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(41, 37);
            this.button_suivant.TabIndex = 14;
            this.button_suivant.UseVisualStyleBackColor = true;
            this.button_suivant.Click += new System.EventHandler(this.button_suivant_Click);
            // 
            // button_precedent
            // 
            this.button_precedent.Image = global::ADO5.Properties.Resources.resultset_previous1;
            this.button_precedent.Location = new System.Drawing.Point(82, 11);
            this.button_precedent.Name = "button_precedent";
            this.button_precedent.Size = new System.Drawing.Size(41, 37);
            this.button_precedent.TabIndex = 13;
            this.button_precedent.UseVisualStyleBackColor = true;
            this.button_precedent.Click += new System.EventHandler(this.button_precedent_Click);
            // 
            // button_premier
            // 
            this.button_premier.Image = global::ADO5.Properties.Resources.resultset_first;
            this.button_premier.Location = new System.Drawing.Point(17, 11);
            this.button_premier.Name = "button_premier";
            this.button_premier.Size = new System.Drawing.Size(41, 37);
            this.button_premier.TabIndex = 12;
            this.button_premier.UseVisualStyleBackColor = true;
            this.button_premier.Click += new System.EventHandler(this.button_premier_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.button_rechercher_nom);
            this.panel4.Controls.Add(this.button_rechercher_num);
            this.panel4.Location = new System.Drawing.Point(12, 293);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(273, 88);
            this.panel4.TabIndex = 1;
            // 
            // button_rechercher_nom
            // 
            this.button_rechercher_nom.Image = global::ADO5.Properties.Resources.search_accounts1;
            this.button_rechercher_nom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rechercher_nom.Location = new System.Drawing.Point(7, 47);
            this.button_rechercher_nom.Name = "button_rechercher_nom";
            this.button_rechercher_nom.Size = new System.Drawing.Size(256, 29);
            this.button_rechercher_nom.TabIndex = 11;
            this.button_rechercher_nom.Text = "Rechercher Stagiaire par Nom et Prénom";
            this.button_rechercher_nom.UseVisualStyleBackColor = true;
            this.button_rechercher_nom.Click += new System.EventHandler(this.button_rechercher_nom_Click);
            // 
            // button_rechercher_num
            // 
            this.button_rechercher_num.Image = global::ADO5.Properties.Resources.search_accounts1;
            this.button_rechercher_num.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_rechercher_num.Location = new System.Drawing.Point(7, 11);
            this.button_rechercher_num.Name = "button_rechercher_num";
            this.button_rechercher_num.Size = new System.Drawing.Size(256, 29);
            this.button_rechercher_num.TabIndex = 10;
            this.button_rechercher_num.Text = "Rechercher Stagiaire par Numéro";
            this.button_rechercher_num.UseVisualStyleBackColor = true;
            this.button_rechercher_num.Click += new System.EventHandler(this.button_rechercher_num_Click);
            // 
            // Form_Stagiaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 399);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form_Stagiaires";
            this.Text = "Gestion des Stagiaires";
            this.Load += new System.EventHandler(this.Form_Stagiaires_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_moyenne;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_enregistrer;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.Button button_dernier;
        private System.Windows.Forms.Button button_suivant;
        private System.Windows.Forms.Button button_precedent;
        private System.Windows.Forms.Button button_premier;
        private System.Windows.Forms.Button button_rechercher_nom;
        private System.Windows.Forms.Button button_rechercher_num;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_date_sta;
        private System.Windows.Forms.TextBox textBox_pre_sta;
        private System.Windows.Forms.TextBox textBox_nom_sta;
        private System.Windows.Forms.TextBox textBox_num_sta;
    }
}