namespace Gestion_Des_Etudiantes
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox_numéro = new System.Windows.Forms.TextBox();
            this.label_Numéro = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.textBox_prénom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox_Contact = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_fixe = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_GSM = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_classe = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Prémier = new System.Windows.Forms.Button();
            this.button_Précédent = new System.Windows.Forms.Button();
            this.button_Suivant = new System.Windows.Forms.Button();
            this.Dernier = new System.Windows.Forms.Button();
            this.button_Rechercher = new System.Windows.Forms.Button();
            this.dataGridView_Etudiantes = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox_Contact.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Etudiantes)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_numéro
            // 
            this.textBox_numéro.Location = new System.Drawing.Point(97, 13);
            this.textBox_numéro.Name = "textBox_numéro";
            this.textBox_numéro.Size = new System.Drawing.Size(100, 20);
            this.textBox_numéro.TabIndex = 0;
            // 
            // label_Numéro
            // 
            this.label_Numéro.AutoSize = true;
            this.label_Numéro.BackColor = System.Drawing.Color.Transparent;
            this.label_Numéro.ForeColor = System.Drawing.Color.DeepPink;
            this.label_Numéro.Location = new System.Drawing.Point(32, 20);
            this.label_Numéro.Name = "label_Numéro";
            this.label_Numéro.Size = new System.Drawing.Size(47, 13);
            this.label_Numéro.TabIndex = 1;
            this.label_Numéro.Text = "Numéro ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_prénom);
            this.groupBox1.Controls.Add(this.textBox_nom);
            this.groupBox1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Location = new System.Drawing.Point(26, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 159);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "les Information Personnel";
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(154, 33);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(161, 20);
            this.textBox_nom.TabIndex = 0;
            // 
            // textBox_prénom
            // 
            this.textBox_prénom.Location = new System.Drawing.Point(154, 70);
            this.textBox_prénom.Name = "textBox_prénom";
            this.textBox_prénom.Size = new System.Drawing.Size(161, 20);
            this.textBox_prénom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(15, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(15, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prénom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(15, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DateDeNaissance";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 109);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // groupBox_Contact
            // 
            this.groupBox_Contact.BackColor = System.Drawing.Color.Transparent;
            this.groupBox_Contact.Controls.Add(this.label6);
            this.groupBox_Contact.Controls.Add(this.label5);
            this.groupBox_Contact.Controls.Add(this.maskedTextBox_GSM);
            this.groupBox_Contact.Controls.Add(this.maskedTextBox_fixe);
            this.groupBox_Contact.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox_Contact.Location = new System.Drawing.Point(514, 20);
            this.groupBox_Contact.Name = "groupBox_Contact";
            this.groupBox_Contact.Size = new System.Drawing.Size(251, 94);
            this.groupBox_Contact.TabIndex = 3;
            this.groupBox_Contact.TabStop = false;
            this.groupBox_Contact.Text = "Contact";
            // 
            // maskedTextBox_fixe
            // 
            this.maskedTextBox_fixe.Location = new System.Drawing.Point(145, 19);
            this.maskedTextBox_fixe.Name = "maskedTextBox_fixe";
            this.maskedTextBox_fixe.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_fixe.TabIndex = 0;
            // 
            // maskedTextBox_GSM
            // 
            this.maskedTextBox_GSM.Location = new System.Drawing.Point(145, 49);
            this.maskedTextBox_GSM.Name = "maskedTextBox_GSM";
            this.maskedTextBox_GSM.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox_GSM.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(24, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Fixe";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(24, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "GSM";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBox_classe);
            this.groupBox3.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox3.Location = new System.Drawing.Point(514, 132);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 96);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Affectation";
            // 
            // comboBox_classe
            // 
            this.comboBox_classe.FormattingEnabled = true;
            this.comboBox_classe.Location = new System.Drawing.Point(124, 45);
            this.comboBox_classe.Name = "comboBox_classe";
            this.comboBox_classe.Size = new System.Drawing.Size(121, 21);
            this.comboBox_classe.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(33, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Classe";
            // 
            // button_Prémier
            // 
            this.button_Prémier.ForeColor = System.Drawing.Color.DeepPink;
            this.button_Prémier.Location = new System.Drawing.Point(77, 268);
            this.button_Prémier.Name = "button_Prémier";
            this.button_Prémier.Size = new System.Drawing.Size(75, 23);
            this.button_Prémier.TabIndex = 5;
            this.button_Prémier.Text = "Première";
            this.button_Prémier.UseVisualStyleBackColor = true;
            // 
            // button_Précédent
            // 
            this.button_Précédent.ForeColor = System.Drawing.Color.DeepPink;
            this.button_Précédent.Location = new System.Drawing.Point(211, 268);
            this.button_Précédent.Name = "button_Précédent";
            this.button_Précédent.Size = new System.Drawing.Size(75, 23);
            this.button_Précédent.TabIndex = 6;
            this.button_Précédent.Text = "Précédent";
            this.button_Précédent.UseVisualStyleBackColor = true;
            // 
            // button_Suivant
            // 
            this.button_Suivant.ForeColor = System.Drawing.Color.DeepPink;
            this.button_Suivant.Location = new System.Drawing.Point(338, 268);
            this.button_Suivant.Name = "button_Suivant";
            this.button_Suivant.Size = new System.Drawing.Size(75, 23);
            this.button_Suivant.TabIndex = 7;
            this.button_Suivant.Text = "Suivant";
            this.button_Suivant.UseVisualStyleBackColor = true;
            // 
            // Dernier
            // 
            this.Dernier.ForeColor = System.Drawing.Color.DeepPink;
            this.Dernier.Location = new System.Drawing.Point(483, 268);
            this.Dernier.Name = "Dernier";
            this.Dernier.Size = new System.Drawing.Size(75, 23);
            this.Dernier.TabIndex = 8;
            this.Dernier.Text = "Dernier";
            this.Dernier.UseVisualStyleBackColor = true;
            // 
            // button_Rechercher
            // 
            this.button_Rechercher.ForeColor = System.Drawing.Color.DeepPink;
            this.button_Rechercher.Location = new System.Drawing.Point(641, 267);
            this.button_Rechercher.Name = "button_Rechercher";
            this.button_Rechercher.Size = new System.Drawing.Size(75, 23);
            this.button_Rechercher.TabIndex = 9;
            this.button_Rechercher.Text = "Rechercher";
            this.button_Rechercher.UseVisualStyleBackColor = true;
            // 
            // dataGridView_Etudiantes
            // 
            this.dataGridView_Etudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Etudiantes.Location = new System.Drawing.Point(26, 296);
            this.dataGridView_Etudiantes.Name = "dataGridView_Etudiantes";
            this.dataGridView_Etudiantes.Size = new System.Drawing.Size(739, 197);
            this.dataGridView_Etudiantes.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 505);
            this.Controls.Add(this.dataGridView_Etudiantes);
            this.Controls.Add(this.button_Rechercher);
            this.Controls.Add(this.Dernier);
            this.Controls.Add(this.button_Suivant);
            this.Controls.Add(this.button_Précédent);
            this.Controls.Add(this.button_Prémier);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox_Contact);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_Numéro);
            this.Controls.Add(this.textBox_numéro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox_Contact.ResumeLayout(false);
            this.groupBox_Contact.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Etudiantes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_numéro;
        private System.Windows.Forms.Label label_Numéro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_prénom;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.GroupBox groupBox_Contact;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_GSM;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fixe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox_classe;
        private System.Windows.Forms.Button button_Prémier;
        private System.Windows.Forms.Button button_Précédent;
        private System.Windows.Forms.Button button_Suivant;
        private System.Windows.Forms.Button Dernier;
        private System.Windows.Forms.Button button_Rechercher;
        private System.Windows.Forms.DataGridView dataGridView_Etudiantes;
    }
}

