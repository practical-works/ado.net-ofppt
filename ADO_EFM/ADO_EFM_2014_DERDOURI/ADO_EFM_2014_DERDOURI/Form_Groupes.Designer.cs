namespace ADO_EFM_2014_DERDOURI
{
    partial class Form_Groupes
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
            this.textBox_filiere = new System.Windows.Forms.TextBox();
            this.numericUpDown_code = new System.Windows.Forms.NumericUpDown();
            this.maskedTextBox_annee = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_responsable = new System.Windows.Forms.ComboBox();
            this.button_nouveau = new System.Windows.Forms.Button();
            this.button_ajouter = new System.Windows.Forms.Button();
            this.button_modifier = new System.Windows.Forms.Button();
            this.button_supprimer = new System.Windows.Forms.Button();
            this.button_premier = new System.Windows.Forms.Button();
            this.button_precedent = new System.Windows.Forms.Button();
            this.button_suivant = new System.Windows.Forms.Button();
            this.button_dernier = new System.Windows.Forms.Button();
            this.textBox_position = new System.Windows.Forms.TextBox();
            this.label_compte = new System.Windows.Forms.Label();
            this.dataGridView_groupes = new System.Windows.Forms.DataGridView();
            this.userControl_CouleursFond1 = new ADO_EFM_2014_DERDOURI.UserControl_CouleursFond();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groupes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filière :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Année :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Responsable :";
            // 
            // textBox_filiere
            // 
            this.textBox_filiere.AutoCompleteCustomSource.AddRange(new string[] {
            "TDI",
            "TDM",
            "TRI",
            "TCOM"});
            this.textBox_filiere.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBox_filiere.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_filiere.Location = new System.Drawing.Point(98, 95);
            this.textBox_filiere.Name = "textBox_filiere";
            this.textBox_filiere.Size = new System.Drawing.Size(100, 20);
            this.textBox_filiere.TabIndex = 5;
            // 
            // numericUpDown_code
            // 
            this.numericUpDown_code.Location = new System.Drawing.Point(98, 61);
            this.numericUpDown_code.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_code.Name = "numericUpDown_code";
            this.numericUpDown_code.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown_code.TabIndex = 6;
            this.numericUpDown_code.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // maskedTextBox_annee
            // 
            this.maskedTextBox_annee.Location = new System.Drawing.Point(98, 129);
            this.maskedTextBox_annee.Mask = "2\\000";
            this.maskedTextBox_annee.Name = "maskedTextBox_annee";
            this.maskedTextBox_annee.Size = new System.Drawing.Size(41, 20);
            this.maskedTextBox_annee.TabIndex = 7;
            // 
            // comboBox_responsable
            // 
            this.comboBox_responsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_responsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_responsable.FormattingEnabled = true;
            this.comboBox_responsable.Location = new System.Drawing.Point(98, 163);
            this.comboBox_responsable.Name = "comboBox_responsable";
            this.comboBox_responsable.Size = new System.Drawing.Size(100, 21);
            this.comboBox_responsable.TabIndex = 8;
            // 
            // button_nouveau
            // 
            this.button_nouveau.Location = new System.Drawing.Point(17, 14);
            this.button_nouveau.Name = "button_nouveau";
            this.button_nouveau.Size = new System.Drawing.Size(75, 23);
            this.button_nouveau.TabIndex = 9;
            this.button_nouveau.Text = "Nouveau";
            this.button_nouveau.UseVisualStyleBackColor = true;
            this.button_nouveau.Click += new System.EventHandler(this.button_nouveau_Click);
            // 
            // button_ajouter
            // 
            this.button_ajouter.Location = new System.Drawing.Point(98, 14);
            this.button_ajouter.Name = "button_ajouter";
            this.button_ajouter.Size = new System.Drawing.Size(75, 23);
            this.button_ajouter.TabIndex = 9;
            this.button_ajouter.Text = "Ajouter";
            this.button_ajouter.UseVisualStyleBackColor = true;
            this.button_ajouter.Click += new System.EventHandler(this.button_ajouter_Click);
            // 
            // button_modifier
            // 
            this.button_modifier.Location = new System.Drawing.Point(179, 14);
            this.button_modifier.Name = "button_modifier";
            this.button_modifier.Size = new System.Drawing.Size(75, 23);
            this.button_modifier.TabIndex = 9;
            this.button_modifier.Text = "Modifier";
            this.button_modifier.UseVisualStyleBackColor = true;
            this.button_modifier.Click += new System.EventHandler(this.button_modifier_Click);
            // 
            // button_supprimer
            // 
            this.button_supprimer.Location = new System.Drawing.Point(260, 14);
            this.button_supprimer.Name = "button_supprimer";
            this.button_supprimer.Size = new System.Drawing.Size(75, 23);
            this.button_supprimer.TabIndex = 9;
            this.button_supprimer.Text = "Supprimer";
            this.button_supprimer.UseVisualStyleBackColor = true;
            this.button_supprimer.Click += new System.EventHandler(this.button_supprimer_Click);
            // 
            // button_premier
            // 
            this.button_premier.Enabled = false;
            this.button_premier.Location = new System.Drawing.Point(387, 14);
            this.button_premier.Name = "button_premier";
            this.button_premier.Size = new System.Drawing.Size(39, 23);
            this.button_premier.TabIndex = 9;
            this.button_premier.Text = "<<";
            this.button_premier.UseVisualStyleBackColor = true;
            // 
            // button_precedent
            // 
            this.button_precedent.Enabled = false;
            this.button_precedent.Location = new System.Drawing.Point(432, 14);
            this.button_precedent.Name = "button_precedent";
            this.button_precedent.Size = new System.Drawing.Size(39, 23);
            this.button_precedent.TabIndex = 9;
            this.button_precedent.Text = "<";
            this.button_precedent.UseVisualStyleBackColor = true;
            // 
            // button_suivant
            // 
            this.button_suivant.Enabled = false;
            this.button_suivant.Location = new System.Drawing.Point(559, 14);
            this.button_suivant.Name = "button_suivant";
            this.button_suivant.Size = new System.Drawing.Size(39, 23);
            this.button_suivant.TabIndex = 9;
            this.button_suivant.Text = ">";
            this.button_suivant.UseVisualStyleBackColor = true;
            // 
            // button_dernier
            // 
            this.button_dernier.Enabled = false;
            this.button_dernier.Location = new System.Drawing.Point(604, 14);
            this.button_dernier.Name = "button_dernier";
            this.button_dernier.Size = new System.Drawing.Size(39, 23);
            this.button_dernier.TabIndex = 9;
            this.button_dernier.Text = ">>";
            this.button_dernier.UseVisualStyleBackColor = true;
            // 
            // textBox_position
            // 
            this.textBox_position.Enabled = false;
            this.textBox_position.Location = new System.Drawing.Point(484, 15);
            this.textBox_position.Name = "textBox_position";
            this.textBox_position.Size = new System.Drawing.Size(32, 20);
            this.textBox_position.TabIndex = 10;
            // 
            // label_compte
            // 
            this.label_compte.AutoSize = true;
            this.label_compte.Enabled = false;
            this.label_compte.Location = new System.Drawing.Point(522, 19);
            this.label_compte.Name = "label_compte";
            this.label_compte.Size = new System.Drawing.Size(24, 13);
            this.label_compte.TabIndex = 11;
            this.label_compte.Text = "/  0";
            // 
            // dataGridView_groupes
            // 
            this.dataGridView_groupes.AllowUserToAddRows = false;
            this.dataGridView_groupes.AllowUserToDeleteRows = false;
            this.dataGridView_groupes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_groupes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView_groupes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_groupes.Location = new System.Drawing.Point(237, 61);
            this.dataGridView_groupes.Name = "dataGridView_groupes";
            this.dataGridView_groupes.ReadOnly = true;
            this.dataGridView_groupes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_groupes.Size = new System.Drawing.Size(406, 279);
            this.dataGridView_groupes.TabIndex = 12;
            // 
            // userControl_CouleursFond1
            // 
            this.userControl_CouleursFond1.BackColor = System.Drawing.SystemColors.Control;
            this.userControl_CouleursFond1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userControl_CouleursFond1.Location = new System.Drawing.Point(17, 229);
            this.userControl_CouleursFond1.Name = "userControl_CouleursFond1";
            this.userControl_CouleursFond1.Size = new System.Drawing.Size(109, 111);
            this.userControl_CouleursFond1.TabIndex = 13;
            // 
            // Form_Groupes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 354);
            this.Controls.Add(this.userControl_CouleursFond1);
            this.Controls.Add(this.dataGridView_groupes);
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
            this.Controls.Add(this.comboBox_responsable);
            this.Controls.Add(this.maskedTextBox_annee);
            this.Controls.Add(this.numericUpDown_code);
            this.Controls.Add(this.textBox_filiere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Groupes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des groupes";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_groupes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_filiere;
        private System.Windows.Forms.NumericUpDown numericUpDown_code;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_annee;
        private System.Windows.Forms.ComboBox comboBox_responsable;
        private System.Windows.Forms.Button button_nouveau;
        private System.Windows.Forms.Button button_ajouter;
        private System.Windows.Forms.Button button_modifier;
        private System.Windows.Forms.Button button_supprimer;
        private System.Windows.Forms.Button button_premier;
        private System.Windows.Forms.Button button_precedent;
        private System.Windows.Forms.Button button_suivant;
        private System.Windows.Forms.Button button_dernier;
        private System.Windows.Forms.TextBox textBox_position;
        private System.Windows.Forms.Label label_compte;
        private System.Windows.Forms.DataGridView dataGridView_groupes;
        private UserControl_CouleursFond userControl_CouleursFond1;
    }
}