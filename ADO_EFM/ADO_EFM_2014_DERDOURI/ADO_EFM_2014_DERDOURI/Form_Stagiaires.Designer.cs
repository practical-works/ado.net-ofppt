namespace ADO_EFM_2014_DERDOURI
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
            this.dataGridView_stagiaires = new System.Windows.Forms.DataGridView();
            this.label_compte = new System.Windows.Forms.Label();
            this.textBox_position = new System.Windows.Forms.TextBox();
            this.button_dernier = new System.Windows.Forms.Button();
            this.button_suivant = new System.Windows.Forms.Button();
            this.button_precedent = new System.Windows.Forms.Button();
            this.button_premier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.comboBox_groupe = new System.Windows.Forms.ComboBox();
            this.numericUpDown_numero = new System.Windows.Forms.NumericUpDown();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.radioButton_masculin = new System.Windows.Forms.RadioButton();
            this.radioButton_feminin = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker_datenaissance = new System.Windows.Forms.DateTimePicker();
            this.userControl_CouleursFond1 = new ADO_EFM_2014_DERDOURI.UserControl_CouleursFond();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numero)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_stagiaires
            // 
            this.dataGridView_stagiaires.AllowUserToAddRows = false;
            this.dataGridView_stagiaires.AllowUserToDeleteRows = false;
            this.dataGridView_stagiaires.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_stagiaires.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_stagiaires.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_stagiaires.Location = new System.Drawing.Point(246, 64);
            this.dataGridView_stagiaires.Name = "dataGridView_stagiaires";
            this.dataGridView_stagiaires.ReadOnly = true;
            this.dataGridView_stagiaires.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_stagiaires.Size = new System.Drawing.Size(482, 331);
            this.dataGridView_stagiaires.TabIndex = 32;
            // 
            // label_compte
            // 
            this.label_compte.AutoSize = true;
            this.label_compte.Location = new System.Drawing.Point(607, 22);
            this.label_compte.Name = "label_compte";
            this.label_compte.Size = new System.Drawing.Size(24, 13);
            this.label_compte.TabIndex = 31;
            this.label_compte.Text = "/  0";
            // 
            // textBox_position
            // 
            this.textBox_position.Location = new System.Drawing.Point(569, 18);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(32, 20);
            this.textBox_position.TabIndex = 30;
            // 
            // button_dernier
            // 
            this.button_dernier.Location = new System.Drawing.Point(689, 17);
            this.button_dernier.Name = "button_dernier";
            this.button_dernier.Size = new System.Drawing.Size(39, 23);
            this.button_dernier.TabIndex = 26;
            this.button_dernier.Text = ">>";
            this.button_dernier.UseVisualStyleBackColor = true;
            this.button_dernier.Click += new System.EventHandler(this.button_dernier_Click);
            // 
            // button_suivant
            // 
            this.button_suivant.Location = new System.Drawing.Point(644, 17);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(39, 23);
            this.button_suivant.TabIndex = 25;
            this.button_suivant.Text = ">";
            this.button_suivant.UseVisualStyleBackColor = true;
            this.button_suivant.Click += new System.EventHandler(this.button_suivant_Click);
            // 
            // button_precedent
            // 
            this.button_precedent.Location = new System.Drawing.Point(517, 17);
            this.button_precedent.Name = "button_precedent";
            this.button_precedent.Size = new System.Drawing.Size(39, 23);
            this.button_precedent.TabIndex = 24;
            this.button_precedent.Text = "<";
            this.button_precedent.UseVisualStyleBackColor = true;
            this.button_precedent.Click += new System.EventHandler(this.button_precedent_Click);
            // 
            // button_premier
            // 
            this.button_premier.Location = new System.Drawing.Point(472, 17);
            this.button_premier.Name = "button_premier";
            this.button_premier.Size = new System.Drawing.Size(39, 23);
            this.button_premier.TabIndex = 29;
            this.button_premier.Text = "<<";
            this.button_premier.UseVisualStyleBackColor = true;
            this.button_premier.Click += new System.EventHandler(this.button_premier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(259, 17);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 28;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(178, 17);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 27;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(97, 17);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 22;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(16, 17);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(75, 23);
            this.button_nouveau.TabIndex = 23;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // comboBox_groupe
            // 
            this.comboBox_groupe.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_groupe.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_groupe.FormattingEnabled = true;
            this.comboBox_groupe.Location = new System.Drawing.Point(127, 251);
            this.comboBox_groupe.Name = "comboBox_groupe";
            this.comboBox_groupe.Size = new System.Drawing.Size(100, 21);
            this.comboBox_groupe.TabIndex = 21;
            // 
            // numericUpDown_numero
            // 
            this.numericUpDown_numero.Location = new System.Drawing.Point(127, 64);
            this.numericUpDown_numero.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_numero.Name = "numericUpDown_numero";
            this.numericUpDown_numero.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_numero.TabIndex = 19;
            this.numericUpDown_numero.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox_nom
            // 
            this.textBox_nom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_nom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_nom.Location = new System.Drawing.Point(127, 98);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Groupe :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sexe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numéro :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Prénom :";
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_prenom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_prenom.Location = new System.Drawing.Point(127, 128);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(100, 20);
            this.textBox_prenom.TabIndex = 18;
            // 
            // radioButton_masculin
            // 
            this.radioButton_masculin.AutoSize = true;
            this.radioButton_masculin.Checked = true;
            this.radioButton_masculin.Location = new System.Drawing.Point(127, 161);
            this.radioButton_masculin.Name = "radioButton_masculin";
            this.radioButton_masculin.Size = new System.Drawing.Size(67, 17);
            this.radioButton_masculin.TabIndex = 34;
            this.radioButton_masculin.TabStop = true;
            this.radioButton_masculin.Text = "Masculin";
            this.radioButton_masculin.UseVisualStyleBackColor = true;
            // 
            // radioButton_feminin
            // 
            this.radioButton_feminin.AutoSize = true;
            this.radioButton_feminin.Location = new System.Drawing.Point(127, 184);
            this.radioButton_feminin.Name = "radioButton_feminin";
            this.radioButton_feminin.Size = new System.Drawing.Size(61, 17);
            this.radioButton_feminin.TabIndex = 35;
            this.radioButton_feminin.Text = "Féminin";
            this.radioButton_feminin.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date de naissance :";
            // 
            // dateTimePicker_datenaissance
            // 
            this.dateTimePicker_datenaissance.CustomFormat = "";
            this.dateTimePicker_datenaissance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_datenaissance.Location = new System.Drawing.Point(127, 220);
            this.dateTimePicker_datenaissance.Name = "dateTimePicker_datenaissance";
            this.dateTimePicker_datenaissance.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_datenaissance.TabIndex = 36;
            // 
            // userControl_CouleursFond1
            // 
            this.userControl_CouleursFond1.BackColor = System.Drawing.SystemColors.Control;
            this.userControl_CouleursFond1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl_CouleursFond1.Location = new System.Drawing.Point(16, 284);
            this.userControl_CouleursFond1.Name = "userControl_CouleursFond1";
            this.userControl_CouleursFond1.Size = new System.Drawing.Size(109, 111);
            this.userControl_CouleursFond1.TabIndex = 33;
            // 
            // Form_Stagiaires
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 412);
            this.Controls.Add(this.dateTimePicker_datenaissance);
            this.Controls.Add(this.radioButton_feminin);
            this.Controls.Add(this.radioButton_masculin);
            this.Controls.Add(this.userControl_CouleursFond1);
            this.Controls.Add(this.dataGridView_stagiaires);
            this.Controls.Add(this.label_compte);
            this.Controls.Add(this.textBox_position);
            this.Controls.Add(this.button_dernier);
            this.Controls.Add(this.button_suivant);
            this.Controls.Add(this.button_precedent);
            this.Controls.Add(this.button_premier);
            this.Controls.Add(this.button_supprimer);
            this.Controls.Add(this.button_modifier);
            this.Controls.Add(this.button_ajouter);
            this.Controls.Add(this.button_nouveau);
            this.Controls.Add(this.comboBox_groupe);
            this.Controls.Add(this.numericUpDown_numero);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Stagiaires";
            this.Text = "Gestion des stagiaires";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_stagiaires)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_numero)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl_CouleursFond userControl_CouleursFond1;
        private System.Windows.Forms.DataGridView dataGridView_stagiaires;
        private System.Windows.Forms.Label label_compte;
        private System.Windows.Forms.TextBox textBox_position;
        private System.Windows.Forms.Button button_dernier;
        private System.Windows.Forms.Button button_suivant;
        private System.Windows.Forms.Button button_precedent;
        private System.Windows.Forms.Button button_premier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.ComboBox comboBox_groupe;
        private System.Windows.Forms.NumericUpDown numericUpDown_numero;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_prenom;
        private System.Windows.Forms.RadioButton radioButton_masculin;
        private System.Windows.Forms.RadioButton radioButton_feminin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker_datenaissance;
    }
}